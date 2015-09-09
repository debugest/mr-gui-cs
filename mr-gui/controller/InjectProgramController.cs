using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr.controller
{
    public class InjectProgramController
    {
        public InjectProgramController(mr.view.MainForm f)
        {
            this.form = f;
            this.program = new mr.model.InjectProgram();
        }

        public void OnInjectStepPhaseChange(int index, mr.model.InjectParameter.InjectPhaseType p)
        {
            program.GetInjectParameter(index).PhaseType = p;
        }

        public void OnInjectStepParameterChange(int index, int r, int v, int t)
        {
            program.GetInjectParameter(index).Set(r, v, t);
        }

        public void OnLoadProgram()
        {

        }

        public mr.model.InjectParameter GetInjectParameterAt(int index)
        {
            if (index >= 0 && index < 8)
            {
                return program.GetInjectParameter(index);
            }
            else
            {
                return null;
            }
        }

        private mr.view.MainForm form;
        private mr.model.InjectProgram program;
    }
}
