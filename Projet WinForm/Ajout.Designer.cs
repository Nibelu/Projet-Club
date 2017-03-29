namespace Projet_WinForm
{
    partial class Ajout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAjoutClub = new System.Windows.Forms.Panel();
            this.buttonCreerClub = new System.Windows.Forms.Button();
            this.nomModal = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxtelephone = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.panelCreerAdherent = new System.Windows.Forms.Panel();
            this.labelNewAdherentNomClub = new System.Windows.Forms.Label();
            this.dateTimePickerNewNaissanceAdherent = new System.Windows.Forms.DateTimePicker();
            this.textBoxNewLicenceAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewCotisationAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewVilleAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewCPAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewAdressAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewSexAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewPrenomAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewNomAdherent = new System.Windows.Forms.TextBox();
            this.buttonCreerAdherent = new System.Windows.Forms.Button();
            this.labelNomClubNewAdherent = new System.Windows.Forms.Label();
            this.panelAjoutEvent = new System.Windows.Forms.Panel();
            this.labelTypeAjoutEvent = new System.Windows.Forms.Label();
            this.labelNomClubAjoutEvent = new System.Windows.Forms.Label();
            this.textBoxNewNomEvent = new System.Windows.Forms.TextBox();
            this.textBoxNewAdresseEvent = new System.Windows.Forms.TextBox();
            this.textBoxNewCPEvent = new System.Windows.Forms.TextBox();
            this.textBoxNewVilleEvent = new System.Windows.Forms.TextBox();
            this.textBoxNewTypeEvent = new System.Windows.Forms.TextBox();
            this.textBoxNewStieEvent = new System.Windows.Forms.TextBox();
            this.labelAjoutNomEvent = new System.Windows.Forms.Label();
            this.labelAjoutLieuEvent = new System.Windows.Forms.Label();
            this.labelAjoutCPEvent = new System.Windows.Forms.Label();
            this.labelAjoutVilleEvent = new System.Windows.Forms.Label();
            this.labelAjoutTypeEvent = new System.Windows.Forms.Label();
            this.labelAjoutDateDebutEvent = new System.Windows.Forms.Label();
            this.labelAjoutDateFinEvent = new System.Windows.Forms.Label();
            this.labelAjoutSiteEvent = new System.Windows.Forms.Label();
            this.buttonCreateEvent = new System.Windows.Forms.Button();
            this.dateTimePickerNewDebutEvent = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNewFinEvent = new System.Windows.Forms.DateTimePicker();
            this.panelAjoutClub.SuspendLayout();
            this.panelCreerAdherent.SuspendLayout();
            this.panelAjoutEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAjoutClub
            // 
            this.panelAjoutClub.Controls.Add(this.buttonCreerClub);
            this.panelAjoutClub.Controls.Add(this.nomModal);
            this.panelAjoutClub.Controls.Add(this.textBoxAdresse);
            this.panelAjoutClub.Controls.Add(this.textBoxCP);
            this.panelAjoutClub.Controls.Add(this.textBoxtelephone);
            this.panelAjoutClub.Controls.Add(this.textBoxMail);
            this.panelAjoutClub.Controls.Add(this.textBoxSite);
            this.panelAjoutClub.Controls.Add(this.textBoxVille);
            this.panelAjoutClub.Controls.Add(this.textBoxNom);
            this.panelAjoutClub.Location = new System.Drawing.Point(2, 1);
            this.panelAjoutClub.Name = "panelAjoutClub";
            this.panelAjoutClub.Size = new System.Drawing.Size(674, 260);
            this.panelAjoutClub.TabIndex = 19;
            // 
            // buttonCreerClub
            // 
            this.buttonCreerClub.Location = new System.Drawing.Point(421, 201);
            this.buttonCreerClub.Name = "buttonCreerClub";
            this.buttonCreerClub.Size = new System.Drawing.Size(201, 23);
            this.buttonCreerClub.TabIndex = 17;
            this.buttonCreerClub.Text = "Créer";
            this.buttonCreerClub.UseVisualStyleBackColor = true;
            this.buttonCreerClub.Click += new System.EventHandler(this.buttonCreerClub_Click);
            // 
            // nomModal
            // 
            this.nomModal.AutoSize = true;
            this.nomModal.Location = new System.Drawing.Point(253, 36);
            this.nomModal.Name = "nomModal";
            this.nomModal.Size = new System.Drawing.Size(35, 13);
            this.nomModal.TabIndex = 16;
            this.nomModal.Text = "label1";
            this.nomModal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(49, 119);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(201, 20);
            this.textBoxAdresse.TabIndex = 15;
            this.textBoxAdresse.Text = "Adresse du club";
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(49, 162);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(201, 20);
            this.textBoxCP.TabIndex = 14;
            this.textBoxCP.Text = "Code Postal ";
            // 
            // textBoxtelephone
            // 
            this.textBoxtelephone.Location = new System.Drawing.Point(421, 80);
            this.textBoxtelephone.Name = "textBoxtelephone";
            this.textBoxtelephone.Size = new System.Drawing.Size(201, 20);
            this.textBoxtelephone.TabIndex = 13;
            this.textBoxtelephone.Text = "N°";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(421, 119);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(201, 20);
            this.textBoxMail.TabIndex = 12;
            this.textBoxMail.Text = "email";
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(421, 162);
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(201, 20);
            this.textBoxSite.TabIndex = 11;
            this.textBoxSite.Text = "URL";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(49, 201);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(201, 20);
            this.textBoxVille.TabIndex = 10;
            this.textBoxVille.Text = "Ville ";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(49, 80);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(201, 20);
            this.textBoxNom.TabIndex = 9;
            this.textBoxNom.Text = "Nom du club";
            // 
            // panelCreerAdherent
            // 
            this.panelCreerAdherent.Controls.Add(this.labelNewAdherentNomClub);
            this.panelCreerAdherent.Controls.Add(this.dateTimePickerNewNaissanceAdherent);
            this.panelCreerAdherent.Controls.Add(this.textBoxNewLicenceAdherent);
            this.panelCreerAdherent.Controls.Add(this.textBoxNewCotisationAdherent);
            this.panelCreerAdherent.Controls.Add(this.textBoxNewVilleAdherent);
            this.panelCreerAdherent.Controls.Add(this.textBoxNewCPAdherent);
            this.panelCreerAdherent.Controls.Add(this.textBoxNewAdressAdherent);
            this.panelCreerAdherent.Controls.Add(this.textBoxNewSexAdherent);
            this.panelCreerAdherent.Controls.Add(this.textBoxNewPrenomAdherent);
            this.panelCreerAdherent.Controls.Add(this.textBoxNewNomAdherent);
            this.panelCreerAdherent.Controls.Add(this.buttonCreerAdherent);
            this.panelCreerAdherent.Controls.Add(this.labelNomClubNewAdherent);
            this.panelCreerAdherent.Location = new System.Drawing.Point(2, 1);
            this.panelCreerAdherent.Name = "panelCreerAdherent";
            this.panelCreerAdherent.Size = new System.Drawing.Size(674, 260);
            this.panelCreerAdherent.TabIndex = 20;
            // 
            // labelNewAdherentNomClub
            // 
            this.labelNewAdherentNomClub.AutoSize = true;
            this.labelNewAdherentNomClub.Location = new System.Drawing.Point(241, 21);
            this.labelNewAdherentNomClub.Name = "labelNewAdherentNomClub";
            this.labelNewAdherentNomClub.Size = new System.Drawing.Size(35, 13);
            this.labelNewAdherentNomClub.TabIndex = 29;
            this.labelNewAdherentNomClub.Text = "label1";
            this.labelNewAdherentNomClub.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePickerNewNaissanceAdherent
            // 
            this.dateTimePickerNewNaissanceAdherent.Location = new System.Drawing.Point(21, 145);
            this.dateTimePickerNewNaissanceAdherent.Name = "dateTimePickerNewNaissanceAdherent";
            this.dateTimePickerNewNaissanceAdherent.Size = new System.Drawing.Size(217, 20);
            this.dateTimePickerNewNaissanceAdherent.TabIndex = 28;
            // 
            // textBoxNewLicenceAdherent
            // 
            this.textBoxNewLicenceAdherent.Location = new System.Drawing.Point(421, 18);
            this.textBoxNewLicenceAdherent.Name = "textBoxNewLicenceAdherent";
            this.textBoxNewLicenceAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewLicenceAdherent.TabIndex = 27;
            this.textBoxNewLicenceAdherent.Text = "N° de licence";
            // 
            // textBoxNewCotisationAdherent
            // 
            this.textBoxNewCotisationAdherent.Location = new System.Drawing.Point(421, 188);
            this.textBoxNewCotisationAdherent.Name = "textBoxNewCotisationAdherent";
            this.textBoxNewCotisationAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewCotisationAdherent.TabIndex = 26;
            this.textBoxNewCotisationAdherent.Text = "Montant de la cotisation";
            // 
            // textBoxNewVilleAdherent
            // 
            this.textBoxNewVilleAdherent.Location = new System.Drawing.Point(421, 145);
            this.textBoxNewVilleAdherent.Name = "textBoxNewVilleAdherent";
            this.textBoxNewVilleAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewVilleAdherent.TabIndex = 25;
            this.textBoxNewVilleAdherent.Text = "Ville";
            // 
            // textBoxNewCPAdherent
            // 
            this.textBoxNewCPAdherent.Location = new System.Drawing.Point(421, 106);
            this.textBoxNewCPAdherent.Name = "textBoxNewCPAdherent";
            this.textBoxNewCPAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewCPAdherent.TabIndex = 24;
            this.textBoxNewCPAdherent.Text = "Code Postal";
            // 
            // textBoxNewAdressAdherent
            // 
            this.textBoxNewAdressAdherent.Location = new System.Drawing.Point(421, 74);
            this.textBoxNewAdressAdherent.Name = "textBoxNewAdressAdherent";
            this.textBoxNewAdressAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewAdressAdherent.TabIndex = 23;
            this.textBoxNewAdressAdherent.Text = "Adresse de l\'adhérent";
            // 
            // textBoxNewSexAdherent
            // 
            this.textBoxNewSexAdherent.Location = new System.Drawing.Point(21, 188);
            this.textBoxNewSexAdherent.Name = "textBoxNewSexAdherent";
            this.textBoxNewSexAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewSexAdherent.TabIndex = 22;
            this.textBoxNewSexAdherent.Text = "Sexe";
            // 
            // textBoxNewPrenomAdherent
            // 
            this.textBoxNewPrenomAdherent.Location = new System.Drawing.Point(21, 106);
            this.textBoxNewPrenomAdherent.Name = "textBoxNewPrenomAdherent";
            this.textBoxNewPrenomAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewPrenomAdherent.TabIndex = 20;
            this.textBoxNewPrenomAdherent.Text = "Prénom de l\'adhérent";
            // 
            // textBoxNewNomAdherent
            // 
            this.textBoxNewNomAdherent.Location = new System.Drawing.Point(21, 74);
            this.textBoxNewNomAdherent.Name = "textBoxNewNomAdherent";
            this.textBoxNewNomAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewNomAdherent.TabIndex = 19;
            this.textBoxNewNomAdherent.Text = "Nom de l\'adhérent";
            // 
            // buttonCreerAdherent
            // 
            this.buttonCreerAdherent.Location = new System.Drawing.Point(253, 213);
            this.buttonCreerAdherent.Name = "buttonCreerAdherent";
            this.buttonCreerAdherent.Size = new System.Drawing.Size(145, 30);
            this.buttonCreerAdherent.TabIndex = 18;
            this.buttonCreerAdherent.Text = "Créer";
            this.buttonCreerAdherent.UseVisualStyleBackColor = true;
            this.buttonCreerAdherent.Click += new System.EventHandler(this.buttonCreerAdherent_Click);
            // 
            // labelNomClubNewAdherent
            // 
            this.labelNomClubNewAdherent.AutoSize = true;
            this.labelNomClubNewAdherent.Location = new System.Drawing.Point(18, 18);
            this.labelNomClubNewAdherent.Name = "labelNomClubNewAdherent";
            this.labelNomClubNewAdherent.Size = new System.Drawing.Size(35, 13);
            this.labelNomClubNewAdherent.TabIndex = 17;
            this.labelNomClubNewAdherent.Text = "label1";
            this.labelNomClubNewAdherent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelAjoutEvent
            // 
            this.panelAjoutEvent.Controls.Add(this.dateTimePickerNewFinEvent);
            this.panelAjoutEvent.Controls.Add(this.dateTimePickerNewDebutEvent);
            this.panelAjoutEvent.Controls.Add(this.buttonCreateEvent);
            this.panelAjoutEvent.Controls.Add(this.labelAjoutSiteEvent);
            this.panelAjoutEvent.Controls.Add(this.labelAjoutDateFinEvent);
            this.panelAjoutEvent.Controls.Add(this.labelAjoutDateDebutEvent);
            this.panelAjoutEvent.Controls.Add(this.labelAjoutTypeEvent);
            this.panelAjoutEvent.Controls.Add(this.labelAjoutVilleEvent);
            this.panelAjoutEvent.Controls.Add(this.labelAjoutCPEvent);
            this.panelAjoutEvent.Controls.Add(this.labelAjoutLieuEvent);
            this.panelAjoutEvent.Controls.Add(this.labelAjoutNomEvent);
            this.panelAjoutEvent.Controls.Add(this.textBoxNewStieEvent);
            this.panelAjoutEvent.Controls.Add(this.textBoxNewTypeEvent);
            this.panelAjoutEvent.Controls.Add(this.textBoxNewVilleEvent);
            this.panelAjoutEvent.Controls.Add(this.textBoxNewCPEvent);
            this.panelAjoutEvent.Controls.Add(this.textBoxNewAdresseEvent);
            this.panelAjoutEvent.Controls.Add(this.textBoxNewNomEvent);
            this.panelAjoutEvent.Controls.Add(this.labelNomClubAjoutEvent);
            this.panelAjoutEvent.Controls.Add(this.labelTypeAjoutEvent);
            this.panelAjoutEvent.Location = new System.Drawing.Point(3, 1);
            this.panelAjoutEvent.Name = "panelAjoutEvent";
            this.panelAjoutEvent.Size = new System.Drawing.Size(673, 261);
            this.panelAjoutEvent.TabIndex = 21;
            // 
            // labelTypeAjoutEvent
            // 
            this.labelTypeAjoutEvent.AutoSize = true;
            this.labelTypeAjoutEvent.Location = new System.Drawing.Point(26, 28);
            this.labelTypeAjoutEvent.Name = "labelTypeAjoutEvent";
            this.labelTypeAjoutEvent.Size = new System.Drawing.Size(35, 13);
            this.labelTypeAjoutEvent.TabIndex = 0;
            this.labelTypeAjoutEvent.Text = "label1";
            // 
            // labelNomClubAjoutEvent
            // 
            this.labelNomClubAjoutEvent.AutoSize = true;
            this.labelNomClubAjoutEvent.Location = new System.Drawing.Point(340, 28);
            this.labelNomClubAjoutEvent.Name = "labelNomClubAjoutEvent";
            this.labelNomClubAjoutEvent.Size = new System.Drawing.Size(35, 13);
            this.labelNomClubAjoutEvent.TabIndex = 1;
            this.labelNomClubAjoutEvent.Text = "label1";
            // 
            // textBoxNewNomEvent
            // 
            this.textBoxNewNomEvent.Location = new System.Drawing.Point(104, 65);
            this.textBoxNewNomEvent.Name = "textBoxNewNomEvent";
            this.textBoxNewNomEvent.Size = new System.Drawing.Size(183, 20);
            this.textBoxNewNomEvent.TabIndex = 2;
            // 
            // textBoxNewAdresseEvent
            // 
            this.textBoxNewAdresseEvent.Location = new System.Drawing.Point(104, 106);
            this.textBoxNewAdresseEvent.Name = "textBoxNewAdresseEvent";
            this.textBoxNewAdresseEvent.Size = new System.Drawing.Size(183, 20);
            this.textBoxNewAdresseEvent.TabIndex = 3;
            // 
            // textBoxNewCPEvent
            // 
            this.textBoxNewCPEvent.Location = new System.Drawing.Point(104, 148);
            this.textBoxNewCPEvent.Name = "textBoxNewCPEvent";
            this.textBoxNewCPEvent.Size = new System.Drawing.Size(183, 20);
            this.textBoxNewCPEvent.TabIndex = 4;
            // 
            // textBoxNewVilleEvent
            // 
            this.textBoxNewVilleEvent.Location = new System.Drawing.Point(104, 188);
            this.textBoxNewVilleEvent.Name = "textBoxNewVilleEvent";
            this.textBoxNewVilleEvent.Size = new System.Drawing.Size(183, 20);
            this.textBoxNewVilleEvent.TabIndex = 5;
            // 
            // textBoxNewTypeEvent
            // 
            this.textBoxNewTypeEvent.Location = new System.Drawing.Point(464, 65);
            this.textBoxNewTypeEvent.Name = "textBoxNewTypeEvent";
            this.textBoxNewTypeEvent.Size = new System.Drawing.Size(183, 20);
            this.textBoxNewTypeEvent.TabIndex = 6;
            // 
            // textBoxNewStieEvent
            // 
            this.textBoxNewStieEvent.Location = new System.Drawing.Point(464, 188);
            this.textBoxNewStieEvent.Name = "textBoxNewStieEvent";
            this.textBoxNewStieEvent.Size = new System.Drawing.Size(183, 20);
            this.textBoxNewStieEvent.TabIndex = 9;
            // 
            // labelAjoutNomEvent
            // 
            this.labelAjoutNomEvent.AutoSize = true;
            this.labelAjoutNomEvent.Location = new System.Drawing.Point(26, 72);
            this.labelAjoutNomEvent.Name = "labelAjoutNomEvent";
            this.labelAjoutNomEvent.Size = new System.Drawing.Size(35, 13);
            this.labelAjoutNomEvent.TabIndex = 11;
            this.labelAjoutNomEvent.Text = "Nom :";
            // 
            // labelAjoutLieuEvent
            // 
            this.labelAjoutLieuEvent.AutoSize = true;
            this.labelAjoutLieuEvent.Location = new System.Drawing.Point(26, 113);
            this.labelAjoutLieuEvent.Name = "labelAjoutLieuEvent";
            this.labelAjoutLieuEvent.Size = new System.Drawing.Size(33, 13);
            this.labelAjoutLieuEvent.TabIndex = 12;
            this.labelAjoutLieuEvent.Text = "Lieu :";
            // 
            // labelAjoutCPEvent
            // 
            this.labelAjoutCPEvent.AutoSize = true;
            this.labelAjoutCPEvent.Location = new System.Drawing.Point(26, 155);
            this.labelAjoutCPEvent.Name = "labelAjoutCPEvent";
            this.labelAjoutCPEvent.Size = new System.Drawing.Size(70, 13);
            this.labelAjoutCPEvent.TabIndex = 13;
            this.labelAjoutCPEvent.Text = "Code Postal :";
            // 
            // labelAjoutVilleEvent
            // 
            this.labelAjoutVilleEvent.AutoSize = true;
            this.labelAjoutVilleEvent.Location = new System.Drawing.Point(26, 195);
            this.labelAjoutVilleEvent.Name = "labelAjoutVilleEvent";
            this.labelAjoutVilleEvent.Size = new System.Drawing.Size(32, 13);
            this.labelAjoutVilleEvent.TabIndex = 14;
            this.labelAjoutVilleEvent.Text = "Ville :";
            // 
            // labelAjoutTypeEvent
            // 
            this.labelAjoutTypeEvent.AutoSize = true;
            this.labelAjoutTypeEvent.Location = new System.Drawing.Point(357, 68);
            this.labelAjoutTypeEvent.Name = "labelAjoutTypeEvent";
            this.labelAjoutTypeEvent.Size = new System.Drawing.Size(101, 13);
            this.labelAjoutTypeEvent.TabIndex = 15;
            this.labelAjoutTypeEvent.Text = "Type d\'évènement :";
            // 
            // labelAjoutDateDebutEvent
            // 
            this.labelAjoutDateDebutEvent.AutoSize = true;
            this.labelAjoutDateDebutEvent.Location = new System.Drawing.Point(357, 106);
            this.labelAjoutDateDebutEvent.Name = "labelAjoutDateDebutEvent";
            this.labelAjoutDateDebutEvent.Size = new System.Drawing.Size(42, 13);
            this.labelAjoutDateDebutEvent.TabIndex = 16;
            this.labelAjoutDateDebutEvent.Text = "Début :";
            // 
            // labelAjoutDateFinEvent
            // 
            this.labelAjoutDateFinEvent.AutoSize = true;
            this.labelAjoutDateFinEvent.Location = new System.Drawing.Point(357, 152);
            this.labelAjoutDateFinEvent.Name = "labelAjoutDateFinEvent";
            this.labelAjoutDateFinEvent.Size = new System.Drawing.Size(27, 13);
            this.labelAjoutDateFinEvent.TabIndex = 17;
            this.labelAjoutDateFinEvent.Text = "Fin :";
            // 
            // labelAjoutSiteEvent
            // 
            this.labelAjoutSiteEvent.AutoSize = true;
            this.labelAjoutSiteEvent.Location = new System.Drawing.Point(357, 195);
            this.labelAjoutSiteEvent.Name = "labelAjoutSiteEvent";
            this.labelAjoutSiteEvent.Size = new System.Drawing.Size(35, 13);
            this.labelAjoutSiteEvent.TabIndex = 18;
            this.labelAjoutSiteEvent.Text = "URL :";
            // 
            // buttonCreateEvent
            // 
            this.buttonCreateEvent.Location = new System.Drawing.Point(291, 220);
            this.buttonCreateEvent.Name = "buttonCreateEvent";
            this.buttonCreateEvent.Size = new System.Drawing.Size(149, 29);
            this.buttonCreateEvent.TabIndex = 19;
            this.buttonCreateEvent.Text = "Créer";
            this.buttonCreateEvent.UseVisualStyleBackColor = true;
            this.buttonCreateEvent.Click += new System.EventHandler(this.buttonCreateEvent_Click);
            // 
            // dateTimePickerNewDebutEvent
            // 
            this.dateTimePickerNewDebutEvent.Location = new System.Drawing.Point(464, 99);
            this.dateTimePickerNewDebutEvent.Name = "dateTimePickerNewDebutEvent";
            this.dateTimePickerNewDebutEvent.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerNewDebutEvent.TabIndex = 20;
            // 
            // dateTimePickerNewFinEvent
            // 
            this.dateTimePickerNewFinEvent.Location = new System.Drawing.Point(464, 145);
            this.dateTimePickerNewFinEvent.Name = "dateTimePickerNewFinEvent";
            this.dateTimePickerNewFinEvent.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerNewFinEvent.TabIndex = 21;
            // 
            // Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 262);
            this.Controls.Add(this.panelAjoutEvent);
            this.Controls.Add(this.panelAjoutClub);
            this.Controls.Add(this.panelCreerAdherent);
            this.Name = "Ajout";
            this.Text = "Ajout";
            this.Load += new System.EventHandler(this.Ajout_Load);
            this.panelAjoutClub.ResumeLayout(false);
            this.panelAjoutClub.PerformLayout();
            this.panelCreerAdherent.ResumeLayout(false);
            this.panelCreerAdherent.PerformLayout();
            this.panelAjoutEvent.ResumeLayout(false);
            this.panelAjoutEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAjoutClub;
        private System.Windows.Forms.Button buttonCreerClub;
        private System.Windows.Forms.Label nomModal;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxtelephone;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Panel panelCreerAdherent;
        private System.Windows.Forms.Button buttonCreerAdherent;
        private System.Windows.Forms.Label labelNomClubNewAdherent;
        private System.Windows.Forms.TextBox textBoxNewNomAdherent;
        private System.Windows.Forms.TextBox textBoxNewLicenceAdherent;
        private System.Windows.Forms.TextBox textBoxNewCotisationAdherent;
        private System.Windows.Forms.TextBox textBoxNewVilleAdherent;
        private System.Windows.Forms.TextBox textBoxNewCPAdherent;
        private System.Windows.Forms.TextBox textBoxNewAdressAdherent;
        private System.Windows.Forms.TextBox textBoxNewSexAdherent;
        private System.Windows.Forms.TextBox textBoxNewPrenomAdherent;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewNaissanceAdherent;
        private System.Windows.Forms.Label labelNewAdherentNomClub;
        private System.Windows.Forms.Panel panelAjoutEvent;
        private System.Windows.Forms.Label labelTypeAjoutEvent;
        private System.Windows.Forms.Button buttonCreateEvent;
        private System.Windows.Forms.Label labelAjoutSiteEvent;
        private System.Windows.Forms.Label labelAjoutDateFinEvent;
        private System.Windows.Forms.Label labelAjoutDateDebutEvent;
        private System.Windows.Forms.Label labelAjoutTypeEvent;
        private System.Windows.Forms.Label labelAjoutVilleEvent;
        private System.Windows.Forms.Label labelAjoutCPEvent;
        private System.Windows.Forms.Label labelAjoutLieuEvent;
        private System.Windows.Forms.Label labelAjoutNomEvent;
        private System.Windows.Forms.TextBox textBoxNewStieEvent;
        private System.Windows.Forms.TextBox textBoxNewTypeEvent;
        private System.Windows.Forms.TextBox textBoxNewVilleEvent;
        private System.Windows.Forms.TextBox textBoxNewCPEvent;
        private System.Windows.Forms.TextBox textBoxNewAdresseEvent;
        private System.Windows.Forms.TextBox textBoxNewNomEvent;
        private System.Windows.Forms.Label labelNomClubAjoutEvent;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewFinEvent;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewDebutEvent;
    }
}