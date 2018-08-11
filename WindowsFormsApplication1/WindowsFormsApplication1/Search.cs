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
        int pageNumber;
        int totalPages;
        System.Windows.Forms.Button button5;
        System.Windows.Forms.Button button6;
        System.Windows.Forms.Button button4;
        System.Windows.Forms.Button button1;
        System.Windows.Forms.Label label3;
        System.Windows.Forms.Label label2;
        System.Windows.Forms.Label label1;
        System.Windows.Forms.PictureBox pictureBox1;



        public Search()
        {
          
            InitializeComponent();
            cart = new ShoppingCart();
            searchContent = new WindowsFormsApplication1.SearchList();
            pageNumber = 1;
            this.Controls.Add(button4);
            this.Controls.Add(button1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(pictureBox1);

        }

        public void populateTableRow(String name, String price, String desc, String image, int rowNum)
        {


            button4 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(328, 155 + (245 * (rowNum - 1)));
            label1.Name = "label1"+rowNum;
           
            label1.Size = new System.Drawing.Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = name;
            

            
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(328, 192 + (245 * (rowNum - 1)));
            label2.Name = "label2" + rowNum;
            label2.Size = new System.Drawing.Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = price;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(328, 232 + (245 * (rowNum - 1)));
            label3.Name = "label3" + rowNum;
            label3.Size = new System.Drawing.Size(125, 20);
            label3.TabIndex = 3;
            label3.Text = desc;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(332, 352 + (245 * (rowNum - 1)));
            button1.Name = "button1"+rowNum;
            button1.Size = new System.Drawing.Size(122, 29);
            button1.TabIndex = 4;
            button1.Text = "Add to Cart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(710, 352 + (245 * (rowNum - 1)));
            button4.Name = "button4"+rowNum;
            button4.Size = new System.Drawing.Size(86, 29);
            button4.TabIndex = 8;
            button4.Text = "Cart";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(button4_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(52, 148 + (245 * (rowNum - 1)));
            pictureBox1.Name = "pictureBox1"+rowNum;
            pictureBox1.Size = new System.Drawing.Size(230, 234);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(image);

            this.Controls.Add(button4);
            this.Controls.Add(button1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(pictureBox1);

        }

        public void populateTableRow2(String name, String price, String desc, String image, int rowNum)
        {

            // 
            // label1
            // 
            Label label1 = (Label)this.Controls["label1" + rowNum];
            label1.AutoSize = true;

            label1.Name = "label1" + rowNum;

            label1.Size = new System.Drawing.Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = name;




            // 
            // label2
            // 
            Label label2 = (Label)this.Controls["label2" + rowNum];
            label2.AutoSize = true;
            
            label2.Name = "label2" + rowNum;
            label2.Size = new System.Drawing.Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = price;
            // 
            // label3
            // 

            Label label3 = (Label)this.Controls["label3" + rowNum];
            label3.AutoSize = true;
            
            label3.Name = "label3" + rowNum;
            label3.Size = new System.Drawing.Size(125, 20);
            label3.TabIndex = 3;
            label3.Text = desc;
            // 
            // button1
            // 

            System.Windows.Forms.Button button1 = (System.Windows.Forms.Button)this.Controls["button1" + rowNum];
            button1.Name = "button1" + rowNum;
            button1.Size = new System.Drawing.Size(122, 29);
            button1.TabIndex = 4;
            button1.Text = "Add to Cart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // button4
            // 

            System.Windows.Forms.Button button4 = (System.Windows.Forms.Button)this.Controls["button4" + rowNum];
            button4.Name = "button4" + rowNum;
            button4.Size = new System.Drawing.Size(86, 29);
            button4.TabIndex = 8;
            button4.Text = "Cart";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(button4_Click);
            // 
            // pictureBox1
            //
            PictureBox picturebox1 = (PictureBox)this.Controls["pictureBox1" + rowNum];
            pictureBox1.Name = "pictureBox1" + rowNum;
            pictureBox1.Size = new System.Drawing.Size(230, 234);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(image);

        }

        private void populateTable()
        {
            for (int i = 0 + (5 * (pageNumber - 1)),j=1; i < 5 + (5 * (pageNumber - 1)); i++,j++)
            {
                try
                {
                    populateTableRow(searchContent[i].ItemName, searchContent[i].ItemPrice.ToString("c1"), searchContent[i].ItemDesc, searchContent[i].ImageLocation,j);
                }
                catch(ArgumentOutOfRangeException aoor)
                {

                }
            }

            // 
            // button5
            // 
            
                this.button5 = new System.Windows.Forms.Button();
                this.button5.Location = new System.Drawing.Point(332, 148 + (245 * (6 - 1)));
                this.button5.Name = "button5";
                this.button5.Size = new System.Drawing.Size(122, 29);
                this.button5.TabIndex = 4;
                this.button5.Text = "Prev";
                this.button5.UseVisualStyleBackColor = true;
                this.button5.Click += new System.EventHandler(this.button5_Click);
                this.Controls.Add(this.button5);
            
            // 
            // button6
            // 
            
                this.button6 = new System.Windows.Forms.Button();
                this.button6.Location = new System.Drawing.Point(710, 148 + (245 * (6 - 1)));
                this.button6.Name = "button6";
                this.button6.Size = new System.Drawing.Size(86, 29);
                this.button6.TabIndex = 8;
                this.button6.Text = "Next";
                this.button6.UseVisualStyleBackColor = true;
                this.button6.Click += new System.EventHandler(this.button6_Click);
                this.Controls.Add(this.button6);
            
        }

        private void populateTable2()
        {
            for (int i = 0 + (5 * (pageNumber - 1)), j = 1; i < 5 + (5 * (pageNumber - 1)); i++, j++)
            {
                try
                {
                    populateTableRow2(searchContent[i].ItemName, searchContent[i].ItemPrice.ToString("c1"), searchContent[i].ItemDesc, searchContent[i].ImageLocation, j);
                }
                catch (ArgumentOutOfRangeException aoor)
                {

                }
            }

            // 
            // button5
            // 
            
                this.button6 = (System.Windows.Forms.Button)this.Controls["button6"];
                this.button5.Name = "button5";
                this.button5.Size = new System.Drawing.Size(122, 29);
                this.button5.TabIndex = 4;
                this.button5.Text = "Prev";
                this.button5.UseVisualStyleBackColor = true;
                this.button5.Click += new System.EventHandler(this.button5_Click);
                this.Controls.Add(this.button5);
            
            // 
            // button6
            // 
            
                this.button6 = (System.Windows.Forms.Button)this.Controls["button6"];
                this.button6.Name = "button6";
                this.button6.Size = new System.Drawing.Size(86, 29);
                this.button6.TabIndex = 8;
                this.button6.Text = "Next";
                this.button6.UseVisualStyleBackColor = true;
                this.button6.Click += new System.EventHandler(this.button6_Click);
                this.Controls.Add(this.button6);
            
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

        private void button5_Click(object sender, EventArgs e)
        {   
            if (pageNumber > 1) { pageNumber--;  populateTable2(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pageNumber < totalPages) { pageNumber++; populateTable2(); }         
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
            totalPages = (int)Math.Ceiling(Convert.ToDecimal(count) / 5.0m);

            populateTable();
            
            

            //pictureBox1.Load("https://images-na.ssl-images-amazon.com/images/I/41x0As6IqmL._AC_US218_.jpg");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //label1.Text += ": Dell Latitude D630 14.1-Inch Notebook PC (OS may vary) - Silver";
            //label2.Text += ": $84.59";
            //label3.Text += ": The Dell Latitude D630 Notebook PC comes with an Intel Core 2 Duo\nT7250 2GHz processor, 2GB DDR2 of memory, a 80GB hard drive, combo optical drive, wifi, and\nWindows XP Professional Operating System.";
        }

        
    }
}
