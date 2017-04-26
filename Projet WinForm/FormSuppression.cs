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
    public partial class FormSuppression : Form
    {
        private Object leObjet { get; set; }
        public static bool deleted;
        public static string typedeleted;
    
        public FormSuppression( Object leObjet = null)
        {
            deleted = false;
            this.leObjet = leObjet;            

            InitializeComponent();
        }

        private void buttonConfirmSuppr_Click(object sender, EventArgs e)
        {
            BDD Delete = new BDD();
            if (leObjet.GetType() == typeof(Evenement))
            {
                Delete.DeleteEvent(((Evenement)leObjet).id);
                typedeleted = "event";
            }
            else if (leObjet.GetType() == typeof(Club))
            {
                Delete.DeleteClub(((Club)leObjet).id);
                typedeleted = "club";
            }
            else if (leObjet.GetType() == typeof(Adherent))
            {
                Delete.DeleteAdherent(((Adherent)leObjet).id);
                typedeleted = "adh";
            }
            deleted = true;
            Close();
        }

        private void buttonAnnulSuppr_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
