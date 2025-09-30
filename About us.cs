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
    public partial class About_us : Form
    {
        public About_us()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text= "We are a leading camping franchise corporation providing a “Best in Class” customer experience with the goal to be 'world’s best camping experience provider'. Through our website camper can explore, research, compare prices and book a wide range of services catering to their camping needs. Since our inception in 2008, more than 1 million customers have used one or more of our comprehensive services, which include international lucrative holiday packages.\r\nA strong and \"trusted\" camping brand across the world, our strengths include a large and loyal customer base, a multi-channel platform for cozy campers, a strong infrastructure designed to deliver a high level of sustainability and eco-friendly environment and a seasoned senior management team comprising of industry executives with deep roots in the camping industry.\r\nWildland Camping Grounds was ranked “One of The Most Trusted E-Commerce Camping Brand” in the world in the Corbs in 2014 for the second successive year and has won the International base camp award for 'Best campsite Operator ' conferred by the International Camping site organization in year 2016.\r\nCommunity guidelines\r\n•    Privacy: Invading the privacy of others in not allowed.\r\n•    Illegal Activities: Any kind of illegal activity in the campsites is strictly prohibited.\r\n•    Integrity & Security: Interfering with the integrity and security of our services is illegal.\r\n•    Misinformation: spreading contents that contains, endorses, or perpetuates Potentially Harmful Misinformation is prohibited.";
        }
    }
}
