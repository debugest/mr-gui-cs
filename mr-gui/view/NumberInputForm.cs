﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mr.view
{
    public partial class NumberInputForm : Form
    {
        public NumberInputForm(String infoTxt, String origin, int max, int min, int factor)
        {
            InitializeComponent();
            this.infoLbl.Text = infoTxt;
            if ("----" != origin)
            {
                inputContent.Text = origin;
            }
            this.max = max;
            this.min = min;
            this.factor = factor;
        }

        private void key_button_Click(object sender, EventArgs e)
        {
            this.inputContent.Text += (sender as Button).Text;
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            String text = this.inputContent.Text;
            if (text.Length != 0)
            {
                this.inputContent.Text = text.Remove(text.Length - 1);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            this.inputContent.Clear();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Owner.Tag = null;
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            int iResult = MainForm.LabelTextToInt(inputContent.Text, factor);
            if (iResult >= min && iResult <= max)
            {
                this.Owner.Tag = MainForm.IntToLabelText(iResult, factor);
                this.Close();
            }
            else
            {
                WarningForm form = new WarningForm("WARNING!!! INVALID PARAMETER.\nPlease check allowable range.");
                form.ShowDialog();
            }
        }

        private void key_button_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.key_down;
        }

        private void key_button_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.key_up;
        }

        private void enter_button_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.enter_key_down;
        }

        private void enter_button_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.enter_key_up;
        }

        private int max;
        private int min;
        private int factor;
    }
}
