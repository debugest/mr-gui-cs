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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            contrastTimingCtrl = new mr.controller.TimingController(this);
            isContrastTiming = true;
        }

        public delegate void TimingInvoke();

        public void BeginContrastTiming(int sec)
        {
            //
        }

        public void UpdateTimingText()
        {
            TimingInvoke invoke = new TimingInvoke(changeText);
            this.BeginInvoke(invoke);
        }

        private void changeText()
        {
            this.timingLabel.Text = contrastTimingCtrl.GetTimingString();
        }

        private void timeBtn_Click(object sender, EventArgs e)
        {
            if (isContrastTiming)
            {
                contrastTimingCtrl.Suspend();
                isContrastTiming = false;
                this.timeBtn.Text = "Start\nTiming";
            }
            else
            {

                contrastTimingCtrl.Start();
                isContrastTiming = true;
                this.timeBtn.Text = "Suspend\nTiming";
            }
        }

        private void timeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.enter_key_down;
        }

        private void timeBtn_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.enter_key_up;
        }

        private mr.controller.TimingController contrastTimingCtrl;
        private bool isContrastTiming;
    }
}
