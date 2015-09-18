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

        public void OnSelectTimedPause(int index, int pauseTime)
        {
            program.GetInjectParameter(index).PauseTime = pauseTime;
        }

        public void OnLoadProgram()
        {

        }

        public void Reset(int index)
        {
            if (0 <= index && index < 8)
            {
                program.RemoveInjectStep(index);
            }
        }

        public bool canPausePhase(int index)
        {
            if (index == 0)
            {
                return false;
            }
            else
            {
                mr.model.InjectParameter para = GetInjectParameterAt(index - 1);
                if (null != para && (para.PhaseType == mr.model.InjectParameter.InjectPhaseType.PAUSE
                    || para.PhaseType == mr.model.InjectParameter.InjectPhaseType.TIMED_PAUSE)) 
                {
                    return false;
                }
                return true;
            }
        }

        public bool canInjectContrast(int index)
        {
            if (index == 0)
            {
                return true;
            }
            else
            {
                bool result = true;
                for (int i = 0; i != index; ++i)
                {
                    mr.model.InjectParameter para = GetInjectParameterAt(i);
                    if (null != para && para.PhaseType == mr.model.InjectParameter.InjectPhaseType.SALINE)
                    {
                        result = false;
                        break;
                    }
                }
                return result;
            }
        }

        public bool canInjectSaline(int index)
        {
            if (index == 0 || index > 1)
            {
                return false;
            }
            else
            {
                bool result = true;
                for (int i = 0; i != index; ++i)
                {
                    mr.model.InjectParameter para = GetInjectParameterAt(i);
                    if (null != para)
                    {
                        if (para.PhaseType == mr.model.InjectParameter.InjectPhaseType.PAUSE
                            || para.PhaseType == mr.model.InjectParameter.InjectPhaseType.TIMED_PAUSE
                            || para.PhaseType == mr.model.InjectParameter.InjectPhaseType.SALINE)
                        {
                            result = false;
                            break;
                        }
                    }
                }
                return result;
            }
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
