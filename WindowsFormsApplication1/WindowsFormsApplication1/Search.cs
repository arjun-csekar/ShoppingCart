using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApplication1
{
    public partial class Search : Form
    {

        ShoppingCart cart;
        SearchList searchContent;
         
        public Search()
        {
          
            InitializeComponent();
            cart = new ShoppingCart();
            searchContent = new WindowsFormsApplication1.SearchList();
            populate_picturebox();


        }

        public void populateTableRow(String name, String price, String desc, String image, int rowNum)
        {
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 155 + (245 * (rowNum - 1)));
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = name;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 192 + (245 * (rowNum - 1)));
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = price;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 232 + (245 * (rowNum - 1)));
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = desc;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 352 + (245 * (rowNum - 1)));
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(710, 352 + (245 * (rowNum - 1)));
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cart";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 148 + (245 * (rowNum - 1)));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 234);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(image);

            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
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
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(this.cart);
            cart.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            searchContent.addItem("1: Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver", "84.59", ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.", "https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            searchContent.addItem("2: Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver", "84.59", ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.", "https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            searchContent.addItem("3: Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver", "84.59", ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.", "https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            searchContent.addItem("4: Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver", "84.59", ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.", "https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            searchContent.addItem("5: Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver", "84.59", ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.", "https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            searchContent.addItem("6: Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver", "84.59", ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.", "https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            searchContent.addItem("7: Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver", "84.59", ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.", "https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            searchContent.addItem("8: Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver", "84.59", ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.", "https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            searchContent.addItem("9: Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver", "84.59", ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.", "https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            int count = searchContent.getCount();
            int pages = count / 5;

            
            
            for(int i = 0; i<5; i++)
            {
                populateTableRow(searchContent[i].ItemName, searchContent[i].ItemPrice.ToString("c1"), searchContent[i].ItemDesc, searchContent[i].ImageLocation, i + 1);
                
            }


            //pictureBox1.Load("https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //label1.Text += ": Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver";
            //label2.Text += ": $84.59";
            //label3.Text += ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.";
        }

        
    }
}
