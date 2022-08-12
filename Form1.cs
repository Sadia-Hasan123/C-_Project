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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\EDUCATIONAL\SOFTWARE\FINALC#\BBMS\BBMS\ADMINTABLE.MDF;Integrated Security=True");
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*)From AdminTable where UserID='" + textUser.Text + "'and Password = '" +textPass.Text+"'",con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Option d = new Option();
                d.Show();
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("unsuccess");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CACC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ainfo f = new Ainfo();
            f.Show();
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
