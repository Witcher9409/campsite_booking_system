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
    public partial class marketplace : Form
    {
        string usname;
        public marketplace()
        {
            InitializeComponent();
        }
        public marketplace(string ussname)
        {
            InitializeComponent();
            usname = ussname;
        }

        private void buttonFooditems_Click(object sender, EventArgs e)
        {
            foodbeverage obj1=new foodbeverage(usname);
            obj1.Show();
        }

        private void buttonCampingequipments_Click(object sender, EventArgs e)
        {
            Campeqipments obj1=new Campeqipments(usname);
            obj1.Show();
        }

        private void buttonUtilities_Click(object sender, EventArgs e)
        {
            utilities obj1 = new utilities(usname);
            obj1.Show();
        }

        private void buttonFirstaid_Click(object sender, EventArgs e)
        {
            Firstaid obj1 = new Firstaid(usname);
            obj1.Show();
        }

        private void buttongoback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttoncartmarket_Click(object sender, EventArgs e)
        {
            mycart aa = new mycart(usname);
            aa.Show();
        }
    }
}
