using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturation.Data.Entities;
using Bunifu.UI.WinForms.BunifuButton;

namespace Facturation.UserControls
{
    public partial class UIngenieur : UserControl
    {
        public UIngenieur()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            //remplissage comboBox data grid view : testé et validé !
           
            LoadGridData();
        }

        public void LoadGridData()
        {
            //remplir data grid view : testé et validé !
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                var req = (from ing in db.INGENIEURs
                           select new
                           {
                               ing.IdIngenieur,
                               ing.noming,
                               ing.NumeroTelephoneIngenieur
                           });
                MyDataGrid.DataSource = req.ToList();
            }
            if (MyDataGrid.Columns.Count < 3)
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

     
        public void Modifier_Click(object sender, EventArgs e)
        {
            //modifier : testé et validé !
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                INGENIEUR ing = db.INGENIEURs.Find(InputCode.Text);
                ing.noming = InputNom.Text; 
                ing.NumeroTelephoneIngenieur = InputTel.Text;
               
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
            this.Ajouter.ButtonText = "Ajouter un Ingenieur";
            this.Ajouter.Location = new System.Drawing.Point(343, 67);
            this.Ajouter.Size = new System.Drawing.Size(150, 32);
            if (InputCode.Enabled.Equals(false))
            {
                this.Ajouter.Click -= new EventHandler(Modifier_Click);
                this.Ajouter.Click += new EventHandler(Ajouter_Click);
                InputCode.Enabled = true;
            }
            InputCode.ResetText();
            InputNom.ResetText();
            InputTel.ResetText();
         
            bunifuTransition1.ShowSync(bunifuShadowPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //rechercher : testé et validé !
            using (Facturation_DBEntities db = new Facturation_DBEntities())
            {
                MyDataGrid.DataSource = (from ing in db.INGENIEURs
                                         select new
                                         {
                                             ing.IdIngenieur,
                                             ing.noming,
                                             ing.NumeroTelephoneIngenieur
                                         }).Where(INGENIEUR => INGENIEUR.noming.Contains(bunifuMetroTextbox1.Text))
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
                using (Facturation_DBEntities db = new Facturation_DBEntities())
                {
                    bunifuTransition1.HideSync(bunifuShadowPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
                    this.Ajouter.ButtonText = "Confirmer !";
                    this.Ajouter.Location = new System.Drawing.Point(423, 67);
                    this.Ajouter.Size = new System.Drawing.Size(92, 32);
                    if (this.InputCode.Enabled)
            {
                    {
                        this.Ajouter.Click -= new EventHandler(Ajouter_Click);
                        this.Ajouter.Click += new EventHandler(Modifier_Click);
                        InputCode.Enabled = false;
                    }
                    var ing = db.INGENIEURs.Find(MyDataGrid.Rows[e.RowIndex].Cells["idIngenieur"].Value);
                    InputCode.Text = ing.IdIngenieur.ToString();
                    InputNom.Text = ing.noming;
                    InputTel.Text = ing.NumeroTelephoneIngenieur.ToString();
                  
                   

                    bunifuButton4.Visible = true;
                    bunifuTransition1.ShowSync(bunifuShadowPanel1, false, BunifuAnimatorNS.Animation.HorizSlide);
                }
            }
            else if (e.ColumnIndex.Equals(5) || e.ColumnIndex.Equals(1))
            {
                if (
                    DialogResult.Yes ==
                    MessageBox.Show($"Etes vous sur de vouloir supprimer <{MyDataGrid.Rows[e.RowIndex].Cells["nom"].Value}> de la base de donnée ?? Cette action est irréversible !",
                    "Supression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    )
                {
                    using (Facturation_DBEntities db = new Facturation_DBEntities())
                    {
                        db.CLIENTs.Remove(db.CLIENTs.Find(MyDataGrid.Rows[e.RowIndex].Cells["idIngenieur"].Value));
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

        private void UIngenieur_Load(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
         
                //ajouter : testé et validé !
                using (Facturation_DBEntities db = new Facturation_DBEntities())
                {
                    if (db.INGENIEURs.Find(InputCode.Text) is null)
                    {
                        db.INGENIEURs.Add(new INGENIEUR
                        {
                            IdIngenieur = Convert.ToInt32(InputCode.Text),
                            noming = InputNom.Text,
                            NumeroTelephoneIngenieur = InputTel.Text,


                        });
                        db.SaveChanges();
                        AnimationFeedback("Ajouté avec succées !", Properties.Resources.good);
                    }
                    else
                        AnimationFeedback("Client déja existant !", Properties.Resources.notValid);
                }
            

        }

        private void Modifier(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

