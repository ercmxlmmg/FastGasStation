using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastGasStation
{
    public partial class Card : Form
    {
        public Card()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int num = 8;
            txtInput.Text += num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 1;
            txtInput.Text += num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 2;
            txtInput.Text += num.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 3;
            txtInput.Text += num.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num = 4;
            txtInput.Text += num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = 5;
            txtInput.Text += num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = 6;
            txtInput.Text += num.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int num = 7;
            txtInput.Text += num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num = 9;
            txtInput.Text += num.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int num = 0;
            txtInput.Text += num.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(txtInput.Text == "12345")
            {
                txtCard.Text = txtInput.Text.ToString();
                txtName.Text = "Erica Mago";
                txtNum.Text = "1111-2222-3333-4444";
                txtBal.Text = "Php 5,000";
            }
            else
            {
                MessageBox.Show("Incorrect Pin. Please try again");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Fuels fls = new Fuels();
            this.Hide();
            fls.ShowDialog();
        }
    }
}
