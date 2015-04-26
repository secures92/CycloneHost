namespace CycloneHost
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSerialRefresh = new System.Windows.Forms.Button();
            this.labelSerialStatus = new System.Windows.Forms.Label();
            this.textBoxBaudrate = new System.Windows.Forms.TextBox();
            this.COMbox = new System.Windows.Forms.ComboBox();
            this.buttonSerialClose = new System.Windows.Forms.Button();
            this.buttonSerialOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLogSend = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxLogSend = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.GCode = new System.Windows.Forms.TabPage();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.xgView1 = new CycloneHost.libs.XGView();
            this.buttonGcodeRefresh = new System.Windows.Forms.Button();
            this.buttonGcodeShow = new System.Windows.Forms.Button();
            this.buttonGcodeOpen = new System.Windows.Forms.Button();
            this.Probe = new System.Windows.Forms.TabPage();
            this.ManualControl = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.buttonGoZeroXY = new System.Windows.Forms.Button();
            this.buttonSingZProbe = new System.Windows.Forms.Button();
            this.buttonSetCamXY = new System.Windows.Forms.Button();
            this.buttonSetZero = new System.Windows.Forms.Button();
            this.buttonStartCam = new System.Windows.Forms.Button();
            this.buttonResetGrbl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonManControlZ10m = new System.Windows.Forms.Button();
            this.buttonManControlZ1m = new System.Windows.Forms.Button();
            this.buttonManControlZ01m = new System.Windows.Forms.Button();
            this.buttonManControlZ01p = new System.Windows.Forms.Button();
            this.buttonManControlZ1p = new System.Windows.Forms.Button();
            this.buttonManControlZ10p = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonVacuumOff = new System.Windows.Forms.Button();
            this.buttonVacuumOn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonCoolantOff = new System.Windows.Forms.Button();
            this.buttonCoolantOn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSpindleOff = new System.Windows.Forms.Button();
            this.buttonSpindleOn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonManControlX100m = new System.Windows.Forms.Button();
            this.buttonManControlX10m = new System.Windows.Forms.Button();
            this.buttonManControlX1m = new System.Windows.Forms.Button();
            this.buttonManControlX100p = new System.Windows.Forms.Button();
            this.buttonManControlX10p = new System.Windows.Forms.Button();
            this.buttonManControlY100m = new System.Windows.Forms.Button();
            this.buttonManControlY10m = new System.Windows.Forms.Button();
            this.buttonManControlY1m = new System.Windows.Forms.Button();
            this.buttonManControlY01m = new System.Windows.Forms.Button();
            this.buttonManControlY01p = new System.Windows.Forms.Button();
            this.buttonManControlX01m = new System.Windows.Forms.Button();
            this.buttonManControlY1p = new System.Windows.Forms.Button();
            this.buttonManControlX1p = new System.Windows.Forms.Button();
            this.buttonManControlY10p = new System.Windows.Forms.Button();
            this.buttonManControlX01p = new System.Windows.Forms.Button();
            this.buttonManControlY100p = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.TabPage();
            this.buttonRefreshSettings = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBoxCamVisionOffsetY = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBoxCamVisionOffsetX = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxGRBLResp = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.checkBoxM119Resp = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxStatusUpdate = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxMaxDepthProbe = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxSafetyHeightProbe = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxFeedZProbe = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxPulloffProbe = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.radioButtonPreLoad = new System.Windows.Forms.RadioButton();
            this.radioButtonPingPong = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxBufferSize = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxFeedZMax = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxFeedXYMax = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.checkBoxInvertZ = new System.Windows.Forms.CheckBox();
            this.checkBoxInvertY = new System.Windows.Forms.CheckBox();
            this.checkBoxInvertX = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxFeedZManCtrl = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxFeedXYManCtrl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxWYCoord = new System.Windows.Forms.TextBox();
            this.textBoxWZCoord = new System.Windows.Forms.TextBox();
            this.textBoxWXCoord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.progressBarFile = new System.Windows.Forms.ProgressBar();
            this.buttonFileStop = new System.Windows.Forms.Button();
            this.buttonFileStart = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.labelMachineStatus = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.labelStatusRequests = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.buttonStartPosUpdate = new System.Windows.Forms.Button();
            this.bufferProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBoxMYCoord = new System.Windows.Forms.TextBox();
            this.textBoxMZCoord = new System.Windows.Forms.TextBox();
            this.textBoxMXCoord = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.GCode.SuspendLayout();
            this.ManualControl.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Settings.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSerialRefresh);
            this.groupBox1.Controls.Add(this.labelSerialStatus);
            this.groupBox1.Controls.Add(this.textBoxBaudrate);
            this.groupBox1.Controls.Add(this.COMbox);
            this.groupBox1.Controls.Add(this.buttonSerialClose);
            this.groupBox1.Controls.Add(this.buttonSerialOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            // 
            // buttonSerialRefresh
            // 
            this.buttonSerialRefresh.Location = new System.Drawing.Point(115, 17);
            this.buttonSerialRefresh.Name = "buttonSerialRefresh";
            this.buttonSerialRefresh.Size = new System.Drawing.Size(23, 23);
            this.buttonSerialRefresh.TabIndex = 5;
            this.buttonSerialRefresh.Text = "R";
            this.buttonSerialRefresh.UseVisualStyleBackColor = true;
            this.buttonSerialRefresh.Click += new System.EventHandler(this.buttonSerialRefresh_Click);
            // 
            // labelSerialStatus
            // 
            this.labelSerialStatus.AutoSize = true;
            this.labelSerialStatus.Location = new System.Drawing.Point(7, 51);
            this.labelSerialStatus.Name = "labelSerialStatus";
            this.labelSerialStatus.Size = new System.Drawing.Size(73, 13);
            this.labelSerialStatus.TabIndex = 4;
            this.labelSerialStatus.Text = "Disconnected";
            // 
            // textBoxBaudrate
            // 
            this.textBoxBaudrate.Location = new System.Drawing.Point(144, 19);
            this.textBoxBaudrate.Name = "textBoxBaudrate";
            this.textBoxBaudrate.Size = new System.Drawing.Size(55, 20);
            this.textBoxBaudrate.TabIndex = 3;
            this.textBoxBaudrate.Text = "115200";
            this.textBoxBaudrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COMbox
            // 
            this.COMbox.FormattingEnabled = true;
            this.COMbox.Location = new System.Drawing.Point(10, 19);
            this.COMbox.Name = "COMbox";
            this.COMbox.Size = new System.Drawing.Size(99, 21);
            this.COMbox.TabIndex = 2;
            // 
            // buttonSerialClose
            // 
            this.buttonSerialClose.Enabled = false;
            this.buttonSerialClose.Location = new System.Drawing.Point(205, 46);
            this.buttonSerialClose.Name = "buttonSerialClose";
            this.buttonSerialClose.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialClose.TabIndex = 1;
            this.buttonSerialClose.Text = "CLOSE";
            this.buttonSerialClose.UseVisualStyleBackColor = true;
            this.buttonSerialClose.Click += new System.EventHandler(this.buttonSerialClose_Click);
            // 
            // buttonSerialOpen
            // 
            this.buttonSerialOpen.Location = new System.Drawing.Point(205, 19);
            this.buttonSerialOpen.Name = "buttonSerialOpen";
            this.buttonSerialOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialOpen.TabIndex = 0;
            this.buttonSerialOpen.Text = "OPEN";
            this.buttonSerialOpen.UseVisualStyleBackColor = true;
            this.buttonSerialOpen.Click += new System.EventHandler(this.buttonSerialOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.buttonLogSend);
            this.groupBox2.Controls.Add(this.textBoxLog);
            this.groupBox2.Controls.Add(this.textBoxLogSend);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 496);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log:";
            // 
            // buttonLogSend
            // 
            this.buttonLogSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogSend.Enabled = false;
            this.buttonLogSend.Location = new System.Drawing.Point(225, 472);
            this.buttonLogSend.Name = "buttonLogSend";
            this.buttonLogSend.Size = new System.Drawing.Size(55, 20);
            this.buttonLogSend.TabIndex = 2;
            this.buttonLogSend.Text = "SEND";
            this.buttonLogSend.UseVisualStyleBackColor = true;
            this.buttonLogSend.Click += new System.EventHandler(this.buttonLogSend_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLog.Location = new System.Drawing.Point(6, 19);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(274, 447);
            this.textBoxLog.TabIndex = 1;
            // 
            // textBoxLogSend
            // 
            this.textBoxLogSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogSend.Enabled = false;
            this.textBoxLogSend.Location = new System.Drawing.Point(6, 472);
            this.textBoxLogSend.Name = "textBoxLogSend";
            this.textBoxLogSend.Size = new System.Drawing.Size(213, 20);
            this.textBoxLogSend.TabIndex = 0;
            this.textBoxLogSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxLogSend_KeyUp);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.GCode);
            this.tabControl.Controls.Add(this.Probe);
            this.tabControl.Controls.Add(this.ManualControl);
            this.tabControl.Controls.Add(this.Settings);
            this.tabControl.Enabled = false;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl.Location = new System.Drawing.Point(304, 97);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(563, 606);
            this.tabControl.TabIndex = 2;
            // 
            // GCode
            // 
            this.GCode.Controls.Add(this.elementHost1);
            this.GCode.Controls.Add(this.buttonGcodeRefresh);
            this.GCode.Controls.Add(this.buttonGcodeShow);
            this.GCode.Controls.Add(this.buttonGcodeOpen);
            this.GCode.Location = new System.Drawing.Point(4, 22);
            this.GCode.Name = "GCode";
            this.GCode.Padding = new System.Windows.Forms.Padding(3);
            this.GCode.Size = new System.Drawing.Size(555, 580);
            this.GCode.TabIndex = 0;
            this.GCode.Text = "GCode";
            this.GCode.UseVisualStyleBackColor = true;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(10, 35);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(539, 539);
            this.elementHost1.TabIndex = 6;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.xgView1;
            // 
            // buttonGcodeRefresh
            // 
            this.buttonGcodeRefresh.Location = new System.Drawing.Point(87, 6);
            this.buttonGcodeRefresh.Name = "buttonGcodeRefresh";
            this.buttonGcodeRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonGcodeRefresh.TabIndex = 4;
            this.buttonGcodeRefresh.Text = "REFRESH";
            this.buttonGcodeRefresh.UseVisualStyleBackColor = true;
            this.buttonGcodeRefresh.Click += new System.EventHandler(this.buttonGcodeRefresh_Click);
            // 
            // buttonGcodeShow
            // 
            this.buttonGcodeShow.Location = new System.Drawing.Point(168, 6);
            this.buttonGcodeShow.Name = "buttonGcodeShow";
            this.buttonGcodeShow.Size = new System.Drawing.Size(75, 23);
            this.buttonGcodeShow.TabIndex = 5;
            this.buttonGcodeShow.Text = "SHOW";
            this.buttonGcodeShow.UseVisualStyleBackColor = true;
            this.buttonGcodeShow.Click += new System.EventHandler(this.buttonGcodeShow_Click);
            // 
            // buttonGcodeOpen
            // 
            this.buttonGcodeOpen.Location = new System.Drawing.Point(6, 6);
            this.buttonGcodeOpen.Name = "buttonGcodeOpen";
            this.buttonGcodeOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonGcodeOpen.TabIndex = 3;
            this.buttonGcodeOpen.Text = "OPEN";
            this.buttonGcodeOpen.UseVisualStyleBackColor = true;
            this.buttonGcodeOpen.Click += new System.EventHandler(this.buttonGcodeOpen_Click);
            // 
            // Probe
            // 
            this.Probe.Location = new System.Drawing.Point(4, 22);
            this.Probe.Name = "Probe";
            this.Probe.Size = new System.Drawing.Size(555, 580);
            this.Probe.TabIndex = 2;
            this.Probe.Text = "Probe";
            this.Probe.UseVisualStyleBackColor = true;
            // 
            // ManualControl
            // 
            this.ManualControl.Controls.Add(this.groupBox3);
            this.ManualControl.Location = new System.Drawing.Point(4, 22);
            this.ManualControl.Name = "ManualControl";
            this.ManualControl.Size = new System.Drawing.Size(555, 580);
            this.ManualControl.TabIndex = 3;
            this.ManualControl.Text = "ManualControl";
            this.ManualControl.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox15);
            this.groupBox3.Controls.Add(this.buttonResetGrbl);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.buttonManControlZ10m);
            this.groupBox3.Controls.Add(this.buttonManControlZ1m);
            this.groupBox3.Controls.Add(this.buttonManControlZ01m);
            this.groupBox3.Controls.Add(this.buttonManControlZ01p);
            this.groupBox3.Controls.Add(this.buttonManControlZ1p);
            this.groupBox3.Controls.Add(this.buttonManControlZ10p);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.buttonManControlX100m);
            this.groupBox3.Controls.Add(this.buttonManControlX10m);
            this.groupBox3.Controls.Add(this.buttonManControlX1m);
            this.groupBox3.Controls.Add(this.buttonManControlX100p);
            this.groupBox3.Controls.Add(this.buttonManControlX10p);
            this.groupBox3.Controls.Add(this.buttonManControlY100m);
            this.groupBox3.Controls.Add(this.buttonManControlY10m);
            this.groupBox3.Controls.Add(this.buttonManControlY1m);
            this.groupBox3.Controls.Add(this.buttonManControlY01m);
            this.groupBox3.Controls.Add(this.buttonManControlY01p);
            this.groupBox3.Controls.Add(this.buttonManControlX01m);
            this.groupBox3.Controls.Add(this.buttonManControlY1p);
            this.groupBox3.Controls.Add(this.buttonManControlX1p);
            this.groupBox3.Controls.Add(this.buttonManControlY10p);
            this.groupBox3.Controls.Add(this.buttonManControlX01p);
            this.groupBox3.Controls.Add(this.buttonManControlY100p);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 574);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.buttonGoZeroXY);
            this.groupBox15.Controls.Add(this.buttonSingZProbe);
            this.groupBox15.Controls.Add(this.buttonSetCamXY);
            this.groupBox15.Controls.Add(this.buttonSetZero);
            this.groupBox15.Controls.Add(this.buttonStartCam);
            this.groupBox15.Location = new System.Drawing.Point(253, 400);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(142, 168);
            this.groupBox15.TabIndex = 36;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Positioning";
            // 
            // buttonGoZeroXY
            // 
            this.buttonGoZeroXY.Location = new System.Drawing.Point(6, 79);
            this.buttonGoZeroXY.Name = "buttonGoZeroXY";
            this.buttonGoZeroXY.Size = new System.Drawing.Size(128, 23);
            this.buttonGoZeroXY.TabIndex = 36;
            this.buttonGoZeroXY.Text = "TRAVEL XY ZERO";
            this.buttonGoZeroXY.UseVisualStyleBackColor = true;
            this.buttonGoZeroXY.Click += new System.EventHandler(this.buttonGoZeroXY_Click);
            // 
            // buttonSingZProbe
            // 
            this.buttonSingZProbe.Location = new System.Drawing.Point(6, 137);
            this.buttonSingZProbe.Name = "buttonSingZProbe";
            this.buttonSingZProbe.Size = new System.Drawing.Size(128, 23);
            this.buttonSingZProbe.TabIndex = 33;
            this.buttonSingZProbe.Text = "SINGLE Z PROBE";
            this.buttonSingZProbe.UseVisualStyleBackColor = true;
            this.buttonSingZProbe.Click += new System.EventHandler(this.buttonSingZProbe_Click);
            // 
            // buttonSetCamXY
            // 
            this.buttonSetCamXY.Location = new System.Drawing.Point(6, 50);
            this.buttonSetCamXY.Name = "buttonSetCamXY";
            this.buttonSetCamXY.Size = new System.Drawing.Size(128, 23);
            this.buttonSetCamXY.TabIndex = 35;
            this.buttonSetCamXY.Text = "SET POSITION";
            this.buttonSetCamXY.UseVisualStyleBackColor = true;
            this.buttonSetCamXY.Click += new System.EventHandler(this.buttonSetCamXY_Click);
            // 
            // buttonSetZero
            // 
            this.buttonSetZero.Location = new System.Drawing.Point(6, 108);
            this.buttonSetZero.Name = "buttonSetZero";
            this.buttonSetZero.Size = new System.Drawing.Size(128, 23);
            this.buttonSetZero.TabIndex = 32;
            this.buttonSetZero.Text = "ZERO POSITION";
            this.buttonSetZero.UseVisualStyleBackColor = true;
            this.buttonSetZero.Click += new System.EventHandler(this.buttonSetZero_Click);
            // 
            // buttonStartCam
            // 
            this.buttonStartCam.Location = new System.Drawing.Point(6, 19);
            this.buttonStartCam.Name = "buttonStartCam";
            this.buttonStartCam.Size = new System.Drawing.Size(128, 23);
            this.buttonStartCam.TabIndex = 34;
            this.buttonStartCam.Text = "CAM VISION";
            this.buttonStartCam.UseVisualStyleBackColor = true;
            this.buttonStartCam.Click += new System.EventHandler(this.buttonStartCam_Click);
            // 
            // buttonResetGrbl
            // 
            this.buttonResetGrbl.Location = new System.Drawing.Point(6, 545);
            this.buttonResetGrbl.Name = "buttonResetGrbl";
            this.buttonResetGrbl.Size = new System.Drawing.Size(128, 23);
            this.buttonResetGrbl.TabIndex = 31;
            this.buttonResetGrbl.Text = "RESET GRBL";
            this.buttonResetGrbl.UseVisualStyleBackColor = true;
            this.buttonResetGrbl.Click += new System.EventHandler(this.buttonResetGrbl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(5, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(207, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Y";
            // 
            // buttonManControlZ10m
            // 
            this.buttonManControlZ10m.Location = new System.Drawing.Point(463, 325);
            this.buttonManControlZ10m.Name = "buttonManControlZ10m";
            this.buttonManControlZ10m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlZ10m.TabIndex = 25;
            this.buttonManControlZ10m.Text = "10";
            this.buttonManControlZ10m.UseVisualStyleBackColor = true;
            this.buttonManControlZ10m.Click += new System.EventHandler(this.buttonManControlZ10m_Click);
            // 
            // buttonManControlZ1m
            // 
            this.buttonManControlZ1m.Location = new System.Drawing.Point(463, 285);
            this.buttonManControlZ1m.Name = "buttonManControlZ1m";
            this.buttonManControlZ1m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlZ1m.TabIndex = 26;
            this.buttonManControlZ1m.Text = "1";
            this.buttonManControlZ1m.UseVisualStyleBackColor = true;
            this.buttonManControlZ1m.Click += new System.EventHandler(this.buttonManControlZ1m_Click);
            // 
            // buttonManControlZ01m
            // 
            this.buttonManControlZ01m.Location = new System.Drawing.Point(463, 245);
            this.buttonManControlZ01m.Name = "buttonManControlZ01m";
            this.buttonManControlZ01m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlZ01m.TabIndex = 27;
            this.buttonManControlZ01m.Text = "0.1";
            this.buttonManControlZ01m.UseVisualStyleBackColor = true;
            this.buttonManControlZ01m.Click += new System.EventHandler(this.buttonManControlZ01m_Click);
            // 
            // buttonManControlZ01p
            // 
            this.buttonManControlZ01p.Location = new System.Drawing.Point(463, 153);
            this.buttonManControlZ01p.Name = "buttonManControlZ01p";
            this.buttonManControlZ01p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlZ01p.TabIndex = 24;
            this.buttonManControlZ01p.Text = "0.1";
            this.buttonManControlZ01p.UseVisualStyleBackColor = true;
            this.buttonManControlZ01p.Click += new System.EventHandler(this.buttonManControlZ01p_Click);
            // 
            // buttonManControlZ1p
            // 
            this.buttonManControlZ1p.Location = new System.Drawing.Point(463, 113);
            this.buttonManControlZ1p.Name = "buttonManControlZ1p";
            this.buttonManControlZ1p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlZ1p.TabIndex = 23;
            this.buttonManControlZ1p.Text = "1";
            this.buttonManControlZ1p.UseVisualStyleBackColor = true;
            this.buttonManControlZ1p.Click += new System.EventHandler(this.buttonManControlZ1p_Click);
            // 
            // buttonManControlZ10p
            // 
            this.buttonManControlZ10p.Location = new System.Drawing.Point(463, 73);
            this.buttonManControlZ10p.Name = "buttonManControlZ10p";
            this.buttonManControlZ10p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlZ10p.TabIndex = 22;
            this.buttonManControlZ10p.Text = "10";
            this.buttonManControlZ10p.UseVisualStyleBackColor = true;
            this.buttonManControlZ10p.Click += new System.EventHandler(this.buttonManControlZ10p_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonVacuumOff);
            this.groupBox6.Controls.Add(this.buttonVacuumOn);
            this.groupBox6.Location = new System.Drawing.Point(403, 400);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(141, 48);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Vaccum";
            // 
            // buttonVacuumOff
            // 
            this.buttonVacuumOff.Location = new System.Drawing.Point(75, 18);
            this.buttonVacuumOff.Name = "buttonVacuumOff";
            this.buttonVacuumOff.Size = new System.Drawing.Size(60, 23);
            this.buttonVacuumOff.TabIndex = 18;
            this.buttonVacuumOff.Text = "OFF";
            this.buttonVacuumOff.UseVisualStyleBackColor = true;
            this.buttonVacuumOff.Click += new System.EventHandler(this.buttonVacuumOff_Click);
            // 
            // buttonVacuumOn
            // 
            this.buttonVacuumOn.Location = new System.Drawing.Point(6, 18);
            this.buttonVacuumOn.Name = "buttonVacuumOn";
            this.buttonVacuumOn.Size = new System.Drawing.Size(60, 23);
            this.buttonVacuumOn.TabIndex = 17;
            this.buttonVacuumOn.Text = "ON";
            this.buttonVacuumOn.UseVisualStyleBackColor = true;
            this.buttonVacuumOn.Click += new System.EventHandler(this.buttonVacuumOn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonCoolantOff);
            this.groupBox5.Controls.Add(this.buttonCoolantOn);
            this.groupBox5.Location = new System.Drawing.Point(402, 462);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(141, 48);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Coolant";
            // 
            // buttonCoolantOff
            // 
            this.buttonCoolantOff.Location = new System.Drawing.Point(75, 18);
            this.buttonCoolantOff.Name = "buttonCoolantOff";
            this.buttonCoolantOff.Size = new System.Drawing.Size(60, 23);
            this.buttonCoolantOff.TabIndex = 18;
            this.buttonCoolantOff.Text = "OFF";
            this.buttonCoolantOff.UseVisualStyleBackColor = true;
            this.buttonCoolantOff.Click += new System.EventHandler(this.buttonCoolantOff_Click);
            // 
            // buttonCoolantOn
            // 
            this.buttonCoolantOn.Location = new System.Drawing.Point(6, 18);
            this.buttonCoolantOn.Name = "buttonCoolantOn";
            this.buttonCoolantOn.Size = new System.Drawing.Size(60, 23);
            this.buttonCoolantOn.TabIndex = 17;
            this.buttonCoolantOn.Text = "ON";
            this.buttonCoolantOn.UseVisualStyleBackColor = true;
            this.buttonCoolantOn.Click += new System.EventHandler(this.buttonCoolantOn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSpindleOff);
            this.groupBox4.Controls.Add(this.buttonSpindleOn);
            this.groupBox4.Location = new System.Drawing.Point(402, 520);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 48);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spindle";
            // 
            // buttonSpindleOff
            // 
            this.buttonSpindleOff.Location = new System.Drawing.Point(75, 18);
            this.buttonSpindleOff.Name = "buttonSpindleOff";
            this.buttonSpindleOff.Size = new System.Drawing.Size(60, 23);
            this.buttonSpindleOff.TabIndex = 18;
            this.buttonSpindleOff.Text = "OFF";
            this.buttonSpindleOff.UseVisualStyleBackColor = true;
            this.buttonSpindleOff.Click += new System.EventHandler(this.buttonSpindleOff_Click);
            // 
            // buttonSpindleOn
            // 
            this.buttonSpindleOn.Location = new System.Drawing.Point(6, 18);
            this.buttonSpindleOn.Name = "buttonSpindleOn";
            this.buttonSpindleOn.Size = new System.Drawing.Size(60, 23);
            this.buttonSpindleOn.TabIndex = 17;
            this.buttonSpindleOn.Text = "ON";
            this.buttonSpindleOn.UseVisualStyleBackColor = true;
            this.buttonSpindleOn.Click += new System.EventHandler(this.buttonSpindleOn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CycloneHost.Properties.Resources.alle_richtungen_pfeile_318_9290;
            this.pictureBox1.InitialImage = global::CycloneHost.Properties.Resources.alle_richtungen_pfeile_318_9290;
            this.pictureBox1.Location = new System.Drawing.Point(198, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonManControlX100m
            // 
            this.buttonManControlX100m.Location = new System.Drawing.Point(32, 198);
            this.buttonManControlX100m.Name = "buttonManControlX100m";
            this.buttonManControlX100m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX100m.TabIndex = 12;
            this.buttonManControlX100m.Text = "100";
            this.buttonManControlX100m.UseVisualStyleBackColor = true;
            this.buttonManControlX100m.Click += new System.EventHandler(this.buttonManControlX100m_Click);
            // 
            // buttonManControlX10m
            // 
            this.buttonManControlX10m.Location = new System.Drawing.Point(72, 198);
            this.buttonManControlX10m.Name = "buttonManControlX10m";
            this.buttonManControlX10m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX10m.TabIndex = 8;
            this.buttonManControlX10m.Text = "10";
            this.buttonManControlX10m.UseVisualStyleBackColor = true;
            this.buttonManControlX10m.Click += new System.EventHandler(this.buttonManControlX10m_Click);
            // 
            // buttonManControlX1m
            // 
            this.buttonManControlX1m.Location = new System.Drawing.Point(112, 198);
            this.buttonManControlX1m.Name = "buttonManControlX1m";
            this.buttonManControlX1m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX1m.TabIndex = 7;
            this.buttonManControlX1m.Text = "1";
            this.buttonManControlX1m.UseVisualStyleBackColor = true;
            this.buttonManControlX1m.Click += new System.EventHandler(this.buttonManControlX1m_Click);
            // 
            // buttonManControlX100p
            // 
            this.buttonManControlX100p.Location = new System.Drawing.Point(363, 198);
            this.buttonManControlX100p.Name = "buttonManControlX100p";
            this.buttonManControlX100p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX100p.TabIndex = 14;
            this.buttonManControlX100p.Text = "100";
            this.buttonManControlX100p.UseVisualStyleBackColor = true;
            this.buttonManControlX100p.Click += new System.EventHandler(this.buttonManControlX100p_Click);
            // 
            // buttonManControlX10p
            // 
            this.buttonManControlX10p.Location = new System.Drawing.Point(323, 198);
            this.buttonManControlX10p.Name = "buttonManControlX10p";
            this.buttonManControlX10p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX10p.TabIndex = 5;
            this.buttonManControlX10p.Text = "10";
            this.buttonManControlX10p.UseVisualStyleBackColor = true;
            this.buttonManControlX10p.Click += new System.EventHandler(this.buttonManControlX10p_Click);
            // 
            // buttonManControlY100m
            // 
            this.buttonManControlY100m.Location = new System.Drawing.Point(198, 364);
            this.buttonManControlY100m.Name = "buttonManControlY100m";
            this.buttonManControlY100m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY100m.TabIndex = 15;
            this.buttonManControlY100m.Text = "100";
            this.buttonManControlY100m.UseVisualStyleBackColor = true;
            this.buttonManControlY100m.Click += new System.EventHandler(this.buttonManControlY100m_Click);
            // 
            // buttonManControlY10m
            // 
            this.buttonManControlY10m.Location = new System.Drawing.Point(198, 324);
            this.buttonManControlY10m.Name = "buttonManControlY10m";
            this.buttonManControlY10m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY10m.TabIndex = 9;
            this.buttonManControlY10m.Text = "10";
            this.buttonManControlY10m.UseVisualStyleBackColor = true;
            this.buttonManControlY10m.Click += new System.EventHandler(this.buttonManControlY10m_Click);
            // 
            // buttonManControlY1m
            // 
            this.buttonManControlY1m.Location = new System.Drawing.Point(198, 284);
            this.buttonManControlY1m.Name = "buttonManControlY1m";
            this.buttonManControlY1m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY1m.TabIndex = 10;
            this.buttonManControlY1m.Text = "1";
            this.buttonManControlY1m.UseVisualStyleBackColor = true;
            this.buttonManControlY1m.Click += new System.EventHandler(this.buttonManControlY1m_Click);
            // 
            // buttonManControlY01m
            // 
            this.buttonManControlY01m.Location = new System.Drawing.Point(198, 244);
            this.buttonManControlY01m.Name = "buttonManControlY01m";
            this.buttonManControlY01m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY01m.TabIndex = 11;
            this.buttonManControlY01m.Text = "0.1";
            this.buttonManControlY01m.UseVisualStyleBackColor = true;
            this.buttonManControlY01m.Click += new System.EventHandler(this.buttonManControlY01m_Click);
            // 
            // buttonManControlY01p
            // 
            this.buttonManControlY01p.Location = new System.Drawing.Point(198, 152);
            this.buttonManControlY01p.Name = "buttonManControlY01p";
            this.buttonManControlY01p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY01p.TabIndex = 13;
            this.buttonManControlY01p.Text = "0.1";
            this.buttonManControlY01p.UseVisualStyleBackColor = true;
            this.buttonManControlY01p.Click += new System.EventHandler(this.buttonManControlY01p_Click);
            // 
            // buttonManControlX01m
            // 
            this.buttonManControlX01m.Location = new System.Drawing.Point(152, 198);
            this.buttonManControlX01m.Name = "buttonManControlX01m";
            this.buttonManControlX01m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX01m.TabIndex = 6;
            this.buttonManControlX01m.Text = "0.1";
            this.buttonManControlX01m.UseVisualStyleBackColor = true;
            this.buttonManControlX01m.Click += new System.EventHandler(this.buttonManControlX01m_Click);
            // 
            // buttonManControlY1p
            // 
            this.buttonManControlY1p.Location = new System.Drawing.Point(198, 112);
            this.buttonManControlY1p.Name = "buttonManControlY1p";
            this.buttonManControlY1p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY1p.TabIndex = 2;
            this.buttonManControlY1p.Text = "1";
            this.buttonManControlY1p.UseVisualStyleBackColor = true;
            this.buttonManControlY1p.Click += new System.EventHandler(this.buttonManControlY1p_Click);
            // 
            // buttonManControlX1p
            // 
            this.buttonManControlX1p.Location = new System.Drawing.Point(283, 198);
            this.buttonManControlX1p.Name = "buttonManControlX1p";
            this.buttonManControlX1p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX1p.TabIndex = 4;
            this.buttonManControlX1p.Text = "1";
            this.buttonManControlX1p.UseVisualStyleBackColor = true;
            this.buttonManControlX1p.Click += new System.EventHandler(this.buttonManControlX1p_Click);
            // 
            // buttonManControlY10p
            // 
            this.buttonManControlY10p.Location = new System.Drawing.Point(198, 72);
            this.buttonManControlY10p.Name = "buttonManControlY10p";
            this.buttonManControlY10p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY10p.TabIndex = 1;
            this.buttonManControlY10p.Text = "10";
            this.buttonManControlY10p.UseVisualStyleBackColor = true;
            this.buttonManControlY10p.Click += new System.EventHandler(this.buttonManControlY10p_Click);
            // 
            // buttonManControlX01p
            // 
            this.buttonManControlX01p.Location = new System.Drawing.Point(244, 198);
            this.buttonManControlX01p.Name = "buttonManControlX01p";
            this.buttonManControlX01p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX01p.TabIndex = 3;
            this.buttonManControlX01p.Text = "0.1";
            this.buttonManControlX01p.UseVisualStyleBackColor = true;
            this.buttonManControlX01p.Click += new System.EventHandler(this.buttonManControlX01p_Click);
            // 
            // buttonManControlY100p
            // 
            this.buttonManControlY100p.Location = new System.Drawing.Point(198, 32);
            this.buttonManControlY100p.Name = "buttonManControlY100p";
            this.buttonManControlY100p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY100p.TabIndex = 0;
            this.buttonManControlY100p.Text = "100";
            this.buttonManControlY100p.UseVisualStyleBackColor = true;
            this.buttonManControlY100p.Click += new System.EventHandler(this.buttonManControlY100p_Click);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.buttonRefreshSettings);
            this.Settings.Controls.Add(this.buttonSaveSettings);
            this.Settings.Controls.Add(this.groupBox16);
            this.Settings.Controls.Add(this.groupBox14);
            this.Settings.Controls.Add(this.groupBox13);
            this.Settings.Controls.Add(this.groupBox12);
            this.Settings.Controls.Add(this.groupBox11);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(555, 580);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshSettings
            // 
            this.buttonRefreshSettings.Location = new System.Drawing.Point(393, 551);
            this.buttonRefreshSettings.Name = "buttonRefreshSettings";
            this.buttonRefreshSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshSettings.TabIndex = 6;
            this.buttonRefreshSettings.Text = "REFRESH";
            this.buttonRefreshSettings.UseVisualStyleBackColor = true;
            this.buttonRefreshSettings.Click += new System.EventHandler(this.buttonRefreshSettings_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(474, 551);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSettings.TabIndex = 5;
            this.buttonSaveSettings.Text = "SAVE";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label34);
            this.groupBox16.Controls.Add(this.textBoxCamVisionOffsetY);
            this.groupBox16.Controls.Add(this.label35);
            this.groupBox16.Controls.Add(this.label31);
            this.groupBox16.Controls.Add(this.textBoxCamVisionOffsetX);
            this.groupBox16.Controls.Add(this.label32);
            this.groupBox16.Location = new System.Drawing.Point(10, 333);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(536, 103);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "CamVision";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(178, 35);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 13);
            this.label34.TabIndex = 9;
            this.label34.Text = "mm";
            // 
            // textBoxCamVisionOffsetY
            // 
            this.textBoxCamVisionOffsetY.Location = new System.Drawing.Point(112, 32);
            this.textBoxCamVisionOffsetY.Name = "textBoxCamVisionOffsetY";
            this.textBoxCamVisionOffsetY.Size = new System.Drawing.Size(60, 20);
            this.textBoxCamVisionOffsetY.TabIndex = 8;
            this.textBoxCamVisionOffsetY.Text = "-18.8";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 35);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(48, 13);
            this.label35.TabIndex = 7;
            this.label35.Text = "Offset Y:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(178, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(23, 13);
            this.label31.TabIndex = 6;
            this.label31.Text = "mm";
            // 
            // textBoxCamVisionOffsetX
            // 
            this.textBoxCamVisionOffsetX.Location = new System.Drawing.Point(112, 13);
            this.textBoxCamVisionOffsetX.Name = "textBoxCamVisionOffsetX";
            this.textBoxCamVisionOffsetX.Size = new System.Drawing.Size(60, 20);
            this.textBoxCamVisionOffsetX.TabIndex = 5;
            this.textBoxCamVisionOffsetX.Text = "-27.1";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 16);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(48, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "Offset X:";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label1);
            this.groupBox14.Controls.Add(this.checkBoxGRBLResp);
            this.groupBox14.Controls.Add(this.label33);
            this.groupBox14.Controls.Add(this.checkBoxM119Resp);
            this.groupBox14.Controls.Add(this.label27);
            this.groupBox14.Controls.Add(this.textBoxStatusUpdate);
            this.groupBox14.Controls.Add(this.label28);
            this.groupBox14.Location = new System.Drawing.Point(13, 442);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(536, 103);
            this.groupBox14.TabIndex = 3;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Misc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Show GRBL Responeses:";
            // 
            // checkBoxGRBLResp
            // 
            this.checkBoxGRBLResp.AutoSize = true;
            this.checkBoxGRBLResp.Location = new System.Drawing.Point(157, 59);
            this.checkBoxGRBLResp.Name = "checkBoxGRBLResp";
            this.checkBoxGRBLResp.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGRBLResp.TabIndex = 9;
            this.checkBoxGRBLResp.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 39);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(129, 13);
            this.label33.TabIndex = 8;
            this.label33.Text = "Show M119 Responeses:";
            // 
            // checkBoxM119Resp
            // 
            this.checkBoxM119Resp.AutoSize = true;
            this.checkBoxM119Resp.Location = new System.Drawing.Point(157, 39);
            this.checkBoxM119Resp.Name = "checkBoxM119Resp";
            this.checkBoxM119Resp.Size = new System.Drawing.Size(15, 14);
            this.checkBoxM119Resp.TabIndex = 7;
            this.checkBoxM119Resp.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(178, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 13);
            this.label27.TabIndex = 6;
            this.label27.Text = "ms";
            // 
            // textBoxStatusUpdate
            // 
            this.textBoxStatusUpdate.Location = new System.Drawing.Point(112, 13);
            this.textBoxStatusUpdate.Name = "textBoxStatusUpdate";
            this.textBoxStatusUpdate.Size = new System.Drawing.Size(60, 20);
            this.textBoxStatusUpdate.TabIndex = 5;
            this.textBoxStatusUpdate.Text = "1000";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(107, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "Status Update every:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label25);
            this.groupBox13.Controls.Add(this.textBoxMaxDepthProbe);
            this.groupBox13.Controls.Add(this.label26);
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Controls.Add(this.textBoxSafetyHeightProbe);
            this.groupBox13.Controls.Add(this.label30);
            this.groupBox13.Controls.Add(this.label20);
            this.groupBox13.Controls.Add(this.textBoxFeedZProbe);
            this.groupBox13.Controls.Add(this.label21);
            this.groupBox13.Controls.Add(this.label22);
            this.groupBox13.Controls.Add(this.textBoxPulloffProbe);
            this.groupBox13.Controls.Add(this.label23);
            this.groupBox13.Location = new System.Drawing.Point(10, 224);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(536, 103);
            this.groupBox13.TabIndex = 2;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Probing";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(178, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "mm";
            // 
            // textBoxMaxDepthProbe
            // 
            this.textBoxMaxDepthProbe.Enabled = false;
            this.textBoxMaxDepthProbe.Location = new System.Drawing.Point(112, 51);
            this.textBoxMaxDepthProbe.Name = "textBoxMaxDepthProbe";
            this.textBoxMaxDepthProbe.Size = new System.Drawing.Size(60, 20);
            this.textBoxMaxDepthProbe.TabIndex = 14;
            this.textBoxMaxDepthProbe.Text = "-5";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 54);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 13);
            this.label26.TabIndex = 13;
            this.label26.Text = "Maximum Depth:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(178, 35);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 13);
            this.label29.TabIndex = 12;
            this.label29.Text = "mm";
            // 
            // textBoxSafetyHeightProbe
            // 
            this.textBoxSafetyHeightProbe.Enabled = false;
            this.textBoxSafetyHeightProbe.Location = new System.Drawing.Point(112, 32);
            this.textBoxSafetyHeightProbe.Name = "textBoxSafetyHeightProbe";
            this.textBoxSafetyHeightProbe.Size = new System.Drawing.Size(60, 20);
            this.textBoxSafetyHeightProbe.TabIndex = 11;
            this.textBoxSafetyHeightProbe.Text = "1";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 35);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(74, 13);
            this.label30.TabIndex = 10;
            this.label30.Text = "Safety Height:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(178, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "mm/s";
            // 
            // textBoxFeedZProbe
            // 
            this.textBoxFeedZProbe.Enabled = false;
            this.textBoxFeedZProbe.Location = new System.Drawing.Point(112, 13);
            this.textBoxFeedZProbe.Name = "textBoxFeedZProbe";
            this.textBoxFeedZProbe.Size = new System.Drawing.Size(60, 20);
            this.textBoxFeedZProbe.TabIndex = 8;
            this.textBoxFeedZProbe.Text = "50";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "Z ProbeFeed:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(178, 73);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "mm";
            // 
            // textBoxPulloffProbe
            // 
            this.textBoxPulloffProbe.Enabled = false;
            this.textBoxPulloffProbe.Location = new System.Drawing.Point(112, 70);
            this.textBoxPulloffProbe.Name = "textBoxPulloffProbe";
            this.textBoxPulloffProbe.Size = new System.Drawing.Size(60, 20);
            this.textBoxPulloffProbe.TabIndex = 5;
            this.textBoxPulloffProbe.Text = "0.5";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 73);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Pulloff Height:";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label36);
            this.groupBox12.Controls.Add(this.radioButtonPreLoad);
            this.groupBox12.Controls.Add(this.radioButtonPingPong);
            this.groupBox12.Controls.Add(this.label19);
            this.groupBox12.Controls.Add(this.textBoxBufferSize);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Controls.Add(this.label15);
            this.groupBox12.Controls.Add(this.textBoxFeedZMax);
            this.groupBox12.Controls.Add(this.label16);
            this.groupBox12.Controls.Add(this.label17);
            this.groupBox12.Controls.Add(this.textBoxFeedXYMax);
            this.groupBox12.Controls.Add(this.label18);
            this.groupBox12.Location = new System.Drawing.Point(10, 115);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(536, 103);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "GcodeStreaming";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(247, 43);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(99, 13);
            this.label36.TabIndex = 21;
            this.label36.Text = "Streaming Protocol:";
            // 
            // radioButtonPreLoad
            // 
            this.radioButtonPreLoad.AutoSize = true;
            this.radioButtonPreLoad.Enabled = false;
            this.radioButtonPreLoad.Location = new System.Drawing.Point(374, 62);
            this.radioButtonPreLoad.Name = "radioButtonPreLoad";
            this.radioButtonPreLoad.Size = new System.Drawing.Size(123, 17);
            this.radioButtonPreLoad.TabIndex = 20;
            this.radioButtonPreLoad.Text = "agressive Preloading";
            this.radioButtonPreLoad.UseVisualStyleBackColor = true;
            // 
            // radioButtonPingPong
            // 
            this.radioButtonPingPong.AutoSize = true;
            this.radioButtonPingPong.Checked = true;
            this.radioButtonPingPong.Location = new System.Drawing.Point(374, 39);
            this.radioButtonPingPong.Name = "radioButtonPingPong";
            this.radioButtonPingPong.Size = new System.Drawing.Size(74, 17);
            this.radioButtonPingPong.TabIndex = 19;
            this.radioButtonPingPong.TabStop = true;
            this.radioButtonPingPong.Text = "Ping Pong";
            this.radioButtonPingPong.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(419, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "commands";
            // 
            // textBoxBufferSize
            // 
            this.textBoxBufferSize.Enabled = false;
            this.textBoxBufferSize.Location = new System.Drawing.Point(353, 13);
            this.textBoxBufferSize.Name = "textBoxBufferSize";
            this.textBoxBufferSize.Size = new System.Drawing.Size(60, 20);
            this.textBoxBufferSize.TabIndex = 17;
            this.textBoxBufferSize.Text = "10";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(247, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 13);
            this.label24.TabIndex = 16;
            this.label24.Text = "GRBL Buffersize:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(178, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "mm/s";
            // 
            // textBoxFeedZMax
            // 
            this.textBoxFeedZMax.Enabled = false;
            this.textBoxFeedZMax.Location = new System.Drawing.Point(112, 32);
            this.textBoxFeedZMax.Name = "textBoxFeedZMax";
            this.textBoxFeedZMax.Size = new System.Drawing.Size(60, 20);
            this.textBoxFeedZMax.TabIndex = 14;
            this.textBoxFeedZMax.Text = "300";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Z Maximum Feed:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(178, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "mm/s";
            // 
            // textBoxFeedXYMax
            // 
            this.textBoxFeedXYMax.Enabled = false;
            this.textBoxFeedXYMax.Location = new System.Drawing.Point(112, 13);
            this.textBoxFeedXYMax.Name = "textBoxFeedXYMax";
            this.textBoxFeedXYMax.Size = new System.Drawing.Size(60, 20);
            this.textBoxFeedXYMax.TabIndex = 11;
            this.textBoxFeedXYMax.Text = "1000";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "XY Maximum Feed:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.checkBoxInvertZ);
            this.groupBox11.Controls.Add(this.checkBoxInvertY);
            this.groupBox11.Controls.Add(this.checkBoxInvertX);
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Controls.Add(this.textBoxFeedZManCtrl);
            this.groupBox11.Controls.Add(this.label14);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.textBoxFeedXYManCtrl);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Location = new System.Drawing.Point(10, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(536, 103);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "ManualControl";
            // 
            // checkBoxInvertZ
            // 
            this.checkBoxInvertZ.AutoSize = true;
            this.checkBoxInvertZ.Location = new System.Drawing.Point(279, 61);
            this.checkBoxInvertZ.Name = "checkBoxInvertZ";
            this.checkBoxInvertZ.Size = new System.Drawing.Size(85, 17);
            this.checkBoxInvertZ.TabIndex = 12;
            this.checkBoxInvertZ.Text = "Invert Z Axis";
            this.checkBoxInvertZ.UseVisualStyleBackColor = true;
            // 
            // checkBoxInvertY
            // 
            this.checkBoxInvertY.AutoSize = true;
            this.checkBoxInvertY.Location = new System.Drawing.Point(279, 38);
            this.checkBoxInvertY.Name = "checkBoxInvertY";
            this.checkBoxInvertY.Size = new System.Drawing.Size(85, 17);
            this.checkBoxInvertY.TabIndex = 11;
            this.checkBoxInvertY.Text = "Invert Y Axis";
            this.checkBoxInvertY.UseVisualStyleBackColor = true;
            // 
            // checkBoxInvertX
            // 
            this.checkBoxInvertX.AutoSize = true;
            this.checkBoxInvertX.Location = new System.Drawing.Point(279, 15);
            this.checkBoxInvertX.Name = "checkBoxInvertX";
            this.checkBoxInvertX.Size = new System.Drawing.Size(85, 17);
            this.checkBoxInvertX.TabIndex = 10;
            this.checkBoxInvertX.Text = "Invert X Axis";
            this.checkBoxInvertX.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "mm/s";
            // 
            // textBoxFeedZManCtrl
            // 
            this.textBoxFeedZManCtrl.Location = new System.Drawing.Point(112, 32);
            this.textBoxFeedZManCtrl.Name = "textBoxFeedZManCtrl";
            this.textBoxFeedZManCtrl.Size = new System.Drawing.Size(60, 20);
            this.textBoxFeedZManCtrl.TabIndex = 8;
            this.textBoxFeedZManCtrl.Text = "300";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Z Movement Feed:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(178, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "mm/s";
            // 
            // textBoxFeedXYManCtrl
            // 
            this.textBoxFeedXYManCtrl.Location = new System.Drawing.Point(112, 13);
            this.textBoxFeedXYManCtrl.Name = "textBoxFeedXYManCtrl";
            this.textBoxFeedXYManCtrl.Size = new System.Drawing.Size(60, 20);
            this.textBoxFeedXYManCtrl.TabIndex = 5;
            this.textBoxFeedXYManCtrl.Text = "1000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "XY Movement Feed:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxWYCoord);
            this.groupBox7.Controls.Add(this.textBoxWZCoord);
            this.groupBox7.Controls.Add(this.textBoxWXCoord);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Location = new System.Drawing.Point(304, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(188, 79);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Work Coordinates";
            // 
            // textBoxWYCoord
            // 
            this.textBoxWYCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWYCoord.Location = new System.Drawing.Point(66, 33);
            this.textBoxWYCoord.Name = "textBoxWYCoord";
            this.textBoxWYCoord.Size = new System.Drawing.Size(100, 20);
            this.textBoxWYCoord.TabIndex = 5;
            this.textBoxWYCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWZCoord
            // 
            this.textBoxWZCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWZCoord.Location = new System.Drawing.Point(66, 53);
            this.textBoxWZCoord.Name = "textBoxWZCoord";
            this.textBoxWZCoord.Size = new System.Drawing.Size(100, 20);
            this.textBoxWZCoord.TabIndex = 4;
            this.textBoxWZCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWXCoord
            // 
            this.textBoxWXCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWXCoord.Location = new System.Drawing.Point(66, 13);
            this.textBoxWXCoord.Name = "textBoxWXCoord";
            this.textBoxWXCoord.Size = new System.Drawing.Size(100, 20);
            this.textBoxWXCoord.TabIndex = 3;
            this.textBoxWXCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Z:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "X:";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.progressBarFile);
            this.groupBox8.Controls.Add(this.buttonFileStop);
            this.groupBox8.Controls.Add(this.buttonFileStart);
            this.groupBox8.Location = new System.Drawing.Point(692, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(171, 79);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "File";
            // 
            // progressBarFile
            // 
            this.progressBarFile.Location = new System.Drawing.Point(6, 18);
            this.progressBarFile.Name = "progressBarFile";
            this.progressBarFile.Size = new System.Drawing.Size(156, 23);
            this.progressBarFile.TabIndex = 6;
            // 
            // buttonFileStop
            // 
            this.buttonFileStop.Enabled = false;
            this.buttonFileStop.Location = new System.Drawing.Point(87, 47);
            this.buttonFileStop.Name = "buttonFileStop";
            this.buttonFileStop.Size = new System.Drawing.Size(75, 23);
            this.buttonFileStop.TabIndex = 5;
            this.buttonFileStop.Text = "STOP";
            this.buttonFileStop.UseVisualStyleBackColor = true;
            this.buttonFileStop.Click += new System.EventHandler(this.buttonFileStop_Click);
            // 
            // buttonFileStart
            // 
            this.buttonFileStart.Enabled = false;
            this.buttonFileStart.Location = new System.Drawing.Point(6, 47);
            this.buttonFileStart.Name = "buttonFileStart";
            this.buttonFileStart.Size = new System.Drawing.Size(75, 23);
            this.buttonFileStart.TabIndex = 4;
            this.buttonFileStart.Text = "START";
            this.buttonFileStart.UseVisualStyleBackColor = true;
            this.buttonFileStart.Click += new System.EventHandler(this.buttonFileStart_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.labelMachineStatus);
            this.groupBox9.Controls.Add(this.label40);
            this.groupBox9.Controls.Add(this.labelStatusRequests);
            this.groupBox9.Controls.Add(this.label38);
            this.groupBox9.Controls.Add(this.label37);
            this.groupBox9.Controls.Add(this.buttonStartPosUpdate);
            this.groupBox9.Controls.Add(this.bufferProgressBar);
            this.groupBox9.Location = new System.Drawing.Point(12, 97);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(289, 104);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "MachineStatus";
            // 
            // labelMachineStatus
            // 
            this.labelMachineStatus.AutoSize = true;
            this.labelMachineStatus.Location = new System.Drawing.Point(102, 76);
            this.labelMachineStatus.Name = "labelMachineStatus";
            this.labelMachineStatus.Size = new System.Drawing.Size(24, 13);
            this.labelMachineStatus.TabIndex = 11;
            this.labelMachineStatus.Text = "Idle";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(7, 76);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(81, 13);
            this.label40.TabIndex = 10;
            this.label40.Text = "MachineStatus:";
            // 
            // labelStatusRequests
            // 
            this.labelStatusRequests.AutoSize = true;
            this.labelStatusRequests.Location = new System.Drawing.Point(102, 52);
            this.labelStatusRequests.Name = "labelStatusRequests";
            this.labelStatusRequests.Size = new System.Drawing.Size(47, 13);
            this.labelStatusRequests.TabIndex = 9;
            this.labelStatusRequests.Text = "Stopped";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(7, 52);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(85, 13);
            this.label38.TabIndex = 8;
            this.label38.Text = "StatusRequests:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 25);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(85, 13);
            this.label37.TabIndex = 7;
            this.label37.Text = "CommandBuffer:";
            // 
            // buttonStartPosUpdate
            // 
            this.buttonStartPosUpdate.Location = new System.Drawing.Point(186, 47);
            this.buttonStartPosUpdate.Name = "buttonStartPosUpdate";
            this.buttonStartPosUpdate.Size = new System.Drawing.Size(94, 23);
            this.buttonStartPosUpdate.TabIndex = 6;
            this.buttonStartPosUpdate.Text = "Toggle";
            this.buttonStartPosUpdate.UseVisualStyleBackColor = true;
            this.buttonStartPosUpdate.Click += new System.EventHandler(this.buttonStartPosUpdate_Click);
            // 
            // bufferProgressBar
            // 
            this.bufferProgressBar.Location = new System.Drawing.Point(105, 18);
            this.bufferProgressBar.Name = "bufferProgressBar";
            this.bufferProgressBar.Size = new System.Drawing.Size(175, 23);
            this.bufferProgressBar.TabIndex = 6;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBoxMYCoord);
            this.groupBox10.Controls.Add(this.textBoxMZCoord);
            this.groupBox10.Controls.Add(this.textBoxMXCoord);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Location = new System.Drawing.Point(498, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(188, 79);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Machine Coordinates";
            // 
            // textBoxMYCoord
            // 
            this.textBoxMYCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMYCoord.Location = new System.Drawing.Point(66, 33);
            this.textBoxMYCoord.Name = "textBoxMYCoord";
            this.textBoxMYCoord.Size = new System.Drawing.Size(100, 20);
            this.textBoxMYCoord.TabIndex = 5;
            this.textBoxMYCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMZCoord
            // 
            this.textBoxMZCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMZCoord.Location = new System.Drawing.Point(66, 53);
            this.textBoxMZCoord.Name = "textBoxMZCoord";
            this.textBoxMZCoord.Size = new System.Drawing.Size(100, 20);
            this.textBoxMZCoord.TabIndex = 4;
            this.textBoxMZCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMXCoord
            // 
            this.textBoxMXCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMXCoord.Location = new System.Drawing.Point(66, 13);
            this.textBoxMXCoord.Name = "textBoxMXCoord";
            this.textBoxMXCoord.Size = new System.Drawing.Size(100, 20);
            this.textBoxMXCoord.TabIndex = 3;
            this.textBoxMXCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Z:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "X:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 715);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(895, 754);
            this.Name = "MainForm";
            this.Text = "CycloneHost";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.GCode.ResumeLayout(false);
            this.ManualControl.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Settings.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox COMbox;
        private System.Windows.Forms.Button buttonSerialClose;
        private System.Windows.Forms.Button buttonSerialOpen;
        private System.Windows.Forms.TextBox textBoxBaudrate;
        private System.Windows.Forms.Label labelSerialStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLogSend;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxLogSend;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage GCode;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Button buttonGcodeRefresh;
        private System.Windows.Forms.Button buttonGcodeShow;
        private System.Windows.Forms.Button buttonGcodeOpen;
        private System.Windows.Forms.TabPage Probe;
        private System.Windows.Forms.TabPage ManualControl;
        private System.Windows.Forms.Button buttonManControlY01m;
        private System.Windows.Forms.Button buttonManControlY1m;
        private System.Windows.Forms.Button buttonManControlY10m;
        private System.Windows.Forms.Button buttonManControlX10m;
        private System.Windows.Forms.Button buttonManControlX1m;
        private System.Windows.Forms.Button buttonManControlX01m;
        private System.Windows.Forms.Button buttonManControlX10p;
        private System.Windows.Forms.Button buttonManControlX1p;
        private System.Windows.Forms.Button buttonManControlX01p;
        private System.Windows.Forms.Button buttonManControlY1p;
        private System.Windows.Forms.Button buttonManControlY10p;
        private System.Windows.Forms.Button buttonManControlY100p;
        private System.Windows.Forms.Button buttonManControlY100m;
        private System.Windows.Forms.Button buttonManControlX100p;
        private System.Windows.Forms.Button buttonManControlY01p;
        private System.Windows.Forms.Button buttonManControlX100m;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSpindleOn;
        private System.Windows.Forms.Button buttonSpindleOff;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonVacuumOff;
        private System.Windows.Forms.Button buttonVacuumOn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonCoolantOff;
        private System.Windows.Forms.Button buttonCoolantOn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWYCoord;
        private System.Windows.Forms.TextBox textBoxWZCoord;
        private System.Windows.Forms.TextBox textBoxWXCoord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ProgressBar progressBarFile;
        private System.Windows.Forms.Button buttonFileStop;
        private System.Windows.Forms.Button buttonFileStart;
        private System.Windows.Forms.Button buttonSerialRefresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonManControlZ10m;
        private System.Windows.Forms.Button buttonManControlZ1m;
        private System.Windows.Forms.Button buttonManControlZ01m;
        private System.Windows.Forms.Button buttonManControlZ01p;
        private System.Windows.Forms.Button buttonManControlZ1p;
        private System.Windows.Forms.Button buttonManControlZ10p;
        private System.Windows.Forms.Button buttonSetZero;
        private System.Windows.Forms.Button buttonResetGrbl;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ProgressBar bufferProgressBar;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBoxMYCoord;
        private System.Windows.Forms.TextBox textBoxMZCoord;
        private System.Windows.Forms.TextBox textBoxMXCoord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxStatusUpdate;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxFeedZProbe;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxPulloffProbe;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxBufferSize;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxFeedZMax;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxFeedXYMax;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBoxInvertZ;
        private System.Windows.Forms.CheckBox checkBoxInvertY;
        private System.Windows.Forms.CheckBox checkBoxInvertX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxFeedZManCtrl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxFeedXYManCtrl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSingZProbe;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxMaxDepthProbe;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxSafetyHeightProbe;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button buttonStartCam;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button buttonSetCamXY;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBoxCamVisionOffsetX;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckBox checkBoxM119Resp;
        private System.Windows.Forms.Button buttonGoZeroXY;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBoxCamVisionOffsetY;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonRefreshSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxGRBLResp;
        private System.Windows.Forms.Button buttonStartPosUpdate;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private libs.XGView xgView1;
        private System.Windows.Forms.RadioButton radioButtonPreLoad;
        private System.Windows.Forms.RadioButton radioButtonPingPong;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label labelMachineStatus;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label labelStatusRequests;
    }
}