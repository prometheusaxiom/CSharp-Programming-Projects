using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exp_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pk, bf, shp, ts, coke, royal, sprite, td, total, cash, change;
            pk = Convert.ToDouble(textBox1.Text) * 20;

            bf = Convert.ToDouble(textBox2.Text) * 25;

            shp = Convert.ToDouble(textBox3.Text) * 30;

            ts = pk + bf + shp;
            textBox4.Text = ts.ToString();

            coke = Convert.ToDouble(textBox5.Text) * 20;

            royal = Convert.ToDouble(textBox6.Text) * 20;

            sprite = Convert.ToDouble(textBox7.Text) * 20;

            td = coke + royal + sprite;
            textBox8.Text = td.ToString();

            total = ts + td;
            textBox9.Text = total.ToString();

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pk, bf, shp, ts, coke, royal, sprite, td, total, cash, change;
            pk = Convert.ToDouble(textBox1.Text) * 20;

            bf = Convert.ToDouble(textBox2.Text) * 25;

            shp = Convert.ToDouble(textBox3.Text) * 30;

            ts = pk + bf + shp;

            coke = Convert.ToDouble(textBox5.Text) * 20;

            royal = Convert.ToDouble(textBox6.Text) * 20;

            sprite = Convert.ToDouble(textBox7.Text) * 20;

            td = coke + royal + sprite;

            cash = Convert.ToDouble(textBox10.Text);

            total = ts + td;

            change = cash - total;
            textBox11.Text = change.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
