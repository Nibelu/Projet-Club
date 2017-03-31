namespace Projet_WinForm
{
    partial class afficheVille
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
            this.dataGridViewAfficheVille = new System.Windows.Forms.DataGridView();
            this.buttonAfficheVilleBack = new System.Windows.Forms.Button();
            this.textBoxSearchParVille = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfficheVille)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAfficheVille
            // 
            this.dataGridViewAfficheVille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAfficheVille.Location = new System.Drawing.Point(2, 41);
            this.dataGridViewAfficheVille.Name = "dataGridViewAfficheVille";
            this.dataGridViewAfficheVille.Size = new System.Drawing.Size(509, 178);
            this.dataGridViewAfficheVille.TabIndex = 0;
            this.dataGridViewAfficheVille.VisibleChanged += new System.EventHandler(this.dataGridViewAfficheVille_VisibleChanged);
            // 
            // buttonAfficheVilleBack
            // 
            this.buttonAfficheVilleBack.Location = new System.Drawing.Point(12, 6);
            this.buttonAfficheVilleBack.Name = "buttonAfficheVilleBack";
            this.buttonAfficheVilleBack.Size = new System.Drawing.Size(131, 29);
            this.buttonAfficheVilleBack.TabIndex = 1;
            this.buttonAfficheVilleBack.Text = "Retour";
            this.buttonAfficheVilleBack.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchParVille
            // 
            this.textBoxSearchParVille.Location = new System.Drawing.Point(309, 13);
            this.textBoxSearchParVille.Name = "textBoxSearchParVille";
            this.textBoxSearchParVille.Size = new System.Drawing.Size(173, 20);
            this.textBoxSearchParVille.TabIndex = 2;
            this.textBoxSearchParVille.TextChanged += new System.EventHandler(this.textBoxSearchParVille_TextChanged);
            // 
            // afficheVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 262);
            this.Controls.Add(this.textBoxSearchParVille);
            this.Controls.Add(this.buttonAfficheVilleBack);
            this.Controls.Add(this.dataGridViewAfficheVille);
            this.Name = "afficheVille";
            this.Text = "afficheVille";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfficheVille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAfficheVille;
        private System.Windows.Forms.Button buttonAfficheVilleBack;
        private System.Windows.Forms.TextBox textBoxSearchParVille;
    }
}