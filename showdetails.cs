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
    public partial class showdetails : Form
    {
        string Usname;
        public showdetails()
        {
            InitializeComponent();
        }

        public showdetails(string ussname)
        {
            InitializeComponent();
            Usname = ussname;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"select Fname,Lname,Email,Uname,Phonenum,Gender,[Date of birth] from Registration where Uname='{Usname}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["X"].ToString();
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonchangeinfo_Click(object sender, EventArgs e)
        {
            changeuserinfo aa = new changeuserinfo(Usname);
            aa.Show();
            
            
           
        }

        private void buttonSubmit69_Click(object sender, EventArgs e)
        {
           
            }
        

        private void radioButtonusername_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonemail_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonpassword_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            orderhistory aa = new orderhistory(Usname);
            aa.Show();
        }

        private void textBoxUpdateuname_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

