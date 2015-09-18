using System;
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
    public partial class WarningForm : Form
    {
        public WarningForm(String info)
        {
            InitializeComponent();
            this.infoLbl.Text = info;
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitBtn_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.enter_key_down;
        }

        private void quitBtn_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.enter_key_up;
        }
    }
}
