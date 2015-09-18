using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr.controller
{
    public class TimingController
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

        public void Restart()
        {
            timer.Start();
        }
        
        public void OnTimeOut(Object sender, System.Timers.ElapsedEventArgs e)
        {
            timingModel.AddSecond();
            mainForm.UpdateTimingText(GetTimingString());
        }

        public void Reset()
        {
            timingModel.Reset();
            mainForm.UpdateTimingText(GetTimingString());
        }

        public String GetTimingString()
        {
            return timingModel.ToString();
        }

        private System.Timers.Timer timer;
        private mr.model.Timing timingModel;
        private mr.view.MainForm mainForm;
    }
}
