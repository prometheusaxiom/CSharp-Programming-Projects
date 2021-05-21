using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW_2_Computer_Programming_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
            Password.MaxLength = 8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            if (Password.Text == "12345")
            {
                MessageBox.Show("Correct Password");
                this.Hide();
                Application f2 = new Application();
                f2.ShowDialog();
            }
            else
                MessageBox.Show("Incorrect Password");
        }
    }
}
