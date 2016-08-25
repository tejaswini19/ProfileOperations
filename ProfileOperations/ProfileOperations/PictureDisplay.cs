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
    public partial class PictureDisplay : Form
    {
        public PictureDisplay()
        {
            InitializeComponent();
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Images\\" + listBoxItems.SelectedItem.ToString() + ".png";
            pictureBox1.Image = Image.FromFile(path);
        }
    }
}
