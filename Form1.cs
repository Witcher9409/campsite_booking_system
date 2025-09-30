namespace campsite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        

        private void buttonSignup_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxLuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginpage obj1=new loginpage();
            obj1.Show();
        }

        private void buttonCampsites_Click(object sender, EventArgs e)
        {
            campsite obj1=new campsite();
            obj1.Show();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About_us obj1= new About_us();
            obj1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            publicpackages obj1=new publicpackages();
            obj1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }
    }
}