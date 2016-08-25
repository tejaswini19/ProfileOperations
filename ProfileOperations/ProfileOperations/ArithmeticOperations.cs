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
    public partial class ArithmeticOperations : Form
    {
        public ArithmeticOperations()
        {
            InitializeComponent();
        }

        int a, b, c;

        private void sub_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(varA.Text);
            b = Convert.ToInt32(varB.Text);
            c = a - b;
            ans.Text = Convert.ToString(c);
        }

        private void div_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(varA.Text);
            b = Convert.ToInt32(varB.Text);
            c = a / b;
            ans.Text = Convert.ToString(c);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MDIParent mdi = new MDIParent();
            mdi.Show();
            this.Hide();
        }

        private void btn_Twelve_Click(object sender, EventArgs e)
        {
            double amnt = Convert.ToDouble(amount.Text);
            double tax = (0.12 * amnt);
            total.Text = (Convert.ToString(tax));
        }

        private void btn_Four_Click(object sender, EventArgs e)
        {
            double amnt = Convert.ToDouble(amount.Text);
            double tax = (0.04 * amnt);
            total.Text = (Convert.ToString(tax));
        }

        private void mul_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(varA.Text);
            b = Convert.ToInt32(varB.Text);
            c = a * b;
            ans.Text = Convert.ToString(c);

        }

        private void add_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(varA.Text);
            b = Convert.ToInt32(varB.Text);
            c = a + b;
            ans.Text = Convert.ToString(c);
        }
    }
}
