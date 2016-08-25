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
    public partial class MDIParent : Form
    {
       

        public MDIParent()
        {
            InitializeComponent();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void arithmeticOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArithmeticOperations aOp = new ArithmeticOperations();
            aOp.Show();
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm rForm = new RegistrationForm();
            rForm.Show();
            this.Hide();
        }

        private void cosmeticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cosmetics cosmo = new Cosmetics();
            cosmo.Show();
            this.Hide();
        }

        private void tickEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerControl tc = new TimerControl();
            tc.Show();
            this.Hide();
        }

        private void textKeyEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextKeyEvent tke = new TextKeyEvent();
            tke.Show();
            this.Hide();
        }

        private void pictureDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureDisplay pd = new PictureDisplay();
            pd.Show();
            this.Hide();
        }
    }
}
