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
    public partial class Firstaid : Form
    {
        string usname;
        public Firstaid()
        {
            InitializeComponent();
        }
        public Firstaid(string ussname)
        {
            InitializeComponent();
            usname = ussname;
        }
        private void buttongoback5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddtocartfirstaid2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Alcohol Pads',40,'{usname}');";
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

        private void buttonAddtocartfirstaid1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Bandage',20,'{usname}');";
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

        private void buttonAddtocartfirstaid3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Paracetamol',30,'{usname}');";
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

        private void buttonAddtocartfirstaid4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Anticeptic Ointment',50,'{usname}');";
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

        private void buttoncart4_Click(object sender, EventArgs e)
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
