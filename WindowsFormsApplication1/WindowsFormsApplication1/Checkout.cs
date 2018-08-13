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
    public partial class Checkout : Form
    {
        List<decimal> totals;
        public Checkout(List<decimal> t)
        {
            InitializeComponent();
            totals = t;
            label21.Text = totals[0].ToString("c");
            label19.Text = totals[1].ToString("c");
            label17.Text = totals[2].ToString("c");



        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receipt r = new Receipt(totals, textBox1.Text);
            r.Show();
            this.Close();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

