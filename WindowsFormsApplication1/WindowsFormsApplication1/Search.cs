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
            populate_picturebox();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void populate_picturebox()
        {
            //pictureBox1.Image = Bitmap.FromFile("C:\\Users\\Jacob\\Pictures\\Saved Pictures\\image42.jpeg");
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
    }
}
