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
    public partial class Lakeshorecamps : Form
    {
        public Lakeshorecamps()
        {
            InitializeComponent();
        }

        private void buttonbooknow2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please login first to book");
            loginpage obj2=new loginpage();
            obj2.Show();
        }

        private void buttongobac2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
