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
    public partial class Assetmanagement : Form
    {
        string pass;
        public Assetmanagement()
        {
            InitializeComponent();
        }
        public Assetmanagement(string puss)
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

                string query = $"select *  from Assets;";



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

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBox1.Visible = true;
            buttonUpdate.Visible = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            radioButtonNR.Visible = true;
            radioButtonBA.Visible = true;
        }

        private void radioButtonNR_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNR.Checked)
            {
                label1.Visible = true;
                button3.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                label1.Visible = false;
                button3.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void radioButtonBA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBA.Checked)
            {
                label2.Visible = true;
                button3.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                button3.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                
                string update = textBox1.Text;


                string updateTarget = "";


                if (radioButtonNR.Checked) updateTarget = "Necessary_Renovations";
                else if (radioButtonBA.Checked) updateTarget = "Budget_Allocation";
                

                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"update Assets set {updateTarget} = '{textBox2.Text}' where Code_No = '{update}';";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                //DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["Password"].ToString();
                // dataGridView1.Refresh();
                MessageBox.Show("Succesfully updated  " + updateTarget);
                // label6.Visible = false;
                // textBox1.Visible = false;
                //  buttonUpdate.Visible = false;
                //  label10.Visible = false;
                //  textBoxall.Visible = false;
                //   button2.Visible = false;
                //   label8.Visible = false;
                //   radioButtonEname.Visible = false;
                //   radioButtonDesignation.Visible = false;
                //   radioButtonSal.Visible = false;
                //   radioButtonAddress.Visible = false;
                //Close();






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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
