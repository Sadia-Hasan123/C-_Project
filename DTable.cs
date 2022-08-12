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

namespace BBMS
{
    public partial class DTable : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\EDUCATIONAL\SOFTWARE\FINALC#\BBMS\BBMS\ADMINTABLE.MDF;Integrated Security=True");
        public DTable()
        {
            InitializeComponent();
        }

        private void DTable_Load(object sender, EventArgs e)
        {
            autoId();
        }
        private void autoId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(DonorId) from DTable", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            textBox1.Text = i.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try { 

            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into DTable(DonorId,DonorName,Email,Contact,Age,Address,BloodGroup,Gender,Date,NextDate)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker1.Text + "')", con);
            cmd.ExecuteNonQuery();
          
            con.Close();
            //textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            dateTimePicker2.Text = "";
            dateTimePicker1.Text = "";


            display();
            autoId();
                MessageBox.Show("inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void display()
        {
            try { 
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from[DTable]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
                autoId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from DTable where DonorId='" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();

                con.Close();
               // textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox2.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";

                display();
                autoId();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DTable where DonorId='" + textBox8.Text + "'", con);

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                //textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox2.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                autoId();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update DTable set DonorName='" + textBox2.Text + "',Email='" + textBox3.Text + "',Contact='" + textBox4.Text + "',Age='" + textBox5.Text + "',Address='" + textBox6.Text + "',BloodGroup='" + comboBox2.Text + "',Gender='" + comboBox1.Text + "' where DonorId='" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();

                con.Close();
                //textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox2.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";

                display();
                autoId();
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Option o = new Option();
            this.Hide();
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();
            autoId();
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"+ "@"+ @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
            if (textBox3.Text.Length > 0)
            {
                if (!rEmail.IsMatch(textBox3.Text))
                {
                    MessageBox.Show("Invalid Email");
                    textBox3.SelectAll();
                    e.Cancel = true;
                }
            }

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
           
            System.Text.RegularExpressions.Regex rName = new System.Text.RegularExpressions.Regex(@"^([A-Z][a-z-A-z ]+)$");
            if (textBox2.Text.Length > 0)
            {
                if (!rName.IsMatch(textBox2.Text))
                {
                    MessageBox.Show("Invalid Name");
                    textBox2.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rContact = new System.Text.RegularExpressions.Regex(@"^[0-9]{11}$");
            if (textBox4.Text.Length > 0)
            {
                if (!rContact.IsMatch(textBox4.Text))
                {
                    MessageBox.Show("Invalid Contact Number");
                    textBox4.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void DTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today.AddMonths(+3);
        }
    }
}
