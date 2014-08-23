using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CycloneHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SerialPort serPort = null;
        private delegate void SetTextDeleg(string text);
        private string filename = "";
        BackgroundWorker gCodeStreamer = null;
        int streamedLines = 0;
        int linePreStreamNbr = 10;
        string[] gCodeLines;



        #region SerialCommunication

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                COMbox.Items.Add(port);
            }
            COMbox.SelectedIndex = 0;

        }

        private void buttonSerialOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serPort = new SerialPort(COMbox.SelectedItem.ToString(), Convert.ToInt32(textBoxBaudrate.Text));
                serPort.DataReceived += serPort_dataReceived;
                serPort.ReadBufferSize = 8192;
                COMbox.Enabled = false;
                textBoxBaudrate.Enabled = false;
                buttonSerialClose.Enabled = true;
                buttonSerialOpen.Enabled = false;
                buttonLogSend.Enabled = true;
                textBoxLogSend.Enabled = true;
                serPort.Open();
                labelSerialStatus.Text = "Connected to " + COMbox.SelectedItem.ToString() + " @ " + textBoxBaudrate.Text + " baud";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void serPort_dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serPort.ReadExisting();
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
            if (gCodeStreamer != null)
            {
                if (gCodeStreamer.IsBusy && data.Equals("OK"))
                {
                    streamedLines++;
                }
            }

        }

        private void si_DataReceived(string data)
        {
            textBoxLog.AppendText(data);
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
            serPort.Close();
        }

        private void buttonLogSend_Click(object sender, EventArgs e)
        {
            if (textBoxLogSend.Text.Equals("clr"))
            {
                textBoxLog.Clear();
                textBoxLogSend.Clear();
                return;
            }

            textBoxLog.AppendText(">" + textBoxLogSend.Text + "\r\n");
            serPort.WriteLine(textBoxLogSend.Text);
        }

        private void textBoxLogSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogSend.PerformClick();
            }
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

        private void buttonFileStart_Click(object sender, EventArgs e)
        {
            if (filename.Equals("")) return;
            
            gCodeLines = System.IO.File.ReadAllLines(filename);

            textBoxLogSend.Enabled = false;
            buttonLogSend.Enabled = false;

            gCodeStreamer = new BackgroundWorker();
            gCodeStreamer.WorkerReportsProgress = true;
            gCodeStreamer.WorkerSupportsCancellation = true;


            gCodeStreamer.DoWork += new DoWorkEventHandler(worker_DoWork);
            gCodeStreamer.ProgressChanged +=
                        new ProgressChangedEventHandler(worker_ProgressChanged);
            gCodeStreamer.RunWorkerCompleted +=
                       new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        private void buttonFileStop_Click(object sender, EventArgs e)
        {
            if (gCodeStreamer != null)
            {
                if (gCodeStreamer.IsBusy)
                {
                    gCodeStreamer.CancelAsync();
                    textBoxLogSend.Enabled = true;
                    buttonLogSend.Enabled = true;
                }
            }
        }

        #region Backgroundworker

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < gCodeLines.Length; i++)
            {
                while ((i-streamedLines) > linePreStreamNbr);
                serPort.WriteLine(gCodeLines[i]);
                this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { ">>"+gCodeLines[i] });
                gCodeStreamer.ReportProgress((int)(1.0 * i / gCodeLines.Length) * 100);
            }
        }
        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarFile.Value = e.ProgressPercentage;
        }
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBoxLogSend.Enabled = true;
            buttonLogSend.Enabled = true;
        }

        #endregion

        #endregion

        #region GcodeTab

        private void buttonGcodeOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                filename = ofd.FileName;
                gCodeView1.attachGcode(ofd.FileName);
                gCodeView1.updateView();
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            gCodeView1.updateView();
        }

        private void buttonGcodeZoomPlu_Click(object sender, EventArgs e)
        {
            gCodeView1.scale += 0.2;
            gCodeView1.updateView();
        }

        private void buttonGcodeZoomMin_Click(object sender, EventArgs e)
        {
            gCodeView1.scale -= 0.2;
            gCodeView1.updateView();
        }

        private void buttonGcodeShow_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", filename);
        }

        private void buttonGcodeRefresh_Click(object sender, EventArgs e)
        {
            gCodeView1.clear();
            gCodeView1.attachGcode(filename);
            gCodeView1.updateView();
        }

        #endregion

        #region ManualControlTab

        private void buttonSpindleOn_Click(object sender, EventArgs e)
        {

        }

        private void buttonSpindleOff_Click(object sender, EventArgs e)
        {

        }

        private void buttonCoolantOn_Click(object sender, EventArgs e)
        {

        }

        private void buttonCoolantOff_Click(object sender, EventArgs e)
        {

        }

        private void buttonVacuumOn_Click(object sender, EventArgs e)
        {

        }

        private void buttonVacuumOff_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlX100m_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlX10m_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlX1m_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlX01m_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlY100p_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlY10p_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlY1p_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlY01p_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlY01m_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlY1m_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlY10m_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlY100m_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlX01p_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlX1p_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlX10p_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlX100p_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlZ10p_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlZ1p_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlZ01p_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlZ01m_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlZ1m_Click(object sender, EventArgs e)
        {

        }

        private void buttonManControlZ10m_Click(object sender, EventArgs e)
        {

        }

        #endregion





    }
}
