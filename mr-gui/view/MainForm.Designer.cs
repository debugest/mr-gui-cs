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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.contrastPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastImageBox)).BeginInit();
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
            this.salinePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salinePanel.BackgroundImage")));
            this.salinePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salinePanel.Location = new System.Drawing.Point(435, 9);
            this.salinePanel.Margin = new System.Windows.Forms.Padding(0);
            this.salinePanel.Name = "salinePanel";
            this.salinePanel.Size = new System.Drawing.Size(400, 260);
            this.salinePanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(91)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1024, 709);
            this.Controls.Add(this.salinePanel);
            this.Controls.Add(this.contrastPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.contrastPanel.ResumeLayout(false);
            this.contrastPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contrastPanel;
        private System.Windows.Forms.Panel salinePanel;
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

    }
}