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
    public partial class trendingcampsite : Form
    {
        public trendingcampsite()
        {
            InitializeComponent();
        }
        



        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonbooknow_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Please login first to book ");
            loginpage obj3 = new loginpage();
            MessageBox.Show("Please login first to book ");
            obj3.Show();
        }

        private void buttongobac_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
