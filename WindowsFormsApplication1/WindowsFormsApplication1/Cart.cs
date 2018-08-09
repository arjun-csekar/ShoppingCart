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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                Label number = new Label();
                number.Location= new Point(59, 30 * i + 10);
                number.Text = i.ToString();
                
                Label itemName = new Label();
                itemName.Location = new Point(103, 30 * i + 10);
                itemName.Text = "Item " + i.ToString();

                Label itemPrice = new Label();
                itemPrice.Location = new Point(368, 30 * i + 10);
                itemPrice.Text = "$0.00";

                Button button = new Button();
                button.Location = new Point(472, 30 * i + 10);
                button.Text = "Remove";

                button.Click += new EventHandler(button1_Click);
                button.Tag = i;

                this.Controls.Add(button);
                this.Controls.Add(itemPrice);
                this.Controls.Add(itemName);
                this.Controls.Add(number);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
