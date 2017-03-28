using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_WinForm
{
    class Evenement
    {
        public int id { set; get; }
        public string typeEvent { set; get; }
        public string nomEvent { set; get; }
        public string adresseEvent { set; get; }
        public int CPEvent { set; get; }
        public string villeEvent { set; get; }
        public string siteEvent { set; get; }
        public DateTime dateDebutEvent { set; get; } 
        public DateTime dateFinEvent { set; get; }
        public int nbParticipants { set; get; }
        public int id_club { set; get; }

        //ici le contructeur evenement
        public Evenement (int id, string typeEvent, string nomEvent, string adresseEvent, int CPEvent, string villeEvent, string siteEvent, DateTime dateDebutEvent, DateTime dateFinEvent, int nbParticipants, int id_club)
        {
            this.id = id;
            this.typeEvent = typeEvent;
            this.nomEvent = nomEvent;
            this.adresseEvent = adresseEvent;
            this.CPEvent = CPEvent;
            this.villeEvent = villeEvent;
            this.siteEvent = siteEvent;
            this.dateDebutEvent = dateDebutEvent;
            this.dateFinEvent = dateFinEvent;
            this.nbParticipants = nbParticipants;
            this.id_club = id_club;
            

        }
    }
}
