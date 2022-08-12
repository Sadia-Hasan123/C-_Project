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
    public partial class BGroup : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\EDUCATIONAL\SOFTWARE\FINALC#\BBMS\BBMS\ADMINTABLE.MDF;Integrated Security=True");
        
        public BGroup()
        {
            InitializeComponent();
        }

      public void display1()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from[ApTable]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void display2()
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from[AnTable]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void display3()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from[BpTable]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dt);
                dataGridView3.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void display4()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from[BnTable]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dt);
                dataGridView4.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void display5()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from[OpTable]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dt);
                dataGridView5.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void display6()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from[OnTable]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dt);
                dataGridView6.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void display7()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from[ABpTable]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dt);
                dataGridView7.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void display8()
        {
            try { 
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from[ABnTable]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);
            dataGridView8.DataSource = dt;
            con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      

        private void BGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BGroup_Load(object sender, EventArgs e)
        {
            display1();
            display2();
            display3();
            display4();
            display5();
            display6();
            display7();
            display8();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            display1();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from ApTable where BloodId='" + textBox1.Text + "'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            display1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Option o = new Option();
            this.Hide();
            o.Show();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            display2();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            display3();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            display4();

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            display5();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            display6();
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {
            display7();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {
            display8();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from AnTable where BloodId='" + textBox2.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox2.Text = "";
            display2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from BpTable where BloodId='" + textBox3.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox3.Text = "";
            display3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete  from BnTable where BloodId='" + textBox4.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox4.Text = "";
            display4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from OpTable where BloodId='" + textBox5.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox5.Text = "";
            display5();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from OnTable where BloodId='" + textBox6.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox6.Text = "";
            display6();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete  from ABpTable where BloodId='" + textBox7.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox7.Text = "";
            display7();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete  from ABnTable where BloodId='" + textBox8.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox8.Text = "";
            display8();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
