namespace mr.view
{
    partial class PhaseSelectForm
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
            this.pauseBtn = new System.Windows.Forms.Button();
            this.timedPauseBtn = new System.Windows.Forms.Button();
            this.salineBtn = new System.Windows.Forms.Button();
            this.contrastBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.infoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackgroundImage = global::mr.Properties.Resources.enter_key_up;
            this.pauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseBtn.FlatAppearance.BorderSize = 0;
            this.pauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseBtn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pauseBtn.ForeColor = System.Drawing.Color.White;
            this.pauseBtn.Location = new System.Drawing.Point(12, 81);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(160, 78);
            this.pauseBtn.TabIndex = 0;
            this.pauseBtn.Text = "PAUSE";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.phaseBtn_Click);
            this.pauseBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseDown);
            this.pauseBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseUp);
            // 
            // timedPauseBtn
            // 
            this.timedPauseBtn.BackgroundImage = global::mr.Properties.Resources.enter_key_up;
            this.timedPauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timedPauseBtn.FlatAppearance.BorderSize = 0;
            this.timedPauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timedPauseBtn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timedPauseBtn.ForeColor = System.Drawing.Color.White;
            this.timedPauseBtn.Location = new System.Drawing.Point(183, 81);
            this.timedPauseBtn.Name = "timedPauseBtn";
            this.timedPauseBtn.Size = new System.Drawing.Size(160, 78);
            this.timedPauseBtn.TabIndex = 1;
            this.timedPauseBtn.Text = "TIMED\nPAUSE";
            this.timedPauseBtn.UseVisualStyleBackColor = true;
            this.timedPauseBtn.Click += new System.EventHandler(this.timedPauseBtn_Click);
            this.timedPauseBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseDown);
            this.timedPauseBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseUp);
            // 
            // salineBtn
            // 
            this.salineBtn.BackgroundImage = global::mr.Properties.Resources.enter_key_up;
            this.salineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salineBtn.FlatAppearance.BorderSize = 0;
            this.salineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salineBtn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.salineBtn.ForeColor = System.Drawing.Color.White;
            this.salineBtn.Location = new System.Drawing.Point(183, 165);
            this.salineBtn.Name = "salineBtn";
            this.salineBtn.Size = new System.Drawing.Size(160, 78);
            this.salineBtn.TabIndex = 3;
            this.salineBtn.Text = "SALINE";
            this.salineBtn.UseVisualStyleBackColor = true;
            this.salineBtn.Click += new System.EventHandler(this.phaseBtn_Click);
            this.salineBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseDown);
            this.salineBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseUp);
            // 
            // contrastBtn
            // 
            this.contrastBtn.BackgroundImage = global::mr.Properties.Resources.enter_key_up;
            this.contrastBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contrastBtn.FlatAppearance.BorderSize = 0;
            this.contrastBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contrastBtn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contrastBtn.ForeColor = System.Drawing.Color.White;
            this.contrastBtn.Location = new System.Drawing.Point(12, 165);
            this.contrastBtn.Name = "contrastBtn";
            this.contrastBtn.Size = new System.Drawing.Size(160, 78);
            this.contrastBtn.TabIndex = 2;
            this.contrastBtn.Text = "CONTRAST";
            this.contrastBtn.UseVisualStyleBackColor = true;
            this.contrastBtn.Click += new System.EventHandler(this.phaseBtn_Click);
            this.contrastBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseDown);
            this.contrastBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseUp);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImage = global::mr.Properties.Resources.enter_key_up;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(183, 249);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(160, 78);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseDown);
            this.cancelBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseUp);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImage = global::mr.Properties.Resources.enter_key_up;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(12, 249);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(160, 78);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.phaseBtn_Click);
            this.deleteBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseDown);
            this.deleteBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.phaseBtn_MouseUp);
            // 
            // infoLbl
            // 
            this.infoLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.infoLbl.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoLbl.ForeColor = System.Drawing.Color.White;
            this.infoLbl.Location = new System.Drawing.Point(12, 15);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(331, 54);
            this.infoLbl.TabIndex = 45;
            this.infoLbl.Text = "Select Phase";
            this.infoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhaseSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mr.Properties.Resources.phase_select_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(355, 336);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.salineBtn);
            this.Controls.Add(this.contrastBtn);
            this.Controls.Add(this.timedPauseBtn);
            this.Controls.Add(this.pauseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhaseSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PhaseSelectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button timedPauseBtn;
        private System.Windows.Forms.Button salineBtn;
        private System.Windows.Forms.Button contrastBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label infoLbl;
    }
}