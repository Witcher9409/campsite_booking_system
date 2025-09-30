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
    
    public partial class campsite : Form
    {
        
        public campsite()
        {
            InitializeComponent();
        }

        private void buttongoback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trendingcampsite obj1=new trendingcampsite();
            obj1.Show();
        }

        private void buttonLogin2_Click(object sender, EventArgs e)
        {
            prefcamp obj1=new prefcamp();
            obj1.Show();
        }
    }
}
