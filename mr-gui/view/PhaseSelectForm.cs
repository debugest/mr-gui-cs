using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mr.view
{
    public partial class PhaseSelectForm : Form
    {
        public PhaseSelectForm() : this(true, true, true, true)
        {
            InitializeComponent();
        }

        public PhaseSelectForm(bool pauseVisable, bool timedPasueVisable, bool contrastVisable, bool salineVisable)
        {
            InitializeComponent();
            pauseBtn.Visible = pauseVisable;
            timedPauseBtn.Visible = timedPasueVisable;
            contrastBtn.Visible = contrastVisable;
            salineBtn.Visible = salineVisable;
        }

        private void phaseBtn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (btn != null)
            {
                string result = btn.Text.Replace("\n", "");
                this.Owner.Tag = result;
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Tag = null;
            this.Close();
        }

        private void phaseBtn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (sender as Button);
            if (btn != null)
            {
                btn.BackgroundImage = global::mr.Properties.Resources.enter_key_down;
            }
        }

        private void phaseBtn_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (sender as Button);
            if (btn != null)
            {
                btn.BackgroundImage = global::mr.Properties.Resources.enter_key_up;
            }
        }
    }
}
