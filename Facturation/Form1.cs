using Bunifu.Framework.UI;
using Facturation.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation
{
    public partial class Form1 : Form
    {
        public bool IsAdmin { get; set; }
        public Form1()
        {
            InitializeComponent();
            // à modifier !
            IsAdmin = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //(new LoginForm()).Show();
            ActiveButton("flatBtn_home");
            this.ucHome1.BringToFront();
            this.ucHome1.InitialiseAnimation();
            if (!IsAdmin)
                this.flatBtn_gestion.Text = "    Gestion des               clients";
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(((BunifuFlatButton)sender).Name);
            this.ucStatistique1.LoadData();
            this.ucStatistique1.BringToFront();
        }

        private void stopHomeAnimation()
        {
            this.ucHome1.StopAnimation();
        }

        private void flatBtn_gestion_Click(object sender, EventArgs e)
        {
            ActiveButton(((BunifuFlatButton)sender).Name);
            if (IsAdmin)
                this.panelChoix.BringToFront();
            else
            {
                this.ucCrudClient1.loaddata();
                this.ucCrudClient1.BringToFront();
            }
        }

        private void tileBtnClient_Click(object sender, EventArgs e)
        {
            this.ucCrudClient1.loaddata();
            this.ucCrudClient1.BringToFront();
        }

        private void ActiveButton(string btnName)
        {
            if (!btnName.Equals("flatBtn_home"))
                stopHomeAnimation();
            foreach (Control c in containerButton.Controls)
                if (c is BunifuFlatButton btn)
                    if (!(btn.Name.Equals(btnName)))
                        btn.Normalcolor = Color.Transparent;
                    else
                        btn.Normalcolor = System.Drawing.Color.FromArgb
                            (
                            ((int)(((byte)(106)))),
                            ((int)(((byte)(131)))),
                            ((int)(((byte)(245))))
                            );
        }

        private void flatBtn_home_Click(object sender, EventArgs e)
        {
            ActiveButton(((BunifuFlatButton)sender).Name);
            this.ucHome1.InitialiseAnimation();
            this.ucHome1.BringToFront();
        }

        private void flatBtn_saisie_Click(object sender, EventArgs e)
        {
            ActiveButton(((BunifuFlatButton)sender).Name);
            this.ucSaisie1.BringToFront();
        }

        private void tileBtnIngenieur_Click(object sender, EventArgs e)
        {
            //interface saisie des ingénieurs
            this.uIngenieur1.BringToFront();



        }

        private void tileBtnSecrtr_Click(object sender, EventArgs e)
        {
            //interface saisie des secretaires
        }

        private void flatBtn_impression_Click(object sender, EventArgs e)
        {
            ActiveButton(((BunifuFlatButton)sender).Name);
            // afficher user control de l'impression
        }

        private void ucHome1_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
