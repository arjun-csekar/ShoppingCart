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
        public Cart(ShoppingCart cart)
        {
            InitializeComponent();
            if (cart.returnCart().Count == 0)
            {
                Label empty = new Label();
                empty.Location = new Point(59, 30 + 10);
                empty.Text = "Shopping cart is empty";
            }
            else
            {
                int i = 0;
                decimal subTotal = 0.0m;

                foreach (Item item in cart.returnCart())
                {
                    i++;
                    Label number = new Label();
                    number.Location = new Point(59, 30 * i + 10);
                    number.Text = i.ToString();

                    Label itemName = new Label();
                    itemName.Location = new Point(103, 30 * i + 10);
                    itemName.Text = item.ItemName;

                    Label itemPrice = new Label();
                    itemPrice.Location = new Point(368, 30 * i + 10);
                    itemPrice.Text = item.ItemPrice.ToString();

                    Button button = new Button();
                    button.Location = new Point(472, 30 * i + 10);
                    button.Text = "Remove";

                    button.Click += new EventHandler(button1_Click);
                    button.Tag = i;

                    this.Controls.Add(button);
                    this.Controls.Add(itemPrice);
                    this.Controls.Add(itemName);
                    this.Controls.Add(number);

                    subTotal += item.ItemPrice;

                }

                i++;

                Label subTotaltxt = new Label();
                subTotaltxt.Location = new Point(59, 30 * i + 10);
                subTotaltxt.Text = "Subtotal:";

                Label subTotalval = new Label();
                subTotalval.Location = new Point(103, 30 * i + 10);
                subTotalval.Text = subTotal.ToString();

                decimal tax = subTotal * 0.08m;

                i++;

                Label taxTxt = new Label();
                taxTxt.Location = new Point(59, 30 * i + 10);
                taxTxt.Text = "Tax:";

                Label taxVal = new Label();
                taxVal.Location = new Point(103, 30 * i + 10);
                taxVal.Text = tax.ToString("c1");

                decimal total = subTotal + tax;

                i++;

                Label totalTxt = new Label();
                totalTxt.Location = new Point(59, 30 * i + 10);
                totalTxt.Text = "Total:";

                Label totalVal = new Label();
                totalVal.Location = new Point(103, 30 * i + 10);
                totalVal.Text = total.ToString("c1");
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
