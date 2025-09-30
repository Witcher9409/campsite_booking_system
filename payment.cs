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

    public partial class payment : Form
    {
        string usname;
        public payment()
        {
            InitializeComponent();
            buttonCard.Visible = true;
            buttonBkash.Visible = true;
        }
        public payment(string ussname)
        {
            InitializeComponent();
            
          usname=ussname;
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            buttonBkash.Visible = false;
            textBoxCard.Visible = true;
            labelCard.Visible = true;
            buttonPay.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {

            string card=textBoxCard.Text;
            string code = textBox1.Text;



            if ((card != null) && (labelright2.Visible==true) && (labeleight3.Visible == true) && (code != null))
            {
                SqlConnection conn = null;
                try
                {






                    conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                    conn.Open();

                    string query = $"INSERT INTO Myorder1    select* from Mycart6   where Uname='{usname}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    //DataTable dt = ds.Tables[0];
                    //string val = dt.Rows[0]["Password"].ToString();
                    MessageBox.Show("Payment successful");
                    Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Payment unsuccessful");
                }
                finally
                {
                    //MessageBox.Show("Login Successfull");

                    conn.Close();
                }


                try
                {






                    conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                    conn.Open();

                    string query = $"delete from Mycart6  WHERE Uname='{usname}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    //DataTable dt = ds.Tables[0];
                    //string val = dt.Rows[0]["Password"].ToString();
                    //MessageBox.Show("Payment successful");



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // MessageBox.Show("Payment unsuccessful");
                }
                finally
                {
                    //MessageBox.Show("Login Successfull");

                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect card number / code");
            }
            
        }

        private void buttonBkash_Click(object sender, EventArgs e)
        {
            buttonCard.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible=true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bkash = textBox3.Text;
            string code = textBox2.Text;



            if ((bkash != null) && (labelright.Visible==true)&&(labelright1.Visible==true) && (code != null) && (code.Length == 5))
            {
                SqlConnection conn = null;
                try
                {






                    conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                    conn.Open();

                    string query = $"INSERT INTO Myorder1    select* from Mycart6   where Uname='{usname}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    //DataTable dt = ds.Tables[0];
                    //string val = dt.Rows[0]["Password"].ToString();
                    MessageBox.Show("Payment successful");
                    Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Payment unsuccessful");
                }
                finally
                {
                    //MessageBox.Show("Login Successfull");

                    conn.Close();
                }


                try
                {






                    conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                    conn.Open();

                    string query = $"delete from Mycart6  WHERE Uname='{usname}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    //DataTable dt = ds.Tables[0];
                    //string val = dt.Rows[0]["Password"].ToString();
                    //MessageBox.Show("Payment successful");



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // MessageBox.Show("Payment unsuccessful");
                }
                finally
                {
                    //MessageBox.Show("Login Successfull");

                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect bkash number / code");
            }
        }

        private void labelright_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            string bkash = textBox3.Text;
            if (bkash.StartsWith("01") && bkash.Length==11)
            {
                labelright.Visible = true;
                labelWrong.Visible = false;
            }
            else
            {
                labelright.Visible = false;
                labelWrong.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string bkash = textBox2.Text;
            if (bkash.Length == 5)
            {
                labelright1.Visible = true;
                labelwrong1.Visible = false;
            }
            else
            {
                labelright1.Visible = false;
                labelwrong1.Visible = true;
            }
        }

        private void textBoxCard_TextChanged(object sender, EventArgs e)
        {
            string card = textBoxCard.Text;
            if (card.Length == 15)
            {
                labelright2.Visible = true;
                labelwrong2.Visible = false;
            }
            else
            {
                labelright2.Visible = false;
                labelwrong2.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string card = textBox1.Text;
            if (card.Length == 4)
            {
                labeleight3.Visible = true;
                labelwrong3.Visible = false;
            }
            else
            {
                labeleight3.Visible = false;
                labelwrong3.Visible = true;
            }
        }
    }
}
