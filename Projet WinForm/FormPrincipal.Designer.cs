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
            this.buttonRetour = new System.Windows.Forms.Button();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pageClub = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listClubs)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel2.Controls.Add(this.buttonRetour);
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
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pageClub);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 558);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(0, 15);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(138, 27);
            this.buttonRetour.TabIndex = 13;
            this.buttonRetour.Text = "Retour à la liste des clubs";
            this.buttonRetour.UseVisualStyleBackColor = true;
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
            this.textBoxModifURLClub.Location = new System.Drawing.Point(416, 398);
            this.textBoxModifURLClub.Name = "textBoxModifURLClub";
            this.textBoxModifURLClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifURLClub.TabIndex = 9;
            // 
            // textBoxModifMailClub
            // 
            this.textBoxModifMailClub.Location = new System.Drawing.Point(416, 324);
            this.textBoxModifMailClub.Name = "textBoxModifMailClub";
            this.textBoxModifMailClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifMailClub.TabIndex = 8;
            // 
            // textBoxModifTelClub
            // 
            this.textBoxModifTelClub.Location = new System.Drawing.Point(416, 249);
            this.textBoxModifTelClub.Name = "textBoxModifTelClub";
            this.textBoxModifTelClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifTelClub.TabIndex = 7;
            // 
            // textBoxModifVilleClub
            // 
            this.textBoxModifVilleClub.Location = new System.Drawing.Point(416, 175);
            this.textBoxModifVilleClub.Name = "textBoxModifVilleClub";
            this.textBoxModifVilleClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifVilleClub.TabIndex = 6;
            // 
            // textBoxModifCPClub
            // 
            this.textBoxModifCPClub.Location = new System.Drawing.Point(32, 398);
            this.textBoxModifCPClub.Name = "textBoxModifCPClub";
            this.textBoxModifCPClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifCPClub.TabIndex = 5;
            // 
            // textBoxModifAdresseClub
            // 
            this.textBoxModifAdresseClub.Location = new System.Drawing.Point(32, 324);
            this.textBoxModifAdresseClub.Name = "textBoxModifAdresseClub";
            this.textBoxModifAdresseClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifAdresseClub.TabIndex = 4;
            // 
            // textBoxModifNameClub
            // 
            this.textBoxModifNameClub.Location = new System.Drawing.Point(32, 249);
            this.textBoxModifNameClub.Name = "textBoxModifNameClub";
            this.textBoxModifNameClub.Size = new System.Drawing.Size(242, 20);
            this.textBoxModifNameClub.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Consulter Evenements";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consulter Adhérents";
            this.button1.UseVisualStyleBackColor = true;
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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(789, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.Text = "Liste Clubs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listClubs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonModifClub;
        private System.Windows.Forms.Button ajoutClub;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.TextBox textBoxRecherche;
    }
}

