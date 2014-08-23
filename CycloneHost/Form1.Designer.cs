namespace CycloneHost
{
    partial class Form1
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
            this.buttonGcodeZoomMin = new System.Windows.Forms.Button();
            this.buttonGcodeZoomPlu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gCodeView = new System.Windows.Forms.Integration.ElementHost();
            this.gCodeView1 = new CycloneHost.GCodeView();
            this.buttonGcodeRefresh = new System.Windows.Forms.Button();
            this.buttonGcodeShow = new System.Windows.Forms.Button();
            this.buttonGcodeOpen = new System.Windows.Forms.Button();
            this.Probe = new System.Windows.Forms.TabPage();
            this.ManualControl = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxYCoord = new System.Windows.Forms.TextBox();
            this.textBoxZCoord = new System.Windows.Forms.TextBox();
            this.textBoxXCoord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.progressBarFile = new System.Windows.Forms.ProgressBar();
            this.buttonFileStop = new System.Windows.Forms.Button();
            this.buttonFileStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.GCode.SuspendLayout();
            this.ManualControl.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log:";
            // 
            // buttonLogSend
            // 
            this.buttonLogSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogSend.Enabled = false;
            this.buttonLogSend.Location = new System.Drawing.Point(225, 388);
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
            this.textBoxLog.Size = new System.Drawing.Size(274, 363);
            this.textBoxLog.TabIndex = 1;
            // 
            // textBoxLogSend
            // 
            this.textBoxLogSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogSend.Enabled = false;
            this.textBoxLogSend.Location = new System.Drawing.Point(6, 388);
            this.textBoxLogSend.Name = "textBoxLogSend";
            this.textBoxLogSend.Size = new System.Drawing.Size(213, 20);
            this.textBoxLogSend.TabIndex = 0;
            this.textBoxLogSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLogSend_KeyDown);
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
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl.Location = new System.Drawing.Point(304, 97);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(363, 414);
            this.tabControl.TabIndex = 2;
            // 
            // GCode
            // 
            this.GCode.Controls.Add(this.buttonGcodeZoomMin);
            this.GCode.Controls.Add(this.buttonGcodeZoomPlu);
            this.GCode.Controls.Add(this.label1);
            this.GCode.Controls.Add(this.gCodeView);
            this.GCode.Controls.Add(this.buttonGcodeRefresh);
            this.GCode.Controls.Add(this.buttonGcodeShow);
            this.GCode.Controls.Add(this.buttonGcodeOpen);
            this.GCode.Location = new System.Drawing.Point(4, 22);
            this.GCode.Name = "GCode";
            this.GCode.Padding = new System.Windows.Forms.Padding(3);
            this.GCode.Size = new System.Drawing.Size(355, 388);
            this.GCode.TabIndex = 0;
            this.GCode.Text = "GCode";
            this.GCode.UseVisualStyleBackColor = true;
            // 
            // buttonGcodeZoomMin
            // 
            this.buttonGcodeZoomMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGcodeZoomMin.Location = new System.Drawing.Point(325, 6);
            this.buttonGcodeZoomMin.Name = "buttonGcodeZoomMin";
            this.buttonGcodeZoomMin.Size = new System.Drawing.Size(24, 23);
            this.buttonGcodeZoomMin.TabIndex = 9;
            this.buttonGcodeZoomMin.Text = "-";
            this.buttonGcodeZoomMin.UseVisualStyleBackColor = true;
            this.buttonGcodeZoomMin.Click += new System.EventHandler(this.buttonGcodeZoomMin_Click);
            // 
            // buttonGcodeZoomPlu
            // 
            this.buttonGcodeZoomPlu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGcodeZoomPlu.Location = new System.Drawing.Point(295, 6);
            this.buttonGcodeZoomPlu.Name = "buttonGcodeZoomPlu";
            this.buttonGcodeZoomPlu.Size = new System.Drawing.Size(24, 23);
            this.buttonGcodeZoomPlu.TabIndex = 8;
            this.buttonGcodeZoomPlu.Text = "+";
            this.buttonGcodeZoomPlu.UseVisualStyleBackColor = true;
            this.buttonGcodeZoomPlu.Click += new System.EventHandler(this.buttonGcodeZoomPlu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zoom:";
            // 
            // gCodeView
            // 
            this.gCodeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCodeView.Location = new System.Drawing.Point(7, 36);
            this.gCodeView.Name = "gCodeView";
            this.gCodeView.Size = new System.Drawing.Size(342, 346);
            this.gCodeView.TabIndex = 6;
            this.gCodeView.Text = "elementHost1";
            this.gCodeView.Child = this.gCodeView1;
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
            this.Probe.Size = new System.Drawing.Size(355, 388);
            this.Probe.TabIndex = 2;
            this.Probe.Text = "Probe";
            this.Probe.UseVisualStyleBackColor = true;
            // 
            // ManualControl
            // 
            this.ManualControl.Controls.Add(this.groupBox3);
            this.ManualControl.Location = new System.Drawing.Point(4, 22);
            this.ManualControl.Name = "ManualControl";
            this.ManualControl.Size = new System.Drawing.Size(355, 388);
            this.ManualControl.TabIndex = 3;
            this.ManualControl.Text = "ManualControl";
            this.ManualControl.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox3.Size = new System.Drawing.Size(349, 382);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Y";
            // 
            // buttonManControlZ10m
            // 
            this.buttonManControlZ10m.Location = new System.Drawing.Point(287, 308);
            this.buttonManControlZ10m.Name = "buttonManControlZ10m";
            this.buttonManControlZ10m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlZ10m.TabIndex = 25;
            this.buttonManControlZ10m.Text = "10";
            this.buttonManControlZ10m.UseVisualStyleBackColor = true;
            this.buttonManControlZ10m.Click += new System.EventHandler(this.buttonManControlZ10m_Click);
            // 
            // buttonManControlZ1m
            // 
            this.buttonManControlZ1m.Location = new System.Drawing.Point(287, 278);
            this.buttonManControlZ1m.Name = "buttonManControlZ1m";
            this.buttonManControlZ1m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlZ1m.TabIndex = 26;
            this.buttonManControlZ1m.Text = "1";
            this.buttonManControlZ1m.UseVisualStyleBackColor = true;
            this.buttonManControlZ1m.Click += new System.EventHandler(this.buttonManControlZ1m_Click);
            // 
            // buttonManControlZ01m
            // 
            this.buttonManControlZ01m.Location = new System.Drawing.Point(287, 248);
            this.buttonManControlZ01m.Name = "buttonManControlZ01m";
            this.buttonManControlZ01m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlZ01m.TabIndex = 27;
            this.buttonManControlZ01m.Text = "0.1";
            this.buttonManControlZ01m.UseVisualStyleBackColor = true;
            this.buttonManControlZ01m.Click += new System.EventHandler(this.buttonManControlZ01m_Click);
            // 
            // buttonManControlZ01p
            // 
            this.buttonManControlZ01p.Location = new System.Drawing.Point(287, 96);
            this.buttonManControlZ01p.Name = "buttonManControlZ01p";
            this.buttonManControlZ01p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlZ01p.TabIndex = 24;
            this.buttonManControlZ01p.Text = "0.1";
            this.buttonManControlZ01p.UseVisualStyleBackColor = true;
            this.buttonManControlZ01p.Click += new System.EventHandler(this.buttonManControlZ01p_Click);
            // 
            // buttonManControlZ1p
            // 
            this.buttonManControlZ1p.Location = new System.Drawing.Point(287, 66);
            this.buttonManControlZ1p.Name = "buttonManControlZ1p";
            this.buttonManControlZ1p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlZ1p.TabIndex = 23;
            this.buttonManControlZ1p.Text = "1";
            this.buttonManControlZ1p.UseVisualStyleBackColor = true;
            this.buttonManControlZ1p.Click += new System.EventHandler(this.buttonManControlZ1p_Click);
            // 
            // buttonManControlZ10p
            // 
            this.buttonManControlZ10p.Location = new System.Drawing.Point(287, 36);
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
            this.groupBox6.Location = new System.Drawing.Point(6, 114);
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
            this.groupBox5.Location = new System.Drawing.Point(7, 60);
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
            this.groupBox4.Location = new System.Drawing.Point(7, 6);
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
            this.pictureBox1.Location = new System.Drawing.Point(154, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonManControlX100m
            // 
            this.buttonManControlX100m.Location = new System.Drawing.Point(18, 172);
            this.buttonManControlX100m.Name = "buttonManControlX100m";
            this.buttonManControlX100m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX100m.TabIndex = 12;
            this.buttonManControlX100m.Text = "100";
            this.buttonManControlX100m.UseVisualStyleBackColor = true;
            this.buttonManControlX100m.Click += new System.EventHandler(this.buttonManControlX100m_Click);
            // 
            // buttonManControlX10m
            // 
            this.buttonManControlX10m.Location = new System.Drawing.Point(48, 172);
            this.buttonManControlX10m.Name = "buttonManControlX10m";
            this.buttonManControlX10m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX10m.TabIndex = 8;
            this.buttonManControlX10m.Text = "10";
            this.buttonManControlX10m.UseVisualStyleBackColor = true;
            this.buttonManControlX10m.Click += new System.EventHandler(this.buttonManControlX10m_Click);
            // 
            // buttonManControlX1m
            // 
            this.buttonManControlX1m.Location = new System.Drawing.Point(78, 172);
            this.buttonManControlX1m.Name = "buttonManControlX1m";
            this.buttonManControlX1m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX1m.TabIndex = 7;
            this.buttonManControlX1m.Text = "1";
            this.buttonManControlX1m.UseVisualStyleBackColor = true;
            this.buttonManControlX1m.Click += new System.EventHandler(this.buttonManControlX1m_Click);
            // 
            // buttonManControlX100p
            // 
            this.buttonManControlX100p.Location = new System.Drawing.Point(287, 172);
            this.buttonManControlX100p.Name = "buttonManControlX100p";
            this.buttonManControlX100p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX100p.TabIndex = 14;
            this.buttonManControlX100p.Text = "100";
            this.buttonManControlX100p.UseVisualStyleBackColor = true;
            this.buttonManControlX100p.Click += new System.EventHandler(this.buttonManControlX100p_Click);
            // 
            // buttonManControlX10p
            // 
            this.buttonManControlX10p.Location = new System.Drawing.Point(258, 172);
            this.buttonManControlX10p.Name = "buttonManControlX10p";
            this.buttonManControlX10p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX10p.TabIndex = 5;
            this.buttonManControlX10p.Text = "10";
            this.buttonManControlX10p.UseVisualStyleBackColor = true;
            this.buttonManControlX10p.Click += new System.EventHandler(this.buttonManControlX10p_Click);
            // 
            // buttonManControlY100m
            // 
            this.buttonManControlY100m.Location = new System.Drawing.Point(154, 308);
            this.buttonManControlY100m.Name = "buttonManControlY100m";
            this.buttonManControlY100m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY100m.TabIndex = 15;
            this.buttonManControlY100m.Text = "100";
            this.buttonManControlY100m.UseVisualStyleBackColor = true;
            this.buttonManControlY100m.Click += new System.EventHandler(this.buttonManControlY100m_Click);
            // 
            // buttonManControlY10m
            // 
            this.buttonManControlY10m.Location = new System.Drawing.Point(154, 278);
            this.buttonManControlY10m.Name = "buttonManControlY10m";
            this.buttonManControlY10m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY10m.TabIndex = 9;
            this.buttonManControlY10m.Text = "10";
            this.buttonManControlY10m.UseVisualStyleBackColor = true;
            this.buttonManControlY10m.Click += new System.EventHandler(this.buttonManControlY10m_Click);
            // 
            // buttonManControlY1m
            // 
            this.buttonManControlY1m.Location = new System.Drawing.Point(154, 248);
            this.buttonManControlY1m.Name = "buttonManControlY1m";
            this.buttonManControlY1m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY1m.TabIndex = 10;
            this.buttonManControlY1m.Text = "1";
            this.buttonManControlY1m.UseVisualStyleBackColor = true;
            this.buttonManControlY1m.Click += new System.EventHandler(this.buttonManControlY1m_Click);
            // 
            // buttonManControlY01m
            // 
            this.buttonManControlY01m.Location = new System.Drawing.Point(154, 218);
            this.buttonManControlY01m.Name = "buttonManControlY01m";
            this.buttonManControlY01m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY01m.TabIndex = 11;
            this.buttonManControlY01m.Text = "0.1";
            this.buttonManControlY01m.UseVisualStyleBackColor = true;
            this.buttonManControlY01m.Click += new System.EventHandler(this.buttonManControlY01m_Click);
            // 
            // buttonManControlY01p
            // 
            this.buttonManControlY01p.Location = new System.Drawing.Point(154, 126);
            this.buttonManControlY01p.Name = "buttonManControlY01p";
            this.buttonManControlY01p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY01p.TabIndex = 13;
            this.buttonManControlY01p.Text = "0.1";
            this.buttonManControlY01p.UseVisualStyleBackColor = true;
            this.buttonManControlY01p.Click += new System.EventHandler(this.buttonManControlY01p_Click);
            // 
            // buttonManControlX01m
            // 
            this.buttonManControlX01m.Location = new System.Drawing.Point(108, 172);
            this.buttonManControlX01m.Name = "buttonManControlX01m";
            this.buttonManControlX01m.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX01m.TabIndex = 6;
            this.buttonManControlX01m.Text = "0.1";
            this.buttonManControlX01m.UseVisualStyleBackColor = true;
            this.buttonManControlX01m.Click += new System.EventHandler(this.buttonManControlX01m_Click);
            // 
            // buttonManControlY1p
            // 
            this.buttonManControlY1p.Location = new System.Drawing.Point(154, 96);
            this.buttonManControlY1p.Name = "buttonManControlY1p";
            this.buttonManControlY1p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY1p.TabIndex = 2;
            this.buttonManControlY1p.Text = "1";
            this.buttonManControlY1p.UseVisualStyleBackColor = true;
            this.buttonManControlY1p.Click += new System.EventHandler(this.buttonManControlY1p_Click);
            // 
            // buttonManControlX1p
            // 
            this.buttonManControlX1p.Location = new System.Drawing.Point(229, 172);
            this.buttonManControlX1p.Name = "buttonManControlX1p";
            this.buttonManControlX1p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX1p.TabIndex = 4;
            this.buttonManControlX1p.Text = "1";
            this.buttonManControlX1p.UseVisualStyleBackColor = true;
            this.buttonManControlX1p.Click += new System.EventHandler(this.buttonManControlX1p_Click);
            // 
            // buttonManControlY10p
            // 
            this.buttonManControlY10p.Location = new System.Drawing.Point(154, 66);
            this.buttonManControlY10p.Name = "buttonManControlY10p";
            this.buttonManControlY10p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY10p.TabIndex = 1;
            this.buttonManControlY10p.Text = "10";
            this.buttonManControlY10p.UseVisualStyleBackColor = true;
            this.buttonManControlY10p.Click += new System.EventHandler(this.buttonManControlY10p_Click);
            // 
            // buttonManControlX01p
            // 
            this.buttonManControlX01p.Location = new System.Drawing.Point(200, 172);
            this.buttonManControlX01p.Name = "buttonManControlX01p";
            this.buttonManControlX01p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlX01p.TabIndex = 3;
            this.buttonManControlX01p.Text = "0.1";
            this.buttonManControlX01p.UseVisualStyleBackColor = true;
            this.buttonManControlX01p.Click += new System.EventHandler(this.buttonManControlX01p_Click);
            // 
            // buttonManControlY100p
            // 
            this.buttonManControlY100p.Location = new System.Drawing.Point(154, 36);
            this.buttonManControlY100p.Name = "buttonManControlY100p";
            this.buttonManControlY100p.Size = new System.Drawing.Size(40, 40);
            this.buttonManControlY100p.TabIndex = 0;
            this.buttonManControlY100p.Text = "100";
            this.buttonManControlY100p.UseVisualStyleBackColor = true;
            this.buttonManControlY100p.Click += new System.EventHandler(this.buttonManControlY100p_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(355, 388);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxYCoord);
            this.groupBox7.Controls.Add(this.textBoxZCoord);
            this.groupBox7.Controls.Add(this.textBoxXCoord);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Location = new System.Drawing.Point(304, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(188, 79);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Coordinates";
            // 
            // textBoxYCoord
            // 
            this.textBoxYCoord.Location = new System.Drawing.Point(66, 33);
            this.textBoxYCoord.Name = "textBoxYCoord";
            this.textBoxYCoord.Size = new System.Drawing.Size(100, 20);
            this.textBoxYCoord.TabIndex = 5;
            // 
            // textBoxZCoord
            // 
            this.textBoxZCoord.Location = new System.Drawing.Point(66, 53);
            this.textBoxZCoord.Name = "textBoxZCoord";
            this.textBoxZCoord.Size = new System.Drawing.Size(100, 20);
            this.textBoxZCoord.TabIndex = 4;
            // 
            // textBoxXCoord
            // 
            this.textBoxXCoord.Location = new System.Drawing.Point(66, 13);
            this.textBoxXCoord.Name = "textBoxXCoord";
            this.textBoxXCoord.Size = new System.Drawing.Size(100, 20);
            this.textBoxXCoord.TabIndex = 3;
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
            this.groupBox8.Location = new System.Drawing.Point(498, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(169, 79);
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
            this.buttonFileStart.Location = new System.Drawing.Point(6, 47);
            this.buttonFileStart.Name = "buttonFileStart";
            this.buttonFileStart.Size = new System.Drawing.Size(75, 23);
            this.buttonFileStart.TabIndex = 4;
            this.buttonFileStart.Text = "START";
            this.buttonFileStart.UseVisualStyleBackColor = true;
            this.buttonFileStart.Click += new System.EventHandler(this.buttonFileStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 523);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(695, 562);
            this.Name = "Form1";
            this.Text = "CycloneHost";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.GCode.ResumeLayout(false);
            this.GCode.PerformLayout();
            this.ManualControl.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
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
        private System.Windows.Forms.Integration.ElementHost gCodeView;
        private GCodeView gCodeView1;
        private System.Windows.Forms.Button buttonGcodeZoomMin;
        private System.Windows.Forms.Button buttonGcodeZoomPlu;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox textBoxYCoord;
        private System.Windows.Forms.TextBox textBoxZCoord;
        private System.Windows.Forms.TextBox textBoxXCoord;
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
    }
}