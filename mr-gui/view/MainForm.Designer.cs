namespace mr.view
{
    partial class MainForm
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
            this.contrastPanel = new System.Windows.Forms.Panel();
            this.timeBtn = new System.Windows.Forms.Button();
            this.contrastTitleLbl = new System.Windows.Forms.Label();
            this.contrastImageBox = new System.Windows.Forms.PictureBox();
            this.timingLabel = new System.Windows.Forms.Label();
            this.timeTitleLabel = new System.Windows.Forms.Label();
            this.contrastDivideLine2 = new System.Windows.Forms.Panel();
            this.contrastInjectedUnitLbl = new System.Windows.Forms.Label();
            this.contrastInjectedNumberLbl = new System.Windows.Forms.Label();
            this.contrastInjectedTitleLbl = new System.Windows.Forms.Label();
            this.contrastRemainUnitLbl = new System.Windows.Forms.Label();
            this.contrastDivideLine1 = new System.Windows.Forms.Panel();
            this.contrastRemainNumberLbl = new System.Windows.Forms.Label();
            this.constrastRemainTitleLbl = new System.Windows.Forms.Label();
            this.salinePanel = new System.Windows.Forms.Panel();
            this.kvoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.salineImageBox = new System.Windows.Forms.PictureBox();
            this.salineDivideLine2 = new System.Windows.Forms.Panel();
            this.salineInjectedUnitLbl = new System.Windows.Forms.Label();
            this.salineInjectedNumberLbl = new System.Windows.Forms.Label();
            this.salineInjectedTitleLbl = new System.Windows.Forms.Label();
            this.salineRemainUnitLbl = new System.Windows.Forms.Label();
            this.salineDivideLine1 = new System.Windows.Forms.Panel();
            this.salineRemainNumberLbl = new System.Windows.Forms.Label();
            this.salineRemainTitleLbl = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contrastPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastImageBox)).BeginInit();
            this.salinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salineImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contrastPanel
            // 
            this.contrastPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(61)))), ((int)(((byte)(140)))));
            this.contrastPanel.BackgroundImage = global::mr.Properties.Resources.syringe_background;
            this.contrastPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contrastPanel.Controls.Add(this.timeBtn);
            this.contrastPanel.Controls.Add(this.contrastTitleLbl);
            this.contrastPanel.Controls.Add(this.contrastImageBox);
            this.contrastPanel.Controls.Add(this.timingLabel);
            this.contrastPanel.Controls.Add(this.timeTitleLabel);
            this.contrastPanel.Controls.Add(this.contrastDivideLine2);
            this.contrastPanel.Controls.Add(this.contrastInjectedUnitLbl);
            this.contrastPanel.Controls.Add(this.contrastInjectedNumberLbl);
            this.contrastPanel.Controls.Add(this.contrastInjectedTitleLbl);
            this.contrastPanel.Controls.Add(this.contrastRemainUnitLbl);
            this.contrastPanel.Controls.Add(this.contrastDivideLine1);
            this.contrastPanel.Controls.Add(this.contrastRemainNumberLbl);
            this.contrastPanel.Controls.Add(this.constrastRemainTitleLbl);
            this.contrastPanel.Location = new System.Drawing.Point(25, 9);
            this.contrastPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contrastPanel.Name = "contrastPanel";
            this.contrastPanel.Size = new System.Drawing.Size(400, 260);
            this.contrastPanel.TabIndex = 0;
            // 
            // timeBtn
            // 
            this.timeBtn.BackgroundImage = global::mr.Properties.Resources.enter_key_up;
            this.timeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timeBtn.FlatAppearance.BorderSize = 0;
            this.timeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeBtn.ForeColor = System.Drawing.Color.Red;
            this.timeBtn.Location = new System.Drawing.Point(283, 199);
            this.timeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Size = new System.Drawing.Size(90, 56);
            this.timeBtn.TabIndex = 11;
            this.timeBtn.Text = "Suspend\nTiming";
            this.timeBtn.UseVisualStyleBackColor = true;
            this.timeBtn.Visible = false;
            this.timeBtn.Click += new System.EventHandler(this.timeBtn_Click);
            this.timeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeBtn_MouseDown);
            this.timeBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.timeBtn_MouseUp);
            // 
            // contrastTitleLbl
            // 
            this.contrastTitleLbl.AutoSize = true;
            this.contrastTitleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contrastTitleLbl.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contrastTitleLbl.ForeColor = System.Drawing.Color.Tan;
            this.contrastTitleLbl.Location = new System.Drawing.Point(306, 15);
            this.contrastTitleLbl.Name = "contrastTitleLbl";
            this.contrastTitleLbl.Size = new System.Drawing.Size(71, 14);
            this.contrastTitleLbl.TabIndex = 10;
            this.contrastTitleLbl.Text = "Contrast";
            // 
            // contrastImageBox
            // 
            this.contrastImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contrastImageBox.ErrorImage = null;
            this.contrastImageBox.InitialImage = null;
            this.contrastImageBox.Location = new System.Drawing.Point(213, 35);
            this.contrastImageBox.Name = "contrastImageBox";
            this.contrastImageBox.Size = new System.Drawing.Size(160, 160);
            this.contrastImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contrastImageBox.TabIndex = 9;
            this.contrastImageBox.TabStop = false;
            // 
            // timingLabel
            // 
            this.timingLabel.AutoSize = true;
            this.timingLabel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timingLabel.ForeColor = System.Drawing.Color.Lime;
            this.timingLabel.Location = new System.Drawing.Point(20, 210);
            this.timingLabel.Name = "timingLabel";
            this.timingLabel.Size = new System.Drawing.Size(70, 21);
            this.timingLabel.TabIndex = 8;
            this.timingLabel.Text = "--:--";
            // 
            // timeTitleLabel
            // 
            this.timeTitleLabel.AutoSize = true;
            this.timeTitleLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeTitleLabel.ForeColor = System.Drawing.Color.Lime;
            this.timeTitleLabel.Location = new System.Drawing.Point(21, 185);
            this.timeTitleLabel.Name = "timeTitleLabel";
            this.timeTitleLabel.Size = new System.Drawing.Size(125, 16);
            this.timeTitleLabel.TabIndex = 7;
            this.timeTitleLabel.Text = "Elaspsed Time";
            // 
            // contrastDivideLine2
            // 
            this.contrastDivideLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(91)))), ((int)(((byte)(166)))));
            this.contrastDivideLine2.Location = new System.Drawing.Point(18, 171);
            this.contrastDivideLine2.Name = "contrastDivideLine2";
            this.contrastDivideLine2.Size = new System.Drawing.Size(175, 5);
            this.contrastDivideLine2.TabIndex = 3;
            // 
            // contrastInjectedUnitLbl
            // 
            this.contrastInjectedUnitLbl.AutoSize = true;
            this.contrastInjectedUnitLbl.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contrastInjectedUnitLbl.ForeColor = System.Drawing.Color.White;
            this.contrastInjectedUnitLbl.Location = new System.Drawing.Point(72, 145);
            this.contrastInjectedUnitLbl.Name = "contrastInjectedUnitLbl";
            this.contrastInjectedUnitLbl.Size = new System.Drawing.Size(34, 21);
            this.contrastInjectedUnitLbl.TabIndex = 6;
            this.contrastInjectedUnitLbl.Text = "ml";
            // 
            // contrastInjectedNumberLbl
            // 
            this.contrastInjectedNumberLbl.AutoSize = true;
            this.contrastInjectedNumberLbl.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contrastInjectedNumberLbl.ForeColor = System.Drawing.Color.White;
            this.contrastInjectedNumberLbl.Location = new System.Drawing.Point(20, 144);
            this.contrastInjectedNumberLbl.Name = "contrastInjectedNumberLbl";
            this.contrastInjectedNumberLbl.Size = new System.Drawing.Size(46, 21);
            this.contrastInjectedNumberLbl.TabIndex = 5;
            this.contrastInjectedNumberLbl.Text = "---";
            // 
            // contrastInjectedTitleLbl
            // 
            this.contrastInjectedTitleLbl.AutoSize = true;
            this.contrastInjectedTitleLbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contrastInjectedTitleLbl.ForeColor = System.Drawing.Color.White;
            this.contrastInjectedTitleLbl.Location = new System.Drawing.Point(20, 120);
            this.contrastInjectedTitleLbl.Name = "contrastInjectedTitleLbl";
            this.contrastInjectedTitleLbl.Size = new System.Drawing.Size(143, 16);
            this.contrastInjectedTitleLbl.TabIndex = 4;
            this.contrastInjectedTitleLbl.Text = "Volume Injected";
            // 
            // contrastRemainUnitLbl
            // 
            this.contrastRemainUnitLbl.AutoSize = true;
            this.contrastRemainUnitLbl.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contrastRemainUnitLbl.ForeColor = System.Drawing.Color.White;
            this.contrastRemainUnitLbl.Location = new System.Drawing.Point(72, 76);
            this.contrastRemainUnitLbl.Name = "contrastRemainUnitLbl";
            this.contrastRemainUnitLbl.Size = new System.Drawing.Size(34, 21);
            this.contrastRemainUnitLbl.TabIndex = 3;
            this.contrastRemainUnitLbl.Text = "ml";
            // 
            // contrastDivideLine1
            // 
            this.contrastDivideLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(91)))), ((int)(((byte)(166)))));
            this.contrastDivideLine1.Location = new System.Drawing.Point(18, 104);
            this.contrastDivideLine1.Name = "contrastDivideLine1";
            this.contrastDivideLine1.Size = new System.Drawing.Size(175, 5);
            this.contrastDivideLine1.TabIndex = 2;
            // 
            // contrastRemainNumberLbl
            // 
            this.contrastRemainNumberLbl.AutoSize = true;
            this.contrastRemainNumberLbl.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contrastRemainNumberLbl.ForeColor = System.Drawing.Color.White;
            this.contrastRemainNumberLbl.Location = new System.Drawing.Point(20, 75);
            this.contrastRemainNumberLbl.Name = "contrastRemainNumberLbl";
            this.contrastRemainNumberLbl.Size = new System.Drawing.Size(46, 21);
            this.contrastRemainNumberLbl.TabIndex = 1;
            this.contrastRemainNumberLbl.Text = "---";
            // 
            // constrastRemainTitleLbl
            // 
            this.constrastRemainTitleLbl.AutoSize = true;
            this.constrastRemainTitleLbl.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.constrastRemainTitleLbl.ForeColor = System.Drawing.Color.White;
            this.constrastRemainTitleLbl.Location = new System.Drawing.Point(20, 25);
            this.constrastRemainTitleLbl.Name = "constrastRemainTitleLbl";
            this.constrastRemainTitleLbl.Size = new System.Drawing.Size(118, 42);
            this.constrastRemainTitleLbl.TabIndex = 0;
            this.constrastRemainTitleLbl.Text = "Volume\nRemaining";
            // 
            // salinePanel
            // 
            this.salinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(61)))), ((int)(((byte)(140)))));
            this.salinePanel.BackgroundImage = global::mr.Properties.Resources.syringe_background;
            this.salinePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salinePanel.Controls.Add(this.kvoBtn);
            this.salinePanel.Controls.Add(this.label1);
            this.salinePanel.Controls.Add(this.salineImageBox);
            this.salinePanel.Controls.Add(this.salineDivideLine2);
            this.salinePanel.Controls.Add(this.salineInjectedUnitLbl);
            this.salinePanel.Controls.Add(this.salineInjectedNumberLbl);
            this.salinePanel.Controls.Add(this.salineInjectedTitleLbl);
            this.salinePanel.Controls.Add(this.salineRemainUnitLbl);
            this.salinePanel.Controls.Add(this.salineDivideLine1);
            this.salinePanel.Controls.Add(this.salineRemainNumberLbl);
            this.salinePanel.Controls.Add(this.salineRemainTitleLbl);
            this.salinePanel.Location = new System.Drawing.Point(435, 9);
            this.salinePanel.Margin = new System.Windows.Forms.Padding(0);
            this.salinePanel.Name = "salinePanel";
            this.salinePanel.Size = new System.Drawing.Size(400, 260);
            this.salinePanel.TabIndex = 12;
            // 
            // kvoBtn
            // 
            this.kvoBtn.BackgroundImage = global::mr.Properties.Resources.enter_key_up;
            this.kvoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kvoBtn.FlatAppearance.BorderSize = 0;
            this.kvoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kvoBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kvoBtn.ForeColor = System.Drawing.Color.Red;
            this.kvoBtn.Location = new System.Drawing.Point(23, 199);
            this.kvoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.kvoBtn.Name = "kvoBtn";
            this.kvoBtn.Size = new System.Drawing.Size(90, 56);
            this.kvoBtn.TabIndex = 11;
            this.kvoBtn.Text = "KVO OFF";
            this.kvoBtn.UseVisualStyleBackColor = true;
            this.kvoBtn.Click += new System.EventHandler(this.kvoBtn_Click);
            this.kvoBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kvoBtn_MouseDown);
            this.kvoBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kvoBtn_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(306, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Saline";
            // 
            // salineImageBox
            // 
            this.salineImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salineImageBox.ErrorImage = null;
            this.salineImageBox.InitialImage = null;
            this.salineImageBox.Location = new System.Drawing.Point(213, 35);
            this.salineImageBox.Name = "salineImageBox";
            this.salineImageBox.Size = new System.Drawing.Size(160, 160);
            this.salineImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.salineImageBox.TabIndex = 9;
            this.salineImageBox.TabStop = false;
            // 
            // salineDivideLine2
            // 
            this.salineDivideLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(91)))), ((int)(((byte)(166)))));
            this.salineDivideLine2.Location = new System.Drawing.Point(18, 171);
            this.salineDivideLine2.Name = "salineDivideLine2";
            this.salineDivideLine2.Size = new System.Drawing.Size(175, 5);
            this.salineDivideLine2.TabIndex = 3;
            // 
            // salineInjectedUnitLbl
            // 
            this.salineInjectedUnitLbl.AutoSize = true;
            this.salineInjectedUnitLbl.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.salineInjectedUnitLbl.ForeColor = System.Drawing.Color.White;
            this.salineInjectedUnitLbl.Location = new System.Drawing.Point(72, 145);
            this.salineInjectedUnitLbl.Name = "salineInjectedUnitLbl";
            this.salineInjectedUnitLbl.Size = new System.Drawing.Size(34, 21);
            this.salineInjectedUnitLbl.TabIndex = 6;
            this.salineInjectedUnitLbl.Text = "ml";
            // 
            // salineInjectedNumberLbl
            // 
            this.salineInjectedNumberLbl.AutoSize = true;
            this.salineInjectedNumberLbl.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.salineInjectedNumberLbl.ForeColor = System.Drawing.Color.White;
            this.salineInjectedNumberLbl.Location = new System.Drawing.Point(20, 144);
            this.salineInjectedNumberLbl.Name = "salineInjectedNumberLbl";
            this.salineInjectedNumberLbl.Size = new System.Drawing.Size(46, 21);
            this.salineInjectedNumberLbl.TabIndex = 5;
            this.salineInjectedNumberLbl.Text = "---";
            // 
            // salineInjectedTitleLbl
            // 
            this.salineInjectedTitleLbl.AutoSize = true;
            this.salineInjectedTitleLbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.salineInjectedTitleLbl.ForeColor = System.Drawing.Color.White;
            this.salineInjectedTitleLbl.Location = new System.Drawing.Point(20, 120);
            this.salineInjectedTitleLbl.Name = "salineInjectedTitleLbl";
            this.salineInjectedTitleLbl.Size = new System.Drawing.Size(143, 16);
            this.salineInjectedTitleLbl.TabIndex = 4;
            this.salineInjectedTitleLbl.Text = "Volume Injected";
            // 
            // salineRemainUnitLbl
            // 
            this.salineRemainUnitLbl.AutoSize = true;
            this.salineRemainUnitLbl.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.salineRemainUnitLbl.ForeColor = System.Drawing.Color.White;
            this.salineRemainUnitLbl.Location = new System.Drawing.Point(72, 76);
            this.salineRemainUnitLbl.Name = "salineRemainUnitLbl";
            this.salineRemainUnitLbl.Size = new System.Drawing.Size(34, 21);
            this.salineRemainUnitLbl.TabIndex = 3;
            this.salineRemainUnitLbl.Text = "ml";
            // 
            // salineDivideLine1
            // 
            this.salineDivideLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(91)))), ((int)(((byte)(166)))));
            this.salineDivideLine1.Location = new System.Drawing.Point(18, 104);
            this.salineDivideLine1.Name = "salineDivideLine1";
            this.salineDivideLine1.Size = new System.Drawing.Size(175, 5);
            this.salineDivideLine1.TabIndex = 2;
            // 
            // salineRemainNumberLbl
            // 
            this.salineRemainNumberLbl.AutoSize = true;
            this.salineRemainNumberLbl.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.salineRemainNumberLbl.ForeColor = System.Drawing.Color.White;
            this.salineRemainNumberLbl.Location = new System.Drawing.Point(20, 75);
            this.salineRemainNumberLbl.Name = "salineRemainNumberLbl";
            this.salineRemainNumberLbl.Size = new System.Drawing.Size(46, 21);
            this.salineRemainNumberLbl.TabIndex = 1;
            this.salineRemainNumberLbl.Text = "---";
            // 
            // salineRemainTitleLbl
            // 
            this.salineRemainTitleLbl.AutoSize = true;
            this.salineRemainTitleLbl.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.salineRemainTitleLbl.ForeColor = System.Drawing.Color.White;
            this.salineRemainTitleLbl.Location = new System.Drawing.Point(20, 25);
            this.salineRemainTitleLbl.Name = "salineRemainTitleLbl";
            this.salineRemainTitleLbl.Size = new System.Drawing.Size(118, 42);
            this.salineRemainTitleLbl.TabIndex = 0;
            this.salineRemainTitleLbl.Text = "Volume\nRemaining";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(861, 53);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 13;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(861, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(861, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(91)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1024, 709);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.salinePanel);
            this.Controls.Add(this.contrastPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.contrastPanel.ResumeLayout(false);
            this.contrastPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastImageBox)).EndInit();
            this.salinePanel.ResumeLayout(false);
            this.salinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salineImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contrastPanel;
        private System.Windows.Forms.Label constrastRemainTitleLbl;
        System.Windows.Forms.Label contrastRemainNumberLbl;
        private System.Windows.Forms.Panel contrastDivideLine1;
        private System.Windows.Forms.Label contrastRemainUnitLbl;
        private System.Windows.Forms.Label contrastInjectedUnitLbl;
        System.Windows.Forms.Label contrastInjectedNumberLbl;
        private System.Windows.Forms.Label contrastInjectedTitleLbl;
        System.Windows.Forms.Label timingLabel;
        private System.Windows.Forms.Label timeTitleLabel;
        private System.Windows.Forms.Panel contrastDivideLine2;
        private System.Windows.Forms.PictureBox contrastImageBox;
        private System.Windows.Forms.Label contrastTitleLbl;
        private System.Windows.Forms.Button timeBtn;
        private System.Windows.Forms.Panel salinePanel;
        private System.Windows.Forms.Button kvoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox salineImageBox;
        private System.Windows.Forms.Panel salineDivideLine2;
        private System.Windows.Forms.Label salineInjectedUnitLbl;
        private System.Windows.Forms.Label salineInjectedNumberLbl;
        private System.Windows.Forms.Label salineInjectedTitleLbl;
        private System.Windows.Forms.Label salineRemainUnitLbl;
        private System.Windows.Forms.Panel salineDivideLine1;
        private System.Windows.Forms.Label salineRemainNumberLbl;
        private System.Windows.Forms.Label salineRemainTitleLbl;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}