using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_WinForm
{
    class Participant
    {
        public int id { set; get; }
        public int idEvent { set; get; }
        public int idAdh { set; get; }
        public int idNA { set; get; }

        internal Evenement Evenement
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal Adherent Adherent
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal NonAdherent NonAdherent
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Participant(int id, int idEvent, int idAdh, int idNA)
        {
            this.id = id;
            this.idEvent = idEvent;
            this.idAdh = idAdh;
            this.idNA = idNA;
        }
    }
}
