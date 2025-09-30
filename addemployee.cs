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
    public partial class addemployee : Form
    {
        string pass;
        public addemployee()
        {
            InitializeComponent();
        }
        public addemployee(string puss)
        {
            InitializeComponent();
            pass = puss;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string Empname = textBoxEmpname.Text;
            string Designation = textBoxEmpdes.Text;
            string salary = textBoxEmpsal.Text;
            string Address = textBoxEmpaddress.Text;
            string Date = dateTimePicker1.Text;
            


            if (textBoxEmpname.Text != null &&
                textBoxEmpdes.Text != null &&
                textBoxEmpsal.Text != null &&
                textBoxEmpaddress.Text != null )
            {
                MessageBox.Show("Employee added");


                SqlConnection conn = null;
                try
                {






                    conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                    conn.Open();

                    string query = $"INSERT INTO Employees(Ename,Designation,Salary,Address,Joining_Date) VALUES ('{Empname}','{Designation}','{salary}','{Address}','{Date}');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    //DataTable dt = ds.Tables[0];
                    //string val = dt.Rows[0]["Password"].ToString();
                    Close();



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
               


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBox1.Visible = true;
            buttonUpdate.Visible = true;


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            radioButtonEname.Visible = true;
             radioButtonDesignation.Visible = true;
             radioButtonSal.Visible = true;
             radioButtonAddress.Visible = true;

            label6.Visible = false;
            textBox1.Visible = false;
            buttonUpdate.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                string updateUname = textBox1.Text;


                string updateTarget = "";


                if (radioButtonEname.Checked) updateTarget = "Ename";
                else if (radioButtonDesignation.Checked) updateTarget = "Designation";
                else if (radioButtonSal.Checked) updateTarget = "Salary";
                else if (radioButtonAddress.Checked) updateTarget = "Address";


                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True`");
                conn.Open();

                string query = $"update Employees set {updateTarget} = '{textBoxall.Text}' where Ename = '{updateUname}';";
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
              //  Close();

               
                



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

        private void radioButtonEname_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEname.Checked)
            {
                label10.Visible = true;
                textBoxall.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                label10.Visible = false;
                textBoxall.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
        }

        private void radioButtonDesignation_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDesignation.Checked)
            {
                label7.Visible = true;
                textBoxall.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            else 
            {
                label7.Visible = false;
                textBoxall.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
        }

        private void radioButtonSal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSal.Checked)
            {
                label8.Visible = true;
                textBoxall.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            else 
            {
                label8.Visible = false;
                textBoxall.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
        }

        private void radioButtonAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAddress.Checked)
            {
                label9.Visible = true;
                textBoxall.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            else 
            {
                label9.Visible = false;
                textBoxall.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBox1.Visible = true;
            buttonUpdate.Visible = true;

            label10.Visible = false;
            textBoxall.Visible=false;
            button2.Visible=false;
            label8.Visible = false;
            button3.Visible=false;
            label9.Visible=false;
            label7.Visible=false;
            
           // Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
