namespace Facturation.UserControls
{
    partial class UCCrudClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCrudClient));
            this.MyDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.columnModif = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dropListVille = new Bunifu.UI.WinForms.BunifuDropdown();
            this.InputCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.InputTel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.InputNom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelFeedback = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGrid)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            this.panelFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
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
            this.MyDataGrid.Location = new System.Drawing.Point(27, 282);
            this.MyDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MyDataGrid.Name = "MyDataGrid";
            this.MyDataGrid.ReadOnly = true;
            this.MyDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MyDataGrid.RowHeadersVisible = false;
            this.MyDataGrid.RowTemplate.DividerHeight = 1;
            this.MyDataGrid.RowTemplate.Height = 40;
            this.MyDataGrid.RowTemplate.ReadOnly = true;
            this.MyDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MyDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyDataGrid.Size = new System.Drawing.Size(1442, 654);
            this.MyDataGrid.TabIndex = 0;
            this.MyDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyDataGrid_CellClick);
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
            // dropListVille
            // 
            this.dropListVille.BackColor = System.Drawing.Color.Snow;
            this.dropListVille.BorderRadius = 3;
            this.dropListVille.Color = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.bunifuTransition1.SetDecoration(this.dropListVille, BunifuAnimatorNS.DecorationType.None);
            this.dropListVille.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropListVille.DisabledColor = System.Drawing.Color.Gray;
            this.dropListVille.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropListVille.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dropListVille.DropDownHeight = 80;
            this.dropListVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropListVille.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropListVille.FillDropDown = false;
            this.dropListVille.FillIndicator = false;
            this.dropListVille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropListVille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.dropListVille.FormattingEnabled = true;
            this.dropListVille.Icon = null;
            this.dropListVille.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.dropListVille.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropListVille.IntegralHeight = false;
            this.dropListVille.ItemBackColor = System.Drawing.Color.White;
            this.dropListVille.ItemBorderColor = System.Drawing.Color.White;
            this.dropListVille.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.dropListVille.ItemHeight = 26;
            this.dropListVille.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.dropListVille.Location = new System.Drawing.Point(74, 103);
            this.dropListVille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dropListVille.Name = "dropListVille";
            this.dropListVille.Size = new System.Drawing.Size(384, 32);
            this.dropListVille.TabIndex = 15;
            this.dropListVille.Text = null;
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
            this.InputCode.Location = new System.Drawing.Point(38, 31);
            this.InputCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.InputCode.MaxLength = 32767;
            this.InputCode.Name = "InputCode";
            this.InputCode.Size = new System.Drawing.Size(176, 46);
            this.InputCode.TabIndex = 16;
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
            this.InputTel.Location = new System.Drawing.Point(248, 31);
            this.InputTel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.InputTel.MaxLength = 32767;
            this.InputTel.Name = "InputTel";
            this.InputTel.Size = new System.Drawing.Size(176, 46);
            this.InputTel.TabIndex = 16;
            this.InputTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.InputNom.Location = new System.Drawing.Point(458, 31);
            this.InputNom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.InputNom.MaxLength = 32767;
            this.InputNom.Name = "InputNom";
            this.InputNom.Size = new System.Drawing.Size(315, 46);
            this.InputNom.TabIndex = 16;
            this.InputNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.MyDataGrid;
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
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(459, 215);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuMetroTextbox1.MaxLength = 32767;
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(555, 60);
            this.bunifuMetroTextbox1.TabIndex = 17;
            this.bunifuMetroTextbox1.Text = "Nom de l\'agence/client ...";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.Controls.Add(this.InputNom);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuButton4);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuButton1);
            this.bunifuShadowPanel1.Controls.Add(this.dropListVille);
            this.bunifuShadowPanel1.Controls.Add(this.InputCode);
            this.bunifuShadowPanel1.Controls.Add(this.InputTel);
            this.bunifuTransition1.SetDecoration(this.bunifuShadowPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(57, 5);
            this.bunifuShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 5;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = true;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(798, 172);
            this.bunifuShadowPanel1.TabIndex = 20;
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
            this.bunifuButton4.Location = new System.Drawing.Point(501, 103);
            this.bunifuButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuButton4.Name = "bunifuButton4";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton4.onHoverState = stateProperties1;
            this.bunifuButton4.Size = new System.Drawing.Size(124, 49);
            this.bunifuButton4.TabIndex = 6;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton4.Visible = false;
            this.bunifuButton4.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Ajouter un client";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuTransition1.SetDecoration(this.bunifuButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(514, 103);
            this.bunifuButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(225, 49);
            this.bunifuButton1.TabIndex = 6;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panelFeedback
            // 
            this.panelFeedback.Controls.Add(this.label1);
            this.panelFeedback.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panelFeedback, BunifuAnimatorNS.DecorationType.None);
            this.panelFeedback.Location = new System.Drawing.Point(1114, 54);
            this.panelFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFeedback.Name = "panelFeedback";
            this.panelFeedback.Size = new System.Drawing.Size(306, 54);
            this.panelFeedback.TabIndex = 22;
            this.panelFeedback.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajoutée avec succées";
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Facturation.Properties.Resources.good;
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
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
            this.bunifuImageButton2.Location = new System.Drawing.Point(1380, 291);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(57, 57);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 21;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::Facturation.Properties.Resources.search;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(956, 222);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(52, 54);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 19;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UCCrudClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.panelFeedback);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.MyDataGrid);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCCrudClient";
            this.Size = new System.Drawing.Size(1491, 940);
            this.Load += new System.EventHandler(this.UCCrudClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGrid)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.panelFeedback.ResumeLayout(false);
            this.panelFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuDropdown dropListVille;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputTel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputNom;

        private Bunifu.Framework.UI.BunifuCustomDataGrid MyDataGrid;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
        private System.Windows.Forms.Panel panelFeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewButtonColumn columnModif;
    }
}
