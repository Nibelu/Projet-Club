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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxtelephone = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.nomModal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(44, 65);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(201, 20);
            this.textBoxNom.TabIndex = 0;
            this.textBoxNom.Text = "Nom du club";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(44, 186);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(201, 20);
            this.textBoxVille.TabIndex = 1;
            this.textBoxVille.Text = "Ville ";
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(416, 147);
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(201, 20);
            this.textBoxSite.TabIndex = 2;
            this.textBoxSite.Text = "URL";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(416, 104);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(201, 20);
            this.textBoxMail.TabIndex = 3;
            this.textBoxMail.Text = "email";
            // 
            // textBoxtelephone
            // 
            this.textBoxtelephone.Location = new System.Drawing.Point(416, 65);
            this.textBoxtelephone.Name = "textBoxtelephone";
            this.textBoxtelephone.Size = new System.Drawing.Size(201, 20);
            this.textBoxtelephone.TabIndex = 4;
            this.textBoxtelephone.Text = "N°";
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(44, 147);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(201, 20);
            this.textBoxCP.TabIndex = 5;
            this.textBoxCP.Text = "Code Postal ";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(44, 104);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(201, 20);
            this.textBoxAdresse.TabIndex = 6;
            this.textBoxAdresse.Text = "Adresse du club";
            // 
            // nomModal
            // 
            this.nomModal.AutoSize = true;
            this.nomModal.Location = new System.Drawing.Point(248, 21);
            this.nomModal.Name = "nomModal";
            this.nomModal.Size = new System.Drawing.Size(35, 13);
            this.nomModal.TabIndex = 7;
            this.nomModal.Text = "label1";
            this.nomModal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Créer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nomModal);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxtelephone);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxSite);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxNom);
            this.Name = "Ajout";
            this.Text = "Ajout";
            this.Load += new System.EventHandler(this.Ajout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxtelephone;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label nomModal;
        private System.Windows.Forms.Button button1;
    }
}