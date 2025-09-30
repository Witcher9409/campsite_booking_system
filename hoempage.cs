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
    public partial class hoempage : Form
    {
        string Username;
        string Password;
        
        public hoempage()
        {
            InitializeComponent();
        }
        public hoempage(string Uname)
        {
            InitializeComponent();
            Username = Uname;
            labelusername.Text = Username;
           // Password = password;
            //Password = password;
        }



        private void buttonProfile_Click(object sender, EventArgs e)
        {
            showdetails obj1=new showdetails(Username);
            obj1.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form1 obj6=new Form1();
            obj6.Show();
        }

        private void buttonBookcampsites_Click(object sender, EventArgs e)
        {
            campsitelogged obj1=new campsitelogged(Username);
            obj1.Show();
        }

        private void buttonContactus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For any queries please call or text the following numbers \n No1 : 01700928892 \n No2 : 01722334455");
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            marketplace obj1=new marketplace(Username);
            obj1.Show();
        }

        private void buttonPackageslogin_Click(object sender, EventArgs e)
        {
            packages obj1 = new packages(Username);
            obj1.Show();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            mycart obj1=new mycart(Username);
            obj1.Show();
        }
    }
}
