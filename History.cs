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
    public partial class History : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\EDUCATIONAL\SOFTWARE\FINALC#\BBMS\BBMS\ADMINTABLE.MDF;Integrated Security=True");

        public History()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            display();
        }
            public void display() { 
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select BloodId,Date,Price from[DNTTable]";
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

        private void History_Load(object sender, EventArgs e)
        {
            display();
            display2();
            
        }
        public void display2()
        {
           try {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select BloodId,Date,SellPrice from[SellTable]";
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

        private void tabPage2_Click(object sender, EventArgs e)
        {
            display2();
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select BloodId,Date,SellPrice from SellTable where Date='" + dateTimePicker2.Text + "'", con);

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

        private void button3_Click(object sender, EventArgs e)
        {
            Option o = new Option();
            this.Hide();
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select BloodId,Date,Price from DNTTable where Date='" + dateTimePicker1.Text + "'", con);

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
    }
}
