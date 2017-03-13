namespace Projet_WinForm
{
    partial class ConfirmModif
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
            this.buttonCloseConfirmModif = new System.Windows.Forms.Button();
            this.labelConfirmModif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCloseConfirmModif
            // 
            this.buttonCloseConfirmModif.Location = new System.Drawing.Point(105, 89);
            this.buttonCloseConfirmModif.Name = "buttonCloseConfirmModif";
            this.buttonCloseConfirmModif.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseConfirmModif.TabIndex = 0;
            this.buttonCloseConfirmModif.Text = "OK";
            this.buttonCloseConfirmModif.UseVisualStyleBackColor = true;
            this.buttonCloseConfirmModif.Click += new System.EventHandler(this.buttonCloseConfirmModif_Click);
            // 
            // labelConfirmModif
            // 
            this.labelConfirmModif.AutoSize = true;
            this.labelConfirmModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmModif.Location = new System.Drawing.Point(34, 22);
            this.labelConfirmModif.Name = "labelConfirmModif";
            this.labelConfirmModif.Size = new System.Drawing.Size(217, 24);
            this.labelConfirmModif.TabIndex = 1;
            this.labelConfirmModif.Text = "Modifiication éffèctué(es)";
            // 
            // ConfirmModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.labelConfirmModif);
            this.Controls.Add(this.buttonCloseConfirmModif);
            this.Name = "ConfirmModif";
            this.Text = "ConfirmModif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseConfirmModif;
        private System.Windows.Forms.Label labelConfirmModif;
    }
}