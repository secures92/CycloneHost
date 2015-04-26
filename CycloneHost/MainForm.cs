using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.Integration;


namespace CycloneHost
{
    public partial class MainForm : Form
    {
        private libs.SerialPortWrapper serialPort;
        private delegate void setCoordDeleg(Vector3 wCoord, Vector3 mCoord, String Status);
        private delegate void setTextDeleg(string text);
        private Timer updateTimer;
        private String fileName = "";
        private String settingsFileName = "";
        private String gCodeSetFileName = "";
        private String mStatusFileName = "";
        private bool requestStatusUpdate = true;
        private String ws = " ";
        private libs.Settings settings;
        private libs.GCodes gCodes;
        private libs.MachineStatus mStatus;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            settingsFileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"/xml/Settings.xml";
            mStatusFileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"/xml/MachineStatus.xml";
            gCodeSetFileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"/xml/Commands.xml";
            
            settings = new libs.Settings(settingsFileName);
            loadSettingsFromClass();
            gCodes = new libs.GCodes(gCodeSetFileName);
            mStatus = new libs.MachineStatus(mStatusFileName);

            setupSerialPort();
            setupFormUpdate();
        }

        private void setupFormUpdate()
        {
            bufferProgressBar.Maximum = (int)settings.GcodeStreamingSettings.BufferSize;
            updateTimer = new Timer();
            updateTimer.Interval = Convert.ToInt32(settings.MiscSettings.StatusUpdateInterval);
            updateTimer.Tick += new EventHandler(updateTimerPerformUpdate);
            updateTimer.Start();
        }

        private void updateTimerPerformUpdate(Object sender, EventArgs e)
        {
            if (serialPort != null)
            {
                refreshMachineStatus();

                if (requestStatusUpdate)
                {
                    labelStatusRequests.Text = "Running";
                    serialPort.addCommandNext("?");
                }
                else
                {
                    labelStatusRequests.Text = "Stopped";
                }
            }
        }

        #region SerialPort

