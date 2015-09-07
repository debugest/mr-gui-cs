using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr.model
{
    public class SyringeInjectStatus
    {
        public enum SyringeDirection
        {
            UP,
            DN,
            MI,
            NO,
        }

        public SyringeInjectStatus()
            : this(SyringeDirection.NO, 0)
        { }

        public SyringeInjectStatus(SyringeDirection dir, int r)
        {
            direction = dir;
            injected = r;
        }

        public void Reset()
        {
            direction = SyringeDirection.NO;
            injected = 0;
        }

        public string ToImageName()
        {
            if (SyringeDirection.NO == direction)
            {
                return null;
            }
            else
            {
                string result = "syr" + direction.ToString().ToLower() + injected / 2 * 2 + ".jpg";
                return result;
            }
        }

        private SyringeDirection direction;
        private int injected;

        public SyringeDirection Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }
        }

        public int Injected
        {
            get
            {
                return injected;
            }
            set
            {
                if (value >= 0 && value <= 200)
                {
                    injected = value;
                }
            }
        }
    }
}
