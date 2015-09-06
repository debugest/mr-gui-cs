using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr.controller
{
    class TimingController
    {
        public TimingController(mr.view.MainForm form)
        {
            mainForm = form;
            timingModel = new mr.model.Timing(0);
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimeOut);
            timer.AutoReset = true;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Suspend()
        {
            timer.Stop();
        }
        
        public void OnTimeOut(Object sender, System.Timers.ElapsedEventArgs e)
        {
            timingModel.minusSecond();
            mainForm.UpdateTimingText();
        }

        public void SetInitialSecond(int sec)
        {
            timingModel.reset(sec);
            mainForm.UpdateTimingText();
        }

        public string GetTimingString()
        {
            return timingModel.ToString();
        }

        private System.Timers.Timer timer;
        private mr.model.Timing timingModel;
        private mr.view.MainForm mainForm;
    }
}
