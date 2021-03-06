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
    public partial class FormPrincipal : Form
    {

        private AjoutParticipants participantAjout;
        private Ajout modalAjout;
        private ConfirmModif confModif;
        private FormSuppression suppression;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public void AfficheList()
        {
            listClubs.Rows.Clear();
            BDD liste1 = new BDD();
            List<Club> ListClub = liste1.SelectAllClub();            
            listClubs.ColumnCount = 8;
            listClubs.Columns[0].Name = "Id";
            listClubs.Columns[1].Name = "Nom du Club";
            listClubs.Columns[2].Name = "Adresse";
            listClubs.Columns[3].Name = "Code Postal";
            listClubs.Columns[4].Name = "Ville";
            listClubs.Columns[5].Name = "Telephone";
            listClubs.Columns[6].Name = "Contact";
            listClubs.Columns[7].Name = "Liens";
            
            foreach (Club list in ListClub)
            {
                listClubs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                listClubs.Rows.Add(list.id, list.nomClub, list.adresseClub, list.CPClub, list.villeClub, list.telephone, list.mail, list.siteClub);
                
            }
            
        }

        public void AfficheListAdherent(int leClub)
        {
            dataGridViewListAdherents.Rows.Clear();
            BDD listeAdherents = new BDD();
            List<Adherent> ListeAdherent = listeAdherents.SelectAllAdherent(leClub);
            dataGridViewListAdherents.ColumnCount = 10;
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
           
            foreach (Adherent adherent in ListeAdherent)
            {
                dataGridViewListAdherents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridViewListAdherents.Rows.Add(adherent.id, adherent.nomAdh, adherent.prenomAdh, adherent.naissance, adherent.sexe, adherent.numLicence, adherent.adresseAdh, adherent.CPAdh, adherent.villeAdh, adherent.cotisation);
            }
        }

        public void AfficheListEvent(int leClub)
        {
            dataGridViewListEvent.Rows.Clear();
            BDD listeEvents = new BDD();
            List<Evenement> listeEvenement = listeEvents.SelectAllEvent(leClub);
            dataGridViewListEvent.ColumnCount = 10;
            dataGridViewListEvent.Columns[0].Name = "Id";
            dataGridViewListEvent.Columns[1].Name = "Type d'évènement";
            dataGridViewListEvent.Columns[2].Name = "Nom évènement";
            dataGridViewListEvent.Columns[3].Name = "Adresse évènement";
            dataGridViewListEvent.Columns[4].Name = "Code Postal";
            dataGridViewListEvent.Columns[5].Name = "Ville évènement";
            dataGridViewListEvent.Columns[6].Name = "Liens";
            dataGridViewListEvent.Columns[7].Name = "Début";
            dataGridViewListEvent.Columns[8].Name = "Fin";
            dataGridViewListEvent.Columns[9].Name = "Participants";
            
            foreach (Evenement Event in listeEvenement)
            {
                dataGridViewListEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridViewListEvent.Rows.Add(Event.id, Event.typeEvent, Event.nomEvent, Event.adresseEvent, Event.CPEvent, Event.villeEvent, Event.siteEvent, Event.dateDebutEvent, Event.dateFinEvent, Event.nbParticipants);
            }

        }


        private void listClubs_VisibleChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelConsultEvent.Visible = false;
            panelListAdherents.Visible = false;
            PanelModifAdherent.Visible = false;
            panelModifEvent.Visible = false;
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
            modalAjout = new Ajout("Ajouter un Club", "", 0);
            modalAjout.FormClosed += ModalAjout_FormClosed;
            modalAjout.ShowDialog();
           

        }

        private void ModalAjout_FormClosed(object sender, FormClosedEventArgs e)
        {           
            listClubs.Rows.Clear();
            dataGridViewListAdherents.Rows.Clear();
            dataGridViewListEvent.Rows.Clear();
            AfficheList();
            AfficheListAdherent(int.Parse(idClub.Text));
            AfficheListEvent(int.Parse(idClub.Text));
        }

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {

            listClubs.Rows.Clear();
            BDD liste1 = new BDD();
            List<Club> ListClub = liste1.SearchClub(textBoxRecherche.Text);
            listClubs.ColumnCount = 8;
            listClubs.Columns[0].Name = "Id";
            listClubs.Columns[1].Name = "Nom du Club";
            listClubs.Columns[2].Name = "Adresse";
            listClubs.Columns[3].Name = "Code Postal";
            listClubs.Columns[4].Name = "Ville";
            listClubs.Columns[5].Name = "Telephone";
            listClubs.Columns[6].Name = "Contact";
            listClubs.Columns[7].Name = "Liens";

            foreach (Club list in ListClub)
            {
                listClubs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                listClubs.Rows.Add(list.id, list.nomClub, list.adresseClub, list.CPClub, list.villeClub, list.telephone, list.mail, list.siteClub);
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
            labelNomDuClub.Text = textBoxModifNameClub.Text;            
            AfficheListAdherent(int.Parse(idClub.Text));
        }

        

        private void buttonRetourClub_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panelListAdherents.Visible = false;
        }

        private void textBoxRechercheAdherent_TextChanged(object sender, EventArgs e)
        {
            dataGridViewListAdherents.Rows.Clear();
            BDD listeAdherents = new BDD();
            List<Adherent> ListeAdherent = listeAdherents.SearchAdherent(textBoxRechercheAdherent.Text, int.Parse(idClub.Text));
            dataGridViewListAdherents.ColumnCount = 10;
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

            foreach (Adherent adherent in ListeAdherent)
            {
                dataGridViewListAdherents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridViewListAdherents.Rows.Add(adherent.id, adherent.nomAdh, adherent.prenomAdh, adherent.naissance, adherent.sexe, adherent.numLicence, adherent.adresseAdh, adherent.CPAdh, adherent.villeAdh, adherent.cotisation);
            }
        }

        private void buttonAjoutAdherent_Click(object sender, EventArgs e)
        {
            modalAjout = new Ajout("Ajouter un adhérent", labelNomDuClub.Text, int.Parse(idClub.Text));
            modalAjout.FormClosed += ModalAjout_FormClosed;
            modalAjout.ShowDialog();
        }

        private void dataGridViewListAdherents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             var LaCellule = dataGridViewListAdherents.Rows[e.RowIndex].Cells[0].Value.ToString();            
             panelListAdherents.Visible = false;
             PanelModifAdherent.Visible = true;
             labelIdAdhModif.Text = LaCellule;
             BDD UnAdherent = new BDD();             
             Adherent ThisAdherent = UnAdherent.ReadAdherent(int.Parse(LaCellule));    
             Club clubDeLAdh = UnAdherent.ReadClub(ThisAdherent.id_club);
             labelNomClubAdhModif.Text = clubDeLAdh.nomClub;
             labelIdAdhModif.Text = ThisAdherent.id.ToString();             
             textBoxNomAdhModif.Text = ThisAdherent.nomAdh;
             textBoxPrenomAdhModif.Text = ThisAdherent.prenomAdh;
             textBoxSexeAdhModif.Text = ThisAdherent.sexe;
             dateTimePickerNaissanceAdhModif.Value = ThisAdherent.naissance;
             textBoxLicenceAdhModif.Text = ThisAdherent.numLicence;
             textBoxAdresseAdhModif.Text = ThisAdherent.adresseAdh;
             textBoxCPAdhModif.Text = ThisAdherent.CPAdh.ToString();
             textBoxVilleAdhModif.Text = ThisAdherent.villeAdh;
             textBoxCotisationAdhModif.Text = ThisAdherent.cotisation.ToString();

             labelIdClubAdh.Text = ThisAdherent.id_club.ToString();
        }

        private void buttonModifierAdherent_Click(object sender, EventArgs e)
        {
            BDD ModifAdh1 = new BDD();
            Adherent LAdherent = new Adherent(int.Parse(labelIdAdhModif.Text), textBoxNomAdhModif.Text, textBoxPrenomAdhModif.Text, dateTimePickerNaissanceAdhModif.Value, textBoxSexeAdhModif.Text, textBoxLicenceAdhModif.Text, textBoxAdresseAdhModif.Text, int.Parse(textBoxCPAdhModif.Text), textBoxVilleAdhModif.Text, int.Parse(textBoxCotisationAdhModif.Text), int.Parse(labelIdClubAdh.Text));
            ModifAdh1.UpdateAdherent(LAdherent);
            confModif = new ConfirmModif();
            confModif.ShowDialog();
        }

        private void buttonBackToListAdherent_Click(object sender, EventArgs e)
        {
            panelListAdherents.Visible = true;
            PanelModifAdherent.Visible = false;
        }

        private void buttonConsultEvent_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panelConsultEvent.Visible = true;
            labelNomClubOnEvent.Text = textBoxModifNameClub.Text;
            AfficheListEvent(int.Parse(idClub.Text));
        }

        private void buttonBackToClubFromEvent_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panelConsultEvent.Visible = false;
        }

        private void textBoxSearchEvent_TextChanged(object sender, EventArgs e)
        {
            dataGridViewListEvent.Rows.Clear();
            BDD listeEvents = new BDD();
            List<Evenement> listeEvenement = listeEvents.SearchEvent(textBoxSearchEvent.Text, int.Parse(idClub.Text));
            dataGridViewListEvent.ColumnCount = 10;
            dataGridViewListEvent.Columns[0].Name = "Id";
            dataGridViewListEvent.Columns[1].Name = "Type d'évènement";
            dataGridViewListEvent.Columns[2].Name = "Nom évènement";
            dataGridViewListEvent.Columns[3].Name = "Adresse évènement";
            dataGridViewListEvent.Columns[4].Name = "Code Postal";
            dataGridViewListEvent.Columns[5].Name = "Ville évènement";
            dataGridViewListEvent.Columns[6].Name = "Liens";
            dataGridViewListEvent.Columns[7].Name = "Début";
            dataGridViewListEvent.Columns[8].Name = "Fin";
            dataGridViewListEvent.Columns[9].Name = "Participants";

            foreach (Evenement Event in listeEvenement)
            {
                dataGridViewListEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridViewListEvent.Rows.Add(Event.id, Event.typeEvent, Event.nomEvent, Event.adresseEvent, Event.CPEvent, Event.villeEvent, Event.siteEvent, Event.dateDebutEvent, Event.dateFinEvent, Event.nbParticipants);
            }
        }

        private void buttonNewEvent_Click(object sender, EventArgs e)
        {
            modalAjout = new Ajout("Ajouter un évènement", labelNomClubOnEvent.Text, int.Parse(idClub.Text));
            modalAjout.FormClosed += ModalAjout_FormClosed;
            modalAjout.ShowDialog();
        }        

        private void buttonBackToListEvent_Click(object sender, EventArgs e)
        {
            panelConsultEvent.Visible = true;
            panelModifEvent.Visible = false;
        }

        private void dataGridViewListEvent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var LaCellule = dataGridViewListEvent.Rows[e.RowIndex].Cells[0].Value.ToString();
            panelConsultEvent.Visible = false;
            panelModifEvent.Visible = true;            
            BDD UnEvent = new BDD();
            Evenement ThisEvent = UnEvent.ReadEvent(int.Parse(LaCellule));
            Club clubDeLEvent = UnEvent.ReadClub(ThisEvent.id_club);
            labelShowIdEvent.Text = ThisEvent.id.ToString();
            labelNomDuClubModifEvent.Text = clubDeLEvent.nomClub;
            labelNbParticpant.Text = ThisEvent.nbParticipants.ToString();
            textBoxModifNomEvent.Text = ThisEvent.nomEvent;
            textBoxModifAdresseEvent.Text = ThisEvent.adresseEvent;
            textBoxModifCPEvent.Text = ThisEvent.CPEvent.ToString();
            textBoxModifVilleEvent.Text = ThisEvent.villeEvent;
            textBoxModifTypeEvent.Text = ThisEvent.typeEvent;
            textBoxModifSiteEvent.Text = ThisEvent.siteEvent;
            dateTimePickerModifDateDebutEvent.Value = ThisEvent.dateDebutEvent;
            dateTimePickerModifDateFinEvent.Value = ThisEvent.dateFinEvent;
            labelIdClubEvent.Text = ThisEvent.id_club.ToString();
        }

        private void buttonModifEvent_Click(object sender, EventArgs e)
        {
            BDD ModifEvent1 = new BDD();
            Evenement LEvent = new Evenement(int.Parse(labelShowIdEvent.Text), textBoxModifTypeEvent.Text, textBoxModifNomEvent.Text,
                textBoxModifAdresseEvent.Text, int.Parse(textBoxModifCPEvent.Text), textBoxModifVilleEvent.Text,
                textBoxModifSiteEvent.Text, dateTimePickerModifDateDebutEvent.Value, dateTimePickerModifDateFinEvent.Value, int.Parse(labelNbParticpant.Text), int.Parse(labelIdClubEvent.Text));
            ModifEvent1.UpdateEvent(LEvent);
            confModif = new ConfirmModif();
            confModif.ShowDialog();
        }

        private void buttonAddParticipantToEvent_Click(object sender, EventArgs e)
        {
            participantAjout = new AjoutParticipants("FromModifEvent",int.Parse(labelIdClubEvent.Text), int.Parse(labelShowIdEvent.Text));
            participantAjout.FormClosed += ModalAjout_FormClosed;
            participantAjout.ShowDialog();
        }

        private void buttonAfficheListeParticipants_Click(object sender, EventArgs e)
        {
            participantAjout = new AjoutParticipants("ListeParticipants", int.Parse(labelIdClubEvent.Text), int.Parse(labelShowIdEvent.Text));
            participantAjout.FormClosed += ModalAjout_FormClosed;
            participantAjout.ShowDialog();
        }

        private void buttonSupprimerEvent_Click(object sender, EventArgs e)
        {
            
            Evenement LEvent = new Evenement(int.Parse(labelShowIdEvent.Text), textBoxModifTypeEvent.Text, textBoxModifNomEvent.Text,
                textBoxModifAdresseEvent.Text, int.Parse(textBoxModifCPEvent.Text), textBoxModifVilleEvent.Text,
                textBoxModifSiteEvent.Text, dateTimePickerModifDateDebutEvent.Value, dateTimePickerModifDateFinEvent.Value, int.Parse(labelNbParticpant.Text), int.Parse(labelIdClubEvent.Text));
            suppression = new FormSuppression(LEvent);
            suppression.FormClosed += FormSuppr_FormClosed;
            suppression.ShowDialog();

        }

        private void buttonSupprClub_Click(object sender, EventArgs e)
        {
            Club leClub = new Club(int.Parse(idClub.Text), textBoxModifNameClub.Text, textBoxModifAdresseClub.Text, int.Parse(textBoxModifCPClub.Text), textBoxModifVilleClub.Text, textBoxModifTelClub.Text, textBoxModifMailClub.Text, textBoxModifURLClub.Text);
            suppression = new FormSuppression(leClub);
            suppression.FormClosed += FormSuppr_FormClosed;
            suppression.ShowDialog();
        }

        private void buttonSupprAdh_Click(object sender, EventArgs e)
        {
            Adherent LAdherent = new Adherent(int.Parse(labelIdAdhModif.Text), textBoxNomAdhModif.Text, textBoxPrenomAdhModif.Text, dateTimePickerNaissanceAdhModif.Value, textBoxSexeAdhModif.Text, textBoxLicenceAdhModif.Text, textBoxAdresseAdhModif.Text, int.Parse(textBoxCPAdhModif.Text), textBoxVilleAdhModif.Text, int.Parse(textBoxCotisationAdhModif.Text), int.Parse(labelIdClubAdh.Text));
            suppression = new FormSuppression(LAdherent);
            suppression.FormClosed += FormSuppr_FormClosed;
            suppression.ShowDialog();
        }

        private void FormSuppr_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(FormSuppression.deleted && FormSuppression.typedeleted == "event")
            {
                dataGridViewListEvent.Rows.Clear();  
                AfficheListEvent(int.Parse(idClub.Text));                
                panelModifEvent.Visible = false;
                panelConsultEvent.Visible = true;

            }
            else if (FormSuppression.deleted && FormSuppression.typedeleted == "club")
            {
                listClubs.Rows.Clear();               
                AfficheList();
                panel2.Visible = false;
                panel1.Visible = true;
            }
            else if (FormSuppression.deleted && FormSuppression.typedeleted == "adh")
            {                
                dataGridViewListAdherents.Rows.Clear();
                AfficheListAdherent(int.Parse(idClub.Text));
                PanelModifAdherent.Visible = false;
                panelListAdherents.Visible = true; 
            }
        }

        
    }
}
