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
    public partial class SellForm : Form
    {
        bool flag = false;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\EDUCATIONAL\SOFTWARE\FINALC#\BBMS\BBMS\ADMINTABLE.MDF;Integrated Security=True");
        public SellForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into SellTable(BloodId,Date,SellPrice)Values('" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox1.Text + "')",con);
            cmd.ExecuteNonQuery();
               
            con.Close();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
           
            dateTimePicker1.Text = "";
            textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Payment p = new Payment();
            this.Hide();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int price = 0;
            float discount, d, sellprice = 0;
            price = int.Parse(textBox3.Text);
            discount = float.Parse(textBox4.Text);
            d = price * (discount / 100);
            sellprice = price - d;
            textBox1.Text = sellprice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Option o = new Option();
            this.Hide();
            o.Show();
        }

        private void SellForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            SqlDataAdapter da = new SqlDataAdapter("Select DonorId from Dtable where DonorId='" + DId.Text + "'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Exists");
            }
            else
            {
                MessageBox.Show("Not Exists");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellForm_Load(object sender, EventArgs e)
        {

        }
    }
}
