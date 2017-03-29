namespace Projet_WinForm
{
    partial class ConfirmAjoutEvent
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
            this.labelConfirmAjoutPart = new System.Windows.Forms.Label();
            this.labelInfoEvent = new System.Windows.Forms.Label();
            this.labelInfoAdhOnEvent = new System.Windows.Forms.Label();
            this.labelNomEventConfirm = new System.Windows.Forms.Label();
            this.labelNomAdhConfirm = new System.Windows.Forms.Label();
            this.labelLicenceConfirm = new System.Windows.Forms.Label();
            this.labelDateDebutEventConfirm = new System.Windows.Forms.Label();
            this.labelDateFinConfirm = new System.Windows.Forms.Label();
            this.buttonConfirmAddPart = new System.Windows.Forms.Button();
            this.buttonRefuseAddPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConfirmAjoutPart
            // 
            this.labelConfirmAjoutPart.AutoSize = true;
            this.labelConfirmAjoutPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmAjoutPart.Location = new System.Drawing.Point(11, 21);
            this.labelConfirmAjoutPart.Name = "labelConfirmAjoutPart";
            this.labelConfirmAjoutPart.Size = new System.Drawing.Size(218, 29);
            this.labelConfirmAjoutPart.TabIndex = 0;
            this.labelConfirmAjoutPart.Text = "Confirmer l\'ajout :";
            // 
            // labelInfoEvent
            // 
            this.labelInfoEvent.AutoSize = true;
            this.labelInfoEvent.Location = new System.Drawing.Point(14, 82);
            this.labelInfoEvent.Name = "labelInfoEvent";
            this.labelInfoEvent.Size = new System.Drawing.Size(66, 13);
            this.labelInfoEvent.TabIndex = 1;
            this.labelInfoEvent.Text = "évènement :";
            // 
            // labelInfoAdhOnEvent
            // 
            this.labelInfoAdhOnEvent.AutoSize = true;
            this.labelInfoAdhOnEvent.Location = new System.Drawing.Point(14, 153);
            this.labelInfoAdhOnEvent.Name = "labelInfoAdhOnEvent";
            this.labelInfoAdhOnEvent.Size = new System.Drawing.Size(56, 13);
            this.labelInfoAdhOnEvent.TabIndex = 2;
            this.labelInfoAdhOnEvent.Text = "Adhérent :";
            // 
            // labelNomEventConfirm
            // 
            this.labelNomEventConfirm.AutoSize = true;
            this.labelNomEventConfirm.Location = new System.Drawing.Point(134, 82);
            this.labelNomEventConfirm.Name = "labelNomEventConfirm";
            this.labelNomEventConfirm.Size = new System.Drawing.Size(55, 13);
            this.labelNomEventConfirm.TabIndex = 3;
            this.labelNomEventConfirm.Text = "nomEvent";
            // 
            // labelNomAdhConfirm
            // 
            this.labelNomAdhConfirm.AutoSize = true;
            this.labelNomAdhConfirm.Location = new System.Drawing.Point(134, 153);
            this.labelNomAdhConfirm.Name = "labelNomAdhConfirm";
            this.labelNomAdhConfirm.Size = new System.Drawing.Size(48, 13);
            this.labelNomAdhConfirm.TabIndex = 4;
            this.labelNomAdhConfirm.Text = "NomAdh";
            // 
            // labelLicenceConfirm
            // 
            this.labelLicenceConfirm.AutoSize = true;
            this.labelLicenceConfirm.Location = new System.Drawing.Point(290, 153);
            this.labelLicenceConfirm.Name = "labelLicenceConfirm";
            this.labelLicenceConfirm.Size = new System.Drawing.Size(41, 13);
            this.labelLicenceConfirm.TabIndex = 5;
            this.labelLicenceConfirm.Text = "licence";
            // 
            // labelDateDebutEventConfirm
            // 
            this.labelDateDebutEventConfirm.AutoSize = true;
            this.labelDateDebutEventConfirm.Location = new System.Drawing.Point(290, 82);
            this.labelDateDebutEventConfirm.Name = "labelDateDebutEventConfirm";
            this.labelDateDebutEventConfirm.Size = new System.Drawing.Size(57, 13);
            this.labelDateDebutEventConfirm.TabIndex = 6;
            this.labelDateDebutEventConfirm.Text = "dateDebut";
            // 
            // labelDateFinConfirm
            // 
            this.labelDateFinConfirm.AutoSize = true;
            this.labelDateFinConfirm.Location = new System.Drawing.Point(468, 82);
            this.labelDateFinConfirm.Name = "labelDateFinConfirm";
            this.labelDateFinConfirm.Size = new System.Drawing.Size(42, 13);
            this.labelDateFinConfirm.TabIndex = 7;
            this.labelDateFinConfirm.Text = "dateFin";
            // 
            // buttonConfirmAddPart
            // 
            this.buttonConfirmAddPart.Location = new System.Drawing.Point(152, 204);
            this.buttonConfirmAddPart.Name = "buttonConfirmAddPart";
            this.buttonConfirmAddPart.Size = new System.Drawing.Size(77, 25);
            this.buttonConfirmAddPart.TabIndex = 8;
            this.buttonConfirmAddPart.Text = "Confirmer";
            this.buttonConfirmAddPart.UseVisualStyleBackColor = true;
            this.buttonConfirmAddPart.Click += new System.EventHandler(this.buttonConfirmAddPart_Click);
            // 
            // buttonRefuseAddPart
            // 
            this.buttonRefuseAddPart.Location = new System.Drawing.Point(270, 204);
            this.buttonRefuseAddPart.Name = "buttonRefuseAddPart";
            this.buttonRefuseAddPart.Size = new System.Drawing.Size(77, 25);
            this.buttonRefuseAddPart.TabIndex = 9;
            this.buttonRefuseAddPart.Text = "Retour";
            this.buttonRefuseAddPart.UseVisualStyleBackColor = true;
            this.buttonRefuseAddPart.Click += new System.EventHandler(this.buttonRefuseAddPart_Click);
            // 
            // ConfirmAjoutEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 255);
            this.Controls.Add(this.buttonRefuseAddPart);
            this.Controls.Add(this.buttonConfirmAddPart);
            this.Controls.Add(this.labelDateFinConfirm);
            this.Controls.Add(this.labelDateDebutEventConfirm);
            this.Controls.Add(this.labelLicenceConfirm);
            this.Controls.Add(this.labelNomAdhConfirm);
            this.Controls.Add(this.labelNomEventConfirm);
            this.Controls.Add(this.labelInfoAdhOnEvent);
            this.Controls.Add(this.labelInfoEvent);
            this.Controls.Add(this.labelConfirmAjoutPart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfirmAjoutEvent";
            this.Text = "ConfirmAjoutEvent";
            this.VisibleChanged += new System.EventHandler(this.ConfirmAjoutEvent_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConfirmAjoutPart;
        private System.Windows.Forms.Label labelInfoEvent;
        private System.Windows.Forms.Label labelInfoAdhOnEvent;
        private System.Windows.Forms.Label labelNomEventConfirm;
        private System.Windows.Forms.Label labelNomAdhConfirm;
        private System.Windows.Forms.Label labelLicenceConfirm;
        private System.Windows.Forms.Label labelDateDebutEventConfirm;
        private System.Windows.Forms.Label labelDateFinConfirm;
        private System.Windows.Forms.Button buttonConfirmAddPart;
        private System.Windows.Forms.Button buttonRefuseAddPart;
    }
}