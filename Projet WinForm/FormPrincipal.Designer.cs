namespace Projet_WinForm
{
    partial class FormPrincipal
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.ajoutClub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listClubs = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRetourListeClub = new System.Windows.Forms.Button();
            this.buttonModifClub = new System.Windows.Forms.Button();
            this.idClub = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxModifURLClub = new System.Windows.Forms.TextBox();
            this.textBoxModifMailClub = new System.Windows.Forms.TextBox();
            this.textBoxModifTelClub = new System.Windows.Forms.TextBox();
            this.textBoxModifVilleClub = new System.Windows.Forms.TextBox();
            this.textBoxModifCPClub = new System.Windows.Forms.TextBox();
            this.textBoxModifAdresseClub = new System.Windows.Forms.TextBox();
            this.textBoxModifNameClub = new System.Windows.Forms.TextBox();
            this.buttonConsultEvent = new System.Windows.Forms.Button();
            this.buttonConsultAdherent = new System.Windows.Forms.Button();
            this.pageClub = new System.Windows.Forms.Label();
            this.panelListAdherents = new System.Windows.Forms.Panel();
            this.textBoxRechercheAdherent = new System.Windows.Forms.TextBox();
            this.labelNomDuClub = new System.Windows.Forms.Label();
            this.buttonAjoutAdherent = new System.Windows.Forms.Button();
            this.buttonRetourClub = new System.Windows.Forms.Button();
            this.dataGridViewListAdherents = new System.Windows.Forms.DataGridView();
            this.PanelModifAdherent = new System.Windows.Forms.Panel();
            this.buttonAdhToEvent = new System.Windows.Forms.Button();
            this.labelNomClubAdhModif = new System.Windows.Forms.Label();
            this.dateTimePickerNaissanceAdhModif = new System.Windows.Forms.DateTimePicker();
            this.textBoxCotisationAdhModif = new System.Windows.Forms.TextBox();
            this.textBoxVilleAdhModif = new System.Windows.Forms.TextBox();
            this.textBoxCPAdhModif = new System.Windows.Forms.TextBox();
            this.textBoxAdresseAdhModif = new System.Windows.Forms.TextBox();
            this.textBoxLicenceAdhModif = new System.Windows.Forms.TextBox();
            this.textBoxSexeAdhModif = new System.Windows.Forms.TextBox();
            this.textBoxPrenomAdhModif = new System.Windows.Forms.TextBox();
            this.textBoxNomAdhModif = new System.Windows.Forms.TextBox();
            this.buttonModifierAdherent = new System.Windows.Forms.Button();
            this.buttonBackToListAdherent = new System.Windows.Forms.Button();
            this.labelTextIdDeLAdh = new System.Windows.Forms.Label();
            this.labelIdAdhModif = new System.Windows.Forms.Label();
            this.labelIdClubAdh = new System.Windows.Forms.Label();
            this.labelNomAdh = new System.Windows.Forms.Label();
            this.labelPrenomAdh = new System.Windows.Forms.Label();
            this.labelSexeAdh = new System.Windows.Forms.Label();
            this.labelNaissanceAdh = new System.Windows.Forms.Label();
            this.labelAdresseAdh = new System.Windows.Forms.Label();
            this.labelCPAdh = new System.Windows.Forms.Label();
            this.labelVilleAdh = new System.Windows.Forms.Label();
            this.labelCotisAdh = new System.Windows.Forms.Label();
            this.labelLicenceAdh = new System.Windows.Forms.Label();
            this.labelNomClub = new System.Windows.Forms.Label();
            this.labelAdresseClub = new System.Windows.Forms.Label();
            this.labelCPClub = new System.Windows.Forms.Label();
            this.labelVilleClub = new System.Windows.Forms.Label();
            this.labelTelClub = new System.Windows.Forms.Label();
            this.labelMailClub = new System.Windows.Forms.Label();
            this.labelURLClub = new System.Windows.Forms.Label();
            this.panelConsultEvent = new System.Windows.Forms.Panel();
            this.buttonBackToClubFromEvent = new System.Windows.Forms.Button();
            this.dataGridViewListEvent = new System.Windows.Forms.DataGridView();
            this.buttonNewEvent = new System.Windows.Forms.Button();
            this.labelNomClubOnEvent = new System.Windows.Forms.Label();
            this.textBoxSearchEvent = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listClubs)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelListAdherents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAdherents)).BeginInit();
            this.PanelModifAdherent.SuspendLayout();
            this.panelConsultEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.textBoxRecherche);
            this.panel1.Controls.Add(this.ajoutClub);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listClubs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 558);
            this.panel1.TabIndex = 0;
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(13, 55);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(229, 20);
            this.textBoxRecherche.TabIndex = 4;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // ajoutClub
            // 
            this.ajoutClub.Location = new System.Drawing.Point(214, 468);
            this.ajoutClub.Name = "ajoutClub";
            this.ajoutClub.Size = new System.Drawing.Size(251, 37);
            this.ajoutClub.TabIndex = 3;
            this.ajoutClub.Text = "Ajouter un Club";
            this.ajoutClub.UseVisualStyleBackColor = true;
            this.ajoutClub.Click += new System.EventHandler(this.ajoutClub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Page de consultation des Clubs";
            // 
            // listClubs
            // 
            this.listClubs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listClubs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listClubs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listClubs.DefaultCellStyle = dataGridViewCellStyle4;
            this.listClubs.Location = new System.Drawing.Point(0, 85);
            this.listClubs.Name = "listClubs";
            this.listClubs.Size = new System.Drawing.Size(788, 359);
            this.listClubs.TabIndex = 2;
            this.listClubs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listClubs_CellDoubleClick);
            this.listClubs.VisibleChanged += new System.EventHandler(this.listClubs_VisibleChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelURLClub);
            this.panel2.Controls.Add(this.labelMailClub);
            this.panel2.Controls.Add(this.labelTelClub);
            this.panel2.Controls.Add(this.labelVilleClub);
            this.panel2.Controls.Add(this.labelCPClub);
            this.panel2.Controls.Add(this.labelAdresseClub);
            this.panel2.Controls.Add(this.labelNomClub);
            this.panel2.Controls.Add(this.buttonRetourListeClub);
            this.panel2.Controls.Add(this.buttonModifClub);
            this.panel2.Controls.Add(this.idClub);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.textBoxModifURLClub);
            this.panel2.Controls.Add(this.textBoxModifMailClub);
            this.panel2.Controls.Add(this.textBoxModifTelClub);
            this.panel2.Controls.Add(this.textBoxModifVilleClub);
            this.panel2.Controls.Add(this.textBoxModifCPClub);
            this.panel2.Controls.Add(this.textBoxModifAdresseClub);
            this.panel2.Controls.Add(this.textBoxModifNameClub);
            this.panel2.Controls.Add(this.buttonConsultEvent);
            this.panel2.Controls.Add(this.buttonConsultAdherent);
            this.panel2.Controls.Add(this.pageClub);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 558);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // buttonRetourListeClub
            // 
            this.buttonRetourListeClub.Location = new System.Drawing.Point(0, 15);
            this.buttonRetourListeClub.Name = "buttonRetourListeClub";
            this.buttonRetourListeClub.Size = new System.Drawing.Size(138, 27);
            this.buttonRetourListeClub.TabIndex = 13;
            this.buttonRetourListeClub.Text = "Retour à la liste des clubs";
            this.buttonRetourListeClub.UseVisualStyleBackColor = true;
            this.buttonRetourListeClub.Click += new System.EventHandler(this.buttonRetourListeClub_Click);
            // 
            // buttonModifClub
            // 
            this.buttonModifClub.Location = new System.Drawing.Point(136, 448);
            this.buttonModifClub.Name = "buttonModifClub";
            this.buttonModifClub.Size = new System.Drawing.Size(138, 29);
            this.buttonModifClub.TabIndex = 12;
            this.buttonModifClub.Text = "Modifier";
            this.buttonModifClub.UseVisualStyleBackColor = true;
            this.buttonModifClub.Click += new System.EventHandler(this.buttonModifClub_Click);
            // 
            // idClub
            // 
            this.idClub.AutoSize = true;
            this.idClub.Location = new System.Drawing.Point(239, 175);
            this.idClub.Name = "idClub";
            this.idClub.Size = new System.Drawing.Size(35, 13);
            this.idClub.TabIndex = 11;
            this.idClub.Text = "label4";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(29, 182);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 13);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "Id : ";
            // 
            // textBoxModifURLClub
            // 
            this.textBoxModifURLClub.Location = new System.Drawing.Point(474, 398);
            this.textBoxModifURLClub.Name = "textBoxModifURLClub";
            this.textBoxModifURLClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifURLClub.TabIndex = 9;
            // 
            // textBoxModifMailClub
            // 
            this.textBoxModifMailClub.Location = new System.Drawing.Point(474, 324);
            this.textBoxModifMailClub.Name = "textBoxModifMailClub";
            this.textBoxModifMailClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifMailClub.TabIndex = 8;
            // 
            // textBoxModifTelClub
            // 
            this.textBoxModifTelClub.Location = new System.Drawing.Point(474, 249);
            this.textBoxModifTelClub.Name = "textBoxModifTelClub";
            this.textBoxModifTelClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifTelClub.TabIndex = 7;
            // 
            // textBoxModifVilleClub
            // 
            this.textBoxModifVilleClub.Location = new System.Drawing.Point(474, 175);
            this.textBoxModifVilleClub.Name = "textBoxModifVilleClub";
            this.textBoxModifVilleClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifVilleClub.TabIndex = 6;
            // 
            // textBoxModifCPClub
            // 
            this.textBoxModifCPClub.Location = new System.Drawing.Point(91, 398);
            this.textBoxModifCPClub.Name = "textBoxModifCPClub";
            this.textBoxModifCPClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifCPClub.TabIndex = 5;
            // 
            // textBoxModifAdresseClub
            // 
            this.textBoxModifAdresseClub.Location = new System.Drawing.Point(91, 324);
            this.textBoxModifAdresseClub.Name = "textBoxModifAdresseClub";
            this.textBoxModifAdresseClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifAdresseClub.TabIndex = 4;
            // 
            // textBoxModifNameClub
            // 
            this.textBoxModifNameClub.Location = new System.Drawing.Point(91, 249);
            this.textBoxModifNameClub.Name = "textBoxModifNameClub";
            this.textBoxModifNameClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifNameClub.TabIndex = 3;
            // 
            // buttonConsultEvent
            // 
            this.buttonConsultEvent.Location = new System.Drawing.Point(416, 83);
            this.buttonConsultEvent.Name = "buttonConsultEvent";
            this.buttonConsultEvent.Size = new System.Drawing.Size(187, 23);
            this.buttonConsultEvent.TabIndex = 2;
            this.buttonConsultEvent.Text = "Consulter Evenements";
            this.buttonConsultEvent.UseVisualStyleBackColor = true;
            this.buttonConsultEvent.Click += new System.EventHandler(this.buttonConsultEvent_Click);
            // 
            // buttonConsultAdherent
            // 
            this.buttonConsultAdherent.Location = new System.Drawing.Point(87, 83);
            this.buttonConsultAdherent.Name = "buttonConsultAdherent";
            this.buttonConsultAdherent.Size = new System.Drawing.Size(187, 24);
            this.buttonConsultAdherent.TabIndex = 1;
            this.buttonConsultAdherent.Text = "Consulter Adhérents";
            this.buttonConsultAdherent.UseVisualStyleBackColor = true;
            this.buttonConsultAdherent.Click += new System.EventHandler(this.buttonConsultAdherent_Click);
            // 
            // pageClub
            // 
            this.pageClub.AutoSize = true;
            this.pageClub.Location = new System.Drawing.Point(324, 15);
            this.pageClub.Name = "pageClub";
            this.pageClub.Size = new System.Drawing.Size(84, 13);
            this.pageClub.TabIndex = 0;
            this.pageClub.Text = "club selectionné";
            // 
            // panelListAdherents
            // 
            this.panelListAdherents.Controls.Add(this.textBoxRechercheAdherent);
            this.panelListAdherents.Controls.Add(this.labelNomDuClub);
            this.panelListAdherents.Controls.Add(this.buttonAjoutAdherent);
            this.panelListAdherents.Controls.Add(this.buttonRetourClub);
            this.panelListAdherents.Controls.Add(this.dataGridViewListAdherents);
            this.panelListAdherents.Location = new System.Drawing.Point(0, 0);
            this.panelListAdherents.Name = "panelListAdherents";
            this.panelListAdherents.Size = new System.Drawing.Size(790, 558);
            this.panelListAdherents.TabIndex = 2;
            // 
            // textBoxRechercheAdherent
            // 
            this.textBoxRechercheAdherent.Location = new System.Drawing.Point(13, 57);
            this.textBoxRechercheAdherent.Name = "textBoxRechercheAdherent";
            this.textBoxRechercheAdherent.Size = new System.Drawing.Size(202, 20);
            this.textBoxRechercheAdherent.TabIndex = 4;
            this.textBoxRechercheAdherent.TextChanged += new System.EventHandler(this.textBoxRechercheAdherent_TextChanged);
            // 
            // labelNomDuClub
            // 
            this.labelNomDuClub.AutoSize = true;
            this.labelNomDuClub.Location = new System.Drawing.Point(340, 15);
            this.labelNomDuClub.Name = "labelNomDuClub";
            this.labelNomDuClub.Size = new System.Drawing.Size(35, 13);
            this.labelNomDuClub.TabIndex = 3;
            this.labelNomDuClub.Text = "label2";
            // 
            // buttonAjoutAdherent
            // 
            this.buttonAjoutAdherent.Location = new System.Drawing.Point(281, 472);
            this.buttonAjoutAdherent.Name = "buttonAjoutAdherent";
            this.buttonAjoutAdherent.Size = new System.Drawing.Size(184, 33);
            this.buttonAjoutAdherent.TabIndex = 2;
            this.buttonAjoutAdherent.Text = "Ajouter un Adhérent";
            this.buttonAjoutAdherent.UseVisualStyleBackColor = true;
            this.buttonAjoutAdherent.Click += new System.EventHandler(this.buttonAjoutAdherent_Click);
            // 
            // buttonRetourClub
            // 
            this.buttonRetourClub.Location = new System.Drawing.Point(12, 12);
            this.buttonRetourClub.Name = "buttonRetourClub";
            this.buttonRetourClub.Size = new System.Drawing.Size(167, 31);
            this.buttonRetourClub.TabIndex = 1;
            this.buttonRetourClub.Text = "Retouner au  Club";
            this.buttonRetourClub.UseVisualStyleBackColor = true;
            this.buttonRetourClub.Click += new System.EventHandler(this.buttonRetourClub_Click);
            // 
            // dataGridViewListAdherents
            // 
            this.dataGridViewListAdherents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAdherents.Location = new System.Drawing.Point(0, 91);
            this.dataGridViewListAdherents.Name = "dataGridViewListAdherents";
            this.dataGridViewListAdherents.Size = new System.Drawing.Size(790, 352);
            this.dataGridViewListAdherents.TabIndex = 0;
            this.dataGridViewListAdherents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListAdherents_CellDoubleClick);
            // 
            // PanelModifAdherent
            // 
            this.PanelModifAdherent.Controls.Add(this.labelLicenceAdh);
            this.PanelModifAdherent.Controls.Add(this.labelCotisAdh);
            this.PanelModifAdherent.Controls.Add(this.labelVilleAdh);
            this.PanelModifAdherent.Controls.Add(this.labelCPAdh);
            this.PanelModifAdherent.Controls.Add(this.labelAdresseAdh);
            this.PanelModifAdherent.Controls.Add(this.labelNaissanceAdh);
            this.PanelModifAdherent.Controls.Add(this.labelSexeAdh);
            this.PanelModifAdherent.Controls.Add(this.labelPrenomAdh);
            this.PanelModifAdherent.Controls.Add(this.labelNomAdh);
            this.PanelModifAdherent.Controls.Add(this.labelIdClubAdh);
            this.PanelModifAdherent.Controls.Add(this.labelIdAdhModif);
            this.PanelModifAdherent.Controls.Add(this.labelTextIdDeLAdh);
            this.PanelModifAdherent.Controls.Add(this.buttonAdhToEvent);
            this.PanelModifAdherent.Controls.Add(this.labelNomClubAdhModif);
            this.PanelModifAdherent.Controls.Add(this.dateTimePickerNaissanceAdhModif);
            this.PanelModifAdherent.Controls.Add(this.textBoxCotisationAdhModif);
            this.PanelModifAdherent.Controls.Add(this.textBoxVilleAdhModif);
            this.PanelModifAdherent.Controls.Add(this.textBoxCPAdhModif);
            this.PanelModifAdherent.Controls.Add(this.textBoxAdresseAdhModif);
            this.PanelModifAdherent.Controls.Add(this.textBoxLicenceAdhModif);
            this.PanelModifAdherent.Controls.Add(this.textBoxSexeAdhModif);
            this.PanelModifAdherent.Controls.Add(this.textBoxPrenomAdhModif);
            this.PanelModifAdherent.Controls.Add(this.textBoxNomAdhModif);
            this.PanelModifAdherent.Controls.Add(this.buttonModifierAdherent);
            this.PanelModifAdherent.Controls.Add(this.buttonBackToListAdherent);
            this.PanelModifAdherent.Location = new System.Drawing.Point(0, 0);
            this.PanelModifAdherent.Name = "PanelModifAdherent";
            this.PanelModifAdherent.Size = new System.Drawing.Size(789, 557);
            this.PanelModifAdherent.TabIndex = 3;
            // 
            // buttonAdhToEvent
            // 
            this.buttonAdhToEvent.Location = new System.Drawing.Point(593, 455);
            this.buttonAdhToEvent.Name = "buttonAdhToEvent";
            this.buttonAdhToEvent.Size = new System.Drawing.Size(146, 34);
            this.buttonAdhToEvent.TabIndex = 12;
            this.buttonAdhToEvent.Text = "évènements ";
            this.buttonAdhToEvent.UseVisualStyleBackColor = true;
            // 
            // labelNomClubAdhModif
            // 
            this.labelNomClubAdhModif.AutoSize = true;
            this.labelNomClubAdhModif.Location = new System.Drawing.Point(340, 44);
            this.labelNomClubAdhModif.Name = "labelNomClubAdhModif";
            this.labelNomClubAdhModif.Size = new System.Drawing.Size(35, 13);
            this.labelNomClubAdhModif.TabIndex = 11;
            this.labelNomClubAdhModif.Text = "label2";
            // 
            // dateTimePickerNaissanceAdhModif
            // 
            this.dateTimePickerNaissanceAdhModif.Location = new System.Drawing.Point(96, 266);
            this.dateTimePickerNaissanceAdhModif.Name = "dateTimePickerNaissanceAdhModif";
            this.dateTimePickerNaissanceAdhModif.Size = new System.Drawing.Size(204, 20);
            this.dateTimePickerNaissanceAdhModif.TabIndex = 10;
            // 
            // textBoxCotisationAdhModif
            // 
            this.textBoxCotisationAdhModif.Location = new System.Drawing.Point(474, 266);
            this.textBoxCotisationAdhModif.Name = "textBoxCotisationAdhModif";
            this.textBoxCotisationAdhModif.Size = new System.Drawing.Size(205, 20);
            this.textBoxCotisationAdhModif.TabIndex = 9;
            // 
            // textBoxVilleAdhModif
            // 
            this.textBoxVilleAdhModif.Location = new System.Drawing.Point(474, 223);
            this.textBoxVilleAdhModif.Name = "textBoxVilleAdhModif";
            this.textBoxVilleAdhModif.Size = new System.Drawing.Size(205, 20);
            this.textBoxVilleAdhModif.TabIndex = 8;
            // 
            // textBoxCPAdhModif
            // 
            this.textBoxCPAdhModif.Location = new System.Drawing.Point(474, 182);
            this.textBoxCPAdhModif.Name = "textBoxCPAdhModif";
            this.textBoxCPAdhModif.Size = new System.Drawing.Size(205, 20);
            this.textBoxCPAdhModif.TabIndex = 7;
            // 
            // textBoxAdresseAdhModif
            // 
            this.textBoxAdresseAdhModif.Location = new System.Drawing.Point(474, 129);
            this.textBoxAdresseAdhModif.Name = "textBoxAdresseAdhModif";
            this.textBoxAdresseAdhModif.Size = new System.Drawing.Size(205, 20);
            this.textBoxAdresseAdhModif.TabIndex = 6;
            // 
            // textBoxLicenceAdhModif
            // 
            this.textBoxLicenceAdhModif.Location = new System.Drawing.Point(554, 30);
            this.textBoxLicenceAdhModif.Name = "textBoxLicenceAdhModif";
            this.textBoxLicenceAdhModif.Size = new System.Drawing.Size(186, 20);
            this.textBoxLicenceAdhModif.TabIndex = 5;
            // 
            // textBoxSexeAdhModif
            // 
            this.textBoxSexeAdhModif.Location = new System.Drawing.Point(96, 223);
            this.textBoxSexeAdhModif.Name = "textBoxSexeAdhModif";
            this.textBoxSexeAdhModif.Size = new System.Drawing.Size(205, 20);
            this.textBoxSexeAdhModif.TabIndex = 4;
            // 
            // textBoxPrenomAdhModif
            // 
            this.textBoxPrenomAdhModif.Location = new System.Drawing.Point(96, 182);
            this.textBoxPrenomAdhModif.Name = "textBoxPrenomAdhModif";
            this.textBoxPrenomAdhModif.Size = new System.Drawing.Size(205, 20);
            this.textBoxPrenomAdhModif.TabIndex = 3;
            // 
            // textBoxNomAdhModif
            // 
            this.textBoxNomAdhModif.Location = new System.Drawing.Point(96, 129);
            this.textBoxNomAdhModif.Name = "textBoxNomAdhModif";
            this.textBoxNomAdhModif.Size = new System.Drawing.Size(205, 20);
            this.textBoxNomAdhModif.TabIndex = 2;
            // 
            // buttonModifierAdherent
            // 
            this.buttonModifierAdherent.Location = new System.Drawing.Point(286, 455);
            this.buttonModifierAdherent.Name = "buttonModifierAdherent";
            this.buttonModifierAdherent.Size = new System.Drawing.Size(165, 35);
            this.buttonModifierAdherent.TabIndex = 1;
            this.buttonModifierAdherent.Text = "Modifier";
            this.buttonModifierAdherent.UseVisualStyleBackColor = true;
            this.buttonModifierAdherent.Click += new System.EventHandler(this.buttonModifierAdherent_Click);
            // 
            // buttonBackToListAdherent
            // 
            this.buttonBackToListAdherent.Location = new System.Drawing.Point(27, 30);
            this.buttonBackToListAdherent.Name = "buttonBackToListAdherent";
            this.buttonBackToListAdherent.Size = new System.Drawing.Size(176, 27);
            this.buttonBackToListAdherent.TabIndex = 0;
            this.buttonBackToListAdherent.Text = "Revenir à la liste des adhérents";
            this.buttonBackToListAdherent.UseVisualStyleBackColor = true;
            this.buttonBackToListAdherent.Click += new System.EventHandler(this.buttonBackToListAdherent_Click);
            // 
            // labelTextIdDeLAdh
            // 
            this.labelTextIdDeLAdh.AutoSize = true;
            this.labelTextIdDeLAdh.Location = new System.Drawing.Point(283, 75);
            this.labelTextIdDeLAdh.Name = "labelTextIdDeLAdh";
            this.labelTextIdDeLAdh.Size = new System.Drawing.Size(86, 13);
            this.labelTextIdDeLAdh.TabIndex = 13;
            this.labelTextIdDeLAdh.Text = "Id de l\'adhérent :";
            // 
            // labelIdAdhModif
            // 
            this.labelIdAdhModif.AutoSize = true;
            this.labelIdAdhModif.Location = new System.Drawing.Point(385, 75);
            this.labelIdAdhModif.Name = "labelIdAdhModif";
            this.labelIdAdhModif.Size = new System.Drawing.Size(35, 13);
            this.labelIdAdhModif.TabIndex = 14;
            this.labelIdAdhModif.Text = "label2";
            // 
            // labelIdClubAdh
            // 
            this.labelIdClubAdh.AutoSize = true;
            this.labelIdClubAdh.Location = new System.Drawing.Point(266, 44);
            this.labelIdClubAdh.Name = "labelIdClubAdh";
            this.labelIdClubAdh.Size = new System.Drawing.Size(35, 13);
            this.labelIdClubAdh.TabIndex = 15;
            this.labelIdClubAdh.Text = "label2";
            this.labelIdClubAdh.Visible = false;
            // 
            // labelNomAdh
            // 
            this.labelNomAdh.AutoSize = true;
            this.labelNomAdh.Location = new System.Drawing.Point(19, 136);
            this.labelNomAdh.Name = "labelNomAdh";
            this.labelNomAdh.Size = new System.Drawing.Size(38, 13);
            this.labelNomAdh.TabIndex = 16;
            this.labelNomAdh.Text = "Nom : ";
            // 
            // labelPrenomAdh
            // 
            this.labelPrenomAdh.AutoSize = true;
            this.labelPrenomAdh.Location = new System.Drawing.Point(19, 189);
            this.labelPrenomAdh.Name = "labelPrenomAdh";
            this.labelPrenomAdh.Size = new System.Drawing.Size(52, 13);
            this.labelPrenomAdh.TabIndex = 17;
            this.labelPrenomAdh.Text = "Prenom : ";
            // 
            // labelSexeAdh
            // 
            this.labelSexeAdh.AutoSize = true;
            this.labelSexeAdh.Location = new System.Drawing.Point(19, 230);
            this.labelSexeAdh.Name = "labelSexeAdh";
            this.labelSexeAdh.Size = new System.Drawing.Size(40, 13);
            this.labelSexeAdh.TabIndex = 18;
            this.labelSexeAdh.Text = "Sexe : ";
            // 
            // labelNaissanceAdh
            // 
            this.labelNaissanceAdh.AutoSize = true;
            this.labelNaissanceAdh.Location = new System.Drawing.Point(19, 273);
            this.labelNaissanceAdh.Name = "labelNaissanceAdh";
            this.labelNaissanceAdh.Size = new System.Drawing.Size(66, 13);
            this.labelNaissanceAdh.TabIndex = 19;
            this.labelNaissanceAdh.Text = "Naissance : ";
            // 
            // labelAdresseAdh
            // 
            this.labelAdresseAdh.AutoSize = true;
            this.labelAdresseAdh.Location = new System.Drawing.Point(385, 132);
            this.labelAdresseAdh.Name = "labelAdresseAdh";
            this.labelAdresseAdh.Size = new System.Drawing.Size(54, 13);
            this.labelAdresseAdh.TabIndex = 20;
            this.labelAdresseAdh.Text = "Adresse : ";
            // 
            // labelCPAdh
            // 
            this.labelCPAdh.AutoSize = true;
            this.labelCPAdh.Location = new System.Drawing.Point(385, 185);
            this.labelCPAdh.Name = "labelCPAdh";
            this.labelCPAdh.Size = new System.Drawing.Size(73, 13);
            this.labelCPAdh.TabIndex = 21;
            this.labelCPAdh.Text = "Code Postal : ";
            // 
            // labelVilleAdh
            // 
            this.labelVilleAdh.AutoSize = true;
            this.labelVilleAdh.Location = new System.Drawing.Point(385, 226);
            this.labelVilleAdh.Name = "labelVilleAdh";
            this.labelVilleAdh.Size = new System.Drawing.Size(35, 13);
            this.labelVilleAdh.TabIndex = 22;
            this.labelVilleAdh.Text = "Ville : ";
            // 
            // labelCotisAdh
            // 
            this.labelCotisAdh.AutoSize = true;
            this.labelCotisAdh.Location = new System.Drawing.Point(385, 269);
            this.labelCotisAdh.Name = "labelCotisAdh";
            this.labelCotisAdh.Size = new System.Drawing.Size(62, 13);
            this.labelCotisAdh.TabIndex = 23;
            this.labelCotisAdh.Text = "Cotisation : ";
            // 
            // labelLicenceAdh
            // 
            this.labelLicenceAdh.AutoSize = true;
            this.labelLicenceAdh.Location = new System.Drawing.Point(471, 33);
            this.labelLicenceAdh.Name = "labelLicenceAdh";
            this.labelLicenceAdh.Size = new System.Drawing.Size(69, 13);
            this.labelLicenceAdh.TabIndex = 24;
            this.labelLicenceAdh.Text = "N° Licence : ";
            // 
            // labelNomClub
            // 
            this.labelNomClub.AutoSize = true;
            this.labelNomClub.Location = new System.Drawing.Point(24, 252);
            this.labelNomClub.Name = "labelNomClub";
            this.labelNomClub.Size = new System.Drawing.Size(35, 13);
            this.labelNomClub.TabIndex = 14;
            this.labelNomClub.Text = "Nom :";
            // 
            // labelAdresseClub
            // 
            this.labelAdresseClub.AutoSize = true;
            this.labelAdresseClub.Location = new System.Drawing.Point(24, 331);
            this.labelAdresseClub.Name = "labelAdresseClub";
            this.labelAdresseClub.Size = new System.Drawing.Size(51, 13);
            this.labelAdresseClub.TabIndex = 15;
            this.labelAdresseClub.Text = "Adresse :";
            // 
            // labelCPClub
            // 
            this.labelCPClub.AutoSize = true;
            this.labelCPClub.Location = new System.Drawing.Point(24, 405);
            this.labelCPClub.Name = "labelCPClub";
            this.labelCPClub.Size = new System.Drawing.Size(70, 13);
            this.labelCPClub.TabIndex = 16;
            this.labelCPClub.Text = "Code Postal :";
            // 
            // labelVilleClub
            // 
            this.labelVilleClub.AutoSize = true;
            this.labelVilleClub.Location = new System.Drawing.Point(373, 185);
            this.labelVilleClub.Name = "labelVilleClub";
            this.labelVilleClub.Size = new System.Drawing.Size(32, 13);
            this.labelVilleClub.TabIndex = 17;
            this.labelVilleClub.Text = "Ville :";
            // 
            // labelTelClub
            // 
            this.labelTelClub.AutoSize = true;
            this.labelTelClub.Location = new System.Drawing.Point(373, 256);
            this.labelTelClub.Name = "labelTelClub";
            this.labelTelClub.Size = new System.Drawing.Size(64, 13);
            this.labelTelClub.TabIndex = 18;
            this.labelTelClub.Text = "Telephone :";
            // 
            // labelMailClub
            // 
            this.labelMailClub.AutoSize = true;
            this.labelMailClub.Location = new System.Drawing.Point(373, 327);
            this.labelMailClub.Name = "labelMailClub";
            this.labelMailClub.Size = new System.Drawing.Size(32, 13);
            this.labelMailClub.TabIndex = 19;
            this.labelMailClub.Text = "Mail :";
            // 
            // labelURLClub
            // 
            this.labelURLClub.AutoSize = true;
            this.labelURLClub.Location = new System.Drawing.Point(373, 398);
            this.labelURLClub.Name = "labelURLClub";
            this.labelURLClub.Size = new System.Drawing.Size(35, 13);
            this.labelURLClub.TabIndex = 20;
            this.labelURLClub.Text = "URL :";
            // 
            // panelConsultEvent
            // 
            this.panelConsultEvent.Controls.Add(this.textBoxSearchEvent);
            this.panelConsultEvent.Controls.Add(this.labelNomClubOnEvent);
            this.panelConsultEvent.Controls.Add(this.buttonNewEvent);
            this.panelConsultEvent.Controls.Add(this.dataGridViewListEvent);
            this.panelConsultEvent.Controls.Add(this.buttonBackToClubFromEvent);
            this.panelConsultEvent.Location = new System.Drawing.Point(0, 0);
            this.panelConsultEvent.Name = "panelConsultEvent";
            this.panelConsultEvent.Size = new System.Drawing.Size(789, 556);
            this.panelConsultEvent.TabIndex = 4;
            // 
            // buttonBackToClubFromEvent
            // 
            this.buttonBackToClubFromEvent.Location = new System.Drawing.Point(18, 23);
            this.buttonBackToClubFromEvent.Name = "buttonBackToClubFromEvent";
            this.buttonBackToClubFromEvent.Size = new System.Drawing.Size(196, 32);
            this.buttonBackToClubFromEvent.TabIndex = 0;
            this.buttonBackToClubFromEvent.Text = "Retour";
            this.buttonBackToClubFromEvent.UseVisualStyleBackColor = true;
            this.buttonBackToClubFromEvent.Click += new System.EventHandler(this.buttonBackToClubFromEvent_Click);
            // 
            // dataGridViewListEvent
            // 
            this.dataGridViewListEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListEvent.Location = new System.Drawing.Point(2, 81);
            this.dataGridViewListEvent.Name = "dataGridViewListEvent";
            this.dataGridViewListEvent.Size = new System.Drawing.Size(785, 374);
            this.dataGridViewListEvent.TabIndex = 1;
            // 
            // buttonNewEvent
            // 
            this.buttonNewEvent.Location = new System.Drawing.Point(286, 483);
            this.buttonNewEvent.Name = "buttonNewEvent";
            this.buttonNewEvent.Size = new System.Drawing.Size(177, 34);
            this.buttonNewEvent.TabIndex = 2;
            this.buttonNewEvent.Text = "Créer un évènement";
            this.buttonNewEvent.UseVisualStyleBackColor = true;
            // 
            // labelNomClubOnEvent
            // 
            this.labelNomClubOnEvent.AutoSize = true;
            this.labelNomClubOnEvent.Location = new System.Drawing.Point(360, 28);
            this.labelNomClubOnEvent.Name = "labelNomClubOnEvent";
            this.labelNomClubOnEvent.Size = new System.Drawing.Size(50, 13);
            this.labelNomClubOnEvent.TabIndex = 3;
            this.labelNomClubOnEvent.Text = "NomClub";
            // 
            // textBoxSearchEvent
            // 
            this.textBoxSearchEvent.Location = new System.Drawing.Point(11, 461);
            this.textBoxSearchEvent.Name = "textBoxSearchEvent";
            this.textBoxSearchEvent.Size = new System.Drawing.Size(230, 20);
            this.textBoxSearchEvent.TabIndex = 4;
            this.textBoxSearchEvent.TextChanged += new System.EventHandler(this.textBoxSearchEvent_TextChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(789, 555);
            this.Controls.Add(this.panelConsultEvent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelModifAdherent);
            this.Controls.Add(this.panelListAdherents);
            this.Name = "FormPrincipal";
            this.Text = "Liste Clubs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listClubs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelListAdherents.ResumeLayout(false);
            this.panelListAdherents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAdherents)).EndInit();
            this.PanelModifAdherent.ResumeLayout(false);
            this.PanelModifAdherent.PerformLayout();
            this.panelConsultEvent.ResumeLayout(false);
            this.panelConsultEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView listClubs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pageClub;
        private System.Windows.Forms.Label idClub;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxModifURLClub;
        private System.Windows.Forms.TextBox textBoxModifMailClub;
        private System.Windows.Forms.TextBox textBoxModifTelClub;
        private System.Windows.Forms.TextBox textBoxModifVilleClub;
        private System.Windows.Forms.TextBox textBoxModifCPClub;
        private System.Windows.Forms.TextBox textBoxModifAdresseClub;
        private System.Windows.Forms.TextBox textBoxModifNameClub;
        private System.Windows.Forms.Button buttonConsultEvent;
        private System.Windows.Forms.Button buttonConsultAdherent;
        private System.Windows.Forms.Button buttonModifClub;
        private System.Windows.Forms.Button ajoutClub;
        private System.Windows.Forms.Button buttonRetourListeClub;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Panel panelListAdherents;
        private System.Windows.Forms.TextBox textBoxRechercheAdherent;
        private System.Windows.Forms.Label labelNomDuClub;
        private System.Windows.Forms.Button buttonAjoutAdherent;
        private System.Windows.Forms.Button buttonRetourClub;
        private System.Windows.Forms.DataGridView dataGridViewListAdherents;
        private System.Windows.Forms.Panel PanelModifAdherent;
        private System.Windows.Forms.Button buttonModifierAdherent;
        private System.Windows.Forms.Button buttonBackToListAdherent;
        private System.Windows.Forms.Label labelNomClubAdhModif;
        private System.Windows.Forms.DateTimePicker dateTimePickerNaissanceAdhModif;
        private System.Windows.Forms.TextBox textBoxCotisationAdhModif;
        private System.Windows.Forms.TextBox textBoxVilleAdhModif;
        private System.Windows.Forms.TextBox textBoxCPAdhModif;
        private System.Windows.Forms.TextBox textBoxAdresseAdhModif;
        private System.Windows.Forms.TextBox textBoxLicenceAdhModif;
        private System.Windows.Forms.TextBox textBoxSexeAdhModif;
        private System.Windows.Forms.TextBox textBoxPrenomAdhModif;
        private System.Windows.Forms.TextBox textBoxNomAdhModif;
        private System.Windows.Forms.Button buttonAdhToEvent;
        private System.Windows.Forms.Label labelIdAdhModif;
        private System.Windows.Forms.Label labelTextIdDeLAdh;
        private System.Windows.Forms.Label labelIdClubAdh;
        private System.Windows.Forms.Label labelLicenceAdh;
        private System.Windows.Forms.Label labelCotisAdh;
        private System.Windows.Forms.Label labelVilleAdh;
        private System.Windows.Forms.Label labelCPAdh;
        private System.Windows.Forms.Label labelAdresseAdh;
        private System.Windows.Forms.Label labelNaissanceAdh;
        private System.Windows.Forms.Label labelSexeAdh;
        private System.Windows.Forms.Label labelPrenomAdh;
        private System.Windows.Forms.Label labelNomAdh;
        private System.Windows.Forms.Label labelURLClub;
        private System.Windows.Forms.Label labelMailClub;
        private System.Windows.Forms.Label labelTelClub;
        private System.Windows.Forms.Label labelVilleClub;
        private System.Windows.Forms.Label labelCPClub;
        private System.Windows.Forms.Label labelAdresseClub;
        private System.Windows.Forms.Label labelNomClub;
        private System.Windows.Forms.Panel panelConsultEvent;
        private System.Windows.Forms.Button buttonNewEvent;
        private System.Windows.Forms.DataGridView dataGridViewListEvent;
        private System.Windows.Forms.Button buttonBackToClubFromEvent;
        private System.Windows.Forms.Label labelNomClubOnEvent;
        private System.Windows.Forms.TextBox textBoxSearchEvent;
    }
}

