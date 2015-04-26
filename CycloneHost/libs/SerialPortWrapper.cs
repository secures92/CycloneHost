using System;
using System.IO.Ports;
using System.Collections;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CycloneHost.libs
{

    public class SerialPortWrapper : SerialPort
    {
        private Timer executeTimer;
        private ArrayList execList;
        private bool waitingForResponse = false;
        private Int32 bufferSize = 10;
        private Int32 bufferCount = 0;
        private Int32 timerInterval = 100;
        private String serialCarry = "";
        private TextBox logTextBox = null;
        private libs.Settings settings;
        private libs.GCodes gCodes;
        private libs.MachineStatus mStatus;
        private object syncLock = new object();
        private int serialProtocolMode = 0;
        private const int PINGPONGMODE = 0;
        private const int PRELOADMODE = 1;
        private String ws = " ";

        public delegate void SerialMessageReceivedEventHandler(String message);
        public event SerialMessageReceivedEventHandler SerialMessageReceived;
        public delegate void StatusUpdateEventHandler(Vector3 workCoord, Vector3 machCoord, String status);
        public event StatusUpdateEventHandler StatusUpdateReceived;


        public SerialPortWrapper(String port, int baudrate, libs.Settings settings_, libs.GCodes gCodes_, libs.MachineStatus mStatus_)
            : base(port, baudrate)
        {
            settings = settings_;
            gCodes = gCodes_;
            mStatus = mStatus_;
            execList = new ArrayList();

            this.DataReceived += new SerialDataReceivedEventHandler(serialDataReceivedIntern);

            serialProtocolMode = settings.GcodeStreamingSettings.PingPongProtocol ? PINGPONGMODE : PRELOADMODE;

            executeTimer = new Timer();
            executeTimer.Start();
            executeTimer.Interval = this.timerInterval;
            executeTimer.Tick += new EventHandler(executeTimerUpdate);

            waitingForResponse = false;
        }

        private void executeTimerUpdate(Object sender, EventArgs e)
        {
            lock (syncLock)
            {
                switch (serialProtocolMode)
                {
                    case PRELOADMODE:
                        if (execList.Count != 0 && bufferCount < bufferSize)
                        {
                            if (logTextBox != null && !execList[0].Equals("?"))
                            {
                                logTextBox.AppendText(">" + execList[0] + "\r\n");
                            }
                            executeCommand((String)execList[0]);
                            execList.RemoveAt(0);
                            bufferCount++;
                        }
                        break;
                    case PINGPONGMODE:
                        if (!waitingForResponse && execList.Count != 0)
                        {
                            if (logTextBox != null && !execList[0].Equals("?"))
                            {
                                logTextBox.AppendText(">" + execList[0] + "\r\n");
                            }
                            executeCommand((String)execList[0]);
                            execList.RemoveAt(0);
                            waitingForResponse = true;
                        }
                        break;
                }
            }
        }

        private void serialDataReceivedIntern(object sender, SerialDataReceivedEventArgs e)
        {
            String data = serialCarry + this.ReadExisting();
            String[] msgArray = Regex.Split(data, "\r\n");
            if (data.EndsWith("\r\n"))
            {
                serialCarry = "";
            }
            else
            {
                serialCarry = msgArray[msgArray.Length - 1];
                msgArray[msgArray.Length - 1] = "";
            }
            switch (serialProtocolMode)
            {
                case PINGPONGMODE:
                    #region PINGPONGMODE
                    foreach (String msg_ in msgArray)
                    {
                        String msg = msg_;
                        lock (syncLock)
                        {
                            if (msg.ToLower().Trim().StartsWith("ok") || msg.ToLower().Contains("error") || msg.ToLower().Contains("alarm"))
                            {
                                waitingForResponse = false;
                            }
                        }

                        if (msg.ToLower().Contains("alarm"))
                        {
                            stopStreaming();
                        }

                        if (msg.ToLower().Equals("ok") && !settings.MiscSettings.ShowGRBLResponses)
                        {
                            msg = "";
                        }


                        if (msg.ToLower().Contains("['$' for help]"))
                        {
                            bufferCount = 0;
                        }
                        //<Idle,MPos:0.000,0.000,-2.309,WPos:0.000,0.000,-2.309>
                        //<Idle,MPos:-307.355,7.649,5.000,WPos:0.000,0.000,0.000>
                        Match m = Regex.Match(msg, mStatus.regexPattern);
                        if (m.Success)
                        {
                            try
                            {
                                parsePosition(m);
                                if (!settings.MiscSettings.ShowStatusMessages)
                                {
                                    msg = "";
                                }
                            }
                            catch (Exception ex)
                            {
                                SerialMessageReceived(ex.ToString());
                                msg = "";
                            }
                        }

                        if (!msg.Trim().Equals(""))
                        {
                            SerialMessageReceived(msg);
                        }

                    }
                    #endregion
                    break;
                case PRELOADMODE:
                    #region PRELOADMODE
                    foreach (String msg_ in msgArray)
                    {
                        String msg = msg_;
                        if (msg.ToLower().Equals("ok") || msg.ToLower().Contains("error") || msg.ToLower().Contains("alarm"))
                        {
                            lock (syncLock)
                            {
                                if (bufferCount > 0)
                                {
                                    bufferCount--;
                                }
                            }
                        }

                        if (msg.ToLower().Equals("ok") && !settings.MiscSettings.ShowGRBLResponses)
                        {
                            msg = "";
                        }

                        if (msg.ToLower().Contains("['$' for help]"))
                        {
                            bufferCount = 0;
                        }
                        //<Idle,MPos:0.000,0.000,-2.309,WPos:0.000,0.000,-2.309>
                        //<Idle,MPos:-307.355,7.649,5.000,WPos:0.000,0.000,0.000>
                        Match m = Regex.Match(msg, mStatus.regexPattern);
                        if (m.Success)
                        {
                            try
                            {
                                parsePosition(m);
                                if (!settings.MiscSettings.ShowStatusMessages)
                                {
                                    msg = "";
                                }
                            }
                            catch (Exception ex)
                            {
                                SerialMessageReceived(ex.ToString());
                                msg = "";
                            }
                        }

                        if (!msg.Trim().Equals(""))
                        {
                            SerialMessageReceived(msg);
                        }

                    }
                    #endregion
                    break;
            }
        }

        public void parsePosition(Match m)
        {
            if (mStatus.indexStatus >= 0)
            {
                mStatus.Status = m.Groups[mStatus.indexStatus].ToString();
            }
            else
            {
                mStatus.Status = "---";
            }
            if (mStatus.indexMx >= 0)
            {
                mStatus.MachineCoordinates.X = double.Parse(m.Groups[mStatus.indexMx].ToString(), System.Globalization.NumberFormatInfo.InvariantInfo);
            }
            if (mStatus.indexMx >= 0)
            {
                mStatus.MachineCoordinates.Y = double.Parse(m.Groups[mStatus.indexMy].ToString(), System.Globalization.NumberFormatInfo.InvariantInfo);
            }
            if (mStatus.indexMx >= 0)
            {
                mStatus.MachineCoordinates.Z = double.Parse(m.Groups[mStatus.indexMz].ToString(), System.Globalization.NumberFormatInfo.InvariantInfo);
            }
            if (mStatus.indexMx >= 0)
            {
                mStatus.WorkCoordinates.X = double.Parse(m.Groups[mStatus.indexWx].ToString(), System.Globalization.NumberFormatInfo.InvariantInfo);
            }
            if (mStatus.indexMx >= 0)
            {
                mStatus.WorkCoordinates.Y = double.Parse(m.Groups[mStatus.indexWy].ToString(), System.Globalization.NumberFormatInfo.InvariantInfo);
            }
            if (mStatus.indexMx >= 0)
            {
                mStatus.WorkCoordinates.Z = double.Parse(m.Groups[mStatus.indexWz].ToString(), System.Globalization.NumberFormatInfo.InvariantInfo);
            }
        }

        public void stopStreaming()
        {
            String val = "10";
            execList.Clear();
            execList.Add(gCodes.mCodeSet.M05);//Spindle off
            execList.Add(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Z + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.ZMovementFeed);//Rise Spindle 10mm
        }

        public void attachLogTextBox(TextBox tv)
        {
            this.logTextBox = tv;
        }

        public void addCommand(String cmd)
        {
            // Gcode Correction here
            if (this.IsOpen && !cmd.Trim().Equals(""))
            {
                this.execList.Add(cmd);
            }
        }

        public void addCommandNext(String cmd)
        {
            // Gcode Correction here
            if (this.IsOpen && !cmd.Trim().Equals(""))
            {
                this.execList.Insert(0, cmd); ;
            }
        }

        private void executeCommand(String cmd)
        {
            if (this.IsOpen)
            {
                this.WriteLine(cmd);
            }
        }
    }
}
