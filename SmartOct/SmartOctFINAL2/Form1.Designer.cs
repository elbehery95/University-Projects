namespace SmartOctFINAL2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.switchsPlace = new System.Windows.Forms.FlowLayoutPanel();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.cr = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.signIn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SekoP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.theStatesLabel = new System.Windows.Forms.Label();
            this.SekoU = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sensorsPlace = new System.Windows.Forms.FlowLayoutPanel();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton14 = new MaterialSkin.Controls.MaterialFlatButton();
            this.location = new MaterialSkin.Controls.MaterialFlatButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifications = new System.Windows.Forms.FlowLayoutPanel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.loadNameInfo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.theLoadId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.roomNameInfo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saveLoadConfig = new MaterialSkin.Controls.MaterialFlatButton();
            this.sensorSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.materialFlatButton9 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialFlatButton10 = new MaterialSkin.Controls.MaterialFlatButton();
            this.decIsionValue = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton12 = new MaterialSkin.Controls.MaterialFlatButton();
            this.actionLoadID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sensorIdSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saveForSensor = new MaterialSkin.Controls.MaterialFlatButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sensorTimer = new System.Windows.Forms.Timer(this.components);
            this.PWR = new MaterialSkin.Controls.MaterialFlatButton();
            this.switchsPlace.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sensorsPlace.SuspendLayout();
            this.notifications.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sensorSettings.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // switchsPlace
            // 
            this.switchsPlace.Controls.Add(this.materialFlatButton2);
            this.switchsPlace.Controls.Add(this.materialFlatButton8);
            this.switchsPlace.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.switchsPlace.Location = new System.Drawing.Point(302, 98);
            this.switchsPlace.Name = "switchsPlace";
            this.switchsPlace.Size = new System.Drawing.Size(258, 314);
            this.switchsPlace.TabIndex = 29;
            this.switchsPlace.Paint += new System.Windows.Forms.PaintEventHandler(this.switchsPlace_Paint);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Enabled = false;
            this.materialFlatButton2.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(55, 36);
            this.materialFlatButton2.TabIndex = 36;
            this.materialFlatButton2.Text = "loads";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Location = new System.Drawing.Point(4, 54);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton8.TabIndex = 38;
            this.materialFlatButton8.Text = "Settings";
            this.materialFlatButton8.UseVisualStyleBackColor = true;
            this.materialFlatButton8.Click += new System.EventHandler(this.materialFlatButton8_Click);
            // 
            // cr
            // 
            this.cr.AutoSize = true;
            this.cr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cr.Depth = 0;
            this.cr.Enabled = false;
            this.cr.Location = new System.Drawing.Point(7, 477);
            this.cr.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cr.MouseState = MaterialSkin.MouseState.HOVER;
            this.cr.Name = "cr";
            this.cr.Primary = false;
            this.cr.Size = new System.Drawing.Size(289, 36);
            this.cr.TabIndex = 32;
            this.cr.Text = "all rights reserved. copyright © 2015";
            this.cr.UseMnemonic = false;
            this.cr.UseVisualStyleBackColor = true;
            this.cr.Visible = false;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(0, 144);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(155, 30);
            this.materialCheckBox1.TabIndex = 33;
            this.materialCheckBox1.Text = "Power watchdog";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // signIn
            // 
            this.signIn.AutoSize = true;
            this.signIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signIn.Depth = 0;
            this.signIn.Enabled = false;
            this.signIn.Location = new System.Drawing.Point(204, 19);
            this.signIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.signIn.Name = "signIn";
            this.signIn.Primary = false;
            this.signIn.Size = new System.Drawing.Size(57, 36);
            this.signIn.TabIndex = 27;
            this.signIn.Text = "SignIn";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // SekoP
            // 
            this.SekoP.Depth = 0;
            this.SekoP.Hint = "Password";
            this.SekoP.Location = new System.Drawing.Point(3, 32);
            this.SekoP.MouseState = MaterialSkin.MouseState.HOVER;
            this.SekoP.Name = "SekoP";
            this.SekoP.PasswordChar = '\0';
            this.SekoP.SelectedText = "";
            this.SekoP.SelectionLength = 0;
            this.SekoP.SelectionStart = 0;
            this.SekoP.Size = new System.Drawing.Size(194, 23);
            this.SekoP.TabIndex = 25;
            this.SekoP.Tag = "";
            this.SekoP.UseSystemPasswordChar = true;
            // 
            // theStatesLabel
            // 
            this.theStatesLabel.AutoSize = true;
            this.theStatesLabel.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theStatesLabel.Location = new System.Drawing.Point(25, 78);
            this.theStatesLabel.Name = "theStatesLabel";
            this.theStatesLabel.Size = new System.Drawing.Size(93, 15);
            this.theStatesLabel.TabIndex = 28;
            this.theStatesLabel.Text = "Scanning your WIFI";
            // 
            // SekoU
            // 
            this.SekoU.Depth = 0;
            this.SekoU.Hint = "UserName";
            this.SekoU.Location = new System.Drawing.Point(3, 3);
            this.SekoU.MouseState = MaterialSkin.MouseState.HOVER;
            this.SekoU.Name = "SekoU";
            this.SekoU.PasswordChar = '\0';
            this.SekoU.SelectedText = "";
            this.SekoU.SelectionLength = 0;
            this.SekoU.SelectionStart = 0;
            this.SekoU.Size = new System.Drawing.Size(194, 23);
            this.SekoU.TabIndex = 26;
            this.SekoU.Tag = "";
            this.SekoU.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SekoU);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.theStatesLabel);
            this.panel1.Controls.Add(this.SekoP);
            this.panel1.Controls.Add(this.signIn);
            this.panel1.Location = new System.Drawing.Point(13, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 96);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SmartOctFINAL2.Properties.Resources.ajax_loader;
            this.pictureBox2.Location = new System.Drawing.Point(3, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // sensorsPlace
            // 
            this.sensorsPlace.Controls.Add(this.materialFlatButton3);
            this.sensorsPlace.Controls.Add(this.materialFlatButton14);
            this.sensorsPlace.Controls.Add(this.PWR);
            this.sensorsPlace.Controls.Add(this.materialCheckBox1);
            this.sensorsPlace.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sensorsPlace.Location = new System.Drawing.Point(566, 98);
            this.sensorsPlace.Name = "sensorsPlace";
            this.sensorsPlace.Size = new System.Drawing.Size(231, 314);
            this.sensorsPlace.TabIndex = 35;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Enabled = false;
            this.materialFlatButton3.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(72, 36);
            this.materialFlatButton3.TabIndex = 36;
            this.materialFlatButton3.Text = "sensors";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton14
            // 
            this.materialFlatButton14.AutoSize = true;
            this.materialFlatButton14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton14.Depth = 0;
            this.materialFlatButton14.Location = new System.Drawing.Point(4, 54);
            this.materialFlatButton14.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton14.Name = "materialFlatButton14";
            this.materialFlatButton14.Primary = false;
            this.materialFlatButton14.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton14.TabIndex = 39;
            this.materialFlatButton14.Text = "Settings";
            this.materialFlatButton14.UseVisualStyleBackColor = true;
            this.materialFlatButton14.Visible = false;
            this.materialFlatButton14.Click += new System.EventHandler(this.materialFlatButton14_Click);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.location.Depth = 0;
            this.location.Location = new System.Drawing.Point(13, 66);
            this.location.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.location.MouseState = MaterialSkin.MouseState.HOVER;
            this.location.Name = "location";
            this.location.Primary = false;
            this.location.Size = new System.Drawing.Size(56, 36);
            this.location.TabIndex = 36;
            this.location.Text = "HOME/";
            this.location.UseVisualStyleBackColor = true;
            this.location.Visible = false;
            this.location.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifications
            // 
            this.notifications.Controls.Add(this.materialFlatButton1);
            this.notifications.Controls.Add(this.panel2);
            this.notifications.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.notifications.Location = new System.Drawing.Point(803, 98);
            this.notifications.Name = "notifications";
            this.notifications.Size = new System.Drawing.Size(224, 314);
            this.notifications.TabIndex = 37;
            this.notifications.Visible = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Enabled = false;
            this.materialFlatButton1.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(114, 36);
            this.materialFlatButton1.TabIndex = 36;
            this.materialFlatButton1.Text = "LOAD Settings";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialFlatButton7);
            this.panel2.Controls.Add(this.materialFlatButton6);
            this.panel2.Controls.Add(this.materialFlatButton5);
            this.panel2.Controls.Add(this.loadNameInfo);
            this.panel2.Controls.Add(this.theLoadId);
            this.panel2.Controls.Add(this.roomNameInfo);
            this.panel2.Controls.Add(this.saveLoadConfig);
            this.panel2.Location = new System.Drawing.Point(3, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 240);
            this.panel2.TabIndex = 38;
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Enabled = false;
            this.materialFlatButton7.Location = new System.Drawing.Point(4, 160);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(89, 36);
            this.materialFlatButton7.TabIndex = 41;
            this.materialFlatButton7.Text = "Load name";
            this.materialFlatButton7.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Enabled = false;
            this.materialFlatButton6.Location = new System.Drawing.Point(4, 83);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(94, 36);
            this.materialFlatButton6.TabIndex = 40;
            this.materialFlatButton6.Text = "Room name";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Enabled = false;
            this.materialFlatButton5.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton5.TabIndex = 39;
            this.materialFlatButton5.Text = "Load ID";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            // 
            // loadNameInfo
            // 
            this.loadNameInfo.Depth = 0;
            this.loadNameInfo.Hint = "";
            this.loadNameInfo.Location = new System.Drawing.Point(4, 205);
            this.loadNameInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadNameInfo.Name = "loadNameInfo";
            this.loadNameInfo.PasswordChar = '\0';
            this.loadNameInfo.SelectedText = "";
            this.loadNameInfo.SelectionLength = 0;
            this.loadNameInfo.SelectionStart = 0;
            this.loadNameInfo.Size = new System.Drawing.Size(175, 23);
            this.loadNameInfo.TabIndex = 38;
            this.loadNameInfo.UseSystemPasswordChar = false;
            // 
            // theLoadId
            // 
            this.theLoadId.Depth = 0;
            this.theLoadId.Hint = "";
            this.theLoadId.Location = new System.Drawing.Point(4, 51);
            this.theLoadId.MouseState = MaterialSkin.MouseState.HOVER;
            this.theLoadId.Name = "theLoadId";
            this.theLoadId.PasswordChar = '\0';
            this.theLoadId.SelectedText = "";
            this.theLoadId.SelectionLength = 0;
            this.theLoadId.SelectionStart = 0;
            this.theLoadId.Size = new System.Drawing.Size(110, 23);
            this.theLoadId.TabIndex = 38;
            this.theLoadId.UseSystemPasswordChar = false;
            this.theLoadId.TextChanged += new System.EventHandler(this.theLoadId_TextChanged);
            // 
            // roomNameInfo
            // 
            this.roomNameInfo.Depth = 0;
            this.roomNameInfo.Hint = "";
            this.roomNameInfo.Location = new System.Drawing.Point(4, 128);
            this.roomNameInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.roomNameInfo.Name = "roomNameInfo";
            this.roomNameInfo.PasswordChar = '\0';
            this.roomNameInfo.SelectedText = "";
            this.roomNameInfo.SelectionLength = 0;
            this.roomNameInfo.SelectionStart = 0;
            this.roomNameInfo.Size = new System.Drawing.Size(175, 23);
            this.roomNameInfo.TabIndex = 38;
            this.roomNameInfo.UseSystemPasswordChar = false;
            // 
            // saveLoadConfig
            // 
            this.saveLoadConfig.AutoSize = true;
            this.saveLoadConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveLoadConfig.Depth = 0;
            this.saveLoadConfig.Location = new System.Drawing.Point(133, 6);
            this.saveLoadConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveLoadConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveLoadConfig.Name = "saveLoadConfig";
            this.saveLoadConfig.Primary = false;
            this.saveLoadConfig.Size = new System.Drawing.Size(46, 36);
            this.saveLoadConfig.TabIndex = 37;
            this.saveLoadConfig.Text = "Save";
            this.saveLoadConfig.UseVisualStyleBackColor = true;
            this.saveLoadConfig.Click += new System.EventHandler(this.saveLoadConfig_Click);
            // 
            // sensorSettings
            // 
            this.sensorSettings.Controls.Add(this.materialFlatButton9);
            this.sensorSettings.Controls.Add(this.panel3);
            this.sensorSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sensorSettings.Location = new System.Drawing.Point(803, 98);
            this.sensorSettings.Name = "sensorSettings";
            this.sensorSettings.Size = new System.Drawing.Size(224, 314);
            this.sensorSettings.TabIndex = 38;
            this.sensorSettings.Visible = false;
            // 
            // materialFlatButton9
            // 
            this.materialFlatButton9.AutoSize = true;
            this.materialFlatButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton9.Depth = 0;
            this.materialFlatButton9.Enabled = false;
            this.materialFlatButton9.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton9.Name = "materialFlatButton9";
            this.materialFlatButton9.Primary = false;
            this.materialFlatButton9.Size = new System.Drawing.Size(131, 36);
            this.materialFlatButton9.TabIndex = 36;
            this.materialFlatButton9.Text = "sensor Settings";
            this.materialFlatButton9.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.materialFlatButton10);
            this.panel3.Controls.Add(this.decIsionValue);
            this.panel3.Controls.Add(this.materialFlatButton12);
            this.panel3.Controls.Add(this.actionLoadID);
            this.panel3.Controls.Add(this.sensorIdSearch);
            this.panel3.Controls.Add(this.materialSingleLineTextField6);
            this.panel3.Controls.Add(this.saveForSensor);
            this.panel3.Location = new System.Drawing.Point(3, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 240);
            this.panel3.TabIndex = 38;
            // 
            // materialFlatButton10
            // 
            this.materialFlatButton10.AutoSize = true;
            this.materialFlatButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton10.Depth = 0;
            this.materialFlatButton10.Enabled = false;
            this.materialFlatButton10.Location = new System.Drawing.Point(4, 160);
            this.materialFlatButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton10.Name = "materialFlatButton10";
            this.materialFlatButton10.Primary = false;
            this.materialFlatButton10.Size = new System.Drawing.Size(92, 36);
            this.materialFlatButton10.TabIndex = 41;
            this.materialFlatButton10.Text = "close load";
            this.materialFlatButton10.UseVisualStyleBackColor = true;
            // 
            // decIsionValue
            // 
            this.decIsionValue.AutoSize = true;
            this.decIsionValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.decIsionValue.Depth = 0;
            this.decIsionValue.Enabled = false;
            this.decIsionValue.Location = new System.Drawing.Point(4, 83);
            this.decIsionValue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.decIsionValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.decIsionValue.Name = "decIsionValue";
            this.decIsionValue.Primary = false;
            this.decIsionValue.Size = new System.Drawing.Size(112, 36);
            this.decIsionValue.TabIndex = 40;
            this.decIsionValue.Text = "when value is";
            this.decIsionValue.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton12
            // 
            this.materialFlatButton12.AutoSize = true;
            this.materialFlatButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton12.Depth = 0;
            this.materialFlatButton12.Enabled = false;
            this.materialFlatButton12.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton12.Name = "materialFlatButton12";
            this.materialFlatButton12.Primary = false;
            this.materialFlatButton12.Size = new System.Drawing.Size(80, 36);
            this.materialFlatButton12.TabIndex = 39;
            this.materialFlatButton12.Text = "Sensor ID";
            this.materialFlatButton12.UseVisualStyleBackColor = true;
            // 
            // actionLoadID
            // 
            this.actionLoadID.Depth = 0;
            this.actionLoadID.Hint = "";
            this.actionLoadID.Location = new System.Drawing.Point(4, 205);
            this.actionLoadID.MouseState = MaterialSkin.MouseState.HOVER;
            this.actionLoadID.Name = "actionLoadID";
            this.actionLoadID.PasswordChar = '\0';
            this.actionLoadID.SelectedText = "";
            this.actionLoadID.SelectionLength = 0;
            this.actionLoadID.SelectionStart = 0;
            this.actionLoadID.Size = new System.Drawing.Size(175, 23);
            this.actionLoadID.TabIndex = 38;
            this.actionLoadID.UseSystemPasswordChar = false;
            // 
            // sensorIdSearch
            // 
            this.sensorIdSearch.Depth = 0;
            this.sensorIdSearch.Hint = "";
            this.sensorIdSearch.Location = new System.Drawing.Point(4, 51);
            this.sensorIdSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.sensorIdSearch.Name = "sensorIdSearch";
            this.sensorIdSearch.PasswordChar = '\0';
            this.sensorIdSearch.SelectedText = "";
            this.sensorIdSearch.SelectionLength = 0;
            this.sensorIdSearch.SelectionStart = 0;
            this.sensorIdSearch.Size = new System.Drawing.Size(110, 23);
            this.sensorIdSearch.TabIndex = 38;
            this.sensorIdSearch.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Hint = "";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(4, 128);
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '\0';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(175, 23);
            this.materialSingleLineTextField6.TabIndex = 38;
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            // 
            // saveForSensor
            // 
            this.saveForSensor.AutoSize = true;
            this.saveForSensor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveForSensor.Depth = 0;
            this.saveForSensor.Location = new System.Drawing.Point(133, 6);
            this.saveForSensor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveForSensor.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveForSensor.Name = "saveForSensor";
            this.saveForSensor.Primary = false;
            this.saveForSensor.Size = new System.Drawing.Size(46, 36);
            this.saveForSensor.TabIndex = 37;
            this.saveForSensor.Text = "Save";
            this.saveForSensor.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartOctFINAL2.Properties.Resources.sm;
            this.pictureBox1.Location = new System.Drawing.Point(40, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // sensorTimer
            // 
            this.sensorTimer.Interval = 10000;
            this.sensorTimer.Tick += new System.EventHandler(this.sensorTimer_Tick);
            // 
            // PWR
            // 
            this.PWR.AutoSize = true;
            this.PWR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PWR.Depth = 0;
            this.PWR.Location = new System.Drawing.Point(4, 102);
            this.PWR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PWR.MouseState = MaterialSkin.MouseState.HOVER;
            this.PWR.Name = "PWR";
            this.PWR.Primary = false;
            this.PWR.Size = new System.Drawing.Size(69, 36);
            this.PWR.TabIndex = 40;
            this.PWR.Text = "PWR=0W";
            this.PWR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.notifications);
            this.Controls.Add(this.sensorSettings);
            this.Controls.Add(this.location);
            this.Controls.Add(this.sensorsPlace);
            this.Controls.Add(this.cr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.switchsPlace);
            this.Name = "Form1";
            this.Text = "SmartOct.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.switchsPlace.ResumeLayout(false);
            this.switchsPlace.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sensorsPlace.ResumeLayout(false);
            this.sensorsPlace.PerformLayout();
            this.notifications.ResumeLayout(false);
            this.notifications.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sensorSettings.ResumeLayout(false);
            this.sensorSettings.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel switchsPlace;
        private MaterialSkin.Controls.MaterialFlatButton cr;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialFlatButton signIn;
        private MaterialSkin.Controls.MaterialSingleLineTextField SekoP;
        private System.Windows.Forms.Label theStatesLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField SekoU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel sensorsPlace;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton location;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel notifications;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton saveLoadConfig;
        private MaterialSkin.Controls.MaterialSingleLineTextField loadNameInfo;
        private MaterialSkin.Controls.MaterialSingleLineTextField roomNameInfo;
        private MaterialSkin.Controls.MaterialSingleLineTextField theLoadId;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton7;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton14;
        private System.Windows.Forms.FlowLayoutPanel sensorSettings;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton9;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton10;
        private MaterialSkin.Controls.MaterialFlatButton decIsionValue;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton12;
        private MaterialSkin.Controls.MaterialSingleLineTextField actionLoadID;
        private MaterialSkin.Controls.MaterialSingleLineTextField sensorIdSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
        private MaterialSkin.Controls.MaterialFlatButton saveForSensor;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer sensorTimer;
        private MaterialSkin.Controls.MaterialFlatButton PWR;


    }
}

