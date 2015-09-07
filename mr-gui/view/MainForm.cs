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
            isKvoOff = true;
        }

        public delegate void TimingInvoke(string text);
        public delegate void ContrastInjectInvoke(int remain, int injected, string imageName);
        public delegate void SalineInjectInvoke(int remain, int injected, string imageName);

        public void BeginContrastTiming(int sec)
        {
            //
        }

        public void UpdateTimingText(string text)
        {
            TimingInvoke invoke = new TimingInvoke(InternalUpdateTimingText);
            this.BeginInvoke(invoke, text);
        }

        public void InjectContrast(int remain, int injected, string imageName)
        {
            ContrastInjectInvoke invoke = new ContrastInjectInvoke(InternalContrastInject);
            this.BeginInvoke(invoke, imageName);
        }

        public void InjectSaline(int remain, int injected, string imageName)
        {
            SalineInjectInvoke invoke = new SalineInjectInvoke(InternalSalineInject);
            this.BeginInvoke(invoke, imageName);
        }

        private void InternalUpdateTimingText(string text)
        {
            this.timingLabel.Text = text;
        }

        private void InternalContrastInject(int remain, int injected, string imageName)
        {
            this.contrastRemainNumberLbl.Text = remain.ToString();
            this.contrastInjectedNumberLbl.Text = injected.ToString();
            this.LoadImage(this.contrastImageBox, imageName);
        }

        private void InternalSalineInject(int remain, int injected, string imageName)
        {
            this.salineRemainNumberLbl.Text = remain.ToString();
            this.salineInjectedNumberLbl.Text = injected.ToString();
            this.LoadImage(this.salineImageBox, imageName);
        }

        private void LoadImage(PictureBox box, string imageName)
        {
            box.Image = (Bitmap)global::mr.Properties.Resources.ResourceManager.GetObject(imageName);
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


        private void kvoBtn_Click(object sender, EventArgs e)
        {
            if (isKvoOff)
            {
                this.kvoBtn.Text = "EVO ON";
                isKvoOff = false;
            }
            else
            {
                this.kvoBtn.Text = "EVO OFF";
                isKvoOff = true;
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

        private void kvoBtn_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.enter_key_down;
        }

        private void kvoBtn_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.enter_key_up;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            this.contrastTimingCtrl.Reset();
            this.contrastTimingCtrl.Start();
            this.timeBtn.Visible = true;
        }

        private mr.controller.TimingController contrastTimingCtrl;
        private mr.controller.SyringeInjectController contrastInjectCtrl;
        private mr.controller.SyringeInjectController salineInjectCtrl;
        private bool isContrastTiming;
        private bool isKvoOff;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
