using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Facturation.Data.Database;
using Facturation.Data.Entities;
using Bunifu.UI.WinForms.BunifuButton;

namespace Facturation.UserControls
{
    public partial class UCCrudClient : UserControl
    {
        public UCCrudClient()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            //remplissage comboBox data grid view : testé et validé !
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                dropListVille.DisplayMember = "LblVille";
                dropListVille.ValueMember = "IdVille";
                dropListVille.DataSource = db.VILLEs.ToList();
            }
            LoadGridData();
        }

        public void LoadGridData()
        {
            //remplir data grid view : testé et validé !
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                var req = (from cl in db.CLIENTs
                           select new
                           {
                               cl.NumeroSerie,
                               cl.NomAgenceOuClient,
                               cl.NumeroTelephoneClient,
                               cl.VILLE.LblVille
                           });
                MyDataGrid.DataSource = req.ToList();
            }
            if (MyDataGrid.Columns.Count < 6)
            {
                MyDataGrid.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "columnSupr",
                    UseColumnTextForButtonValue = true,
                    Text = "Supprimer !",
                    HeaderText = "",
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    Width = 488,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet,
                    MinimumWidth = 3
                });
            }
        }

        public void Ajouter_Click(object sender, EventArgs e)
        {
            //ajouter : testé et validé !
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                if (db.CLIENTs.Find(InputCode.Text) is null)
                {
                    db.CLIENTs.Add(new CLIENT
                    {
                        NumeroSerie = InputCode.Text,
                        NumeroTelephoneClient = InputTel.Text,
                        NomAgenceOuClient = InputNom.Text,
                        VILLE = db.VILLEs.Find(dropListVille.SelectedValue)
                    });
                    db.SaveChanges();
                    AnimationFeedback("Ajouté avec succées !", Properties.Resources.good);
                }
                else
                    AnimationFeedback("Client déja existant !", Properties.Resources.notValid);
            }
        }

        public void Modifier_Click(object sender, EventArgs e)
        {
            //modifier : testé et validé !
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                CLIENT client = db.CLIENTs.Find(InputCode.Text);
                client.NumeroTelephoneClient = InputTel.Text;
                client.NomAgenceOuClient = InputNom.Text;
                client.VILLE = db.VILLEs.Find(dropListVille.SelectedValue);
                db.SaveChanges();
                btnAnnuler_Click(sender, e);
            }
            AnimationFeedback("Modifié avec succées !", Properties.Resources.good);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // rendre interface d'ajout 
            // effacer les champs
            // testé et validé !
            bunifuTransition1.HideSync(bunifuShadowPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
            bunifuButton4.Visible = false;
            this.bunifuButton1.ButtonText = "Ajouter un client";
            this.bunifuButton1.Location = new System.Drawing.Point(343, 67);
            this.bunifuButton1.Size = new System.Drawing.Size(150, 32);
            if (InputCode.Enabled.Equals(false))
            {
                this.bunifuButton1.Click -= new EventHandler(Modifier_Click);
                this.bunifuButton1.Click += new EventHandler(Ajouter_Click);
                InputCode.Enabled = true;
            }
            InputCode.ResetText();
            InputNom.ResetText();
            InputTel.ResetText();
            dropListVille.ResetText();
            bunifuTransition1.ShowSync(bunifuShadowPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //rechercher : testé et validé !
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                MyDataGrid.DataSource = (from cl in db.CLIENTs
                                         select new
                                         {
                                             cl.NumeroSerie,
                                             cl.NomAgenceOuClient,
                                             cl.NumeroTelephoneClient,
                                             cl.VILLE.LblVille
                                         }).Where(client => client.NomAgenceOuClient.Contains(bunifuMetroTextbox1.Text))
                                         .ToList();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
            => LoadGridData(); //actualiser dataGridView : testé et validé !

        private void AnimationFeedback(String labelText, Image image)
        {
            //confirmation : testé et validé !
            pictureBox1.Image = image;
            label1.Text = labelText;
            bunifuTransition1.ShowSync(panelFeedback, true, BunifuAnimatorNS.Animation.HorizSlide);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // regulateur d'animation : testé et validé !
            bunifuTransition1.HideSync(panelFeedback, true, BunifuAnimatorNS.Animation.HorizSlide);
        }

        private void MyDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // testé et validé !
            // intégre les donnée lli kaynine f la ligne dans les champs de l'interface d'ajout
            if (e.ColumnIndex.Equals(0))
            {
                using (Facturation_DBEntities db = new Facturation_DBEntities())
                {
                    bunifuTransition1.HideSync(bunifuShadowPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
                    this.bunifuButton1.ButtonText = "Confirmer !";
                    this.bunifuButton1.Location = new System.Drawing.Point(423, 67);
                    this.bunifuButton1.Size = new System.Drawing.Size(92, 32);
                    if (this.InputCode.Enabled)
                    {
                        this.bunifuButton1.Click -= new EventHandler(Ajouter_Click);
                        this.bunifuButton1.Click += new EventHandler(Modifier_Click);
                        InputCode.Enabled = false;
                    }
                    var client = db.CLIENTs.Find(MyDataGrid.Rows[e.RowIndex].Cells["NumeroSerie"].Value);
                    InputCode.Text = client.NumeroSerie;
                    InputTel.Text = client.NumeroTelephoneClient.ToString();
                    InputNom.Text = client.NomAgenceOuClient;
                    dropListVille.SelectedValue = client.VILLE.IdVille;
                    dropListVille.Text = client.VILLE.LblVille;

                    bunifuButton4.Visible = true; 
                    bunifuTransition1.ShowSync(bunifuShadowPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
                }
            }
            else if (e.ColumnIndex.Equals(5) || e.ColumnIndex.Equals(1))
            {
                if (
                    DialogResult.Yes ==
                    MessageBox.Show($"Etes vous sur de vouloir supprimer <{MyDataGrid.Rows[e.RowIndex].Cells["NomAgenceOuClient"].Value}> de la base de donnée ?? Cette action est irréversible !",
                    "Supression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    )
                {
                    using (Facturation_DBEntities db = new Facturation_DBEntities())
                    {
                        db.CLIENTs.Remove(db.CLIENTs.Find(MyDataGrid.Rows[e.RowIndex].Cells["NumeroSerie"].Value));
                        db.SaveChangesAsync();
                        AnimationFeedback("Suprimé avec succées !", Properties.Resources.good);
                    }
                }

            }
        }

        private void UCCrudClient_Load(object sender, EventArgs e)
        {
            // Ne pas toucher
            btnAnnuler_Click(sender, e);
        }
    }
}