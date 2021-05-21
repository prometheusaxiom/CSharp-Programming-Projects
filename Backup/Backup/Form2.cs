using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backup
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
                {
                txtclass.Text = "SINGLE SUITE";
                txtrf.Text = 1000.00.ToString();
                txtrpd.Text = 2000.00.ToString();
                }
            else if (comboBox1.Text == "2")
                {
                txtclass.Text = "SERVICE DE LUXE";
                txtrf.Text = 1500.00.ToString();
                txtrpd.Text = 2500.00.ToString();
                }
            else if (comboBox1.Text == "3")
                {
                txtclass.Text = "SERVICE PREMIERE";
                txtrf.Text = 2000.00.ToString();
                txtrpd.Text = 3000.00.ToString();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            txtrpd.Text = " ";
            txtrf.Text = " ";
            txtclass.Text = " ";
            textBox2.Text = " ";
            txtrent.Text = " ";
            txttb.Text = " ";
            comboBox1.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bill, tbill;
            if (comboBox1.Text == "1")
            {
                bill = 2000.00 * Convert.ToDouble(txtrent.Text);
                tbill = bill + 1000.00;
                txttb.Text = tbill.ToString();
            }
            else if (comboBox1.Text == "2")
            {
                bill = 2500.00 * Convert.ToDouble(txtrent.Text);
                tbill = bill + 1500.00;
                txttb.Text = tbill.ToString();
            }
            else if (comboBox1.Text == "3")
            {
                bill = 3000.00 * Convert.ToDouble(txtrent.Text);
                tbill = bill + 2000.00;
                txttb.Text = tbill.ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
