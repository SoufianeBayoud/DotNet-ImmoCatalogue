using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoWEBProject
{
    internal class KlantDAO
    {
        //version 1 only contains fake data
        public List<Klant> klant { get; set; }
        static string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "DBList.mdf"));
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                        $"AttachDbFilename={info};" +
                        "Integrated Security=True;" +
                        "Connect Timeout=30";

        public List<Klant> getSearches(string searchTerm)
        {
            List<Klant> lijst = new List<Klant>();

            // we voegen nog geen functionaliteit aan de methode toe 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string OpteZoeken = "%" + searchTerm + "%";
            SqlCommand command = new SqlCommand("SELECT * FROM Klanten WHERE Naam like @search", connection);
            command.Parameters.AddWithValue("@search", OpteZoeken);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lijst.Add(new Klant()
                    {
                        id = reader.GetInt32(0),
                        naam = reader.GetString(1),
                        straat = reader.GetString(2),
                        huisnummer = reader.GetInt32(3),
                        email = reader.GetString(4)
                    });

                }
            }
            connection.Close();
            return lijst;
        }

        public List<Klant> getAlleInfo(int Id)
        {
            List<Klant> lijst = new List<Klant>();

            // we voegen nog geen functionaliteit aan de methode toe 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            
            SqlCommand command = new SqlCommand("SELECT * FROM Klanten WHERE Id like @Id", connection);
            command.Parameters.AddWithValue("@Id", Id);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lijst.Add(new Klant()
                    {
                        id = reader.GetInt32(0),
                        naam = reader.GetString(1),
                        straat = reader.GetString(2),
                        huisnummer = reader.GetInt32(3),
                        email = reader.GetString(4)
                    });

                }
            }



            connection.Close();
            return lijst;
        }

        internal int DeleteKlant(int KlantId)
        {
            List<Klant> lijst = new List<Klant>();
            // we voegen nog geen functionaliteit aan de methode toe 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Klanten WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", KlantId);

            int result = command.ExecuteNonQuery();
            connection.Close();



            return result;
        }
    }
}
