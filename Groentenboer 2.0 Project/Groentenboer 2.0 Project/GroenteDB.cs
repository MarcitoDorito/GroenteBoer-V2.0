using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groentenboer_2._0_Project
{
    public class DatabaseHelper
    {
        private string ConnectionString { get; }

        public DatabaseHelper(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public class GroenteNaam
        {
            public string productNaam;
            public int prijs;
            public Bitmap plaatje;
        }
        public List<GroenteNaam> GetGroenten()
        {
            var groentenLijst = new List<GroenteNaam>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM producten";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        var groenten = reader["productNaam"].ToString();
                        var x = new GroenteNaam();
                        x.productNaam = groenten;
                        x.prijs = (int)reader["prijs"];
                        decimal d = new decimal(x.prijs);
                        x.plaatje = (Bitmap) Properties.Resources.ResourceManager.GetObject(reader["productNaam"].ToString());

                        groentenLijst.Add(x);

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            Console.WriteLine(groentenLijst);
            return groentenLijst;
        }
    }
}
