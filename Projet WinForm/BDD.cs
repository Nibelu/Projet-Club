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



        /// <summary>
        /// La méthode Read retourne un fournisseur en fonction de l'id dans la table. 
        /// </summary>
        /// <param name="id">id du fournisseur recherché</param>
        /// <returns></returns>
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

        // selection d'un evenement avec l'id
        public Evenement ReadEvent(int id)
        {
            Evenement lEvenement = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Evenement where id=@id";//vérifier le nom de la table evenement


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", id);

                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        lEvenement = new Evenement(/*
                            (string)dataReader["nomClub"],
                            (string)dataReader["adressClub"],
                            (int)dataReader["CPClub"],
                            (string)dataReader["villeClub"],
                            (string)dataReader["telephone"],
                            (string)dataReader["mail"],
                            (string)dataReader["siteClub"]*/);//renseigner les champs par rapport a evenement
                    }

                }

            }

            return lEvenement;


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
    }
}
