﻿using System;
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
    public partial class OpInsert : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\EDUCATIONAL\SOFTWARE\FINALC#\BBMS\BBMS\ADMINTABLE.MDF;Integrated Security=True");
        string s = "OP";
        int a = 11000;
        public OpInsert()
        {
            InitializeComponent();
        }

        private void OpInsert_Load(object sender, EventArgs e)
        {
            autoId();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            BInsert b = new BInsert();
            b.Show();
        }
        private void autoId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(BloodID) from OpTable", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i=a+i;
            textBox2.Text = s + i.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into OpTable(BloodID,DonorId,Price,Date,ExpireDate)Values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')", con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("Update DTable set Date='" + dateTimePicker1.Text + "' where DonorId='" + textBox1.Text + "'", con);
            cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("Insert into DNTTable (BloodId,Date,Price)Values('" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "')", con);
                cmd2.ExecuteNonQuery();
                con.Close();
            textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            autoId();
            MessageBox.Show("inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DTable d = new DTable();
            this.Hide();
            d.Show();
        }

        private void OpInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today.AddDays(+7);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