        private void setupSerialPort()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                COMbox.Items.Add(port);
            }
            COMbox.SelectedIndex = 0;

        }

        private void refreshMachineStatus()
        {
            textBoxWXCoord.Text = mStatus.WorkCoordinates.X.ToString("0.000");
            textBoxWYCoord.Text = mStatus.WorkCoordinates.Y.ToString("0.000");
            textBoxWZCoord.Text = mStatus.WorkCoordinates.Z.ToString("0.000");
            textBoxMXCoord.Text = mStatus.MachineCoordinates.X.ToString("0.000");
            textBoxMYCoord.Text = mStatus.MachineCoordinates.Y.ToString("0.000");
            textBoxMZCoord.Text = mStatus.MachineCoordinates.Z.ToString("0.000");
            labelMachineStatus.Text = mStatus.Status;
        }

        private void connectSerialPort()
        {
            try
            {
                serialPort = new libs.SerialPortWrapper(COMbox.SelectedItem.ToString(), Convert.ToInt32(textBoxBaudrate.Text), settings, gCodes, mStatus);
                serialPort.SerialMessageReceived += new libs.SerialPortWrapper.SerialMessageReceivedEventHandler(messageReceived);
                serialPort.ReadBufferSize = 8192;
                serialPort.attachLogTextBox(textBoxLog);
                COMbox.Enabled = false;
                textBoxBaudrate.Enabled = false;
                buttonSerialClose.Enabled = true;
                buttonSerialOpen.Enabled = false;
                buttonLogSend.Enabled = true;
                textBoxLogSend.Enabled = true;
                tabControl.Enabled = true;
                buttonFileStop.Enabled = true;
                buttonFileStart.Enabled = true;
                serialPort.Open();
                labelSerialStatus.Text = "Connected to " + COMbox.SelectedItem.ToString() + " @ " + textBoxBaudrate.Text + " baud";

            }
            catch (Exception ex)
            {
                textBoxLog.AppendText(ex.ToString() + "\r\n");
                buttonSerialClose.PerformClick();
            }

        }

        private void textBoxLogSend_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogSend.PerformClick();
            }
        }

        private void buttonSerialOpen_Click(object sender, EventArgs e)
        {
            connectSerialPort();
        }

        private void buttonSerialClose_Click(object sender, EventArgs e)
        {
            labelSerialStatus.Text = "Disconnected";
            COMbox.Enabled = true;
            buttonSerialClose.Enabled = false;
            buttonSerialOpen.Enabled = true;
            textBoxBaudrate.Enabled = true;
            buttonLogSend.Enabled = false;
            textBoxLogSend.Enabled = false;
            tabControl.Enabled = false;
            buttonFileStart.Enabled = false;
            buttonFileStop.Enabled = false;
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void buttonLogSend_Click(object sender, EventArgs e)
        {
            if (textBoxLogSend.Text.Equals("clr"))
            {
                textBoxLog.Clear();
                textBoxLogSend.Clear();
                return;
            }

            serialPort.addCommand(textBoxLogSend.Text);
        }

        private void buttonSerialRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            COMbox.Items.Clear();
            foreach (string port in ports)
            {
                COMbox.Items.Add(port);
            }
            COMbox.SelectedIndex = 0;
        }

        private void messageReceived(String msg)
        {
            this.BeginInvoke(new setTextDeleg(logAppendText), new object[] { msg });
        }

        private void logAppendText(String text)
        {
            textBoxLog.AppendText(text + "\r\n");
        }

        #endregion

        #region GcodeView

        private void buttonGcodeOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = ofd.FileName;
                xgView1.loadFile(fileName);
            }
        }

        private void buttonGcodeRefresh_Click(object sender, EventArgs e)
        {
            loadSettingsFromClass();
        }

        private void buttonGcodeShow_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", fileName);
        }

        #endregion

        #region ManualControl

        private String generateValue(double value, bool invert)
        {
            if (!invert)
            {
                return value.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            }
            else
            {
                return (-value).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        #region XButtons
        private void buttonManControlX100m_Click(object sender, EventArgs e)
        {
            String val = generateValue(-100, settings.ManualControlSettings.InvertXAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.X + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlX10m_Click(object sender, EventArgs e)
        {
            String val = generateValue(-10, settings.ManualControlSettings.InvertXAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.X + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlX1m_Click(object sender, EventArgs e)
        {
            String val = generateValue(-1, settings.ManualControlSettings.InvertXAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.X + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlX01m_Click(object sender, EventArgs e)
        {
            String val = generateValue(-0.1, settings.ManualControlSettings.InvertXAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.X + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlX01p_Click(object sender, EventArgs e)
        {
            String val = generateValue(0.1, settings.ManualControlSettings.InvertXAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.X + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlX1p_Click(object sender, EventArgs e)
        {
            String val = generateValue(1, settings.ManualControlSettings.InvertXAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.X + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlX10p_Click(object sender, EventArgs e)
        {
            String val = generateValue(10, settings.ManualControlSettings.InvertXAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.X + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlX100p_Click(object sender, EventArgs e)
        {
            String val = generateValue(100, settings.ManualControlSettings.InvertXAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.X + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }
        #endregion

        #region YButtons
        private void buttonManControlY100p_Click(object sender, EventArgs e)
        {
            String val = generateValue(100, settings.ManualControlSettings.InvertYAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Y + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlY10p_Click(object sender, EventArgs e)
        {
            String val = generateValue(10, settings.ManualControlSettings.InvertYAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Y + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlY1p_Click(object sender, EventArgs e)
        {
            String val = generateValue(1, settings.ManualControlSettings.InvertYAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Y + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlY01p_Click(object sender, EventArgs e)
        {
            String val = generateValue(0.1, settings.ManualControlSettings.InvertYAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Y + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlY01m_Click(object sender, EventArgs e)
        {
            String val = generateValue(-0.1, settings.ManualControlSettings.InvertYAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Y + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlY1m_Click(object sender, EventArgs e)
        {
            String val = generateValue(-1, settings.ManualControlSettings.InvertYAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Y + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlY10m_Click(object sender, EventArgs e)
        {
            String val = generateValue(-10, settings.ManualControlSettings.InvertYAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Y + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonManControlY100m_Click(object sender, EventArgs e)
        {
            String val = generateValue(-100, settings.ManualControlSettings.InvertYAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Y + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }
        #endregion

        #region ZButtons

        private void buttonManControlZ10p_Click(object sender, EventArgs e)
        {
            String val = generateValue(10, settings.ManualControlSettings.InvertZAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Z + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.ZMovementFeed);
        }

        private void buttonManControlZ1p_Click(object sender, EventArgs e)
        {
            String val = generateValue(1, settings.ManualControlSettings.InvertZAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Z + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.ZMovementFeed);
        }

        private void buttonManControlZ01p_Click(object sender, EventArgs e)
        {
            String val = generateValue(0.1, settings.ManualControlSettings.InvertZAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Z + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.ZMovementFeed);
        }

        private void buttonManControlZ01m_Click(object sender, EventArgs e)
        {
            String val = generateValue(-0.10, settings.ManualControlSettings.InvertZAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Z + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.ZMovementFeed);
        }

        private void buttonManControlZ1m_Click(object sender, EventArgs e)
        {
            String val = generateValue(-1, settings.ManualControlSettings.InvertXAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Z + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.ZMovementFeed);
        }

        private void buttonManControlZ10m_Click(object sender, EventArgs e)
        {
            String val = generateValue(-10, settings.ManualControlSettings.InvertXAxis);
            serialPort.addCommand(gCodes.gCodeSet.G91);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.Z + val.ToString() + ws + gCodes.codeSet.F + settings.ManualControlSettings.ZMovementFeed);
        }
        #endregion

        #region MiscCommandButtons
        private void buttonVacuumOn_Click(object sender, EventArgs e)
        {
            serialPort.addCommand(gCodes.mCodeSet.M10);
        }

        private void buttonVacuumOff_Click(object sender, EventArgs e)
        {
            serialPort.addCommand(gCodes.mCodeSet.M11);
        }

        private void buttonCoolantOn_Click(object sender, EventArgs e)
        {
            serialPort.addCommand(gCodes.mCodeSet.M08);
        }

        private void buttonCoolantOff_Click(object sender, EventArgs e)
        {
            serialPort.addCommand(gCodes.mCodeSet.M09);
        }

        private void buttonSpindleOn_Click(object sender, EventArgs e)
        {
            serialPort.addCommand(gCodes.mCodeSet.M03);
        }

        private void buttonSpindleOff_Click(object sender, EventArgs e)
        {
            serialPort.addCommand(gCodes.mCodeSet.M05);
        }

        private void buttonSetZero_Click(object sender, EventArgs e)
        {
            String val = "0";
            serialPort.addCommand(gCodes.gCodeSet.G92 + ws + gCodes.codeSet.X + val + ws + gCodes.codeSet.Y + val + ws + gCodes.codeSet.Z + val);
        }

        private void buttonResetGrbl_Click(object sender, EventArgs e)
        {
            serialPort.addCommand(gCodes.sCodeSet.Reset);
            serialPort.addCommand(gCodes.sCodeSet.Info);
        }

        private void buttonSingZProbe_Click(object sender, EventArgs e)
        {
            String val = "-10";
            serialPort.addCommand(gCodes.gCodeSet.G90);
            serialPort.addCommand(gCodes.sCodeSet.Probe + ws + gCodes.codeSet.Z + val + gCodes.codeSet.F + settings.ProbeSettings.ZProbeFeed);
        }

        private void buttonGoZeroXY_Click(object sender, EventArgs e)
        {
            String val = "0";
            serialPort.addCommand(gCodes.gCodeSet.G90);
            serialPort.addCommand(gCodes.gCodeSet.G00 + ws + gCodes.codeSet.X + val + ws + gCodes.codeSet.Y + val + ws + gCodes.codeSet.F + settings.ManualControlSettings.XYMovementFeed);
        }

        private void buttonSetCamXY_Click(object sender, EventArgs e)
        {
            serialPort.addCommand(gCodes.gCodeSet.G92 + ws + gCodes.codeSet.X + settings.CamVisionSettings.OffsetX + ws + gCodes.codeSet.Y + settings.CamVisionSettings.OffsetY);
        }

        private void buttonStartCam_Click(object sender, EventArgs e)
        {
            new CameraView().Show();
        }

        #endregion

        #region MiscButtons
        private void buttonFileStart_Click(object sender, EventArgs e)
        {
            if (fileName.Equals("")) return;

            String[] lines = System.IO.File.ReadAllLines(fileName);
            progressBarFile.Maximum = lines.Length;
            progressBarFile.Value = lines.Length;
            foreach (String line in lines)
            {
                serialPort.addCommand(line);
            }
           // requestStatusUpdate = false;

        }

        private void buttonStartPosUpdate_Click(object sender, EventArgs e)
        {
            requestStatusUpdate = !requestStatusUpdate;
        }

        private void buttonFileStop_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.stopStreaming();
            }
        }
        #endregion
        #endregion

        #region Settings

        private bool checkUserInput(TextBox txt)
        {
            try
            {
                double.Parse(txt.Text, System.Globalization.NumberFormatInfo.InvariantInfo);
                return true;
            }
            catch (Exception ex)
            {
                txt.Text = "NaN";
                //textBoxLog.AppendText(ex.ToString() + "\n");
                MessageBox.Show("Error, Please check your entries.");
            }
            return false;
        }

        private double parseDouble(string s)
        {
            return double.Parse(s, System.Globalization.NumberFormatInfo.InvariantInfo);
        }

        private int parseInteger(string s)
        {
            return Convert.ToInt32(double.Parse(s, System.Globalization.NumberFormatInfo.InvariantInfo));
        }

        private void saveSettingsToFile()
        {
            //TODO: Save to XML File
        }
        private void saveSettingsToClass()
        {
            #region ManualControl
            if (checkUserInput(textBoxFeedXYManCtrl))
                settings.ManualControlSettings.XYMovementFeed = parseInteger(textBoxFeedXYManCtrl.Text);
            if (checkUserInput(textBoxFeedZManCtrl))
                settings.ManualControlSettings.ZMovementFeed = parseInteger(textBoxFeedZManCtrl.Text);
            settings.ManualControlSettings.InvertXAxis = checkBoxInvertX.Checked;
            settings.ManualControlSettings.InvertYAxis = checkBoxInvertY.Checked;
            settings.ManualControlSettings.InvertZAxis = checkBoxInvertZ.Checked;
            #endregion

            #region GcodeStreaming
            if (checkUserInput(textBoxFeedXYMax))
                settings.GcodeStreamingSettings.XYMaximumFeed = parseInteger(textBoxFeedXYMax.Text);
            if (checkUserInput(textBoxFeedZMax))
                settings.GcodeStreamingSettings.ZMaximumFeed = parseInteger(textBoxFeedZMax.Text);
            if (checkUserInput(textBoxBufferSize))
                settings.GcodeStreamingSettings.BufferSize = parseInteger(textBoxBufferSize.Text);
            settings.GcodeStreamingSettings.PingPongProtocol = radioButtonPingPong.Checked;
            #endregion

            #region Probing
            if (checkUserInput(textBoxFeedZProbe))
                settings.ProbeSettings.ZProbeFeed = parseInteger(textBoxFeedZProbe.Text);
            if (checkUserInput(textBoxSafetyHeightProbe))
                settings.ProbeSettings.SafetyHeight = parseDouble(textBoxSafetyHeightProbe.Text);
            if (checkUserInput(textBoxMaxDepthProbe))
                settings.ProbeSettings.MaxDepth = parseDouble(textBoxMaxDepthProbe.Text);
            if (checkUserInput(textBoxPulloffProbe))
                settings.ProbeSettings.PulloffHeight = parseDouble(textBoxPulloffProbe.Text);
            #endregion

            #region CamVision
            if (checkUserInput(textBoxCamVisionOffsetX))
                settings.CamVisionSettings.OffsetX = parseDouble(textBoxCamVisionOffsetX.Text);
            if (checkUserInput(textBoxCamVisionOffsetY))
                settings.CamVisionSettings.OffsetY = parseDouble(textBoxCamVisionOffsetY.Text);
            #endregion

            #region Misc
            if (checkUserInput(textBoxStatusUpdate))
                settings.MiscSettings.StatusUpdateInterval = parseInteger(textBoxStatusUpdate.Text);
            settings.MiscSettings.ShowStatusMessages = checkBoxM119Resp.Checked;
            settings.MiscSettings.ShowGRBLResponses = checkBoxGRBLResp.Checked;

            #endregion
        }

        private void loadSettingsFromFile()
        {
            //TODO: Load from XML File
        }

        private void loadSettingsFromClass()
        {
            #region ManualControl
            checkBoxInvertX.Checked = settings.ManualControlSettings.InvertXAxis;
            checkBoxInvertY.Checked = settings.ManualControlSettings.InvertYAxis;
            checkBoxInvertZ.Checked = settings.ManualControlSettings.InvertZAxis;
            textBoxFeedXYManCtrl.Text = settings.ManualControlSettings.XYMovementFeed.ToString();
            textBoxFeedZManCtrl.Text = settings.ManualControlSettings.ZMovementFeed.ToString();
            #endregion

            #region GcodeStreaming
            textBoxFeedXYMax.Text = settings.GcodeStreamingSettings.XYMaximumFeed.ToString();
            textBoxFeedZMax.Text = settings.GcodeStreamingSettings.ZMaximumFeed.ToString();
            textBoxBufferSize.Text = settings.GcodeStreamingSettings.BufferSize.ToString();
            radioButtonPingPong.Checked = settings.GcodeStreamingSettings.PingPongProtocol;
            radioButtonPreLoad.Checked = !radioButtonPingPong.Checked;
            #endregion

            #region Probing
            textBoxFeedZProbe.Text = settings.ProbeSettings.ZProbeFeed.ToString();
            textBoxSafetyHeightProbe.Text = settings.ProbeSettings.SafetyHeight.ToString("0.0");
            textBoxMaxDepthProbe.Text = settings.ProbeSettings.MaxDepth.ToString("0.0");
            textBoxPulloffProbe.Text = settings.ProbeSettings.PulloffHeight.ToString("0.0");
            #endregion

            #region CamVision
            textBoxCamVisionOffsetX.Text = settings.CamVisionSettings.OffsetX.ToString("0.0");
            textBoxCamVisionOffsetY.Text = settings.CamVisionSettings.OffsetY.ToString("0.0");
            #endregion

            #region Misc
            textBoxStatusUpdate.Text = settings.MiscSettings.StatusUpdateInterval.ToString();
            checkBoxM119Resp.Checked = settings.MiscSettings.ShowStatusMessages;
            checkBoxGRBLResp.Checked = settings.MiscSettings.ShowGRBLResponses;
            #endregion
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            saveSettingsToClass();
            saveSettingsToFile();
            loadSettingsFromClass();

        }

        private void buttonRefreshSettings_Click(object sender, EventArgs e)
        {
            loadSettingsFromClass();
        }

        #endregion





    }

}
