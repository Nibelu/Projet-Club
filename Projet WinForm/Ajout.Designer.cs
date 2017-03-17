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
            this.labelNomClubNewAdherent = new System.Windows.Forms.Label();
            this.buttonCreerAdherent = new System.Windows.Forms.Button();
            this.textBoxNewNomAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewPrenomAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewSexAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewAdressAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewCPAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewVilleAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewCotisationAdherent = new System.Windows.Forms.TextBox();
            this.textBoxNewLicenceAdherent = new System.Windows.Forms.TextBox();
            this.dateTimePickerNewNaissanceAdherent = new System.Windows.Forms.DateTimePicker();
            this.labelNewAdherentNomClub = new System.Windows.Forms.Label();
            this.panelAjoutClub.SuspendLayout();
            this.panelCreerAdherent.SuspendLayout();
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
            // textBoxNewNomAdherent
            // 
            this.textBoxNewNomAdherent.Location = new System.Drawing.Point(21, 74);
            this.textBoxNewNomAdherent.Name = "textBoxNewNomAdherent";
            this.textBoxNewNomAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewNomAdherent.TabIndex = 19;
            this.textBoxNewNomAdherent.Text = "Nom de l\'adhérent";
            // 
            // textBoxNewPrenomAdherent
            // 
            this.textBoxNewPrenomAdherent.Location = new System.Drawing.Point(21, 106);
            this.textBoxNewPrenomAdherent.Name = "textBoxNewPrenomAdherent";
            this.textBoxNewPrenomAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewPrenomAdherent.TabIndex = 20;
            this.textBoxNewPrenomAdherent.Text = "Prénom de l\'adhérent";
            // 
            // textBoxNewSexAdherent
            // 
            this.textBoxNewSexAdherent.Location = new System.Drawing.Point(21, 188);
            this.textBoxNewSexAdherent.Name = "textBoxNewSexAdherent";
            this.textBoxNewSexAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewSexAdherent.TabIndex = 22;
            this.textBoxNewSexAdherent.Text = "Sexe";
            // 
            // textBoxNewAdressAdherent
            // 
            this.textBoxNewAdressAdherent.Location = new System.Drawing.Point(421, 74);
            this.textBoxNewAdressAdherent.Name = "textBoxNewAdressAdherent";
            this.textBoxNewAdressAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewAdressAdherent.TabIndex = 23;
            this.textBoxNewAdressAdherent.Text = "Adresse de l\'adhérent";
            // 
            // textBoxNewCPAdherent
            // 
            this.textBoxNewCPAdherent.Location = new System.Drawing.Point(421, 106);
            this.textBoxNewCPAdherent.Name = "textBoxNewCPAdherent";
            this.textBoxNewCPAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewCPAdherent.TabIndex = 24;
            this.textBoxNewCPAdherent.Text = "Code Postal";
            // 
            // textBoxNewVilleAdherent
            // 
            this.textBoxNewVilleAdherent.Location = new System.Drawing.Point(421, 145);
            this.textBoxNewVilleAdherent.Name = "textBoxNewVilleAdherent";
            this.textBoxNewVilleAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewVilleAdherent.TabIndex = 25;
            this.textBoxNewVilleAdherent.Text = "Ville";
            // 
            // textBoxNewCotisationAdherent
            // 
            this.textBoxNewCotisationAdherent.Location = new System.Drawing.Point(421, 188);
            this.textBoxNewCotisationAdherent.Name = "textBoxNewCotisationAdherent";
            this.textBoxNewCotisationAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewCotisationAdherent.TabIndex = 26;
            this.textBoxNewCotisationAdherent.Text = "Montant de la cotisation";
            // 
            // textBoxNewLicenceAdherent
            // 
            this.textBoxNewLicenceAdherent.Location = new System.Drawing.Point(421, 18);
            this.textBoxNewLicenceAdherent.Name = "textBoxNewLicenceAdherent";
            this.textBoxNewLicenceAdherent.Size = new System.Drawing.Size(217, 20);
            this.textBoxNewLicenceAdherent.TabIndex = 27;
            this.textBoxNewLicenceAdherent.Text = "N° de licence";
            // 
            // dateTimePickerNewNaissanceAdherent
            // 
            this.dateTimePickerNewNaissanceAdherent.Location = new System.Drawing.Point(21, 145);
            this.dateTimePickerNewNaissanceAdherent.Name = "dateTimePickerNewNaissanceAdherent";
            this.dateTimePickerNewNaissanceAdherent.Size = new System.Drawing.Size(217, 20);
            this.dateTimePickerNewNaissanceAdherent.TabIndex = 28;
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
            // Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 262);
            this.Controls.Add(this.panelCreerAdherent);
            this.Controls.Add(this.panelAjoutClub);
            this.Name = "Ajout";
            this.Text = "Ajout";
            this.Load += new System.EventHandler(this.Ajout_Load);
            this.panelAjoutClub.ResumeLayout(false);
            this.panelAjoutClub.PerformLayout();
            this.panelCreerAdherent.ResumeLayout(false);
            this.panelCreerAdherent.PerformLayout();
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
    }
}