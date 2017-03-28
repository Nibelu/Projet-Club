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
    }
}
