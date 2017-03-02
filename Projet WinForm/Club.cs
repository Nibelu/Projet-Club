using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_WinForm
{
    class Club
    {

        public int id { set; get; }
        public string nomClub { set; get; }
        public string adresseClub { set; get; }
        public int CPClub { set; get; }
        public string villeClub { set; get; }
        public string telephone { set; get; }
        public string mail { set; get; }
        public string siteClub { set; get; }

        public Club (int id,string nomClub, string adresseClub, int CPClub, string villeClub, string telephone, string mail, string siteClub)
        {
            this.id = id;
            this.nomClub = nomClub;
            this.adresseClub = adresseClub;
            this.CPClub = CPClub;
            this.villeClub = villeClub;
            this.telephone = telephone;
            this.mail = mail;
            this.siteClub = siteClub;

        }
        


    }
}
