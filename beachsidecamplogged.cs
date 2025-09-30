using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace campsite
{
    
    public partial class beachsidecamplogged : Form
    {
        string Usname;
        public beachsidecamplogged()
        {
            InitializeComponent();
        }

        public beachsidecamplogged (string ussname)
        {
            InitializeComponent();
            Usname = ussname;
        }

        private void buttonGobackbeachsidelogged_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonaddtocartbeachlogged1_Click(object sender, EventArgs e)
        {
           
            
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {
                


               


                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Red Lantern Campsite',7000,'{Usname}');";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                //DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["Password"].ToString();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("User doesnot exist");
            }
            finally
            {
                //MessageBox.Show("Login Successfull");
               
                conn.Close();
            }

        }

        private void buttonaddtocartbeachlogged2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Pajeet Beach Campsite',9000,'{Usname}');";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                //DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["Password"].ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("User doesnot exist");
            }
            finally
            {
                //MessageBox.Show("Login Successfull");

                conn.Close();
            }
        }

        private void buttonaddtocartbeachlogged3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Mermaid Beach Campsite',15000,'{Usname}');";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                //DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["Password"].ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("User doesnot exist");
            }
            finally
            {
                //MessageBox.Show("Login Successfull");

                conn.Close();
            }
        }

        private void buttonmycart_Click(object sender, EventArgs e)
        {
            mycart aa = new mycart(Usname);
            aa.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            hoempage aa = new hoempage(Usname);
            aa.Show();
            Close();
        }
    }
}
