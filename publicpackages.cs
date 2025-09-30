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
    public partial class publicpackages : Form
    {
        public publicpackages()
        {
            InitializeComponent();
        }

        private void buttonBooknowbronze_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please log in first ");
            loginpage obj1 =new loginpage();
            obj1.Show();
        }

        private void buttonBooknowsilver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please log in first ");
            loginpage obj1 = new loginpage();
            obj1.Show();
        }

        private void buttonBooknowgold_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please log in first ");
            loginpage obj1 = new loginpage();
            obj1.Show();
        }

        private void buttongobackpackage_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
