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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 8;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "12345")
            {
                MessageBox.Show("Correct Password");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
                MessageBox.Show("Incorrect Password");
        }
    }
}
