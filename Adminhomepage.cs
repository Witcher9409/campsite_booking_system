using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace campsite
{
    public partial class Adminhomepage : Form
    {
        string Password;
        public Adminhomepage()
        {
            InitializeComponent();
        }

        public Adminhomepage(string pword)
        {
            InitializeComponent();
           Password = pword;
        }

        private void Adminhomepage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Userdetailsadmin aa = new Userdetailsadmin();
            aa.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Close();
            loginpage aa = new loginpage();
            aa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Revenue aa = new Revenue();
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee aa = new Employee(Password);
            aa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Assetmanagement aa = new Assetmanagement(Password);
            aa.Show();
        }

        private void buttonAdminpro_Click(object sender, EventArgs e)
        {
            Adminprofile aa = new Adminprofile(Password);
            aa.Show();
        }
    }
}
