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
    public partial class Hillsidecamplogged : Form
    {
        string usname;
        public Hillsidecamplogged()
        {
            InitializeComponent();
        }

        public Hillsidecamplogged(string ussname)
        {
            InitializeComponent();
            usname = ussname;
        }

        private void buttongoback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonaddtocarthillsidelogged1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Cloud 5 Campsite',10000,'{usname}');";
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

        private void buttonaddtocarthillsidelogged2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Mount Snow Campsite',9000,'{usname}');";
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

        private void buttonaddtocarthillsidelogged3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Devils Peak Campsite',12000,'{usname}');";
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
            mycart aa = new mycart(usname);
            aa.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            hoempage aa = new hoempage(usname);
            aa.Show();
            Close();
        }
    }
}
