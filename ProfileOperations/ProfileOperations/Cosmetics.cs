using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileOperations
{
    public partial class Cosmetics : Form
    {
        public Cosmetics()
        {
            InitializeComponent();
        }

        ArrayList soaps = new ArrayList();
        int[] soapPrice = { 34,35,36,37,38,39,40};
        //int i;
            
        private void Cosmetics_Load(object sender, EventArgs e)
        {
            soaps.Add("ABC");
            soaps.Add("DEF");
            soaps.Add("GHI");
            soaps.Add("JKL");
            soaps.Add("MNO");
            soaps.Add("PQR");
            soaps.Add("STU");

            soapsComboBox1.DataSource = soaps;
                                    
        }

        
        private void soapsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = soapPrice[soapsComboBox1.SelectedIndex];
            PriceOfSoap.Text = price.ToString();
            total = price + total;

        }


        int total = 0;
        private void btn_To_Cart_Click(object sender, EventArgs e)
        {
            string s = soapsComboBox1.Text;
            selectedListBox1.Items.Add(s +" - "+ PriceOfSoap.Text);

            //total = Convert.ToInt32(PriceOfSoap) + total;
            totalPrice.Text = total.ToString();

        }
    }
}
