using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr.model
{
    public class SyringeParameter
    {
        public enum SyringePhaseType
        {
            PAUSE,
            TIMED_PAUSE,
            CONTRAST,
            SALINE,
            NONE,
        }

        private SyringePhaseType phase;
        private int flowRate;
        private int volume;
        private int time;
    }
}
