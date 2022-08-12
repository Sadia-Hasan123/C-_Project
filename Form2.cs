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
    public partial class Ainfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\EDUCATIONAL\SOFTWARE\FINALC#\BBMS\BBMS\ADMINTABLE.MDF;Integrated Security=True");

        public Ainfo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into AdminTable(UserID,Password)VALUES('"+textUser.Text+"','"+textPass.Text+"')", con);
            cmd.ExecuteNonQuery();
            
            con.Close();
            textUser.Text = "";
            textPass.Text = "";
            display();
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
            cmd.CommandText = "select UserID from[AdminTable]";
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ainfo_Load(object sender, EventArgs e)
        {

        }

        private void Ainfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
