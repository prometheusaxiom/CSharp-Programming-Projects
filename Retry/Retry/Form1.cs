using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Retry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
            textBox10.Text = " ";
            textBox11.Text = " ";
            textBox12.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bp, all, op, gp = 0;
            bp = Convert.ToDouble(textBox3.Text);
            all = Convert.ToDouble(textBox4.Text);
            op = Convert.ToDouble(textBox5.Text);
            gp = bp + all + op;
            textBox6.Text = gp.ToString();

            double sss, ph, pg, tax, td = 0, grosspay = 0;
            sss = Convert.ToDouble(textBox7.Text);
            ph = Convert.ToDouble(textBox8.Text);
            pg = Convert.ToDouble(textBox9.Text);
            
            

            if (comboBox1.Text == "SL")
            {
                tax = gp * 0.10;
                td = sss + ph + pg + tax;
                textBox10.Text = tax.ToString();
                textBox11.Text = td.ToString();
                grosspay = gp - td;
                textBox12.Text = grosspay.ToString();
                
             
            }
            else if (comboBox1.Text == "HF")
            {
                tax = gp * 0.08;
                td = sss + ph + pg + tax;
                textBox10.Text = tax.ToString();
                textBox11.Text = td.ToString();
                grosspay = gp - td;
                textBox12.Text = grosspay.ToString();
            }
            else if (comboBox1.Text == "MR")
            {
                tax = gp * 0.06;
                td = sss + ph + pg + tax;
                textBox10.Text = tax.ToString();
                textBox11.Text = td.ToString();
                grosspay = gp - td;
                textBox12.Text = grosspay.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "SL")
            {
                textBox7.Text = 400.00.ToString();
            }
            else if (comboBox1.Text == "HF")
            {
                textBox7.Text = 350.00.ToString();
            }
            else if (comboBox1.Text == "MR")
            {
                textBox7.Text = 300.00.ToString();
            }
        }
    }
}
