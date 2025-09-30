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
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            Form2 obj2 = new Form2();
            obj2.Show();
        }

        private void buttonGoback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin2_Click(object sender, EventArgs e)
        {
            string username = textBoxLuname.Text;
            string password = textBoxLpass.Text;

           
            if (username != "Admin")
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                    conn.Open();

                    string query = "select Password from Registration where Uname = '" + username + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    string val = dt.Rows[0]["Password"].ToString();

                    if (val == password)
                    {
                        MessageBox.Show("Login Successfull");
                        hoempage obj5 = new hoempage(username);
                        obj5.Show();
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

            else if(username =="Admin")
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                    conn.Open();

                    string query = "select Apass from Admin1 where Aname = '" + username + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    string val = dt.Rows[0]["Apass"].ToString();

                    if (val == password)
                    {
                        MessageBox.Show("Login Successfull");
                        Adminhomepage obj1= new Adminhomepage(username);
                        obj1.Show();
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

          

        }

        private void buttonForgotpassword_Click(object sender, EventArgs e)
        {
            buttonForgotpassword.Visible = false;
            label12.Visible = true;
            label3.Visible = true;
            textBoxHint.Visible = true;
            buttoncluesubmit.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            //label1.Visible =false;
            label2.Visible = false;
            //textBoxLuname.Visible = false;
            textBoxLpass.Visible = false;
            buttonLogin2.Visible = false;
            buttonSignup.Visible = false;
        }

        private void textBoxHint_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncluesubmit_Click(object sender, EventArgs e)
        {
            string username = textBoxLuname.Text;
            string cluee=textBoxHint.Text;
            

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = "select * from Registration where column_clue = '" + cluee + "' and Uname='"+username+"';";

                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string val = dt.Rows[0]["column_clue"].ToString();
                //textBoxLpass.Text = val;
                if (val == cluee)
                {
                    label4.Visible = true;
                    label5.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    button1.Visible = true;
                    label1.Visible = false;
                    label2.Visible = false;
                    textBoxLuname.Visible = false;
                    textBoxLpass.Visible = false;
                    buttonLogin2.Visible = false;
                    buttonSignup.Visible = false;
                    label3.Visible = false;
                    label12.Visible = false;
                    textBoxHint.Visible = false;
                    buttoncluesubmit.Visible = false;
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

        private void textBoxLpass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBoxLuname != null) && (textBox1.Text == textBox2.Text))
            {
                SqlConnection conn = null;
                try
                {
                    string updatepass = textBox1.Text;
                    string usname = textBoxLuname.Text;








                    conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                    conn.Open();

                    string query = $"update registration set Password = '{updatepass}' where Uname = '{usname}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    //DataTable dt = ds.Tables[0];
                    //string val = dt.Rows[0]["Password"].ToString();
                    //dataGridView1.Refresh();
                    MessageBox.Show("Succesfully updated  password");
                    label4.Visible = false;
                    label5.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    button1.Visible = false;
                    buttoncluesubmit.Visible=false;
                    label1.Visible = true;
                    label2.Visible = true;
                    textBoxLuname.Visible = true;
                    textBoxLpass.Visible = true;
                    buttonLogin2.Visible = true;
                    buttonSignup.Visible = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   // MessageBox.Show("password doesnt match exist");
                }
                finally
                {
                    //MessageBox.Show("Login Successfull");
                    //Usname = textBoxUpdateuname.Text;
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password and confirm password does'nt match");
            }
        }
    }
}
