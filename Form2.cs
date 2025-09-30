using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace campsite
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyy";
        }

        

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string Fname=textBoxFname.Text;
            string Lname=textBoxLname.Text;
            string Email=textBoxEmail.Text;
            string Uname=textBoxRuname.Text;
            string Pass=textBoxRpass.Text;
            string Phone=textBoxPhone.Text;
            string Bdate=dateTimePicker1.Text;
            string Clue=textBoxEnterclue.Text;
            string Gender;
            
            
            if(radioButtonMale.Checked==true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }


            if (textBoxFname.Text != null &&
                textBoxLname.Text != null &&
                textBoxEmail.Text != null &&
                textBoxRuname.Text != null &&
                textBoxRpass.Text != null &&

                textBoxRconpass.Text != null &&

                textBoxPhone.Text != null &&
                textBoxEnterclue.Text != null &&
                labelRight.Visible == true &&
                labelRight1.Visible == true &&
                labelRight2.Visible == true &&
               

                (radioButtonMale.Checked || radioButtonFemale.Checked)


                )
            {
                bool F = false;
                SqlConnection conn = null;

                try
                {

                    conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                    conn.Open();

                    string query = "select Uname from Registration where Uname = '" + Uname + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    string val = dt.Rows[0]["Uname"].ToString();
                    if(val==Uname)
                    {
                        labelred.Visible = true;
                    }
                    else
                    {
                        labelred.Visible = false;
                    }



                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    F = true;

                }
                finally
                {
                    //MessageBox.Show("Login Successfull");
                    conn.Close();
                }

                if (F == true)
                {
                    try
                    {
                        conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                        conn.Open();

                        string query = $"insert into Registration (Fname,Lname,Email,Uname,Password,Phonenum,Gender,[Date of birth],column_clue) VALUES ('{Fname}','{Lname}','{Email}','{Uname}','{Pass}','{Phone}','{Gender}','{Bdate}','{Clue}');";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                    MessageBox.Show("Registration complete!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check the form again!");
            }
            

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if (email.Contains("@") && email.Contains(".com"))
            {
                labelRight.Visible = true;
                labelWrong.Visible = false;
            }
            else
            {
                labelRight.Visible = false;
                labelWrong.Visible = true;
            }
        }

        private void textBoxRpass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRpass.Text == textBoxRconpass.Text)
            {
                labelRight1.Visible = true;
                labelWrong1.Visible = false;
            }
            else
            {
                labelRight1.Visible = false;
                labelWrong1.Visible = true;
            }
        }

        private void textBoxRconpass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRpass.Text == textBoxRconpass.Text)
            {
                labelRight1.Visible = true;
                labelWrong1.Visible = false;
            }
            else
            {
                labelRight1.Visible = false;
                labelWrong1.Visible = true;
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = textBoxPhone.Text;
            if (phone.StartsWith("01") && (phone.Length == 11))
            {
                labelRight2.Visible = true;
                labelWrong2.Visible = false;
            }
            else
            {
                labelRight2.Visible = false;
                labelWrong2.Visible = true;
            }
        }

        private void buttongoback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxEnterclue_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if ((DateTime.Now.Subtract(dateTimePicker1.Value).Days) / (365) < 15)
            {
               MessageBox.Show("You have to be atleast 15 years old to do registration!");
                
            }
        }
    }
}
