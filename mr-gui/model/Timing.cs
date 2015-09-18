using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr.model
{
    class Timing
    {
        public Timing()
            : this(0)
        {
        }

        public Timing(int sec)
        {
            second = sec;
        }

        public void Reset()
        {
            second = 0;
        }

        public void AddSecond()
        {
            ++second;
        }


        public void MinusSecond()
        {
            --second;
        }
        public override String ToString()
        {
            int min = second / 60;
            int sec = second % 60;
            return min + ":" + sec;
        }

        private int second;
    }
}
