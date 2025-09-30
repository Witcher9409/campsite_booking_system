using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace campsite
{
    public partial class mycart : Form
    {
        string usname;
        
        public mycart()
        {
            InitializeComponent();
        }
        public mycart(string ussname)
        {
            InitializeComponent();
            usname = ussname;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlConnection conn = null;
            labeltotal.Visible = true;
            label1.Visible = true;
            
            try
            {
                
                
                
                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"select Added_Items,Price,SUM(Price) as Total from Mycart6 where Uname='{usname}' GROUP BY Added_Items,Price;";
               
                

                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                //string val = dt.Rows[1]["Total"].ToString();
               // MessageBox.Show(val);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            try
            {



                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"select SUM(Price) as Total from Mycart6 where Uname='{usname}';";



                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string val = dt.Rows[0]["Total"].ToString();
                labeltotal.Text = val;
                // MessageBox.Show(val);
               // dataGridView1.DataSource = dt;
                //dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
           
            string Remove=textBox1.Text;
            
             
            SqlConnection conn = null;

            try
            {



                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"delete from Mycart6  where Uname='{usname}' and Added_Items='{Remove}';";



                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
               
                //string val = dt.Rows[1]["Total"].ToString();
                // MessageBox.Show(val);
                
                dataGridView1.Refresh();
                MessageBox.Show("Successfully removed from cart");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Remove failed");

            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            try
            {



                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"SELECT Uname FROM Mycart6 where Uname IS NOT NULL;";



                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
               
                DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["Uname"].ToString();
                if (dt.Rows.Count > 0)
                {
                    //Do your stuff here.

                    string val = dt.Rows[0]["Uname"].ToString();







                    payment aa = new payment(usname);
                    aa.Show();


                }
                else
                {
                    MessageBox.Show("Your Cart is Empty");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
