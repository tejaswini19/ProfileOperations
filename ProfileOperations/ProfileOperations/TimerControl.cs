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
    public partial class TimerControl : Form
    {
        public TimerControl()
        {
            InitializeComponent();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < 60)
            {
                i++;
                label1.Text = i.ToString() + " Seconds";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Time Out","Timer",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MDIParent mdi = new MDIParent();
            mdi.Show();
            this.Hide();

        }
    }
}
