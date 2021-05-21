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
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void Grade_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }
    }
}
