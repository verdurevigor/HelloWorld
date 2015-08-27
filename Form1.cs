using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace HelloWorld
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblText.Text = "HELLO WORLD!";
            gbColors.Visible = true;
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
                lblText.ForeColor = Color.Black;
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
                lblText.ForeColor = Color.Blue;
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
                lblText.ForeColor = Color.ForestGreen;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (lblText.Text != "HELLO WORLD!")
            {
                MessageBox.Show("You cannot hide what is not shown.");
            }
            else
            {
                lblText.Text = "";
                gbColors.Visible = false;
            }
        }
    }
}
