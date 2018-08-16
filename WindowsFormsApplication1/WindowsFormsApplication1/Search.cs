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
        private Login loginPage;
        private Boolean flag;


        public Search(Login li)
        {
          
            InitializeComponent();
            loginPage = li;
            li.Hide();
            cart = new ShoppingCart();
            searchContent = new WindowsFormsApplication1.SearchList();
            pageNumber = 1;
            this.Controls.Add(button4);
            this.Controls.Add(button1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(pictureBox1);
            flag = false;
            Database db = new Database();
            db.getCart(Login.username, cart.returnCart());
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
            button1.Name = rowNum.ToString();
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
            if (name != "None")
            {
                System.Windows.Forms.Button button1 = (System.Windows.Forms.Button)this.Controls[rowNum.ToString()];
                button1.Name = rowNum.ToString();
                button1.Size = new System.Drawing.Size(122, 29);
                button1.TabIndex = 4;
                button1.Text = "Add to Cart";
                button1.UseVisualStyleBackColor = true;
            }
            
            // 
            // button4
            // 

            System.Windows.Forms.Button button4 = (System.Windows.Forms.Button)this.Controls["button4" + rowNum];
            button4.Name = "button4" + rowNum;
            button4.Size = new System.Drawing.Size(86, 29);
            button4.TabIndex = 8;
            button4.Text = "Cart";
            button4.UseVisualStyleBackColor = true;
            
            // 
            // pictureBox1
            //
            PictureBox pictureBox1 = (PictureBox)this.Controls["pictureBox1" + rowNum];
            pictureBox1.Name = "pictureBox1" + rowNum;
            pictureBox1.Size = new System.Drawing.Size(230, 234);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                pictureBox1.Load(image);
            }
            catch(Exception e)
            {

            }

        }

        private void populateTable()
        {
            for (int i = 0 + (5 * (pageNumber - 1)),j=1; i < 5 + (5 * (pageNumber - 1)); i++,j++)
            {
                try
                {
                    populateTableRow(searchContent[i].ItemName, searchContent[i].ItemPrice.ToString("c"), searchContent[i].ItemDesc, searchContent[i].ImageLocation,j);
                }
                catch(ArgumentOutOfRangeException aoor)
                {
                    populateTableRow("", "", "", "", j);
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
                    populateTableRow2(searchContent[i].ItemName, searchContent[i].ItemPrice.ToString("c"), searchContent[i].ItemDesc, searchContent[i].ImageLocation, j);
                }
                catch (ArgumentOutOfRangeException aoor)
                {
                    populateTableRow2("", "", "", "", j);
                }
            }

            // 
            // button5
            // 
            
                this.button5 = (System.Windows.Forms.Button)this.Controls["button5"];
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

        private async void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            try
            {
                this.cart.addItem(searchContent[Convert.ToInt16(btn.Name) - 1 + ((pageNumber - 1) * 5)].ItemName, Convert.ToInt16(btn.Name) + ((pageNumber - 1) * 5), searchContent[Convert.ToInt16(btn.Name) - 1 + ((pageNumber - 1) * 5)].ItemPrice);
            }
            catch(Exception except)
            {

            }
            Database db = new Database();
            await db.addCart(Login.username, cart.returnCart());
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
            pageNumber = 1;
            searchContent.clear();

            HtmlParse html = new HtmlParse(SearchBox.Text);


            int i = 0;
            foreach (SearchItem item in html.GetList())
            {
                i++;
                
                searchContent.addItem(item.ItemName, item.ItemPrice.ToString(), "", item.ImageLocation);

                if (i == 50) break;
            }
            
            int count = searchContent.getCount();
            totalPages = (int)Math.Ceiling(Convert.ToDecimal(count) / 5.0m);

            if (flag == false)
            {
                populateTable();
                flag = true;
            }
            else
            {
                populateTable2();
            }
            
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPage.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }
    }
}
