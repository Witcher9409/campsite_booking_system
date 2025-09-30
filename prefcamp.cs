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
    public partial class prefcamp : Form
    {
        public prefcamp()
        {
            InitializeComponent();
        }

        private void buttonlakecamp_Click(object sender, EventArgs e)
        {
            Lakeshorecamps OBJ1 = new Lakeshorecamps();
            OBJ1.Show();
        }

        private void buttonhillside_Click(object sender, EventArgs e)
        {
            Hillsidecamps OBJ1 = new Hillsidecamps();
            OBJ1.Show();
        }

        private void buttonbeachside_Click(object sender, EventArgs e)
        {
            Beachsidecamps OBJ1 = new Beachsidecamps();
            OBJ1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
