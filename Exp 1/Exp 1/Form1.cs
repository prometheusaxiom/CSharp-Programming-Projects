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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 10;
        }
    
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "joshua")
            {
                MessageBox.Show("Welcome!");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
