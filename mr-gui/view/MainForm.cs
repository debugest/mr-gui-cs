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

        private void phaseLbl_Click(object sender, EventArgs e)
        {
            PhaseSelectForm form = new PhaseSelectForm();
            form.Owner = this;
            form.ShowDialog();
        }

        private void rate1Lbl_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            NumberInputForm form = new NumberInputForm("Flow Rate Range 0.1-10.0ml/sec", label.Text, 100, 1, 10);
            form.Owner = this;
            form.ShowDialog();
            label.Text = this.Tag.ToString();
            AutoCaculate(label, volume1Lbl, time1Lbl, "rate");
        }

        private void volume1Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != rate1Lbl.Text)
            {
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Volume Range 1-100ml", label.Text, 1000, 10, 10);
                form.Owner = this;
                form.ShowDialog();
                label.Text = this.Tag.ToString();
                AutoCaculate(label, volume1Lbl, time1Lbl, "volume");
            }
        }

        private void time1Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != rate1Lbl.Text && "----" != volume1Lbl.Text)
            {
                int rate = LabelTextToInt(rate1Lbl.Text, 10);
                int volume = LabelTextToInt(volume1Lbl.Text, 10);
                int time = volume / rate;
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Phase Time Range 1-" + time + "sec", label.Text, time, 1, 1);
                form.Owner = this;
                form.ShowDialog();
                label.Text = this.Tag.ToString();
                AutoCaculate(label, volume1Lbl, time1Lbl, "volume");
            }
        }

        private void rate2Lbl_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            NumberInputForm form = new NumberInputForm("Flow Rate Range 0.1-10.0ml/sec", label.Text, 100, 1, 10);
            form.Owner = this;
            form.ShowDialog();
            label.Text = this.Tag.ToString();
            AutoCaculate(label, volume2Lbl, time2Lbl, "rate");
        }

        private void rate3Lbl_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            NumberInputForm form = new NumberInputForm("Flow Rate Range 0.1-10.0ml/sec", label.Text, 100, 1, 10);
            form.Owner = this;
            form.ShowDialog();
            label.Text = this.Tag.ToString();
            AutoCaculate(label, volume3Lbl, time3Lbl, "rate");
        }

        private void rate4Lbl_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            NumberInputForm form = new NumberInputForm("Flow Rate Range 0.1-10.0ml/sec", label.Text, 100, 1, 10);
            form.Owner = this;
            form.ShowDialog();
            label.Text = this.Tag.ToString();
            AutoCaculate(label, volume4Lbl, time4Lbl, "rate");
        }

        private void volume2Lbl_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            NumberInputForm form = new NumberInputForm("Volume Range 1-100ml", label.Text, 10000, 100, 100);
            form.Owner = this;
            form.ShowDialog();
            label.Text = this.Tag.ToString();
            AutoCaculate(label, volume2Lbl, time2Lbl, "volume");
        }

        private void volume3Lbl_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            NumberInputForm form = new NumberInputForm("Volume Range 1-100ml", label.Text, 10000, 100, 100);
            form.Owner = this;
            form.ShowDialog();
            label.Text = this.Tag.ToString();
            AutoCaculate(label, volume3Lbl, time3Lbl, "volume");
        }

        private void volume4Lbl_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            NumberInputForm form = new NumberInputForm("Volume Range 1-100ml", label.Text, 10000, 100, 100);
            form.Owner = this;
            form.ShowDialog();
            label.Text = this.Tag.ToString();
            AutoCaculate(label, volume4Lbl, time4Lbl, "volume");
        }

        private void AutoCaculate(Label rateLbl, Label volumeLbl, Label timeLbl, string title)
        {
            int rate = LabelTextToInt(rateLbl.Text, 10);
            int time = LabelTextToInt(timeLbl.Text, 10);
            int volume = LabelTextToInt(volumeLbl.Text, 100);
            if ("rate" == title)
            {
                if (0 == time)
                {
                    if (0 != volume)
                    {
                        timeLbl.Text = IntToLabelText(volume / rate, 10);
                    }
                }
                else
                {
                    if (0 != volume)
                    {
                        volumeLbl.Text = "----";
                        timeLbl.Text = "----";
                    }
                    else
                    {
                        volumeLbl.Text = IntToLabelText(rate * time, 100);
                    }
                }
            }
            else if ("volume" == title)
            {

            }
            else
            {

            }
        }

        public int LabelTextToInt(string text, int factor)
        {
            if ("----" == text || "" == text)
            {
                return 0;
            }
            else
            {
                float val = float.Parse(text);
                return (int)(val * factor);
            }
        }

        public string IntToLabelText(int value, int factor)
        {
            int intPart = value / factor;
            int decPart = value % factor;
            if (0 == decPart)
            {
                return intPart.ToString();
            }
            else
            {
                return intPart.ToString() + "." + decPart.ToString();
            }
        }
    }
}
