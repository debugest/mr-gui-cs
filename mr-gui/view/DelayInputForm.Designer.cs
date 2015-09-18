namespace mr.view
{
    partial class DelayInputForm
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
            this.infoLbl = new System.Windows.Forms.Label();
            this.inputContent = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.backspaceBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLbl
            // 
            this.infoLbl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoLbl.ForeColor = System.Drawing.Color.White;
            this.infoLbl.Location = new System.Drawing.Point(12, 36);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(278, 54);
            this.infoLbl.TabIndex = 61;
            this.infoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputContent
            // 
            this.inputContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.inputContent.Font = new System.Drawing.Font("微软雅黑", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputContent.Location = new System.Drawing.Point(13, 108);
            this.inputContent.Name = "inputContent";
            this.inputContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputContent.Size = new System.Drawing.Size(277, 64);
            this.inputContent.TabIndex = 60;
            this.inputContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // enterBtn
            // 
            this.enterBtn.BackgroundImage = global::mr.Properties.Resources.enter_key_up;
            this.enterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enterBtn.FlatAppearance.BorderSize = 0;
            this.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enterBtn.ForeColor = System.Drawing.Color.White;
            this.enterBtn.Location = new System.Drawing.Point(155, 395);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(135, 61);
            this.enterBtn.TabIndex = 59;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            this.enterBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.enter_button_MouseDown);
            this.enterBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.enter_button_MouseUp);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(225, 328);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(65, 61);
            this.cancelBtn.TabIndex = 58;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancel_button_Click);
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.cancelBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // clearBtn
            // 
            this.clearBtn.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(225, 261);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(65, 61);
            this.clearBtn.TabIndex = 57;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clear_button_Click);
            this.clearBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.clearBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // backspaceBtn
            // 
            this.backspaceBtn.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.backspaceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backspaceBtn.FlatAppearance.BorderSize = 0;
            this.backspaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceBtn.ForeColor = System.Drawing.Color.White;
            this.backspaceBtn.Location = new System.Drawing.Point(225, 194);
            this.backspaceBtn.Name = "backspaceBtn";
            this.backspaceBtn.Size = new System.Drawing.Size(65, 61);
            this.backspaceBtn.TabIndex = 56;
            this.backspaceBtn.Text = "BACK\nSPACE";
            this.backspaceBtn.UseVisualStyleBackColor = true;
            this.backspaceBtn.Click += new System.EventHandler(this.backspaceBtn_Click);
            this.backspaceBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.backspaceBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // resetBtn
            // 
            this.resetBtn.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.resetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(84, 395);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(65, 61);
            this.resetBtn.TabIndex = 55;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            this.resetBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.resetBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // button0
            // 
            this.button0.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(13, 395);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(65, 61);
            this.button0.TabIndex = 54;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.key_button_Click);
            this.button0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.button0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(154, 328);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 61);
            this.button9.TabIndex = 53;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.key_button_Click);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(83, 328);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 61);
            this.button8.TabIndex = 52;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.key_button_Click);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(13, 328);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 61);
            this.button7.TabIndex = 51;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.key_button_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(154, 261);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 61);
            this.button6.TabIndex = 50;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.key_button_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(83, 261);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 61);
            this.button5.TabIndex = 49;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.key_button_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 61);
            this.button4.TabIndex = 48;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.key_button_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(154, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 61);
            this.button3.TabIndex = 47;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.key_button_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(83, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 61);
            this.button2.TabIndex = 46;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.key_button_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::mr.Properties.Resources.key_up;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 61);
            this.button1.TabIndex = 45;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.key_button_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_button_MouseUp);
            // 
            // DelayInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.BackgroundImage = global::mr.Properties.Resources.number_input_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(302, 468);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.inputContent);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.backspaceBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DelayInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DelayInputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.TextBox inputContent;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button backspaceBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}