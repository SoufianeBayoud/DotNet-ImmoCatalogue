using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImmoWEBProject
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void Email_button_Click(object sender, EventArgs e)
        {
            // Werkt ! Ik heb methode gebruikt om outlook mails (gmails is een ander manier) te sturen aangezien ons school email gelinkt is aan outlook
            // Voor Gmail is het een ander manier

            ImmoCatalogus immo = new ImmoCatalogus();
            Specifieke_Immo SpecImmo = new Specifieke_Immo();
            if (Email_tb.Text == "" || Subject_tb.Text == "" || Body_tb.Text == "")
            {
                MessageBox.Show("Alles moet ingevuld worden !");
            }
            else
            {
                try
                {
                    SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com");
                    smtpClient.Port = 587;

                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    System.Net.NetworkCredential cd = new System.Net.NetworkCredential("soufiane.bayoud@student.ehb.be", "Abdelmajid/1");
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = cd;
                    MailMessage mail = new MailMessage("soufiane.bayoud@student.ehb.be", Email_tb.Text);
                    mail.Subject = Subject_tb.Text;
                    mail.Body = Body_tb.Text;
                    smtpClient.Send(mail);
                    this.Close();
                    MessageBox.Show("Email has been sent !");

                }
                catch (Exception)
                {
                    throw;
                }

                this.Close();
                immo.Show();

            }
        }

        private void EmailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
