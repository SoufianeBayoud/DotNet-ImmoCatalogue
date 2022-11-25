using DocumentFormat.OpenXml.EMMA;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ImmoWEBProject
{
    public partial class ImmoCatalogus : Form
    {
        static string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "DBList.mdf"));

        Form1 form1 = new Form1();
        BindingSource BindingSource = new BindingSource();
        public ImmoCatalogus()
        {
            InitializeComponent();
            dataGridView2.AllowUserToAddRows = false;
            dataGridView1.AllowUserToAddRows = false;

        }

        public ImmoCatalogus(Form1 form1)
        {
            InitializeComponent();

        }

        private void Child_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.MdiParent as Form1).EnableButton = true;
        }

        private void ImmoCatalogus_Load(object sender, EventArgs e)
        {
           
            datagridConnect();
            datagrid2Connect();

        }

        private void updateDG(object sender, AddKlant.UpdateEventArgs args)
        {
            datagridConnect();
        }
        private void updateDG2(object sender, AddImmo.UpdateEventArgs args)
        {
            datagrid2Connect();
        }


        public void datagridConnect()
        {

            string infoConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                    $"AttachDbFilename={info};" +
                                    "Integrated Security=True;" +
                                    "Connect Timeout=30";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Klanten", infoConnection);
            DataTable databaselist = new DataTable();
            sqlDataAdapter.Fill(databaselist);
            dataGridView1.DataSource = databaselist;
        }
        public void datagrid2Connect()
        {
            string infoConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                    $"AttachDbFilename={info};" +
                                    "Integrated Security=True;" +
                                    "Connect Timeout=30";

            SqlDataAdapter sqldataAdapter = new SqlDataAdapter("SELECT * FROM Immo", infoConnection);
            DataTable dblist = new DataTable();
            sqldataAdapter.Fill(dblist);
            dataGridView2.DataSource = dblist;
        }


        private void afsluitenCtrlfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.Shutdown();
        }

        private void addKlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddKlant addKlant = new AddKlant();
            addKlant.UpdateEventHandler += updateDG;
            addKlant.Show();
        }

   

        private void addWoningToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            AddImmo addimmo = new AddImmo();
            addimmo.UpdateEventHandler += updateDG2;
            addimmo.Show();
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            if (Search_TBox.Text == "")
            {
                MessageBox.Show("Vul iets in de searchbar ! ");
                KlantDAO klantDAO = new KlantDAO();

                dataGridView1.DataSource = BindingSource;
            }
            else
            {
                KlantDAO klantDAO = new KlantDAO();
                BindingSource.DataSource = klantDAO.getSearches(Search_TBox.Text);
                dataGridView1.DataSource = BindingSource;
            }
        }

     
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int currentRow = dataGridView.CurrentRow.Index;
            KlantDAO klantDAO = new KlantDAO();
            Specifiek_Klant klant = new Specifiek_Klant();
            klant.Id_label.Text = dataGridView.Rows[currentRow].Cells[0].Value.ToString();
            klant.Naam_label.Text = dataGridView.Rows[currentRow].Cells[1].Value.ToString();
            klant.Straat_label.Text = dataGridView.Rows[currentRow].Cells[2].Value.ToString();
            klant.Nummer_label.Text = dataGridView.Rows[currentRow].Cells[3].Value.ToString();
            klant.Email_label.Text = dataGridView.Rows[currentRow].Cells[4].Value.ToString();

            klant.Show();
            this.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int currentRow = dataGridView.CurrentRow.Index;
            ImmoDAO immoDAO = new ImmoDAO();
            Specifieke_Immo immo = new Specifieke_Immo();
            immo.Id_label.Text = dataGridView.Rows[currentRow].Cells[0].Value.ToString();
            immo.Naam_label.Text = dataGridView.Rows[currentRow].Cells[1].Value.ToString();
            immo.Straat_label.Text = dataGridView.Rows[currentRow].Cells[2].Value.ToString();
            immo.Nummer_label.Text = dataGridView.Rows[currentRow].Cells[3].Value.ToString();
            immo.Gemeente_label.Text = dataGridView.Rows[currentRow].Cells[4].Value.ToString();
            immo.Prijs_label.Text = dataGridView.Rows[currentRow].Cells[5].Value.ToString();
            immo.Bouwjaar_label.Text = dataGridView.Rows[currentRow].Cells[6].Value.ToString();
            immo.Kamers_label.Text = dataGridView.Rows[currentRow].Cells[7].Value.ToString();
            immo.Grootte_label.Text = dataGridView.Rows[currentRow].Cells[8].Value.ToString();
            immo.Tuin_label.Text = dataGridView.Rows[currentRow].Cells[9].Value.ToString();
            immo.Type_label.Text = dataGridView.Rows[currentRow].Cells[10].Value.ToString();

            immo.Show();
            this.Close();

 
        }

        public void Test()
        {
            ImmoDAO immoDAO = new ImmoDAO();
            dataGridView2.DataSource = null;
            immoDAO.getAlleImmo();

        }

        private void AantalWoningen_Btn_Click(object sender, EventArgs e)
        {
            int Count = dataGridView2.Rows
                .Cast<DataGridViewRow>()
                .Select(row => row.Cells["Id"].Value)
                .Count(s => s != null);

            MessageBox.Show("Aantal Immos momenteel : " + Count.ToString());
        }

        private void AantalKlanten_Btn_Click(object sender, EventArgs e)
        {
            int Count = dataGridView1.Rows
              .Cast<DataGridViewRow>()
              .Select(row => row.Cells["Id"].Value)
              .Count(s => s != null);

            MessageBox.Show("Aantal Klanten momenteel : " + Count.ToString());
        }

        

        private void LinqOrderBy_Click_1(object sender, EventArgs e)
        {
            ImmoDAO immo = new ImmoDAO();
            BindingSource.DataSource = immo.getOrderByDescending();
            dataGridView2.DataSource = BindingSource;
        }

        private void LingOrderAscending_Click(object sender, EventArgs e)
        {
            ImmoDAO immo = new ImmoDAO();
            BindingSource.DataSource = immo.getOrderByAscending();
            dataGridView2.DataSource = BindingSource;
        }

        private void OrderByBouwjaarRecent_Btn_Click(object sender, EventArgs e)
        {
            ImmoDAO immo = new ImmoDAO();
            BindingSource.DataSource = immo.getOrderByRecentBouwjaar();
            dataGridView2.DataSource = BindingSource;
        }

        private void OrderByType_Btn_Click(object sender, EventArgs e)
        {
            ImmoDAO immo = new ImmoDAO();
            BindingSource.DataSource = immo.getOrderByType();
            dataGridView2.DataSource = BindingSource;
        }

        private void Immo_Search_Btn_Click(object sender, EventArgs e)
        {
            if (Search_TBox1.Text == "")
            {
                MessageBox.Show("Vul iets in de searchbar ! ");
                ImmoDAO immo = new ImmoDAO();

                dataGridView2.DataSource = BindingSource;
            }
            else
            {
                ImmoDAO immoDAO = new ImmoDAO();
                BindingSource.DataSource = immoDAO.getSearches(Search_TBox1.Text);
                dataGridView2.DataSource = BindingSource;
            }
        }
    }
}
