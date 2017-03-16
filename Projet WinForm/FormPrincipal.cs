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
    public partial class FormPrincipal : Form
    {

        private Ajout modalAjout;
        private ConfirmModif confModif;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public void AfficheList()
        {
            BDD liste1 = new BDD();
            List<Club> ListClub = liste1.SelectAllClub();
            listClubs.ColumnCount = 9;
            listClubs.Columns[0].Name = "Id";
            listClubs.Columns[1].Name = "Nom du Club";
            listClubs.Columns[2].Name = "Adresse";
            listClubs.Columns[3].Name = "Code Postal";
            listClubs.Columns[4].Name = "Ville";
            listClubs.Columns[5].Name = "Telephone";
            listClubs.Columns[6].Name = "Contact";
            listClubs.Columns[7].Name = "Liens";
            listClubs.Columns[8].Name = "Suppression";
            
            foreach (Club list in ListClub)
            {
                listClubs.Rows.Add(list.id, list.nomClub, list.adresseClub, list.CPClub, list.villeClub, list.telephone, list.mail, list.siteClub, "Supprimer");
            }
        }

        public void AfficheListAdherent(int leClub)
        {
            BDD listeAdherents = new BDD();
            List<Adherent> ListeAdherent = listeAdherents.SelectAllAdherent(leClub);
            dataGridViewListAdherents.ColumnCount = 11;
            dataGridViewListAdherents.Columns[0].Name = "Id";
            dataGridViewListAdherents.Columns[1].Name = "Nom Adhérent";
            dataGridViewListAdherents.Columns[2].Name = "Prénom Adhérent";
            dataGridViewListAdherents.Columns[3].Name = "Naissance";
            dataGridViewListAdherents.Columns[4].Name = "Sexe";
            dataGridViewListAdherents.Columns[5].Name = "Licence";
            dataGridViewListAdherents.Columns[6].Name = "Adresse";
            dataGridViewListAdherents.Columns[7].Name = "Code postal";
            dataGridViewListAdherents.Columns[8].Name = "ville";
            dataGridViewListAdherents.Columns[9].Name = "Cotisation";
            dataGridViewListAdherents.Columns[10].Name = "Suppression";
           
            foreach (Adherent adherent in ListeAdherent)
            {
                dataGridViewListAdherents.Rows.Add(adherent.id, adherent.nomAdh, adherent.prenomAdh, adherent.naissance, adherent.sexe, adherent.numLicence, adherent.adresseAdh, adherent.CPAdh, adherent.villeAdh, adherent.cotisation, "Supprimer");
            }
        }


        private void listClubs_VisibleChanged(object sender, EventArgs e)
        {
            panelListAdherents.Visible = false;
            AfficheList();
           
        }

        private void listClubs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nb = listClubs.Rows[e.RowIndex].Cells[0].Value.ToString();
            panel1.Visible = false;
            panelListAdherents.Visible = false;
            panel2.Visible = true;
            idClub.Text = nb;
            BDD club1 = new BDD();
            Club leClub = club1.ReadClub(int.Parse(nb));
            pageClub.Text = leClub.nomClub;
            textBoxModifNameClub.Text = leClub.nomClub;
            textBoxModifAdresseClub.Text = leClub.adresseClub;
            textBoxModifCPClub.Text = leClub.CPClub.ToString();
            textBoxModifVilleClub.Text = leClub.villeClub;
            textBoxModifTelClub.Text = leClub.telephone;
            textBoxModifMailClub.Text = leClub.mail;
            textBoxModifURLClub.Text = leClub.siteClub;

        }

        private void ajoutClub_Click(object sender, EventArgs e)
        {
            modalAjout = new Ajout("Ajouter un Club");
            modalAjout.FormClosed += ModalAjout_FormClosed;
            modalAjout.ShowDialog();
           

        }

        private void ModalAjout_FormClosed(object sender, FormClosedEventArgs e)
        {
            listClubs.Rows.Clear();
            AfficheList();
        }

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {

            listClubs.Rows.Clear();
            BDD liste1 = new BDD();
            List<Club> ListClub = liste1.SearchClub(textBoxRecherche.Text);
            listClubs.ColumnCount = 9;
            listClubs.Columns[0].Name = "Id";
            listClubs.Columns[1].Name = "Nom du Club";
            listClubs.Columns[2].Name = "Adresse";
            listClubs.Columns[3].Name = "Code Postal";
            listClubs.Columns[4].Name = "Ville";
            listClubs.Columns[5].Name = "Telephone";
            listClubs.Columns[6].Name = "Contact";
            listClubs.Columns[7].Name = "Liens";
            listClubs.Columns[8].Name = "Suppression";            
            foreach (Club list in ListClub)
            {
                listClubs.Rows.Add(list.id, list.nomClub, list.adresseClub, list.CPClub, list.villeClub, list.telephone, list.mail, list.siteClub, "Supprimer");
            }
        }

        private void buttonModifClub_Click(object sender, EventArgs e)
        {
            BDD Modifclub1 = new BDD();           
            Club leClub = new Club(int.Parse(idClub.Text), textBoxModifNameClub.Text, textBoxModifAdresseClub.Text, int.Parse(textBoxModifCPClub.Text), textBoxModifVilleClub.Text, textBoxModifTelClub.Text, textBoxModifMailClub.Text, textBoxModifURLClub.Text);
            Modifclub1.UpdateClub(leClub);
            confModif = new ConfirmModif();
            confModif.ShowDialog();
        }

        private void buttonRetourListeClub_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panelListAdherents.Visible = false;
        }
        

        private void buttonConsultAdherent_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panelListAdherents.Visible = true;
            Console.WriteLine(idClub.Text);
            AfficheListAdherent(int.Parse(idClub.Text));
        }
    }
}
