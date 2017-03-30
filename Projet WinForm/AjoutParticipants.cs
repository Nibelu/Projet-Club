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
    public partial class AjoutParticipants : Form
    {

        private int idClub;
        private int idEvent;
        private string FromWhere;
        private ConfirmAjoutEvent confirmation;


        public AjoutParticipants(string FromWhere, int idClub, int idEvent)
        {
            this.idClub = idClub;
            this.idEvent = idEvent;
            this.FromWhere = FromWhere;
            InitializeComponent();
        }

        private void panelAddParticipantFromModifEvent_VisibleChanged(object sender, EventArgs e)
        {
            panelChooseAdhToEvent.Visible = false;
            BDD UnEvent = new BDD();
            Evenement ThisEvent = UnEvent.ReadEvent(idEvent);
            Club leClub = UnEvent.ReadClub(idClub);
            labelTypeEventAddPart.Text = ThisEvent.typeEvent;

            labelIdChooseEvent.Text = ThisEvent.id.ToString();

            labelNomClubEventAddPart.Text = leClub.nomClub;            
            labelDateDebutEventAddPart.Text = ThisEvent.dateDebutEvent.ToString();
            labelDateFinEventAddPart.Text = ThisEvent.dateFinEvent.ToString();
            labelAdresseEventAddPart.Text = ThisEvent.adresseEvent;
            labelCPEventAddPart.Text = ThisEvent.CPEvent.ToString();
            labelVilleEventAddPart.Text = ThisEvent.villeEvent;
            labelURLEventAddPart.Text = ThisEvent.siteEvent;
            labelAddPartNomEvent.Text = ThisEvent.nomEvent;
            labelNbPartEventAddPart.Text = ThisEvent.nbParticipants.ToString();
        }

        private void ButtonBackToModifEvent_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddAdhOnEvent_Click(object sender, EventArgs e)
        {
            
            panelAddParticipantFromModifEvent.Visible = false;
            panelChooseAdhToEvent.Visible = true;            
        
            dataGridViewListAdhToEvent.Rows.Clear();
            BDD listeAdherents = new BDD();
            List<Adherent> ListeAdherent = listeAdherents.SelectAllEventAdherent(idEvent, idClub);
            dataGridViewListAdhToEvent.ColumnCount = 11;
            dataGridViewListAdhToEvent.Columns[0].Name = "Id";
            dataGridViewListAdhToEvent.Columns[1].Name = "Nom Adhérent";
            dataGridViewListAdhToEvent.Columns[2].Name = "Prénom Adhérent";
            dataGridViewListAdhToEvent.Columns[3].Name = "Naissance";
            dataGridViewListAdhToEvent.Columns[4].Name = "Sexe";
            dataGridViewListAdhToEvent.Columns[5].Name = "Licence";
            dataGridViewListAdhToEvent.Columns[6].Name = "Adresse";
            dataGridViewListAdhToEvent.Columns[7].Name = "Code postal";
            dataGridViewListAdhToEvent.Columns[8].Name = "ville";
            dataGridViewListAdhToEvent.Columns[9].Name = "Cotisation";
            dataGridViewListAdhToEvent.Columns[10].Name = "Suppression";


            foreach (Adherent adherent in ListeAdherent)
            {                
                    dataGridViewListAdhToEvent.Rows.Add(adherent.id, adherent.nomAdh, adherent.prenomAdh, adherent.naissance, adherent.sexe, adherent.numLicence, adherent.adresseAdh, adherent.CPAdh, adherent.villeAdh, adherent.cotisation, "Supprimer");
            }
        

    }

        private void buttonBackToAddPartEvent_Click(object sender, EventArgs e)
        {
            panelChooseAdhToEvent.Visible = false;
            panelAddParticipantFromModifEvent.Visible = true;
        }

        private void dataGridViewListAdhToEvent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Adh = dataGridViewListAdhToEvent.Rows[e.RowIndex].Cells[0].Value.ToString();
            ConfirmAjoutEvent confirmation = new ConfirmAjoutEvent(idEvent, int.Parse(Adh));
            confirmation.ShowDialog();
        }
    }
}
