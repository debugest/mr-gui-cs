using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr.controller
{
    public class DateController
    {
        private static String DateFormat = "yyyy/MM/dd ddd";
        private static String TimeFormat = "hh:mm:ss tt";
        private static System.Globalization.CultureInfo GlobalInfo = new System.Globalization.CultureInfo("en-us");

        public DateController(view.MainForm form)
        {
            this.form = form;
            FetchCurrentDate();
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimeOut);
            timer.AutoReset = true;
            timer.Start();
        }

        public String Date
        {
            get
            {
                return date;
            }
        }

        public String Time
        {
            get
            {
                return time;
            }
        }

        public void OnTimeOut(Object sender, System.Timers.ElapsedEventArgs e)
        {
            FetchCurrentDate();
            form.UpdateCurrentTime(date, time);
        }

        private void FetchCurrentDate()
        {
            System.DateTime nowTime = System.DateTime.Now;
            date = nowTime.ToString(DateFormat, GlobalInfo);
            time = nowTime.ToString(TimeFormat, GlobalInfo);
        }

        private view.MainForm form;
        private String date;
        private String time;
        private System.Timers.Timer timer;
    }
}
