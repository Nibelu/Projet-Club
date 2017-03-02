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
    public partial class Form1 : Form
    {

        private Ajout modalAjout;

        public Form1()
        {
            InitializeComponent();
        }





        private void listClubs_VisibleChanged(object sender, EventArgs e)
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
            Console.WriteLine(ListClub.Count);
            foreach (Club list in ListClub)
            {
                listClubs.Rows.Add(list.id, list.nomClub, list.adresseClub, list.CPClub, list.villeClub, list.telephone, list.mail, list.siteClub, "Supprimer");
            }
        }

        private void listClubs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nb = listClubs.Rows[e.RowIndex].Cells[0].Value.ToString();
            panel1.Visible = false;
            panel2.Visible = true;
            idClub.Text = nb;
            BDD club1 = new BDD();
            Club leClub = club1.ReadClub(int.Parse(nb));
            pageClub.Text = leClub.nomClub;
            textBox1.Text = leClub.nomClub;
            textBox2.Text = leClub.adresseClub;
            textBox3.Text = leClub.CPClub.ToString();
            textBox4.Text = leClub.villeClub;
            textBox5.Text = leClub.telephone;
            textBox6.Text = leClub.mail;
            textBox7.Text = leClub.siteClub;
        }

        private void ajoutClub_Click(object sender, EventArgs e)
        {
            modalAjout = new Ajout("Ajouter un Club");
            modalAjout.ShowDialog();

        }
    }
}
