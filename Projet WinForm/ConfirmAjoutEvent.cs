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
    public partial class ConfirmAjoutEvent : Form
    {
        private int idEvent;
        private int idAdh;
        private string nomNA;
        private string prenomNA;
        private string telNA;

        public ConfirmAjoutEvent(int idEvent, int idAdh, string nomNA, string prenomNA, string telNA)
        {
            this.idEvent = idEvent;
            this.idAdh = idAdh;
            this.nomNA = nomNA;
            this.prenomNA = prenomNA;
            this.telNA = telNA;

            InitializeComponent();
        }

        private void ConfirmAjoutEvent_VisibleChanged(object sender, EventArgs e)
        {
            if (idAdh != 0)
            {
                panelConfirmAjoutAdh.Visible = true;
                panelConfirmAjoutNA.Visible = false;
                BDD UnEvent = new BDD();
                Evenement ThisEvent = UnEvent.ReadEvent(idEvent);
                Adherent LAdherent = UnEvent.ReadAdherent(idAdh);

                labelNomEventConfirm.Text = ThisEvent.nomEvent;
                labelDateDebutEventConfirm.Text = ThisEvent.dateDebutEvent.ToString();
                labelDateFinConfirm.Text = ThisEvent.dateFinEvent.ToString();
                labelNomAdhConfirm.Text = LAdherent.nomAdh;
                labelLicenceConfirm.Text = LAdherent.numLicence;
            }
            else if (idAdh == 0)
            {
                panelConfirmAjoutAdh.Visible = false;
                panelConfirmAjoutNA.Visible = true;
                BDD UnEvent = new BDD();
                Evenement ThisEvent = UnEvent.ReadEvent(idEvent);
                labelIdEventNA.Text = ThisEvent.id.ToString();
                labelNomEventNA.Text = ThisEvent.nomEvent;

                labelNomNAEvent.Text = nomNA;
                labelPrenomNAEvent.Text = prenomNA;
                labelTelNAEvent.Text = telNA;
            }
        }

        private void buttonRefuseAddPart_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonConfirmAddPart_Click(object sender, EventArgs e)
        {
            BDD UnEvent = new BDD();
            UnEvent.InsertParticipant(idAdh, idEvent, 0);
            Close();

        }

        private void buttonConfirmAjoutNA_Click(object sender, EventArgs e)
        {
            BDD UnEvent = new BDD();
            UnEvent.InsertNA(nomNA, prenomNA, telNA, idEvent);
            NonAdherent NA = UnEvent.ReadNA(telNA,idEvent);            
            UnEvent.InsertParticipant(0, idEvent, NA.id);
            Close();
        }

        private void buttonBackToNewNA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
