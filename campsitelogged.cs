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
    public partial class campsitelogged : Form
    {
        string usname;
        public campsitelogged()
        {
            InitializeComponent();
        }
        public campsitelogged(string ussname)
        {
            InitializeComponent();
            usname = ussname;
        }

        private void buttontrendinglogged_Click(object sender, EventArgs e)
        {
            trendingcamplogged obj1 =new trendingcamplogged(usname);
            obj1.Show();
        }

        private void buttonpreflogged_Click(object sender, EventArgs e)
        {
            prefcamplogged obj1 =new prefcamplogged(usname);
            obj1.Show();
        }

        private void buttongoback_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
