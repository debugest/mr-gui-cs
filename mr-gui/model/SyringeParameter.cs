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

        public SyringeParameter()
            : this(SyringePhaseType.NONE, 0, 0, 0)
        { }

        public SyringeParameter(SyringePhaseType p, int r, int v, int t)
        {
            phaseType = p;
            flowRate = r;
            volume = v;
            time = t;
        }

        public void Reset()
        {
            phaseType = SyringePhaseType.NONE;
            flowRate = 0;
            volume = 0;
            time = 0;
        }

        public void Copy(SyringeParameter para)
        {
            this.phaseType = para.phaseType;
            this.flowRate = para.flowRate;
            this.volume = para.volume;
            this.time = para.time;
        }

        public void Set(int r, int v, int t)
        {
            this.flowRate = r;
            this.volume = v;
            this.time = t;
        }

        public SyringePhaseType PhaseType
        {
            get
            {
                return phaseType;
            }
            set
            {
                phaseType = value;
            }
        }

        public int FlowRate
        {
            get
            {
                return flowRate;
            }
            set
            {
                flowRate = value;
            }
        }

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }

        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
        
        private SyringePhaseType phaseType;
        private int flowRate;
        private int volume;
        private int time;
    }
}
