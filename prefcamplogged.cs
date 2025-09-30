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
    public partial class prefcamplogged : Form
    {
        string usname;
        public prefcamplogged()
        {
            InitializeComponent();
        }
        public prefcamplogged(string ussname)
        {
            InitializeComponent();
            usname = ussname;
        }

        private void buttonlakecamplogged_Click(object sender, EventArgs e)
        {
            lakeshorecampslogged obj1=new lakeshorecampslogged(usname);
            obj1.Show();
        }

        private void buttonhillsidelogged_Click(object sender, EventArgs e)
        {
            Hillsidecamplogged obj1=new Hillsidecamplogged(usname);
            obj1.Show();
        }

        private void buttonbeachsidelogged_Click(object sender, EventArgs e)
        {
            beachsidecamplogged obj1=new beachsidecamplogged(usname);
            obj1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            hoempage aa = new hoempage(usname);
            aa.Show();
            Close();
        }
    }
}
