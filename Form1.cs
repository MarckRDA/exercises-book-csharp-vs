using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowDivisionModule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDividendo.Text == "0" || txtDivisor.Text == "0")
            {
                MessageBox.Show("It's not allowed division by zero!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResto.Clear();
            }
            else
            {
                txtResto.Text = (Convert.ToInt32(txtDividendo.Text) % Convert.ToInt32(txtDivisor.Text)).ToString();
            }
        }

        private void txtDivisor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
