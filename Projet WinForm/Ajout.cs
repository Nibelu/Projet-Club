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
    public partial class Ajout : Form
    {
        private string leTypeAjout;


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
            BDD newClub = new BDD();
            Club nouveauClub = new Club(/* poulet ajouter les textBox*/);
             newClub.InsertClub(nouveauClub);

        }
    }
}
