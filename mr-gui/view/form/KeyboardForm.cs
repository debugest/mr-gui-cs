using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mr.view.form
{
    public partial class KeyboardForm : Form
    {
        public KeyboardForm()
        {
            InitializeComponent();
        }

        private void key_button_Click(object sender, EventArgs e)
        {
            this.inputContent.Text += (sender as Button).Text;
        }

        private void space_button_Click(object sender, EventArgs e)
        {
            this.inputContent.Text += " ";
        }

        private void backspace_button_Click(object sender, EventArgs e)
        {
            string text = this.inputContent.Text;
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
            this.Close();
        }
        private void enter_button_Click(object sender, EventArgs e)
        {

        }

        private void key_button_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.key_down;
        }

        private void key_button_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.key_up;
        }
    }
}
