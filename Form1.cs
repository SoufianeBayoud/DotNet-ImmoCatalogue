namespace ImmoWEBProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public bool EnableButton
        {
            set
            {
                GoToApp_Btn.Enabled = value;
            }
        }
        private void GoToApp_Btn_Click(object sender, EventArgs e)
        {
            ImmoCatalogus child = new ImmoCatalogus(this);
            child.MdiParent = this;
            GoToApp_Btn.Enabled = false;
            GoToApp_Btn.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;

            
            child.Show();
            
        }

        public void Shutdown()
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}