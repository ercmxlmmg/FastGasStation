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
    public partial class Fill : Form
    {
        public Fill()
        {
            InitializeComponent();
        }

        

        private void Fill_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReportProgress.Text = (pbLoading.Value + "%");

            if(pbLoading.Value < 100)
            {
                pbLoading.Value += 5;
                lblStatement.Text = "Filling up your tank...";
            }
            else
            {
                lblStatement.Text = "Tank filled!";
                timer1.Stop();
                Receipt frm = new Receipt();
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
