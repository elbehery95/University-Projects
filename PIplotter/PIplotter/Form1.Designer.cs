namespace PIplotter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stepOneButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.firstView = new System.Windows.Forms.GroupBox();
            this.avaCOMports = new MetroFramework.Controls.MetroComboBox();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.sndView = new System.Windows.Forms.GroupBox();
            this.backToMenu = new MaterialSkin.Controls.MaterialFlatButton();
            this.plotVoltage = new MaterialSkin.Controls.MaterialFlatButton();
            this.mesVoltage = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.measureVoltsBox = new System.Windows.Forms.GroupBox();
            this.back1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.VoltageMeterLabel = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.plotView = new System.Windows.Forms.GroupBox();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.firstView.SuspendLayout();
            this.sndView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.measureVoltsBox.SuspendLayout();
            this.plotView.SuspendLayout();
            this.SuspendLayout();
            // 
            // stepOneButton
            // 
            this.stepOneButton.AutoSize = true;
            this.stepOneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stepOneButton.Depth = 0;
            this.stepOneButton.Location = new System.Drawing.Point(195, 15);
            this.stepOneButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stepOneButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.stepOneButton.Name = "stepOneButton";
            this.stepOneButton.Primary = false;
            this.stepOneButton.Size = new System.Drawing.Size(121, 36);
            this.stepOneButton.TabIndex = 1;
            this.stepOneButton.Text = "Press to start";
            this.stepOneButton.UseVisualStyleBackColor = true;
            this.stepOneButton.Click += new System.EventHandler(this.stepOneButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 70);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(137, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "*Select a COM port";
            // 
            // firstView
            // 
            this.firstView.Controls.Add(this.avaCOMports);
            this.firstView.Controls.Add(this.materialFlatButton2);
            this.firstView.Controls.Add(this.stepOneButton);
            this.firstView.Controls.Add(this.materialLabel1);
            this.firstView.Location = new System.Drawing.Point(12, 12);
            this.firstView.Name = "firstView";
            this.firstView.Size = new System.Drawing.Size(345, 109);
            this.firstView.TabIndex = 4;
            this.firstView.TabStop = false;
            // 
            // avaCOMports
            // 
            this.avaCOMports.FormattingEnabled = true;
            this.avaCOMports.ItemHeight = 23;
            this.avaCOMports.Location = new System.Drawing.Point(6, 19);
            this.avaCOMports.Name = "avaCOMports";
            this.avaCOMports.Size = new System.Drawing.Size(121, 29);
            this.avaCOMports.TabIndex = 0;
            this.avaCOMports.UseSelectable = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(195, 53);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(70, 36);
            this.materialFlatButton2.TabIndex = 3;
            this.materialFlatButton2.Text = "Refresh";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // sndView
            // 
            this.sndView.Controls.Add(this.backToMenu);
            this.sndView.Controls.Add(this.plotVoltage);
            this.sndView.Controls.Add(this.mesVoltage);
            this.sndView.Controls.Add(this.pictureBox2);
            this.sndView.Controls.Add(this.pictureBox1);
            this.sndView.Location = new System.Drawing.Point(512, 12);
            this.sndView.Name = "sndView";
            this.sndView.Size = new System.Drawing.Size(399, 145);
            this.sndView.TabIndex = 5;
            this.sndView.TabStop = false;
            // 
            // backToMenu
            // 
            this.backToMenu.AutoSize = true;
            this.backToMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backToMenu.Depth = 0;
            this.backToMenu.Location = new System.Drawing.Point(158, 95);
            this.backToMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backToMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.Primary = false;
            this.backToMenu.Size = new System.Drawing.Size(47, 36);
            this.backToMenu.TabIndex = 5;
            this.backToMenu.Text = "Back";
            this.backToMenu.UseVisualStyleBackColor = true;
            this.backToMenu.Click += new System.EventHandler(this.backToMenu_Click);
            // 
            // plotVoltage
            // 
            this.plotVoltage.AutoSize = true;
            this.plotVoltage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plotVoltage.Depth = 0;
            this.plotVoltage.Location = new System.Drawing.Point(220, 19);
            this.plotVoltage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.plotVoltage.MouseState = MaterialSkin.MouseState.HOVER;
            this.plotVoltage.Name = "plotVoltage";
            this.plotVoltage.Primary = false;
            this.plotVoltage.Size = new System.Drawing.Size(166, 36);
            this.plotVoltage.TabIndex = 4;
            this.plotVoltage.Text = "Plot voltage vs time";
            this.plotVoltage.UseVisualStyleBackColor = true;
            this.plotVoltage.Click += new System.EventHandler(this.plotVoltage_Click);
            // 
            // mesVoltage
            // 
            this.mesVoltage.AutoSize = true;
            this.mesVoltage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mesVoltage.Depth = 0;
            this.mesVoltage.Location = new System.Drawing.Point(7, 19);
            this.mesVoltage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mesVoltage.MouseState = MaterialSkin.MouseState.HOVER;
            this.mesVoltage.Name = "mesVoltage";
            this.mesVoltage.Primary = false;
            this.mesVoltage.Size = new System.Drawing.Size(138, 36);
            this.mesVoltage.TabIndex = 3;
            this.mesVoltage.Text = "Measure voltage";
            this.mesVoltage.UseVisualStyleBackColor = true;
            this.mesVoltage.Click += new System.EventHandler(this.mesVoltage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PIplotter.Properties.Resources.speedometer;
            this.pictureBox2.Location = new System.Drawing.Point(37, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // measureVoltsBox
            // 
            this.measureVoltsBox.Controls.Add(this.back1);
            this.measureVoltsBox.Controls.Add(this.label2);
            this.measureVoltsBox.Controls.Add(this.VoltageMeterLabel);
            this.measureVoltsBox.Location = new System.Drawing.Point(512, 175);
            this.measureVoltsBox.Name = "measureVoltsBox";
            this.measureVoltsBox.Size = new System.Drawing.Size(399, 145);
            this.measureVoltsBox.TabIndex = 6;
            this.measureVoltsBox.TabStop = false;
            // 
            // back1
            // 
            this.back1.AutoSize = true;
            this.back1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back1.Depth = 0;
            this.back1.Location = new System.Drawing.Point(18, 100);
            this.back1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.back1.MouseState = MaterialSkin.MouseState.HOVER;
            this.back1.Name = "back1";
            this.back1.Primary = false;
            this.back1.Size = new System.Drawing.Size(47, 36);
            this.back1.TabIndex = 2;
            this.back1.Text = "Back";
            this.back1.UseVisualStyleBackColor = true;
            this.back1.Click += new System.EventHandler(this.back1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Proxy 9", 40F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(304, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "V";
            // 
            // VoltageMeterLabel
            // 
            this.VoltageMeterLabel.AutoSize = true;
            this.VoltageMeterLabel.Font = new System.Drawing.Font("Proxy 7", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoltageMeterLabel.ForeColor = System.Drawing.Color.Red;
            this.VoltageMeterLabel.Location = new System.Drawing.Point(6, 27);
            this.VoltageMeterLabel.Name = "VoltageMeterLabel";
            this.VoltageMeterLabel.Size = new System.Drawing.Size(241, 67);
            this.VoltageMeterLabel.TabIndex = 0;
            this.VoltageMeterLabel.Text = "0.00000";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(6, 11);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(494, 167);
            this.zedGraphControl1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // plotView
            // 
            this.plotView.Controls.Add(this.materialFlatButton4);
            this.plotView.Controls.Add(this.materialFlatButton1);
            this.plotView.Controls.Add(this.zedGraphControl1);
            this.plotView.Location = new System.Drawing.Point(12, 191);
            this.plotView.Name = "plotView";
            this.plotView.Size = new System.Drawing.Size(444, 78);
            this.plotView.TabIndex = 8;
            this.plotView.TabStop = false;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(182, 33);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(47, 36);
            this.materialFlatButton4.TabIndex = 8;
            this.materialFlatButton4.Text = "Back";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(10, 33);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(164, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "Start/Stop plotting";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 378);
            this.Controls.Add(this.plotView);
            this.Controls.Add(this.measureVoltsBox);
            this.Controls.Add(this.sndView);
            this.Controls.Add(this.firstView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PI VirtualVoltmeter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.firstView.ResumeLayout(false);
            this.firstView.PerformLayout();
            this.sndView.ResumeLayout(false);
            this.sndView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.measureVoltsBox.ResumeLayout(false);
            this.measureVoltsBox.PerformLayout();
            this.plotView.ResumeLayout(false);
            this.plotView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton stepOneButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox firstView;
        private System.Windows.Forms.GroupBox sndView;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton plotVoltage;
        private MaterialSkin.Controls.MaterialFlatButton mesVoltage;
        private System.Windows.Forms.GroupBox measureVoltsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VoltageMeterLabel;
        private MaterialSkin.Controls.MaterialFlatButton back1;
        private MaterialSkin.Controls.MaterialFlatButton backToMenu;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox plotView;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MetroFramework.Controls.MetroComboBox avaCOMports;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;


    }
}

