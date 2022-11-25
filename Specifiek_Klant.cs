using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImmoWEBProject
{
    public partial class Specifiek_Klant : Form
    {

        
        public Specifiek_Klant()
        {
            InitializeComponent();
        }

        private void Delete_Client_Btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Id_label.Text);
            KlantDAO klantDAO = new KlantDAO();
            klantDAO.DeleteKlant(id);
            ImmoCatalogus immoCatalogus = new ImmoCatalogus();
            immoCatalogus.Show();
            this.Close();

        }

        private void Specifiek_Klant_Load(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            ImmoCatalogus immoCatalogus = new ImmoCatalogus();            
            this.Close();
            immoCatalogus.Show();
        }
    }
}
