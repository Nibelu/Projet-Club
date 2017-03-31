using System;
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
    public partial class afficheVille : Form
    {
        private int idClub;

        public afficheVille(int idClub)
        {
            this.idClub = idClub;
            InitializeComponent();
        }

        
            private void dataGridViewAfficheVille_VisibleChanged(object sender, EventArgs e)
        {
            dataGridViewAfficheVille.Rows.Clear();
            BDD listeAdherents = new BDD();
            List<Adherent> ListeAdherent = listeAdherents.SelectAllAdherent( idClub);
            dataGridViewAfficheVille.ColumnCount = 11;
            dataGridViewAfficheVille.Columns[0].Name = "Id";
            dataGridViewAfficheVille.Columns[1].Name = "Nom Adhérent";
            dataGridViewAfficheVille.Columns[2].Name = "Prénom Adhérent";
            dataGridViewAfficheVille.Columns[3].Name = "Naissance";
            dataGridViewAfficheVille.Columns[4].Name = "Sexe";
            dataGridViewAfficheVille.Columns[5].Name = "Licence";
            dataGridViewAfficheVille.Columns[6].Name = "Adresse";
            dataGridViewAfficheVille.Columns[7].Name = "Code postal";
            dataGridViewAfficheVille.Columns[8].Name = "ville";
            dataGridViewAfficheVille.Columns[9].Name = "Cotisation";
            dataGridViewAfficheVille.Columns[10].Name = "Suppression";


            foreach (Adherent adherent in ListeAdherent)
            {
                dataGridViewAfficheVille.Rows.Add(adherent.id, adherent.nomAdh, adherent.prenomAdh, adherent.naissance, adherent.sexe, adherent.numLicence, adherent.adresseAdh, adherent.CPAdh, adherent.villeAdh, adherent.cotisation, "Supprimer");

            }
        }

        
         private void textBoxSearchParVille_TextChanged(object sender, EventArgs e)
        {
            dataGridViewAfficheVille.Rows.Clear();
            BDD listeAdherents = new BDD();
            List<villeAdh> ListeAdherent = listeAdherents.SearchAdherentVille(textBoxSearchParVille.Text, idClub);
            dataGridViewAfficheVille.ColumnCount = 2;                        
            dataGridViewAfficheVille.Columns[0].Name = "ville";
            dataGridViewAfficheVille.Columns[1].Name = "nombre";


            foreach (villeAdh adherent in ListeAdherent)
            {
                dataGridViewAfficheVille.Rows.Add(adherent.villeAdh,0);

            }
        }

}







}
