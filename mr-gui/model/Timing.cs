using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr.model
{
    class Timing
    {
        Timing()
            : this(0)
        {
        }

        Timing(int sec)
        {
            seconds = sec;
        }

        void reset()
        {
            seconds = 0;
        }

        public override string ToString()
        {
            if (0 == seconds)
            {
                return "--:--";
            }
            else
            {
                int min = seconds / 60;
                int sec = seconds % 60;
                return min + ":" + sec;
            }
        }

        private int seconds;
    }
}
