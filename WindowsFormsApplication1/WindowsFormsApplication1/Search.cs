using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            populate_picturebox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void populate_picturebox()
        {
            //pictureBox1.Image = Image.FromFile("C:\\Users\\June\\Desktop\\Notes.jpg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checkout CO = new Checkout();
            CO.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text += ": Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver";
            label2.Text += ": $84.59";
            label3.Text += ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.";
        }
    }
}
