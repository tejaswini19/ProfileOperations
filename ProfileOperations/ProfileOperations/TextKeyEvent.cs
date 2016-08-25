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
    public partial class TextKeyEvent : Form
    {
        public TextKeyEvent()
        {
            InitializeComponent();
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            int i = Convert.ToInt32(e.KeyChar);
            if ((i >= 48 && i <= 57) || (i == 8))
            {


                e.Handled = false;

            }
            else
            {
                MessageBox.Show("Enter only digits");
                e.Handled = true;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MDIParent mdi = new MDIParent();
            mdi.Show();
            this.Hide();
        } 
    }
}
