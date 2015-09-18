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
    public partial class PressureInputForm : Form
    {
        static String KpaLimitInfo = "Pressure Limit Range\n276-2068Kpa";
        static String BarLimitInfo = "Pressure Limit Range\n2.8-20.7bar";
        static String PsiLimitInfo = "Pressure Limit Range\n40-300psi";
        static String minKpa = "276";
        static String maxKpa = "2068";
        static String minBar = "2.8";
        static String maxBar = "20.7";
        static String minPsi = "40";
        static String maxPsi = "300";

        public PressureInputForm(String origin, String u)
        {
            InitializeComponent();
            this.unit = u;
            if ("Kpa" == u)
            {
                this.infoLbl.Text = KpaLimitInfo;
            }
            else if ("bar" == u)
            {
                this.infoLbl.Text = BarLimitInfo;
            }
            else if ("psi" == u)
            {
                this.infoLbl.Text = PsiLimitInfo;
            }
            if ("----" != origin)
            {
                inputContent.Text = origin;
            }
            InitUnitKeyBackground(u);
        }

        private void key_button_Click(object sender, EventArgs e)
        {
            this.inputContent.Text += (sender as Button).Text;
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            String text = this.inputContent.Text;
            if (text.Length != 0)
            {
                this.inputContent.Text = text.Remove(text.Length - 1);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            this.inputContent.Clear();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Owner.Tag = null;
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            String resultStr = "";
            if (inputContent.Text != "----" && inputContent.Text != "")
            {
                resultStr = inputContent.Text;
            }
            float min = 0;
            float max = 0;
            float result = float.Parse(resultStr);
            if ("Kpa" == this.unit)
            {
                min = float.Parse(minKpa);
                max = float.Parse(maxKpa);
            } 
            else if ("bar" == this.unit)
            {
                min = float.Parse(minBar);
                max = float.Parse(maxBar);
            }
            else
            {
                min = float.Parse(minPsi);
                max = float.Parse(maxPsi);
            }
            if (result >= min && result <= max)
            {
                this.Owner.Tag = new String[] {result.ToString(), this.unit};
                this.Close();
            }
            else
            {
                WarningForm form = new WarningForm("WARNING!!! INVALID PARAMETER.\nPlease check allowable range.");
                form.ShowDialog();
            }
        }

        private void key_button_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.key_down;
        }

        private void key_button_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.key_up;
        }

        private void enter_button_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.enter_key_down;
        }

        private void enter_button_MouseUp(object sender, MouseEventArgs e)
        {
            (sender as Button).BackgroundImage = global::mr.Properties.Resources.enter_key_up;
        }

        private String unit;

        private void kpaBtn_Click(object sender, EventArgs e)
        {
            if (this.unit != "Kpa")
            {
                ResetUnitKeyBackground(this.unit);
                infoLbl.Text = KpaLimitInfo;
                this.unit = "Kpa";
            }
        }

        private void barBtn_Click(object sender, EventArgs e)
        {
            if (this.unit != "bar")
            {
                infoLbl.Text = BarLimitInfo;
                ResetUnitKeyBackground(this.unit);
                this.unit = "bar";
            }
        }

        private void psiBtn_Click(object sender, EventArgs e)
        {
            if (this.unit != "psi")
            {
                infoLbl.Text = PsiLimitInfo;
                ResetUnitKeyBackground(this.unit);
                this.unit = "psi";
            }
        }

        private void InitUnitKeyBackground(String unit)
        {
            Button btn;
            if ("Kpa" == unit)
            {
                btn = kpaBtn;
            }
            else if ("bar" == unit)
            {
                btn = barBtn;
            }
            else
            {
                btn = psiBtn;
            }
            btn.BackgroundImage = global::mr.Properties.Resources.key_down;
        }

        private void ResetUnitKeyBackground(String unit)
        {
            Button btn;
            if ("Kpa" == unit)
            {
                btn = kpaBtn;
            }
            else if ("bar" == unit)
            {
                btn = barBtn;
            }
            else
            {
                btn = psiBtn;
            }
            btn.BackgroundImage = global::mr.Properties.Resources.key_up;
        }
    }
}
