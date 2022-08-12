using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class BInsert : Form
    {
        public BInsert()
        {
            InitializeComponent();
        }

        private void BInsert_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            APInsert ap = new APInsert();
            ap.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Option o = new Option();
            this.Hide();
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnInsert a = new AnInsert();
            this.Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BpInsert b = new BpInsert();
            this.Hide();
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BnInsert b = new BnInsert();
            this.Hide();
            b.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpInsert o = new OpInsert();
            this.Hide();
            o.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OnInsert o = new OnInsert();
            this.Hide();
            o.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ABpInsert ab = new ABpInsert();
            this.Hide();
            ab.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ABnInsert ab = new ABnInsert();
            this.Hide();
            ab.Show();
        }

        private void BInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
