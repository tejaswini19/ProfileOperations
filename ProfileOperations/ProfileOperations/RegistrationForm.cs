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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string name = firstName.Text + " " + lastName.Text;
            if (r_B_Male.Checked == true)
                name = "Mr. " +name;
            else
                name = "Mrs./Ms " + name+ "\n";
            string adrs = addressBox.Text+"\n";
            String dateOfBirth = (dateTimePicker1).Text+"\n";
            string s = " ";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)

                s = s + checkedListBox1.CheckedItems[i].ToString() + "   , ";
            string data = ("Name : "+name + Environment.NewLine + "Address : " + adrs + Environment.NewLine + "Date Of Birth : " + dateOfBirth + Environment.NewLine + "Course : "+s);
            data_Saved1.Text = data;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MMM/yyyy";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MDIParent mdi = new MDIParent();
            mdi.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
