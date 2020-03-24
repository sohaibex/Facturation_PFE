using BunifuAnimatorNS;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Facturation.UserControls
{
    public partial class UCHome : UserControl
    {
        public static IEnumerable<GunaMediumRadioButton> controls;
        public static IEnumerable<Panel> panels;
        int i = 0;
        public UCHome()
        {
            InitializeComponent();
            controls = panel1.Controls.OfType<GunaMediumRadioButton>().OrderBy(c => c.Name).ToList();
            panels = this.Controls.OfType<Panel>().Where(c => c.Visible == false).OrderBy(c => c.Name).ToList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 4)
                i = 0;
            ((GunaMediumRadioButton)panel1.Controls.OfType<GunaMediumRadioButton>().OrderBy(c => c.Name).ToList()[i]).Checked = true;
            ChangeRadioButton(((GunaMediumRadioButton)panel1.Controls.OfType<GunaMediumRadioButton>().OrderBy(c => c.Name).ToList()[i]).Name);
            panels.ToList()[i].BringToFront();
            ChangeSlide(panels.ToList()[i].Name);
            bunifuTransition1.ShowSync(panels.ToList()[i], false, BunifuAnimatorNS.Animation.Leaf);
            i++;
            ChangeurImage.Interval = 8000;
        }

        private void ChangeSlide(string panelName)
        {
            foreach (Panel panel in panels)
            {
                if (!panel.Name.Equals(panelName))
                    bunifuTransition1.HideSync(panel, false, BunifuAnimatorNS.Animation.Leaf);
            }
        }

        private void ChangeRadioButton(string radioName)
        {
            foreach (GunaMediumRadioButton radio in controls)
                if (!radio.Name.Equals(radioName))
                    radio.Checked = false;
        }

        public void InitialiseAnimation()
        {
            ChangeurImage.Start();
        }
        public void StopAnimation()
        {
            ChangeurImage.Stop();
        }
    }
}
