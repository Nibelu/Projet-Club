using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projet_WinForm
{
    class BDD
    {


        private string connectionString;

        //Constructor
        public BDD()
        {
            Initialize();
        }

        /// <summary>
        /// Initialise les champs et cree un objet connection.
        /// </summary>
        private void Initialize()
        {
            string server = "localhost";
            string port = "3306";
            string database = "projet_winform";
            string uid = "root";
            string password = "";
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        }

        
        //selection d'un club avec l'id
        public Club ReadClub(int id)
        {
            Club leClub = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM club where id=@id";


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", id);

                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        leClub = new Club(
                            (int)dataReader["id"],
                            (string)dataReader["nomClub"],
                            (string)dataReader["adresseClub"],
                            (int)dataReader["CPClub"],
                            (string)dataReader["villeClub"],
                            (string)dataReader["telephone"],
                            (string)dataReader["mail"],
                            (string)dataReader["siteClub"]);
                    }
                }
            }
            return leClub;
        }

       

        public void InsertClub(Club nouveauClub)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO club (nomClub, adresseClub, CPClub, villeClub, telephone, mail, siteClub) VALUES (@nom, @adresse, @cp, @ville, @telephone, @mail, @site)";


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nom", nouveauClub.nomClub);
                cmd.Parameters.AddWithValue("@adresse", nouveauClub.adresseClub);
                cmd.Parameters.AddWithValue("@cp", nouveauClub.CPClub);
                cmd.Parameters.AddWithValue("@ville", nouveauClub.villeClub);
                cmd.Parameters.AddWithValue("@telephone", nouveauClub.telephone);
                cmd.Parameters.AddWithValue("@mail", nouveauClub.mail);
                cmd.Parameters.AddWithValue("@site", nouveauClub.siteClub);
                cmd.ExecuteReader();
            }
        }

        public void UpdateClub(Club nouveauClub)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE club SET nomClub = @nom, adresseClub = @adresse, CPClub = @cp, villeClub = @ville, telephone = @telephone, mail = @mail, siteClub = @site WHERE id = @id";


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", nouveauClub.id);
                cmd.Parameters.AddWithValue("@nom", nouveauClub.nomClub);
                cmd.Parameters.AddWithValue("@adresse", nouveauClub.adresseClub);
                cmd.Parameters.AddWithValue("@cp", nouveauClub.CPClub);
                cmd.Parameters.AddWithValue("@ville", nouveauClub.villeClub);
                cmd.Parameters.AddWithValue("@telephone", nouveauClub.telephone);
                cmd.Parameters.AddWithValue("@mail", nouveauClub.mail);
                cmd.Parameters.AddWithValue("@site", nouveauClub.siteClub);
                cmd.ExecuteReader();
                //cmd.ExecuteNonQuery();
            }
        }

        public List<Club> SearchClub(string recherche)
        {
            Club leClub = null;
            List<Club> ListClub = new List<Club>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM club WHERE nomClub LIKE @recherche ORDER BY id ASC";
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@recherche", "%" + recherche + "%");
                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        leClub = new Club(
                            (int)dataReader["id"],
                            (string)dataReader["nomClub"],
                            (string)dataReader["adresseClub"],
                            (int)dataReader["CPClub"],
                            (string)dataReader["villeClub"],
                            (string)dataReader["telephone"],
                            (string)dataReader["mail"],
                            (string)dataReader["siteClub"]);
                        ListClub.Add(leClub);
                    }

                }

            }

            return ListClub;
        }

        public List<Club> SelectAllClub()
        {
            Club leClub = null;
            List<Club> ListClub = new List<Club>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM club ORDER BY id ASC";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        leClub = new Club(
                            (int)dataReader["id"],
                            (string)dataReader["nomClub"],
                            (string)dataReader["adresseClub"],
                            (int)dataReader["CPClub"],
                            (string)dataReader["villeClub"],
                            (string)dataReader["telephone"],
                            (string)dataReader["mail"],
                            (string)dataReader["siteClub"]);
                        ListClub.Add(leClub);
                    }
                }
            }
            return ListClub;
        }

        public List<Adherent> SearchAdherent(string recherche, int idClub)
        {
            Adherent lesAdherents = null;
            List<Adherent> ListAdherent = new List<Adherent>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Adherent WHERE nomAdh LIKE @recherche AND id_club = @idClub ORDER BY id ASC";
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@recherche", "%" + recherche + "%");
                cmd.Parameters.AddWithValue("@idClub", idClub);
                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        lesAdherents = new Adherent(
                            (int)dataReader["id"],
                            (string)dataReader["nomAdh"],
                            (string)dataReader["prenomAdh"],
                            (DateTime)dataReader["naissance"],
                            (string)dataReader["sexe"],
                            (string)dataReader["numLicence"],
                            (string)dataReader["adresseAdh"],
                            (int)dataReader["CPAdh"],
                            (string)dataReader["villeAdh"],
                            (int)dataReader["cotisation"],
                            (int)dataReader["id_club"]);
                        ListAdherent.Add(lesAdherents);
                    }

                }

            }

            return ListAdherent;
        }

        public List<Adherent> SelectAllAdherent(int leClub)
        {
            Adherent LeAdherent = null;
            List<Adherent> ListAdherent = new List<Adherent>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM adherent Where id_club = @club ORDER BY id ASC";


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@club", leClub);
                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        LeAdherent = new Adherent(
                            (int)dataReader["id"],
                            (string)dataReader["nomAdh"],
                            (string)dataReader["prenomAdh"],
                            (DateTime)dataReader["naissance"],
                            (string)dataReader["sexe"],
                            (string)dataReader["numLicence"],
                            (string)dataReader["adresseAdh"],
                            (int)dataReader["CPAdh"],
                            (string)dataReader["villeAdh"],
                            (int)dataReader["cotisation"],
                            (int)dataReader["id_club"]);
                        ListAdherent.Add(LeAdherent);
                    }
                }
            }

            return ListAdherent;
        }

        public void InsertAdherent(Adherent nouvelAdherent)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO adherent (nomAdh, prenomAdh, naissance, sexe, numLicence, adresseAdh, CPAdh, villeAdh, cotisation, id_club) VALUES (@nom, @prenom, @naissance, @sexe, @licence, @adresse, @CP, @ville, @cotisation, @idClub)";


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nom", nouvelAdherent.nomAdh);
                cmd.Parameters.AddWithValue("@prenom", nouvelAdherent.prenomAdh);
                cmd.Parameters.AddWithValue("@naissance", nouvelAdherent.naissance);
                cmd.Parameters.AddWithValue("@sexe", nouvelAdherent.sexe);
                cmd.Parameters.AddWithValue("@licence", nouvelAdherent.numLicence);
                cmd.Parameters.AddWithValue("@adresse", nouvelAdherent.adresseAdh);
                cmd.Parameters.AddWithValue("@CP", nouvelAdherent.CPAdh);
                cmd.Parameters.AddWithValue("@ville", nouvelAdherent.villeAdh);
                cmd.Parameters.AddWithValue("@cotisation", nouvelAdherent.cotisation);
                cmd.Parameters.AddWithValue("@idClub", nouvelAdherent.id_club);
                cmd.ExecuteReader();


            }
        }

        public Adherent ReadAdherent(int id)
        {
            Adherent ThisAdherent = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Adherent where id=@id";


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", id);

                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        ThisAdherent = new Adherent(
                            (int)dataReader["id"],
                            (string)dataReader["nomAdh"],
                            (string)dataReader["prenomAdh"],
                            (DateTime)dataReader["naissance"],
                            (string)dataReader["sexe"],
                            (string)dataReader["numLicence"],
                            (string)dataReader["adresseAdh"],
                            (int)dataReader["CPAdh"],
                            (string)dataReader["villeAdh"],
                            (int)dataReader["cotisation"],
                            (int)dataReader["id_club"]);
                    }
                }
            }
            return ThisAdherent;
        }

        public void UpdateAdherent(Adherent ModifAdherent)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE adherent SET nomAdh = @nom, prenomAdh = @prenom, naissance = @naissance, sexe = @sexe, numLicence = @licence, adresseAdh = @adresse, CPAdh = @cp, villeAdh = @ville, cotisation = @cotisation WHERE id = @id";


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", ModifAdherent.id);
                cmd.Parameters.AddWithValue("@nom", ModifAdherent.nomAdh);
                cmd.Parameters.AddWithValue("@prenom", ModifAdherent.prenomAdh);
                cmd.Parameters.AddWithValue("@naissance", ModifAdherent.naissance);
                cmd.Parameters.AddWithValue("@sexe", ModifAdherent.sexe);
                cmd.Parameters.AddWithValue("@licence", ModifAdherent.numLicence);
                cmd.Parameters.AddWithValue("@adresse", ModifAdherent.adresseAdh);
                cmd.Parameters.AddWithValue("@cp", ModifAdherent.CPAdh);
                cmd.Parameters.AddWithValue("@ville", ModifAdherent.villeAdh);
                cmd.Parameters.AddWithValue("@cotisation", ModifAdherent.cotisation);
                cmd.ExecuteReader();
                //cmd.ExecuteNonQuery();
            }
        }

        public List<Evenement> SelectAllEvent(int leClub)
        {
            Evenement LEvenement = null;
            List<Evenement> ListEvent = new List<Evenement>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM evenement Where id_club = @club ORDER BY id ASC";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@club", leClub);
                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        LEvenement = new Evenement(
                            (int)dataReader["id"],
                            (string)dataReader["typeEvent"],
                            (string)dataReader["nomEvent"],
                            (string)dataReader["adresseEvent"],
                            (int)dataReader["CPEvent"],
                            (string)dataReader["villeEvent"],
                            (string)dataReader["siteEvent"],
                            (DateTime)dataReader["dateDebutEvent"],
                            (DateTime)dataReader["dateFinEvent"],
                            (int)dataReader["nbParticipants"],
                            (int)dataReader["id_club"]);
                        ListEvent.Add(LEvenement);
                    }
                }
            }

            return ListEvent;
        }

        // selection d'un evenement avec l'id
         public List<Evenement> SearchEvent(string recherche, int idClub)
         {
             Evenement LEvent = null;
             List<Evenement> ListEvent = new List<Evenement>();
             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 connection.Open();
                 string query = "SELECT * FROM evenement WHERE nomEvent LIKE @recherche AND id_club = @idClub ORDER BY id ASC";
                 //Create Command
                 MySqlCommand cmd = new MySqlCommand(query, connection);
                 cmd.Parameters.AddWithValue("@recherche", "%" + recherche + "%");
                 cmd.Parameters.AddWithValue("@idClub", idClub);
                 //Create a data reader and Execute the command
                 using (MySqlDataReader dataReader = cmd.ExecuteReader())
                 {

                     //Read the data and store them in the list
                     while (dataReader.Read())
                     {
                        LEvent = new Evenement(
                            (int)dataReader["id"],
                            (string)dataReader["typeEvent"],
                            (string)dataReader["nomEvent"],
                            (string)dataReader["adresseEvent"],
                            (int)dataReader["CPEvent"],
                            (string)dataReader["villeEvent"],
                            (string)dataReader["siteEvent"],
                            (DateTime)dataReader["dateDebutEvent"],
                            (DateTime)dataReader["dateFinEvent"],
                            (int)dataReader["nbParticipants"],
                            (int)dataReader["id_club"]);
                        ListEvent.Add(LEvent);
                     }
                 }
             }
             return ListEvent;
         }

        public void InsertEvent(Evenement nouvelEvent)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO evenement (typeEvent, nomEvent, adresseEvent, CPEvent, villeEvent, siteEvent, dateDebutEvent, dateFinEvent, nbParticipants, id_club) VALUES (@type, @nom, @adresse, @CP, @ville, @site, @dateDebut, @dateFin, @nbPart, @idClub)";


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@type", nouvelEvent.typeEvent);
                cmd.Parameters.AddWithValue("@nom", nouvelEvent.nomEvent);
                cmd.Parameters.AddWithValue("@adresse", nouvelEvent.adresseEvent);
                cmd.Parameters.AddWithValue("@CP", nouvelEvent.CPEvent);
                cmd.Parameters.AddWithValue("@ville", nouvelEvent.villeEvent);
                cmd.Parameters.AddWithValue("@site", nouvelEvent.siteEvent);
                cmd.Parameters.AddWithValue("@dateDebut", nouvelEvent.dateDebutEvent);
                cmd.Parameters.AddWithValue("@dateFin", nouvelEvent.dateFinEvent);
                cmd.Parameters.AddWithValue("@nbPart", nouvelEvent.nbParticipants);
                cmd.Parameters.AddWithValue("@idClub", nouvelEvent.id_club);
                cmd.ExecuteReader();


            }
        }

        public Evenement ReadEvent(int id)
        {
            Evenement ThisEvent = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM evenement where id=@id";
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        ThisEvent = new Evenement(
                            (int)dataReader["id"],
                            (string)dataReader["typeEvent"],
                            (string)dataReader["nomEvent"],
                            (string)dataReader["adresseEvent"],
                            (int)dataReader["CPEvent"],
                            (string)dataReader["villeEvent"],
                            (string)dataReader["siteEvent"],
                            (DateTime)dataReader["dateDebutEvent"],
                            (DateTime)dataReader["dateFinEvent"],
                            (int)dataReader["nbParticipants"],
                            (int)dataReader["id_club"]);                        
                    }
                }
            }
            return ThisEvent;
        }

        public void UpdateEvent(Evenement ModifEvent)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE evenement SET typeEvent = @type, nomEvent = @nom, adresseEvent = @adresse, CPEvent = @CP, villeEvent = @ville, siteEvent = @site, dateDebutEvent = @dateDebut, dateFinEvent = @dateFin WHERE id = @id";


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", ModifEvent.id);
                cmd.Parameters.AddWithValue("@nom", ModifEvent.nomEvent);
                cmd.Parameters.AddWithValue("@type", ModifEvent.typeEvent);
                cmd.Parameters.AddWithValue("@adresse", ModifEvent.adresseEvent);
                cmd.Parameters.AddWithValue("@CP", ModifEvent.CPEvent);
                cmd.Parameters.AddWithValue("@ville", ModifEvent.villeEvent);
                cmd.Parameters.AddWithValue("@site", ModifEvent.siteEvent);
                cmd.Parameters.AddWithValue("@dateDebut", ModifEvent.dateDebutEvent);
                cmd.Parameters.AddWithValue("@dateFin", ModifEvent.dateFinEvent);
                cmd.ExecuteReader();
            }
        }
        
        /// <summary>
        /// InsertParticipant crée une occurence dans la table participants et incrémente le nombre de participants dans la table évènement
        /// </summary>
        /// <param name="idAdh"></param>
        /// <param name="idEvent"></param>
        /// <param name="idNONAdh"></param>
        public void InsertParticipant(int idAdh, int idEvent, int idNONAdh)
        {
            Int64 nb = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO participants (id_adherent, id_evenement, id_NA) VALUES (@adherent, @event, @NA)";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@adherent", idAdh);
                cmd.Parameters.AddWithValue("@event", idEvent);
                cmd.Parameters.AddWithValue("@NA", idNONAdh);
                cmd.ExecuteNonQuery();

                string query2 = "SELECT count(*) as nbPart FROM participants WHERE  id_evenement = @event";

                //Create Command
                cmd = new MySqlCommand(query2, connection);
                cmd.Parameters.AddWithValue("@event", idEvent);

                nb = (Int64)cmd.ExecuteScalar();             

                string query3 = "UPDATE evenement SET nbParticipants = @nb  WHERE  id = @event";

                //Create Command
                cmd = new MySqlCommand(query3, connection);
                cmd.Parameters.AddWithValue("@event", idEvent);
                cmd.Parameters.AddWithValue("@nb", nb);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Adherent> SelectAllEventNotAdherent(int idEvent, int idClub)
        {
            Adherent LeAdherent = null;
            List<Adherent> ListAdherent = new List<Adherent>();            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM adherent Where id_club = @club AND id NOT IN (SELECT id_adherent FROM participants WHERE id_evenement = @event) ORDER BY id ASC";
                                
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@club", idClub);
                cmd.Parameters.AddWithValue("@event", idEvent);


                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {     

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        LeAdherent = new Adherent(
                            (int)dataReader["id"],
                            (string)dataReader["nomAdh"],
                            (string)dataReader["prenomAdh"],
                            (DateTime)dataReader["naissance"],
                            (string)dataReader["sexe"],
                            (string)dataReader["numLicence"],
                            (string)dataReader["adresseAdh"],
                            (int)dataReader["CPAdh"],
                            (string)dataReader["villeAdh"],
                            (int)dataReader["cotisation"],
                            (int)dataReader["id_club"]);
                        ListAdherent.Add(LeAdherent);
                    }
                }
            }

            return ListAdherent;
        }

        public void InsertNA(string nomNA, string prenomNA, string telNA, int idEvent)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO non_adherents (nomNA, prenomNA, telephone, id_event) VALUES (@nom, @prenom, @tel, @idEvent)";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nom", nomNA);
                cmd.Parameters.AddWithValue("@prenom", prenomNA);
                cmd.Parameters.AddWithValue("@tel", telNA);
                cmd.Parameters.AddWithValue("@idEvent", idEvent);
                cmd.ExecuteNonQuery();
                             

            }
        }

        public NonAdherent ReadNA(string telNA, int idEvent)
        {
            NonAdherent ThisNA = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM non_adherents where telephone = @tel";
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tel", telNA);
                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        ThisNA = new NonAdherent(
                            (int)dataReader["id"],
                            (string)dataReader["nomNA"],
                            (string)dataReader["prenomNA"],
                            (string)dataReader["telephone"],
                            (int)dataReader["id_event"]);
                    }
                }
            }
            return ThisNA;
        }

        public List<Adherent> SelectAllEventAdherent(int idEvent, int idClub)
        {
            Adherent LeAdherent = null;
            List<Adherent> ListAdherent = new List<Adherent>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM adherent Where id_club = @club AND id IN (SELECT id_adherent FROM participants WHERE id_evenement = @event) ORDER BY id ASC";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@club", idClub);
                cmd.Parameters.AddWithValue("@event", idEvent);


                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        LeAdherent = new Adherent(
                            (int)dataReader["id"],
                            (string)dataReader["nomAdh"],
                            (string)dataReader["prenomAdh"],
                            (DateTime)dataReader["naissance"],
                            (string)dataReader["sexe"],
                            (string)dataReader["numLicence"],
                            (string)dataReader["adresseAdh"],
                            (int)dataReader["CPAdh"],
                            (string)dataReader["villeAdh"],
                            (int)dataReader["cotisation"],
                            (int)dataReader["id_club"]);
                        ListAdherent.Add(LeAdherent);
                    }
                }
            }

            return ListAdherent;
        }

        public List<NonAdherent> SelectAllEventNonAdherent(int idEvent)
        {
            NonAdherent LeNonAdherent = null;
            List<NonAdherent> ListNonAdherent = new List<NonAdherent>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM non_adherents Where id_event = @event  ORDER BY id ASC";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@event", idEvent);


                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        LeNonAdherent = new NonAdherent(
                            (int)dataReader["id"],
                            (string)dataReader["nomNA"],
                            (string)dataReader["prenomNA"],
                            (string)dataReader["telephone"],
                            (int)dataReader["id_event"]);
                        ListNonAdherent.Add(LeNonAdherent);
                    }
                }
            }

            return ListNonAdherent;
        }




    }
}
