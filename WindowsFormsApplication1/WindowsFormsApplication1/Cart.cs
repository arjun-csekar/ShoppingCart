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
        ShoppingCart cart;
        Button button;
        List<decimal> totals;
        public Cart(ShoppingCart cart)
        {
            InitializeComponent();
            this.cart = cart;
            totals = new List<decimal>();
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
                    number.Name = "number" + i.ToString();
                    number.Location = new Point(59, 30 * i + 10);
                    number.Text = i.ToString();

                    Label itemName = new Label();
                    itemName.Name = "itemName" + i.ToString();
                    itemName.Location = new Point(103, 30 * i + 10);
                    itemName.Text = item.ItemName;

                    Label itemPrice = new Label();
                    itemPrice.Name = "itemPrice" + i.ToString();
                    itemPrice.Location = new Point(368, 30 * i + 10);
                    itemPrice.Text = item.ItemPrice.ToString("c");

                    button = new Button();
                    button.Name = i.ToString();
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
                subTotalval.Text = subTotal.ToString("c");


                this.Controls.Add(subTotalval);
                this.Controls.Add(subTotaltxt);
                

                decimal tax = subTotal * 0.08m;

                i++;

                Label taxTxt = new Label();
                taxTxt.Location = new Point(59, 30 * i + 10);
                taxTxt.Text = "Tax:";

                Label taxVal = new Label();
                taxVal.Location = new Point(103, 30 * i + 10);
                taxVal.Text = tax.ToString("c");

                this.Controls.Add(taxVal);
                this.Controls.Add(taxTxt);
                

                decimal total = subTotal + tax;

                i++;

                Label totalTxt = new Label();
                totalTxt.Location = new Point(59, 30 * i + 10);
                totalTxt.Text = "Total:";

                Label totalVal = new Label();
                totalVal.Location = new Point(103, 30 * i + 10);
                totalVal.Text = total.ToString("c");
                this.Controls.Add(totalVal);
                this.Controls.Add(totalTxt);

                i++;

                System.Windows.Forms.Button rec = new System.Windows.Forms.Button();
                rec.Text = "Checkout";
                rec.Location = new Point(59, 30 * i + 10);
                rec.Size = new System.Drawing.Size(86, 29);
                rec.UseVisualStyleBackColor = true;
                rec.Click += new System.EventHandler(rec_Click);

                this.Controls.Add(rec);

                totals.Add(subTotal);
                totals.Add(tax);
                totals.Add(total);
            }
        }

        private void repopulateCart()
        {
            if (cart.returnCart().Count == 0)
            {
                Label empty = new Label();
                empty.Location = new Point(59, 30 + 10);
                empty.Text = "Shopping cart is empty";
            }
            else
            {
                this.Controls.Clear();
                int i = 0;
                decimal subTotal = 0.0m;

                foreach (Item item in cart.returnCart())
                {
                    i++;
                    Label number = new Label();
                    number.Name = "number" + i.ToString();
                    number.Location = new Point(59, 30 * i + 10);
                    number.Text = i.ToString();

                    Label itemName = new Label();
                    itemName.Name = "itemName" + i.ToString();
                    itemName.Location = new Point(103, 30 * i + 10);
                    itemName.Text = item.ItemName;

                    Label itemPrice = new Label();
                    itemPrice.Name = "itemPrice" + i.ToString();
                    itemPrice.Location = new Point(368, 30 * i + 10);
                    itemPrice.Text = item.ItemPrice.ToString("c");

                    button = new Button();
                    button.Name = i.ToString();
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
                subTotalval.Text = subTotal.ToString("c");

                this.Controls.Add(subTotalval);
                this.Controls.Add(subTotaltxt);
                

                decimal tax = subTotal * 0.08m;

                i++;

                Label taxTxt = new Label();
                taxTxt.Location = new Point(59, 30 * i + 10);
                taxTxt.Text = "Tax:";

                Label taxVal = new Label();
                taxVal.Location = new Point(103, 30 * i + 10);
                taxVal.Text = tax.ToString("c");

                this.Controls.Add(taxVal);
                this.Controls.Add(taxTxt);
                

                decimal total = subTotal + tax;

                i++;

                Label totalTxt = new Label();
                totalTxt.Location = new Point(59, 30 * i + 10);
                totalTxt.Text = "Total:";

                Label totalVal = new Label();
                totalVal.Location = new Point(103, 30 * i + 10);
                totalVal.Text = total.ToString("c");

                this.Controls.Add(totalVal);
                this.Controls.Add(totalTxt);

                i++;

                System.Windows.Forms.Button rec = new System.Windows.Forms.Button();
                rec.Text = "Checkout";
                rec.Location = new Point(59, 30 * i + 10);
                rec.Size = new System.Drawing.Size(86, 29);
                rec.UseVisualStyleBackColor = true;
                rec.Click += new System.EventHandler(rec_Click);

                this.Controls.Add(rec);

                totals.Clear();
                totals.Add(subTotal);
                totals.Add(tax);
                totals.Add(total);
            }
        }
        
        private void rec_Click(object sender, EventArgs e)
        {
            Checkout co = new Checkout(totals);
            co.Show();
            this.Close();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (Button)sender;
            Database db = new Database();
            await db.removeItemCart(Login.username, cart[Convert.ToInt16(btn.Name) - 1].ItemName);
            cart.removeItem(Convert.ToInt16(btn.Name)-1);
            
            repopulateCart();
        }
    }
}
