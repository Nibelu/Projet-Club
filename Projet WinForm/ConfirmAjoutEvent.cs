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

        public ConfirmAjoutEvent(int idEvent, int idAdh)
        {
            this.idEvent = idEvent;
            this.idAdh = idAdh;
            InitializeComponent();
        }

        private void ConfirmAjoutEvent_VisibleChanged(object sender, EventArgs e)
        {
            BDD UnEvent = new BDD();
            Evenement ThisEvent = UnEvent.ReadEvent(idEvent);
            Adherent LAdherent = UnEvent.ReadAdherent(idAdh);

            labelNomEventConfirm.Text = ThisEvent.nomEvent;
            labelDateDebutEventConfirm.Text = ThisEvent.dateDebutEvent.ToString();
            labelDateFinConfirm.Text = ThisEvent.dateFinEvent.ToString();
            labelNomAdhConfirm.Text = LAdherent.nomAdh;
            labelLicenceConfirm.Text = LAdherent.numLicence;

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
    }
}
