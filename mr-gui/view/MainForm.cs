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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            contrastTimingCtrl = new mr.controller.TimingController(this);
            isContrastTiming = true;
            isKvoOff = true;
            injectProgramCtrl = new mr.controller.InjectProgramController(this);
            dateCtrl = new mr.controller.DateController(this);
        }

        public delegate void TimingInvoke(String text);
        public delegate void ContrastInjectInvoke(int remain, int injected, String imageName);
        public delegate void SalineInjectInvoke(int remain, int injected, String imageName);
        public delegate void UpdateTimeInvoke(String date, String time);

        public void BeginContrastTiming(int sec)
        {
            //
        }

        public void UpdateTimingText(String text)
        {
            TimingInvoke invoke = new TimingInvoke(InternalUpdateTimingText);
            this.BeginInvoke(invoke, text);
        }

        public void UpdateCurrentTime(String date, String time)
        {
            UpdateTimeInvoke invoke = new UpdateTimeInvoke(InternalUpdateCurrentTime);
            this.BeginInvoke(invoke, date, time);
        }

        public void InjectContrast(int remain, int injected, String imageName)
        {
            ContrastInjectInvoke invoke = new ContrastInjectInvoke(InternalContrastInject);
            this.BeginInvoke(invoke, imageName);
        }

        public void InjectSaline(int remain, int injected, String imageName)
        {
            SalineInjectInvoke invoke = new SalineInjectInvoke(InternalSalineInject);
            this.BeginInvoke(invoke, imageName);
        }

        private void InternalUpdateTimingText(String text)
        {
            this.timingLabel.Text = text;
        }

        private void InternalContrastInject(int remain, int injected, String imageName)
        {
            this.contrastRemainNumberLbl.Text = remain.ToString();
            this.contrastInjectedNumberLbl.Text = injected.ToString();
            this.LoadImage(this.contrastImageBox, imageName);
        }

        private void InternalSalineInject(int remain, int injected, String imageName)
        {
            this.salineRemainNumberLbl.Text = remain.ToString();
            this.salineInjectedNumberLbl.Text = injected.ToString();
            this.LoadImage(this.salineImageBox, imageName);
        }

        private void InternalUpdateCurrentTime(String date, String time)
        {
            this.currentDateLbl.Text = date;
            this.currentTimeLbl.Text = time;
        }

        private void LoadImage(PictureBox box, String imageName)
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
        private mr.controller.DateController dateCtrl;
        private bool isContrastTiming;
        private bool isKvoOff;
        private int currentStepIndex;
        private mr.controller.InjectProgramController injectProgramCtrl;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phase1Lbl_Click(object sender, EventArgs e)
        {
            bool canPause = injectProgramCtrl.canPausePhase(currentStepIndex + 0);
            bool canContrast = injectProgramCtrl.canInjectContrast(currentStepIndex + 0);
            bool canSaline = injectProgramCtrl.canInjectSaline(currentStepIndex + 0);
            PhaseSelectForm form = new PhaseSelectForm(canPause, canPause, canContrast, canSaline);
            form.Owner = this;
            form.ShowDialog();
            if (Tag != null)
            {
                Label label = sender as Label;
                ChangePhaseType(label, currentStepIndex + 0, rate1Lbl, volume1Lbl, time1Lbl);
            }
        }

        private void phase2Lbl_Click(object sender, EventArgs e)
        {
            bool canPause = injectProgramCtrl.canPausePhase(currentStepIndex + 1);
            bool canContrast = injectProgramCtrl.canInjectContrast(currentStepIndex + 1);
            bool canSaline = injectProgramCtrl.canInjectSaline(currentStepIndex + 1);
            PhaseSelectForm form = new PhaseSelectForm(canPause, canPause, canContrast, canSaline);
            form.Owner = this;
            form.ShowDialog();
            if (Tag != null)
            {
                Label label = sender as Label;
                ChangePhaseType(label, currentStepIndex + 1, rate2Lbl, volume2Lbl, time2Lbl);
            }
        }

        private void phase3Lbl_Click(object sender, EventArgs e)
        {
            bool canPause = injectProgramCtrl.canPausePhase(currentStepIndex + 3);
            bool canContrast = injectProgramCtrl.canInjectContrast(currentStepIndex + 3);
            bool canSaline = injectProgramCtrl.canInjectSaline(currentStepIndex + 3);
            PhaseSelectForm form = new PhaseSelectForm(canPause, canPause, canContrast, canSaline);
            form.Owner = this;
            form.ShowDialog();
            if (Tag != null)
            {
                Label label = sender as Label;
                ChangePhaseType(label, currentStepIndex + 2, rate3Lbl, volume3Lbl, time3Lbl);
            }
        }

        private void phase4Lbl_Click(object sender, EventArgs e)
        {
            bool canPause = injectProgramCtrl.canPausePhase(currentStepIndex + 3);
            bool canContrast = injectProgramCtrl.canInjectContrast(currentStepIndex + 3);
            bool canSaline = injectProgramCtrl.canInjectSaline(currentStepIndex + 3);
            PhaseSelectForm form = new PhaseSelectForm(canPause, canPause, canContrast, canSaline);
            form.Owner = this;
            form.ShowDialog();
            if (Tag != null)
            {
                Label label = sender as Label;
                ChangePhaseType(label, currentStepIndex + 3, rate4Lbl, volume4Lbl, time4Lbl);
            }
        }

        private void ChangePhaseType(Label label, int index, Label rLbl, Label vLbl, Label tLbl)
        {
            String content;
            int pauseTime = 0;
            if (this.Tag is Array)
            {
                Object[] arr = (Object[])Tag;
                content = (String)(arr[0]);
                pauseTime = Convert.ToInt32((String)arr[1]);
            }
            else
            {
                content = (String)Tag;
            }
            if ("DELETE" == content)
            {
                injectProgramCtrl.Reset(index);
                label.Text = "----";
                rLbl.Text = "----";
                vLbl.Text = "----";
                tLbl.Text = "----";
            }
            else if ("CONTRAST" == content)
            {
                injectProgramCtrl.OnInjectStepPhaseChange(index, mr.model.InjectParameter.InjectPhaseType.CONTRAST);
                label.Text = (index + 1).ToString() + "C";
            }
            else if ("SALINE" == content)
            {
                injectProgramCtrl.OnInjectStepPhaseChange(index, mr.model.InjectParameter.InjectPhaseType.SALINE);
                label.Text = (index + 1).ToString() + "S";
            }
            else if ("PAUSE" == content)
            {
                injectProgramCtrl.OnInjectStepPhaseChange(index, mr.model.InjectParameter.InjectPhaseType.PAUSE);
                label.Text = (index + 1).ToString() + "P";
            }
            else if ("TIMEDPAUSE" == content)
            {
                injectProgramCtrl.OnInjectStepPhaseChange(index, mr.model.InjectParameter.InjectPhaseType.TIMED_PAUSE);
                injectProgramCtrl.OnSelectTimedPause(index, pauseTime);
                label.Text = (index + 1).ToString() + "TP";
            }
        }

        private void rate1Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != phase1Lbl.Text && !(phase1Lbl.Text.EndsWith("P")))
            {
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Flow Rate Range 0.1-10.0ml/sec", label.Text, 100, 1, 10);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex, label, volume1Lbl, time1Lbl, "rate");
                }
            }
        }

        private void volume1Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != rate1Lbl.Text)
            {
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Volume Range 1-100ml", label.Text, 1000, 10, 10);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex, rate1Lbl, label, time1Lbl, "volume");
                }
            }
        }

        private void time1Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != rate1Lbl.Text)
            {
                int rate = LabelTextToInt(rate1Lbl.Text, 10);
                int volume = LabelTextToInt(volume1Lbl.Text, 10);
                if (0 == volume)
                {
                    volume = 100 * 10;
                }
                int time = volume / rate;
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Phase Time Range 1-" + time + "sec", label.Text, time, 1, 1);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex, rate1Lbl, volume1Lbl, label, "time");
                }
            }
        }

        private void rate2Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != phase2Lbl.Text && !(phase2Lbl.Text.EndsWith("P")))
            {
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Flow Rate Range 0.1-10.0ml/sec", label.Text, 100, 1, 10);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex + 1, label, volume2Lbl, time2Lbl, "rate");
                }
            }
        }

        private void volume2Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != rate2Lbl.Text)
            {
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Volume Range 1-100ml", label.Text, 1000, 10, 10);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex + 1, rate2Lbl, label, time2Lbl, "volume");
                }
            }
        }

        private void time2Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != rate2Lbl.Text)
            {
                int rate = LabelTextToInt(rate2Lbl.Text, 10);
                int volume = LabelTextToInt(volume2Lbl.Text, 10);
                if (0 == volume)
                {
                    volume = 100 * 10;
                }
                int time = volume / rate;
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Phase Time Range 1-" + time + "sec", label.Text, time, 1, 1);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex + 1, rate2Lbl, volume2Lbl, label, "time");
                }
            }
        }

        private void rate3Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != phase3Lbl.Text && !(phase3Lbl.Text.EndsWith("P")))
            {
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Flow Rate Range 0.1-10.0ml/sec", label.Text, 100, 1, 10);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex + 2, label, volume3Lbl, time3Lbl, "rate");
                }
            }
        }

        private void volume3Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != rate3Lbl.Text)
            {
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Volume Range 1-100ml", label.Text, 1000, 10, 10);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex + 2, rate3Lbl, label, time3Lbl, "volume");
                }
            }
        }

        private void time3Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != rate3Lbl.Text)
            {
                int rate = LabelTextToInt(rate3Lbl.Text, 10);
                int volume = LabelTextToInt(volume3Lbl.Text, 10);
                if (0 == volume)
                {
                    volume = 100 * 10;
                }
                int time = volume / rate;
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Phase Time Range 1-" + time + "sec", label.Text, time, 1, 1);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex + 2, rate3Lbl, volume3Lbl, label, "time");
                }
            }
        }

        private void rate4Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != phase4Lbl.Text && !(phase4Lbl.Text.EndsWith("P")))
            {
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Flow Rate Range 0.1-10.0ml/sec", label.Text, 100, 1, 10);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex + 3, label, volume4Lbl, time4Lbl, "rate");
                }
            }
        }

        private void volume4Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != rate4Lbl.Text)
            {
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Volume Range 1-100ml", label.Text, 1000, 10, 10);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex + 3, rate4Lbl, label, time4Lbl, "volume");
                }
            }
        }

        private void time4Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != rate4Lbl.Text)
            {
                int rate = LabelTextToInt(rate4Lbl.Text, 10);
                int volume = LabelTextToInt(volume4Lbl.Text, 10);
                if (0 == volume)
                {
                    volume = 100 * 10;
                }
                int time = volume / rate;
                Label label = sender as Label;
                NumberInputForm form = new NumberInputForm("Phase Time Range 1-" + time + "sec", label.Text, time, 1, 1);
                form.Owner = this;
                form.ShowDialog();
                if (this.Tag != null)
                {
                    label.Text = this.Tag.ToString();
                    AutoCaculate(currentStepIndex + 3, rate4Lbl, volume4Lbl, label, "time");
                }
            }
        }

        private void AutoCaculate(int stepIndex, Label rateLbl, Label volumeLbl, Label timeLbl, String title)
        {
            int rate = LabelTextToInt(rateLbl.Text, 10);
            int time = LabelTextToInt(timeLbl.Text, 1);
            int volume = LabelTextToInt(volumeLbl.Text, 10);
            if ("rate" == title)
            {
                if (0 != time && 0 != volume)
                {
                    timeLbl.Text = IntToLabelText(volume / rate, 1);
                }
            }
            else if ("volume" == title)
            {
                if (0 != rate && 0 != volume)
                {
                    timeLbl.Text = IntToLabelText(volume / rate, 1);
                }
            }
            else
            {
                if (0 != rate && 0 != volume)
                {
                    volumeLbl.Text = IntToLabelText(rate * time, 10);
                }
            }
            injectProgramCtrl.OnInjectStepParameterChange(stepIndex, LabelTextToInt(rateLbl.Text, 10), 
                LabelTextToInt(volumeLbl.Text, 10), LabelTextToInt(timeLbl.Text, 1));
        }

        public static int LabelTextToInt(String text, int factor)
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

        public static String IntToLabelText(int value, int factor)
        {
            int intPart = value / factor;
            int decPart = value % factor;
            if (0 == decPart)
            {
                if (0 == intPart)
                {
                    return "----";
                }
                else
                { 
                    return intPart.ToString();
                }
            }
            else
            {
                return intPart.ToString() + "." + decPart.ToString();
            }
        }

        private void injectStepUpBtn_Click(object sender, EventArgs e)
        {
            if (currentStepIndex > 0 && currentStepIndex <= 4)
            {
                --currentStepIndex;
                SetDisplayInjectSteps();
            }
        }

        private void injectStepDownBtn_Click(object sender, EventArgs e)
        {
            if (currentStepIndex >= 0 && currentStepIndex < 4)
            {
                ++currentStepIndex;
                SetDisplayInjectSteps();
            }
        }

        private void injectStepUpBtn_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.scroll_up_button_press;
        }

        private void injectStepUpBtn_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.scroll_up_button;
        }

        private void injectStepDownBtn_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.scroll_down_button_press;
        }

        private void injectStepDownBtn_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.scroll_down_button;
        }

        private void SetDisplayInjectSteps()
        {
            mr.model.InjectParameter para = injectProgramCtrl.GetInjectParameterAt(currentStepIndex + 0);
            phase1Lbl.Text = PhaseTypeToString(para.PhaseType, currentStepIndex + 0);
            rate1Lbl.Text = IntToLabelText(para.FlowRate, 10);
            volume1Lbl.Text = IntToLabelText(para.Volume, 10);
            time1Lbl.Text = IntToLabelText(para.Time, 1);

            para = injectProgramCtrl.GetInjectParameterAt(currentStepIndex + 1);
            phase2Lbl.Text = PhaseTypeToString(para.PhaseType, currentStepIndex + 1);
            rate2Lbl.Text = IntToLabelText(para.FlowRate, 10);
            volume2Lbl.Text = IntToLabelText(para.Volume, 10);
            time2Lbl.Text = IntToLabelText(para.Time, 1);

            para = injectProgramCtrl.GetInjectParameterAt(currentStepIndex + 2);
            phase3Lbl.Text = PhaseTypeToString(para.PhaseType, currentStepIndex + 2);
            rate3Lbl.Text = IntToLabelText(para.FlowRate, 10);
            volume3Lbl.Text = IntToLabelText(para.Volume, 10);
            time3Lbl.Text = IntToLabelText(para.Time, 1);

            para = injectProgramCtrl.GetInjectParameterAt(currentStepIndex + 3);
            phase4Lbl.Text = PhaseTypeToString(para.PhaseType, currentStepIndex + 3);
            rate4Lbl.Text = IntToLabelText(para.FlowRate, 10);
            volume4Lbl.Text = IntToLabelText(para.Volume, 10);
            time4Lbl.Text = IntToLabelText(para.Time, 1);
        }

        private String PhaseTypeToString(mr.model.InjectParameter.InjectPhaseType phase, int index)
        {
            String result = (index + 1).ToString();
            if (mr.model.InjectParameter.InjectPhaseType.CONTRAST == phase)
            {
                result += "C";
            }
            else if (mr.model.InjectParameter.InjectPhaseType.SALINE == phase)
            {
                result += "S";
            }
            else if (mr.model.InjectParameter.InjectPhaseType.PAUSE == phase)
            {
                result += "P";
            }
            else if (mr.model.InjectParameter.InjectPhaseType.TIMED_PAUSE == phase)
            {
                result += "TP";
            }
            else
            {
                result = "----";
            }
            return result;
        }

        private void pressLimitLbl_Click(object sender, EventArgs e)
        {
            PressureInputForm form = new PressureInputForm("2068", "Kpa");
            form.Owner = this;
            form.ShowDialog();
            if (Tag != null)
            {
                this.pressLimitLbl.Text = ((String[])Tag)[0];
                this.pressLimitUnitLbl.Text = String.Format("({0})", ((String[])Tag)[1]);
            }
        }

        private void delayToScan1Lbl_Click(object sender, EventArgs e)
        {
            ShowDelayToScanInput(delayToScan1Lbl, 300, 1);
            if (null != this.Tag)
            {
                this.delayToScan1Lbl.Text = (String)(this.Tag);
            }
        }

        private void delayToScan2Lbl_Click(object sender, EventArgs e)
        {
            if ("----" != this.delayToScan1Lbl.Text)
            {
                ShowDelayToScanInput(delayToScan2Lbl, 900, 1);
                if (null != this.Tag)
                {
                    this.delayToScan2Lbl.Text = (String)(this.Tag);
                }
            }
        }

        private void ShowDelayToScanInput(Label label, int max, int min)
        {
            DelayInputForm form = new DelayInputForm(String.Format("Delay to Scan Range {0}-{1}sec", min, max), label.Text, max, min);
            form.Owner = this;
            form.ShowDialog();
        }

    }
}
