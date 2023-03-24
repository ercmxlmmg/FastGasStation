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
    public partial class Fuels : Form
    {
        public Fuels()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Card crd = new Card();
            this.Hide();
            crd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 1
                ;
            txtInputLiter.Text += num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 2;
            txtInputLiter.Text += num.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 3;
            txtInputLiter.Text += num.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num = 4;
            txtInputLiter.Text += num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = 5;
            txtInputLiter.Text += num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = 6;
            txtInputLiter.Text += num.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int num = 7;
            txtInputLiter.Text += num.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int num = 8;
            txtInputLiter.Text += num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num = 9;
            txtInputLiter.Text += num.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int num = 0;
            txtInputLiter.Text += num.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtInputLiter.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double Liter;
            double Amount;

            if (radioButton1.Checked)
            {
                txtLiter.Text = txtInputLiter.Text.ToString();
                Liter = Convert.ToDouble(txtInputLiter.Text);
                Amount = Liter * 62.75;
                txtAmt.Text = Amount.ToString();
            }
            else if (radioButton2.Checked)
            {
                txtLiter.Text = txtInputLiter.Text.ToString();
                Liter = Convert.ToDouble(txtInputLiter.Text);
                Amount = Liter * 56.35;
                txtAmt.Text =  Amount.ToString();
            }
            else if (radioButton3.Checked)
            {
                txtLiter.Text = txtInputLiter.Text.ToString();
                Liter = Convert.ToDouble(txtInputLiter.Text);
                Amount = Liter * 59.25;
                txtAmt.Text = Amount.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double Amount;
            Amount = Convert.ToDouble(txtAmt.Text);

            if (Amount <= 5000)
            {
                Fill frm = new Fill();
                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Insufficient Balance!");

            }
        }
    }
}
