namespace mr.view.form
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
            this.salinePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // contrastPanel
            // 
            this.contrastPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(61)))), ((int)(((byte)(140)))));
            this.contrastPanel.BackgroundImage = global::mr.Properties.Resources.syringe_background;
            this.contrastPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contrastPanel.Location = new System.Drawing.Point(25, 9);
            this.contrastPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contrastPanel.Name = "contrastPanel";
            this.contrastPanel.Size = new System.Drawing.Size(400, 260);
            this.contrastPanel.TabIndex = 0;
            // 
            // salinePanel
            // 
            this.salinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(61)))), ((int)(((byte)(140)))));
            this.salinePanel.BackgroundImage = global::mr.Properties.Resources.syringe_background;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contrastPanel;
        private System.Windows.Forms.Panel salinePanel;

    }
}