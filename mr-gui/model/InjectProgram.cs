using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr.model
{
    public class InjectProgram
    {
        public InjectProgram()
        {
            injectSteps = new List<SyringeParameter>(8);
            for (int i = 0; i != 8; ++i)
            {
                injectSteps.Add(new SyringeParameter());
            }
        }

        public SyringeParameter GetStepParameter(int index)
        {
            if (index >= 0 && index < injectSteps.Count)
            {
                return injectSteps[index];
            }
            else
            {
                return null;
            }
        }

        public bool SetInjectStep(int index, SyringeParameter para)
        {
            if (index >=0 && index < injectSteps.Count)
            {
                injectSteps[index].Copy(para);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveInjectStep(int index)
        {
            if (index >= 0 && index < injectSteps.Count)
            {
                injectSteps[index].Reset();
            }
        }

        private List<SyringeParameter> injectSteps;
    }
}
