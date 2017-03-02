﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_WinForm
{
    public partial class Ajout : Form
    {
        private string leTypeAjout;
        private ErrAjout erreur;

        public Ajout(string typeAjout)
        {
            this.leTypeAjout = typeAjout;
            InitializeComponent();
        }

        private void Ajout_Load(object sender, EventArgs e)
        {
            nomModal.Text = leTypeAjout;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CP;
            if (textBoxNom.Text != "Nom du club" && textBoxAdresse.Text != "Adresse du club" && textBoxCP.Text != "Code Postal" && textBoxVille.Text != "Ville" && textBoxtelephone.Text != "N°" && textBoxMail.Text != "email" && int.TryParse(textBoxCP.Text, out CP))
            {
                
                BDD newClub = new BDD();
                Club nouveauClub = new Club(0, textBoxNom.Text, textBoxAdresse.Text, CP, textBoxVille.Text, textBoxtelephone.Text, textBoxMail.Text, textBoxSite.Text);
                newClub.InsertClub(nouveauClub);
                Close();
                
            }
            else
            { 
                erreur = new ErrAjout();
                erreur.ShowDialog();
            }

        }
    }
}
