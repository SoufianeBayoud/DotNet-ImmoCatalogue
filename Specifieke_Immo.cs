using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using static Aspose.Email.Clients.TokenProvider;

namespace ImmoWEBProject
{
    public partial class Specifieke_Immo : Form
    {
        public Specifieke_Immo()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Contact_Btn_Click(object sender, EventArgs e)
        {
            
            EmailForm emailform = new EmailForm();
            emailform.Show();
            


        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {

            int id = int.Parse(Id_label.Text);
            ImmoDAO immo = new ImmoDAO();
            immo.DeleteImmo(id);
            ImmoCatalogus immoCatalogus = new ImmoCatalogus();
            immoCatalogus.Show();
            this.Close();

        }

        private void Specifieke_Immo_Load(object sender, EventArgs e)
        {
        }

        private void Go_Back_Btn_Click(object sender, EventArgs e)
        {
            ImmoCatalogus immoCatalogus = new ImmoCatalogus();
            this.Close();
            immoCatalogus.Show();
        }
    }
}
