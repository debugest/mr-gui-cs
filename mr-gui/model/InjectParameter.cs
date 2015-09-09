using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr.model
{
    public class InjectParameter
    {
        public enum InjectPhaseType
        {
            PAUSE,
            TIMED_PAUSE,
            CONTRAST,
            SALINE,
            NONE,
        }

        public InjectParameter()
            : this(InjectPhaseType.NONE, 0, 0, 0)
        { }

        public InjectParameter(InjectPhaseType p, int r, int v, int t)
        {
            phaseType = p;
            flowRate = r;
            volume = v;
            time = t;
        }

        public void Reset()
        {
            phaseType = InjectPhaseType.NONE;
            flowRate = 0;
            volume = 0;
            time = 0;
        }

        public void Copy(InjectParameter para)
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

        public InjectPhaseType PhaseType
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
        
        private InjectPhaseType phaseType;
        private int flowRate;
        private int volume;
        private int time;
    }
}
