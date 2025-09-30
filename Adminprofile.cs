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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace campsite
{
    public partial class Adminprofile : Form
    {
        string pass;
        public Adminprofile()
        {
            InitializeComponent();
        }
        public Adminprofile(string puss)
        {
            InitializeComponent();
            pass = puss;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            try
            {



                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"select Full_Name,Email,Phone_Number,Salary,Joining_Date  from Admin1;";



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
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string password=textBox1.Text;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = "select Apass from Admin1 where Aname = 'Admin'";

                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string val = dt.Rows[0]["Apass"].ToString();

                if (val == password)
                {
                    MessageBox.Show("Password is correct, you may change the information");
                    label1.Visible = true;
                    radioButtonEmail.Visible = true;
                    radioButtonPass.Visible = true;
                    radioButtonph.Visible = true;
                    label6.Visible = false;
                    textBox1.Visible=false;
                    buttonUpdate.Visible=false;
                    
                }
                else
                {
                    MessageBox.Show("Password doesn't match");


                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("username doesnot exist");
            }
            finally
            {
                //MessageBox.Show("Login Successfull");
                conn.Close();
            }
        }

        private void radioButtonEmail_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonEmail.Checked)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                label2.Visible = false;
                textBox2.Visible = false;
                button3.Visible = false;
            }
        }

        private void radioButtonPass_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPass.Checked)
            {
                label3.Visible = true;
                textBox2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                label3.Visible = false;
                textBox2.Visible = false;
                button3.Visible = false;
            }
        }

        private void radioButtonph_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonph.Checked)
            {
                label4.Visible = true;
                textBox2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox2.Visible = false;
                button3.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {

                string update = textBox2.Text;
                string updateTarget = "";


                if (radioButtonEmail.Checked) updateTarget = "Email";
                else if (radioButtonPass.Checked) updateTarget = "Apass";
                else if (radioButtonph.Checked) updateTarget = "Phone_Number";


                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"update Admin1 set {updateTarget} = '{update}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                //DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["Password"].ToString();
                // dataGridView1.Refresh();
                MessageBox.Show("Succesfully updated  " + updateTarget);
                






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("User doesnot exist");
            }
            finally
            {
                //MessageBox.Show("Login Successfull");
                //Usname = textBoxUpdateuname.Text;
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBox1.Visible = true;
            buttonUpdate.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
