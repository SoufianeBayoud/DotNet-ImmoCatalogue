using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoWEBProject
{
    internal class ImmoDAO
    {

        public List<Immo> immo { get; set; }
        static string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "DBList.mdf"));
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                        $"AttachDbFilename={info};" +
                        "Integrated Security=True;" +
                        "Connect Timeout=30";

        public List<Immo> getAlleImmo()
        {
            List<Immo> lijst = new List<Immo>();
            // we voegen nog geen functionaliteit aan de methode toe 
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT Id, Naam, Adres, Huisnummer, Gemeente, Prijs, Bouwjaar, Kamers, Grootte, Tuin, Type FROM Immo", connection);
            connection.Open();



            return lijst;
        }

        public List<Immo> getSearches(string searchTerm)
        {
            List<Immo> lijst = new List<Immo>();
            
            // we voegen nog geen functionaliteit aan de methode toe 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string OpteZoeken = "%" + searchTerm + "%";
            SqlCommand command = new SqlCommand("SELECT * FROM Immo WHERE Naam like @search", connection);
            command.Parameters.AddWithValue("@search", OpteZoeken);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lijst.Add(new Immo()
                    {
                        id = reader.GetInt32(0),
                        naam = reader.GetString(1),
                        straat = reader.GetString(2),
                        huisnummer = reader.GetInt32(3),
                        gemeente = reader.GetInt32(4),
                        prijs = Convert.ToSingle(reader.GetDouble(5)),
                        bouwjaar = reader.GetInt32(6),
                        kamers = reader.GetInt32(7),
                        grootte = reader.GetInt32(8),
                        tuin = reader.GetString(9),
                        type = reader.GetString(10),
                    });

                }
            }
            connection.Close();
            return lijst;
        }

        internal int DeleteImmo(int Id)
        {
            List<Immo> lijst = new List<Immo>();
            // we voegen nog geen functionaliteit aan de methode toe 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Immo WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", Id);

            int result = command.ExecuteNonQuery();
            connection.Close();



            return result;
        }



        public List<Immo> getOrderByDescending()
        {
            List<Immo> lijst = new List<Immo>();

            // we voegen nog geen functionaliteit aan de methode toe 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Immo ";
            command.Connection = connection;
           
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lijst.Add(new Immo()
                    {
                        id = reader.GetInt32(0),
                        naam = reader.GetString(1),
                        straat = reader.GetString(2),
                        huisnummer = reader.GetInt32(3),
                        gemeente = reader.GetInt32(4),
                        prijs = Convert.ToSingle(reader.GetDouble(5)),
                        bouwjaar = reader.GetInt32(6),
                        kamers = reader.GetInt32(7),
                        grootte = reader.GetInt32(8),
                        tuin = reader.GetString(9),
                        type = reader.GetString(10),
                    }); ;

                }
            }

            var query = from o in lijst
                        orderby o.prijs descending
                        select o;

            var x = query.ToList();

            connection.Close();
            return x;
        }


        public List<Immo> getOrderByAscending()
        {
            List<Immo> lijst = new List<Immo>();

            // we voegen nog geen functionaliteit aan de methode toe 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Immo ";
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lijst.Add(new Immo()
                    {
                        id = reader.GetInt32(0),
                        naam = reader.GetString(1),
                        straat = reader.GetString(2),
                        huisnummer = reader.GetInt32(3),
                        gemeente = reader.GetInt32(4),
                        prijs = Convert.ToSingle(reader.GetDouble(5)),
                        bouwjaar = reader.GetInt32(6),
                        kamers = reader.GetInt32(7),
                        grootte = reader.GetInt32(8),
                        tuin = reader.GetString(9),
                        type = reader.GetString(10),
                    }); ;

                }
            }

            var query = from o in lijst
                        orderby o.prijs ascending
                        select o;

            var x = query.ToList();

            connection.Close();
            return x;
        }

        public List<Immo> getOrderByRecentBouwjaar()
        {
            List<Immo> lijst = new List<Immo>();

            // we voegen nog geen functionaliteit aan de methode toe 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Immo ";
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lijst.Add(new Immo()
                    {
                        id = reader.GetInt32(0),
                        naam = reader.GetString(1),
                        straat = reader.GetString(2),
                        huisnummer = reader.GetInt32(3),
                        gemeente = reader.GetInt32(4),
                        prijs = Convert.ToSingle(reader.GetDouble(5)),
                        bouwjaar = reader.GetInt32(6),
                        kamers = reader.GetInt32(7),
                        grootte = reader.GetInt32(8),
                        tuin = reader.GetString(9),
                        type = reader.GetString(10),
                    }); ;

                }
            }

            var query = from o in lijst
                        orderby o.bouwjaar ascending
                        select o;

            var x = query.ToList();

            connection.Close();
            return x;
        }

        public List<Immo> getOrderByType()
        {
            List<Immo> lijst = new List<Immo>();

            // we voegen nog geen functionaliteit aan de methode toe 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Immo ";
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lijst.Add(new Immo()
                    {
                        id = reader.GetInt32(0),
                        naam = reader.GetString(1),
                        straat = reader.GetString(2),
                        huisnummer = reader.GetInt32(3),
                        gemeente = reader.GetInt32(4),
                        prijs = Convert.ToSingle(reader.GetDouble(5)),
                        bouwjaar = reader.GetInt32(6),
                        kamers = reader.GetInt32(7),
                        grootte = reader.GetInt32(8),
                        tuin = reader.GetString(9),
                        type = reader.GetString(10),
                    }); ;

                }
            }

            var query = from o in lijst
                        orderby o.type 
                        select o;

            var x = query.ToList();

            connection.Close();
            return x;
        }

    }
}
