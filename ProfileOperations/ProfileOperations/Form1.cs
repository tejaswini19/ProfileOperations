using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string FullName = fname.Text + " " + lName.Text;
            if (r_b_male.Checked == true)
            {
                    fullName.Text = "Mr. " + FullName;
                }
            else{
                    fullName.Text = "Mrs./Ms. " + FullName; }
                //fullName.Text =  FullName;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MDIParent mdi = new MDIParent();
            mdi.Show();
            this.Hide();
        }

        private void r_B_Orange_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Orange;
        }

        private void r_B_Blue_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }

        private void r_B_Pink_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Pink;
        }

        private void r_B_Green_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(0, 255, 0);
        }
    }
}
