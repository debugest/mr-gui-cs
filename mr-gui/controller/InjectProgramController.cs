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

        public void OnInjectStepPhaseChange(int index, mr.model.SyringeParameter.SyringePhaseType p)
        {
            program.GetStepParameter(index).PhaseType = p;
        }

        public void OnInjectStepParameterChange(int index, int r, int v, int t)
        {
            program.GetStepParameter(index).Set(r, v, t);
        }

        public void OnLoadProgram()
        {

        }

        private mr.view.MainForm form;
        private mr.model.InjectProgram program;
    }
}
