using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW_3_Comp_Prog
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pork, beef, shrimp, totalsiomai = 0;

            pork = Convert.ToDouble(textBox1.Text) * 20;
            beef = Convert.ToDouble(textBox2.Text) * 25;
            shrimp = Convert.ToDouble(textBox3.Text) * 30;
            totalsiomai = pork + beef + shrimp;
            textBox4.Text = totalsiomai.ToString();

            double coke, royal, sprite, totalsd = 0;
            coke = Convert.ToDouble(textBox5.Text) * 20;
            royal = Convert.ToDouble(textBox6.Text) * 20;
            sprite = Convert.ToDouble(textBox7.Text) * 20;
            totalsd = coke + royal + sprite;
            textBox8.Text = totalsd.ToString();

            double totalfinal = 0;
            totalfinal = totalsd + totalsiomai;
            textBox9.Text = totalfinal.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double pork, beef, shrimp, totalsiomai = 0;
                pork = Convert.ToDouble(textBox1.Text) * 20;
                beef = Convert.ToDouble(textBox2.Text) * 25;
                shrimp = Convert.ToDouble(textBox3.Text) * 30;
                    totalsiomai = pork + beef + shrimp;

            double coke, royal, sprite, totalsd = 0;
                coke = Convert.ToDouble(textBox5.Text) * 20;
                royal = Convert.ToDouble(textBox6.Text) * 20;
                sprite = Convert.ToDouble(textBox7.Text) * 20;
                    totalsd = coke + royal + sprite;

            double totalfinal = 0;
                 totalfinal = totalsd + totalsiomai;

            double cash, change = 0;
                cash = Convert.ToDouble(textBox10.Text);
                change = cash - totalfinal;
                    textBox11.Text = change.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
