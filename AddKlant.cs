using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImmoWEBProject
{
    public partial class AddKlant : Form
    {
        BindingSource klantBindingSource = new BindingSource();
        static string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "DBList.mdf"));
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                        $"AttachDbFilename={info};" +
                        "Integrated Security=True;" +
                        "Connect Timeout=30";
        //SqlConnection connexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
        //                            "AttachDbFilename=..\\Database\\DBList.mdf;" +
        //                            "Integrated Security=True;" +
        //                            "Connect Timeout=30");
        ImmoCatalogus immoCatalogus = new ImmoCatalogus();

        public AddKlant()
        {
            InitializeComponent();

        }
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string data { get; set; }
        }
        public void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void AddKlant_Load(object sender, EventArgs e)
        {

        }

        private void AddKlant_btn_Click(object sender, EventArgs e)
        {
            if (Naam_tb.Text == "" || Straat_tb.Text == "" || Nummer_tb.Text == "" || Email_TB.Text == "")
            {
                MessageBox.Show("Typ alle gegevens aub !");
            }
            else
            {
                try
                {
                    SqlConnection connexion = new SqlConnection(connectionString);
                    connexion.Open();
                    SqlCommand command = new SqlCommand("insert into Klanten values(@Naam, @Straat, @Huisnummer, @Email)", connexion);
                    command.Parameters.AddWithValue("@Naam", Naam_tb.Text);
                    command.Parameters.AddWithValue("@Straat", Straat_tb.Text);
                    command.Parameters.AddWithValue("@Huisnummer", Int32.Parse(Nummer_tb.Text));
                    command.Parameters.AddWithValue("@Email", Email_TB.Text);

                    command.ExecuteNonQuery();
                    connexion.Close();
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                insert();
            }

            this.Close();

        }

        private void Nummer_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nummer_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //To only allow numbers in this TextBox
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
    }
}
