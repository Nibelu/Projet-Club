using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_WinForm
{
    class Inscrit
    {
        
        public string nom { set; get; }
        public string prenom { set; get; }


        public Inscrit (string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }


        public List<Inscrit> genererListe(List<Adherent> listAdh, List<NonAdherent> listNA)
        {
            Inscrit unInscrit = new Inscrit("","");
            List<Inscrit> lesInscrits = new List<Inscrit>();

            foreach (Adherent Adh in listAdh)
            {
                unInscrit = new Inscrit(Adh.nomAdh, Adh.prenomAdh);
                lesInscrits.Add(unInscrit);
                
            }

            foreach (NonAdherent NA in listNA)
            {
                unInscrit = new Inscrit(NA.nameNonAdherent, NA.prenomNonAdherent);
                lesInscrits.Add(unInscrit);

            }



            return lesInscrits;
        }




    }
}
