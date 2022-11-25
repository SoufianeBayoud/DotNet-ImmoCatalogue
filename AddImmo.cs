using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImmoWEBProject
{
    public partial class AddImmo : Form
    {
        //SqlConnection connexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
        //                            "AttachDbFilename=..\\Database\\DBList.mdf;" +
        //                            "Integrated Security=True;" +
        //                            "Connect Timeout=30");
        static string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "DBList.mdf"));
        string connexion = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                        $"AttachDbFilename={info};" +
                        "Integrated Security=True;" +
                        "Connect Timeout=30";
        ImmoCatalogus immoCatalogus = new ImmoCatalogus();

        public AddImmo()
        {
            InitializeComponent();
            

            
        }
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string data { get; set; }
        }
        protected void insert()
        {
          
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void AddImmo_Btn_Click(object sender, EventArgs e)
        {
            
            if (Naam_tb.Text == "" || Straat_tb.Text == "" || Nummer_tb.Text == "" || Gemeente_tb.Text == "" || Bouwjaar_tb.Text =="" || Kamers_tb.Text == "" || Type_tb.Text =="" || Grootte_tb.Text == "" || Prijs_tb.Text =="" || Tuin_tb.Text =="")
            {
                MessageBox.Show("Typ alle gegevens aub !");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(connexion);
                    conn.Open();
                    SqlCommand command = new SqlCommand("insert into Immo values(@Naam, @Straat, @Huisnummer, @Gemeente, @Prijs, @Bouwjaar, @Kamers, @Grootte, @Tuin, @Type)", conn);
                    command.Parameters.AddWithValue("@Naam", Naam_tb.Text);
                    command.Parameters.AddWithValue("@Straat", Straat_tb.Text);
                    command.Parameters.AddWithValue("@Huisnummer", Int32.Parse(Nummer_tb.Text));
                    command.Parameters.AddWithValue("@Gemeente", Int32.Parse(Gemeente_tb.Text));
                    command.Parameters.AddWithValue("@Prijs", Int32.Parse(Prijs_tb.Text));
                    command.Parameters.AddWithValue("@Bouwjaar", Int32.Parse(Bouwjaar_tb.Text));
                    command.Parameters.AddWithValue("@Kamers", Int32.Parse(Kamers_tb.Text));
                    command.Parameters.AddWithValue("@Grootte", Int32.Parse(Grootte_tb.Text));
                    command.Parameters.AddWithValue("@Tuin", Tuin_tb.Text);
                    command.Parameters.AddWithValue("@Type", Type_tb.Text);
                    //immoCatalogus.dataGridView2.Update();
                    //immoCatalogus.dataGridView2.Refresh();
                    //immoCatalogus.datagrid2Connect();



                    command.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                
                insert();
            }
            this.Close();
        }

        private void Nummer_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //To only allow numbers in this TextBox

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Gemeente_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //To only allow numbers in this TextBox
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Bouwjaar_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //To only allow numbers in this TextBox
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Grootte_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //To only allow numbers in this TextBox
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void Kamers_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //To only allow numbers in this TextBox
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Prijs_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //To only allow numbers in this TextBox
            //if (!char.IsNumber(e.KeyChar) || e.KeyCode == Keys.Back)
            //{
            //    e.Handled = true;
            //}
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void AddImmo_Load(object sender, EventArgs e)
        {

        }
    }
}
