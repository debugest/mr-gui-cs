using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr.controller
{
    class SyringeInjectController
    {
        public SyringeInjectController(mr.view.MainForm form, string type)
        {
            total = 0;
            mainForm = form;
            syringeType = type;
            status.Reset();
        }

        public void Reset()
        {
            total = 0;
            status.Reset();
        }

        public void Initialize(int t, mr.model.SyringeInjectStatus s)
        {
            total = t;
            status.Direction = s.Direction;
            status.Injected = s.Injected;
            this.InternalChange();
        }

        public void OnSyringeInjectedChange(int injected)
        {
            status.Injected = injected;
            this.InternalChange();
        }

        public void OnSyringeDirectionChange(mr.model.SyringeInjectStatus.SyringeDirection dir)
        {
            status.Direction = dir;
            this.InternalChange();
        }

        public void OnSyringeStatusChange(mr.model.SyringeInjectStatus s)
        {
            status.Direction = s.Direction;
            status.Injected = s.Injected;
            this.InternalChange();
        }

        private void InternalChange()
        {
            string imageName = GetImageUrl();
            if (null != imageName)
            {
                if ("contrast" == syringeType)
                {
                    mainForm.InjectContrast(total - status.Injected, status.Injected, imageName);
                }
                else
                {
                    mainForm.InjectSaline(total - status.Injected, status.Injected, imageName);
                }
            }
        }

        private string GetImageUrl()
        {
            string result = status.ToImageName();
            return result;
        }

        private int total;
        private string syringeType;
        private mr.view.MainForm mainForm;
        private mr.model.SyringeInjectStatus status;
    }
}
