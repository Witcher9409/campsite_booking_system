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
    public partial class changeuserinfo : Form
    {
        string usname;
        public changeuserinfo()
        {
            InitializeComponent();
        }
        public changeuserinfo(string ussname)
        {
            InitializeComponent();
            usname = ussname;
        }

        private void buttonSubmit69_Click(object sender, EventArgs e)
        {
            


            SqlConnection conn = null;
            try
            {
                string updateUname = textBoxUpdateuname.Text;


                string updateTarget = "";


                if (radioButtonusername.Checked) updateTarget = "Uname";
                else if (radioButtonemail.Checked) updateTarget = "Email";
                else if (radioButtonpassword.Checked) updateTarget = "Password";


                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"update registration set {updateTarget} = '{textBoxUpdateuname.Text}' where Uname = '{usname}';";
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
                usname = textBoxUpdateuname.Text;
                conn.Close();
            }
        }

        private void radioButtonusername_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonusername.Checked)
            {
                label2.Visible = true;
                textBoxUpdateuname.Visible = true;
                buttonSubmit69.Visible = true;
            }
            else
            {
                label2.Visible = false;
                textBoxUpdateuname.Visible = false;
                buttonSubmit69.Visible = false;
            }
        }

        private void radioButtonemail_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonemail.Checked)
            {
                label3.Visible = true;
                textBoxUpdateuname.Visible = true;
                buttonSubmit69.Visible = true;
            }
            else
            {
                label3.Visible = false;
                textBoxUpdateuname.Visible = false;
                buttonSubmit69.Visible = false;
            }
        }

        private void radioButtonpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonpassword.Checked)
            {
                label4.Visible = true;
                textBoxUpdateuname.Visible = true;
                buttonSubmit69.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBoxUpdateuname.Visible = false;
                buttonSubmit69.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
