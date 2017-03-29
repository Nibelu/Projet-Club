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
        private string nomClub;
        private int idClub;
        private ErrAjout erreur;

        public Ajout(string typeAjout, string nomClub, int idClub)
        {
            this.idClub = idClub;
            this.nomClub = nomClub;
            this.leTypeAjout = typeAjout;
            InitializeComponent();
        }

        private void Ajout_Load(object sender, EventArgs e)
        {            
            if (leTypeAjout.Contains("Club"))
            {
                panelAjoutClub.Visible = true;
                panelCreerAdherent.Visible = false;
                panelAjoutEvent.Visible = false;
                nomModal.Text = leTypeAjout;
                

            }
            else if (leTypeAjout.Contains("adhérent"))
            {

                panelCreerAdherent.Visible = true;
                panelAjoutClub.Visible = false;
                panelAjoutEvent.Visible = false;
                labelNomClubNewAdherent.Text = leTypeAjout;
                labelNewAdherentNomClub.Text = nomClub;
            }

            else if (leTypeAjout.Contains("évènement"))
            {

                panelAjoutEvent.Visible = true;
                panelAjoutClub.Visible = false;
                panelCreerAdherent.Visible = false;
                labelTypeAjoutEvent.Text = leTypeAjout;
                labelNomClubAjoutEvent.Text = nomClub;
            }
        }

        private void buttonCreerClub_Click(object sender, EventArgs e)
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

        private void buttonCreerAdherent_Click(object sender, EventArgs e)
        {
             int CP;
            int cot;
             DateTime thisDay = DateTime.Today;
             if (dateTimePickerNewNaissanceAdherent.Value != thisDay && textBoxNewNomAdherent.Text != "Nom de l'adhérent" && textBoxNewPrenomAdherent.Text != "Prénom de l'adhérent" && textBoxNewSexAdherent.Text != "Sexe" && textBoxNewLicenceAdherent.Text != "N° de licence" && textBoxNewAdressAdherent.Text != "Adresse de l'adhérent" && textBoxNewCPAdherent.Text != "Code Postal" && textBoxNewVilleAdherent.Text != "Ville" && textBoxNewCotisationAdherent.Text != "Montant de la cotisation" && int.TryParse(textBoxNewCPAdherent.Text, out CP) && int.TryParse(textBoxNewCotisationAdherent.Text, out cot))
             {
                 BDD newAdherent = new BDD();
                 Adherent nouvelAdherent = new Adherent(0, textBoxNewNomAdherent.Text, textBoxNewPrenomAdherent.Text, dateTimePickerNewNaissanceAdherent.Value, textBoxNewSexAdherent.Text, textBoxNewLicenceAdherent.Text, textBoxNewAdressAdherent.Text, CP, textBoxNewVilleAdherent.Text, cot, idClub);
                 newAdherent.InsertAdherent(nouvelAdherent);
                 Close();
             }
             else
             {
                 erreur = new ErrAjout();
                 erreur.ShowDialog();
             }  
        }

        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {
            int CP;
            DateTime thisDay = DateTime.Today;
            if (dateTimePickerNewDebutEvent.Value >= thisDay && dateTimePickerNewFinEvent.Value > dateTimePickerNewDebutEvent.Value
                && !string.IsNullOrEmpty(textBoxNewNomEvent.Text) && !string.IsNullOrEmpty(textBoxNewAdresseEvent.Text) 
                && !string.IsNullOrEmpty(textBoxNewCPEvent.Text) && !string.IsNullOrEmpty(textBoxNewVilleEvent.Text)
                && !string.IsNullOrEmpty(textBoxNewTypeEvent.Text) && !string.IsNullOrEmpty(textBoxNewStieEvent.Text) 
                && int.TryParse(textBoxNewCPEvent.Text, out CP))
            {
                BDD newEvent = new BDD();
                Evenement nouvelEvenement = new Evenement(0, textBoxNewTypeEvent.Text, textBoxNewNomEvent.Text, textBoxNewAdresseEvent.Text, CP, textBoxNewVilleEvent.Text, textBoxNewStieEvent.Text, dateTimePickerNewDebutEvent.Value, dateTimePickerNewFinEvent.Value, 0, idClub);
                newEvent.InsertEvent(nouvelEvenement);
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
