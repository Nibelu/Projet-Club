namespace Projet_WinForm
{
    partial class FormSuppression
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
            this.buttonConfirmSuppr = new System.Windows.Forms.Button();
            this.buttonAnnulSuppr = new System.Windows.Forms.Button();
            this.labelConfirmSuppr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConfirmSuppr
            // 
            this.buttonConfirmSuppr.Location = new System.Drawing.Point(56, 190);
            this.buttonConfirmSuppr.Name = "buttonConfirmSuppr";
            this.buttonConfirmSuppr.Size = new System.Drawing.Size(86, 26);
            this.buttonConfirmSuppr.TabIndex = 0;
            this.buttonConfirmSuppr.Text = "Confirmer";
            this.buttonConfirmSuppr.UseVisualStyleBackColor = true;
            this.buttonConfirmSuppr.Click += new System.EventHandler(this.buttonConfirmSuppr_Click);
            // 
            // buttonAnnulSuppr
            // 
            this.buttonAnnulSuppr.Location = new System.Drawing.Point(210, 190);
            this.buttonAnnulSuppr.Name = "buttonAnnulSuppr";
            this.buttonAnnulSuppr.Size = new System.Drawing.Size(86, 26);
            this.buttonAnnulSuppr.TabIndex = 1;
            this.buttonAnnulSuppr.Text = "Annuler";
            this.buttonAnnulSuppr.UseVisualStyleBackColor = true;
            this.buttonAnnulSuppr.Click += new System.EventHandler(this.buttonAnnulSuppr_Click);
            // 
            // labelConfirmSuppr
            // 
            this.labelConfirmSuppr.AutoSize = true;
            this.labelConfirmSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmSuppr.Location = new System.Drawing.Point(53, 67);
            this.labelConfirmSuppr.Name = "labelConfirmSuppr";
            this.labelConfirmSuppr.Size = new System.Drawing.Size(243, 24);
            this.labelConfirmSuppr.TabIndex = 2;
            this.labelConfirmSuppr.Text = "Confirmer la suppression";
            // 
            // FormSuppression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 262);
            this.Controls.Add(this.labelConfirmSuppr);
            this.Controls.Add(this.buttonAnnulSuppr);
            this.Controls.Add(this.buttonConfirmSuppr);
            this.Name = "FormSuppression";
            this.Text = "FormSuppression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmSuppr;
        private System.Windows.Forms.Button buttonAnnulSuppr;
        private System.Windows.Forms.Label labelConfirmSuppr;
    }
}