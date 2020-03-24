namespace Facturation.UserControls
{
    partial class UIngenieur
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIngenieur));
            this.panelFeedback = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.InputNom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Ajouter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.InputCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.InputTel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.MyDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.columnModif = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFeedback
            // 
            this.panelFeedback.Controls.Add(this.label1);
            this.panelFeedback.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panelFeedback, BunifuAnimatorNS.DecorationType.None);
            this.panelFeedback.Location = new System.Drawing.Point(781, 38);
            this.panelFeedback.Name = "panelFeedback";
            this.panelFeedback.Size = new System.Drawing.Size(204, 35);
            this.panelFeedback.TabIndex = 28;
            this.panelFeedback.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajoutée avec succées";
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Facturation.Properties.Resources.good;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = global::Facturation.Properties.Resources.refresh;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(816, 202);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(38, 37);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 27;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.Controls.Add(this.InputNom);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuButton4);
            this.bunifuShadowPanel1.Controls.Add(this.Ajouter);
            this.bunifuShadowPanel1.Controls.Add(this.InputCode);
            this.bunifuShadowPanel1.Controls.Add(this.InputTel);
            this.bunifuTransition1.SetDecoration(this.bunifuShadowPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(78, 23);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 5;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = true;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(532, 112);
            this.bunifuShadowPanel1.TabIndex = 26;
            // 
            // InputNom
            // 
            this.InputNom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.InputNom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.InputNom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.InputNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.InputNom, BunifuAnimatorNS.DecorationType.None);
            this.InputNom.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.InputNom.HintForeColor = System.Drawing.Color.Empty;
            this.InputNom.HintText = "Nom de l\'agence/Client";
            this.InputNom.isPassword = false;
            this.InputNom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.InputNom.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.InputNom.LineMouseHoverColor = System.Drawing.Color.Black;
            this.InputNom.LineThickness = 4;
            this.InputNom.Location = new System.Drawing.Point(163, 20);
            this.InputNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputNom.MaxLength = 32767;
            this.InputNom.Name = "InputNom";
            this.InputNom.Size = new System.Drawing.Size(210, 30);
            this.InputNom.TabIndex = 16;
            this.InputNom.Text = "Nom";
            this.InputNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuButton4
            // 
            this.bunifuButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton4.BackgroundImage")));
            this.bunifuButton4.ButtonText = "Annuler";
            this.bunifuButton4.ButtonTextMarginLeft = 0;
            this.bunifuTransition1.SetDecoration(this.bunifuButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton4.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton4.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconPadding = 10;
            this.bunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.bunifuButton4.IdleBorderRadius = 1;
            this.bunifuButton4.IdleBorderThickness = 0;
            this.bunifuButton4.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.bunifuButton4.IdleIconLeftImage = null;
            this.bunifuButton4.IdleIconRightImage = null;
            this.bunifuButton4.Location = new System.Drawing.Point(255, 67);
            this.bunifuButton4.Name = "bunifuButton4";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton4.onHoverState = stateProperties1;
            this.bunifuButton4.Size = new System.Drawing.Size(83, 32);
            this.bunifuButton4.TabIndex = 6;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton4.Visible = false;
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.Transparent;
            this.Ajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ajouter.BackgroundImage")));
            this.Ajouter.ButtonText = "Ajouter un Ingenieur";
            this.Ajouter.ButtonTextMarginLeft = 0;
            this.bunifuTransition1.SetDecoration(this.Ajouter, BunifuAnimatorNS.DecorationType.None);
            this.Ajouter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Ajouter.DisabledFillColor = System.Drawing.Color.Gray;
            this.Ajouter.DisabledForecolor = System.Drawing.Color.White;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Ajouter.IconPadding = 10;
            this.Ajouter.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Ajouter.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.Ajouter.IdleBorderRadius = 1;
            this.Ajouter.IdleBorderThickness = 0;
            this.Ajouter.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.Ajouter.IdleIconLeftImage = null;
            this.Ajouter.IdleIconRightImage = null;
            this.Ajouter.Location = new System.Drawing.Point(343, 67);
            this.Ajouter.Name = "Ajouter";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.Ajouter.onHoverState = stateProperties2;
            this.Ajouter.Size = new System.Drawing.Size(150, 32);
            this.Ajouter.TabIndex = 6;
            this.Ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // InputCode
            // 
            this.InputCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.InputCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.InputCode.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.InputCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.InputCode, BunifuAnimatorNS.DecorationType.None);
            this.InputCode.Enabled = false;
            this.InputCode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.InputCode.HintForeColor = System.Drawing.Color.Empty;
            this.InputCode.HintText = "Code Client";
            this.InputCode.isPassword = false;
            this.InputCode.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.InputCode.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.InputCode.LineMouseHoverColor = System.Drawing.Color.Black;
            this.InputCode.LineThickness = 4;
            this.InputCode.Location = new System.Drawing.Point(25, 20);
            this.InputCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputCode.MaxLength = 32767;
            this.InputCode.Name = "InputCode";
            this.InputCode.Size = new System.Drawing.Size(117, 30);
            this.InputCode.TabIndex = 16;
            this.InputCode.Text = "Id Ingenieur";
            this.InputCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // InputTel
            // 
            this.InputTel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.InputTel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.InputTel.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.InputTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.InputTel, BunifuAnimatorNS.DecorationType.None);
            this.InputTel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.InputTel.HintForeColor = System.Drawing.Color.Empty;
            this.InputTel.HintText = "+212 606060606";
            this.InputTel.isPassword = false;
            this.InputTel.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.InputTel.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.InputTel.LineMouseHoverColor = System.Drawing.Color.Black;
            this.InputTel.LineThickness = 4;
            this.InputTel.Location = new System.Drawing.Point(390, 20);
            this.InputTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputTel.MaxLength = 32767;
            this.InputTel.Name = "InputTel";
            this.InputTel.Size = new System.Drawing.Size(117, 30);
            this.InputTel.TabIndex = 16;
            this.InputTel.Text = "Tel";
            this.InputTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::Facturation.Properties.Resources.search;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(675, 147);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 25;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 1;
            this.bunifuMetroTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(344, 142);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.MaxLength = 32767;
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(370, 39);
            this.bunifuMetroTextbox1.TabIndex = 24;
            this.bunifuMetroTextbox1.Text = "Nom D\'ingenieur";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MyDataGrid
            // 
            this.MyDataGrid.AllowUserToAddRows = false;
            this.MyDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MyDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MyDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyDataGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.MyDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MyDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MyDataGrid.ColumnHeadersHeight = 50;
            this.MyDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnModif});
            this.bunifuTransition1.SetDecoration(this.MyDataGrid, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MyDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.MyDataGrid.DoubleBuffered = true;
            this.MyDataGrid.EnableHeadersVisualStyles = false;
            this.MyDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.MyDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.MyDataGrid.Location = new System.Drawing.Point(56, 186);
            this.MyDataGrid.Name = "MyDataGrid";
            this.MyDataGrid.ReadOnly = true;
            this.MyDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MyDataGrid.RowHeadersVisible = false;
            this.MyDataGrid.RowTemplate.DividerHeight = 1;
            this.MyDataGrid.RowTemplate.Height = 40;
            this.MyDataGrid.RowTemplate.ReadOnly = true;
            this.MyDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MyDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyDataGrid.Size = new System.Drawing.Size(856, 551);
            this.MyDataGrid.TabIndex = 23;
            this.MyDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Modifier);
            // 
            // columnModif
            // 
            this.columnModif.FillWeight = 98.47716F;
            this.columnModif.HeaderText = "";
            this.columnModif.MinimumWidth = 3;
            this.columnModif.Name = "columnModif";
            this.columnModif.ReadOnly = true;
            this.columnModif.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnModif.Text = "Modifier";
            this.columnModif.UseColumnTextForButtonValue = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // UIngenieur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFeedback);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.MyDataGrid);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UIngenieur";
            this.Size = new System.Drawing.Size(994, 611);
            this.Load += new System.EventHandler(this.UIngenieur_Load);
            this.panelFeedback.ResumeLayout(false);
            this.panelFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputNom;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Ajouter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputTel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid MyDataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn columnModif;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Timer timer1;
    }
}
