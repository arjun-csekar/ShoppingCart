using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class Receipt : Form
    {
        List<decimal> totals;
        private PrintDocument printDocument1 = new PrintDocument();

        public Receipt(List<decimal> t, String n)
        {
            
            InitializeComponent();
            totals = new List<decimal>();
            totals = t;
            label3.Text = totals[0].ToString("c");
            label5.Text = totals[1].ToString("c");
            label7.Text = totals[2].ToString("c");
            label8.Text = n + ": This is your receipt!";
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }


        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }
    }
}
