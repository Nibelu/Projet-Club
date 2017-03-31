using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_WinForm
{
    class NonAdherent
    {
        public int id { set; get; }
        public string nameNonAdherent { set; get; }
        public string prenomNonAdherent { set; get; }
        public string telNonAdherent { set; get; }
        public int idEvent { set; get; }

        public NonAdherent (int id, string nameNonAdherent, string prenomNonAdherent, string telNonAdherent, int idEvent)
        {
            this.id = id;
            this.nameNonAdherent = nameNonAdherent;
            this.prenomNonAdherent = prenomNonAdherent;
            this.telNonAdherent = telNonAdherent;
            this.idEvent = idEvent;
        }




    }
}
