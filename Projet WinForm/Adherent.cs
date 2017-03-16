using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_WinForm
{
    class Adherent
    {
        public int id { set; get; }
        public string nomAdh { set; get; }
        public string prenomAdh { set; get; }
        public DateTime naissance { set; get; }
        public string sexe { set; get; }
        public string numLicence { set; get; }
        public string adresseAdh { set; get; }
        public int CPAdh { set; get; }
        public string villeAdh { set; get; }
        public int cotisation { set; get; }
        public int id_club { set; get; }

        public Adherent(int id, string nomAdh, string prenomAdh, DateTime naissance, string sexe, string numLicence, string adresseAdh, int CPAdh, string villeAdh, int cotisation, int id_club)
        {
            this.id = id;
            this.nomAdh = nomAdh;
            this.prenomAdh = prenomAdh;
            this.naissance = naissance;
            this.sexe = sexe;
            this.numLicence = numLicence;
            this.adresseAdh = adresseAdh;
            this.CPAdh = CPAdh;
            this.villeAdh = villeAdh;
            this.cotisation = cotisation;
            this.id_club = id_club;

        }
    }
}
