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
        System.Windows.Forms.Button prevBtn;
        System.Windows.Forms.Button nextBtn;
        System.Windows.Forms.Button cartPageBtn;
        System.Windows.Forms.Button addToCartBtn;
        System.Windows.Forms.Label descriptionLbl;
        System.Windows.Forms.Label priceLbl;
        System.Windows.Forms.Label nameLbl;
        System.Windows.Forms.PictureBox itemPicBox;
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
            this.Controls.Add(cartPageBtn);
            this.Controls.Add(addToCartBtn);
            this.Controls.Add(descriptionLbl);
            this.Controls.Add(priceLbl);
            this.Controls.Add(nameLbl);
            this.Controls.Add(itemPicBox);
            flag = false;
            Database db = new Database();
            db.getCart(Login.username, cart.returnCart());
        }

        public void populateTableRow(String name, String price, String desc, String image, int rowNum)
        {


            cartPageBtn = new System.Windows.Forms.Button();
            addToCartBtn = new System.Windows.Forms.Button();
            descriptionLbl = new System.Windows.Forms.Label();
            priceLbl = new System.Windows.Forms.Label();
            nameLbl = new System.Windows.Forms.Label();
            itemPicBox = new System.Windows.Forms.PictureBox();

            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new System.Drawing.Point(328, 155 + (245 * (rowNum - 1)));
            nameLbl.Name = "nameLbl"+rowNum;
           
            nameLbl.Size = new System.Drawing.Size(87, 20);
            nameLbl.TabIndex = 1;
            nameLbl.Text = name;
            

            
           
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new System.Drawing.Point(328, 192 + (245 * (rowNum - 1)));
            priceLbl.Name = "priceLbl" + rowNum;
            priceLbl.Size = new System.Drawing.Size(80, 20);
            priceLbl.TabIndex = 2;
            priceLbl.Text = price;
            // 
            // descriptionLbl
            // 
            descriptionLbl.AutoSize = true;
            descriptionLbl.Location = new System.Drawing.Point(328, 232 + (245 * (rowNum - 1)));
            descriptionLbl.Name = "descriptionLbl" + rowNum;
            descriptionLbl.Size = new System.Drawing.Size(125, 20);
            descriptionLbl.TabIndex = 3;
            descriptionLbl.Text = desc;
            // 
            // addToCartBtn
            // 
            addToCartBtn.Location = new System.Drawing.Point(332, 352 + (245 * (rowNum - 1)));
            addToCartBtn.Name = rowNum.ToString();
            addToCartBtn.Size = new System.Drawing.Size(122, 29);
            addToCartBtn.TabIndex = 4;
            addToCartBtn.Text = "Add to Cart";
            addToCartBtn.UseVisualStyleBackColor = true;
            addToCartBtn.Click += new System.EventHandler(addToCartBtn_Click);
            // 
            // cartPageBtn
            // 
            cartPageBtn.Location = new System.Drawing.Point(710, 352 + (245 * (rowNum - 1)));
            cartPageBtn.Name = "cartPageBtn"+rowNum;
            cartPageBtn.Size = new System.Drawing.Size(86, 29);
            cartPageBtn.TabIndex = 8;
            cartPageBtn.Text = "Cart";
            cartPageBtn.UseVisualStyleBackColor = true;
            cartPageBtn.Click += new System.EventHandler(cartPageBtn_Click);
            // 
            // itemPicBox
            // 
            itemPicBox.Location = new System.Drawing.Point(52, 148 + (245 * (rowNum - 1)));
            itemPicBox.Name = "itemPicBox"+rowNum;
            itemPicBox.Size = new System.Drawing.Size(230, 234);
            itemPicBox.TabIndex = 0;
            itemPicBox.TabStop = false;
            itemPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            itemPicBox.Load(image);

            this.Controls.Add(cartPageBtn);
            this.Controls.Add(addToCartBtn);
            this.Controls.Add(descriptionLbl);
            this.Controls.Add(priceLbl);
            this.Controls.Add(nameLbl);
            this.Controls.Add(itemPicBox);

        }

        public void populateTableRow2(String name, String price, String desc, String image, int rowNum)
        {

            // 
            // nameLbl
            // 
            Label nameLbl = (Label)this.Controls["nameLbl" + rowNum];
            nameLbl.AutoSize = true;

            nameLbl.Name = "nameLbl" + rowNum;

            nameLbl.Size = new System.Drawing.Size(87, 20);
            nameLbl.TabIndex = 1;
            nameLbl.Text = name;




            // 
            // priceLbl
            // 
            Label priceLbl = (Label)this.Controls["priceLbl" + rowNum];
            priceLbl.AutoSize = true;
            
            priceLbl.Name = "priceLbl" + rowNum;
            priceLbl.Size = new System.Drawing.Size(80, 20);
            priceLbl.TabIndex = 2;
            priceLbl.Text = price;
            // 
            // descriptionLbl
            // 

            Label descriptionLbl = (Label)this.Controls["descriptionLbl" + rowNum];
            descriptionLbl.AutoSize = true;
            
            descriptionLbl.Name = "descriptionLbl" + rowNum;
            descriptionLbl.Size = new System.Drawing.Size(125, 20);
            descriptionLbl.TabIndex = 3;
            descriptionLbl.Text = desc;
            // 
            // addToCartBtn
            // 
            if (name != "None")
            {
                System.Windows.Forms.Button addToCartBtn = (System.Windows.Forms.Button)this.Controls[rowNum.ToString()];
                addToCartBtn.Name = rowNum.ToString();
                addToCartBtn.Size = new System.Drawing.Size(122, 29);
                addToCartBtn.TabIndex = 4;
                addToCartBtn.Text = "Add to Cart";
                addToCartBtn.UseVisualStyleBackColor = true;
            }
            
            // 
            // cartPageBtn
            // 

            System.Windows.Forms.Button cartPageBtn = (System.Windows.Forms.Button)this.Controls["cartPageBtn" + rowNum];
            cartPageBtn.Name = "cartPageBtn" + rowNum;
            cartPageBtn.Size = new System.Drawing.Size(86, 29);
            cartPageBtn.TabIndex = 8;
            cartPageBtn.Text = "Cart";
            cartPageBtn.UseVisualStyleBackColor = true;
            
            // 
            // itemPicBox
            //
            PictureBox itemPicBox = (PictureBox)this.Controls["itemPicBox" + rowNum];
            itemPicBox.Name = "itemPicBox" + rowNum;
            itemPicBox.Size = new System.Drawing.Size(230, 234);
            itemPicBox.TabIndex = 0;
            itemPicBox.TabStop = false;
            itemPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                itemPicBox.Load(image);
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
            // prevBtn
            // 
            
                this.prevBtn = new System.Windows.Forms.Button();
                this.prevBtn.Location = new System.Drawing.Point(332, 148 + (245 * (6 - 1)));
                this.prevBtn.Name = "prevBtn";
                this.prevBtn.Size = new System.Drawing.Size(122, 29);
                this.prevBtn.TabIndex = 4;
                this.prevBtn.Text = "Prev";
                this.prevBtn.UseVisualStyleBackColor = true;
                this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
                this.Controls.Add(this.prevBtn);
            
            // 
            // nextBtn
            // 
            
                this.nextBtn = new System.Windows.Forms.Button();
                this.nextBtn.Location = new System.Drawing.Point(710, 148 + (245 * (6 - 1)));
                this.nextBtn.Name = "nextBtn";
                this.nextBtn.Size = new System.Drawing.Size(86, 29);
                this.nextBtn.TabIndex = 8;
                this.nextBtn.Text = "Next";
                this.nextBtn.UseVisualStyleBackColor = true;
                this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
                this.Controls.Add(this.nextBtn);
            
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
            // prevBtn
            // 
            
                this.prevBtn = (System.Windows.Forms.Button)this.Controls["prevBtn"];
                this.prevBtn.Name = "prevBtn";
                this.prevBtn.Size = new System.Drawing.Size(122, 29);
                this.prevBtn.TabIndex = 4;
                this.prevBtn.Text = "Prev";
                this.prevBtn.UseVisualStyleBackColor = true;
                this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
                this.Controls.Add(this.prevBtn);
            
            // 
            // nextBtn
            // 
            
                this.nextBtn = (System.Windows.Forms.Button)this.Controls["nextBtn"];
                this.nextBtn.Name = "nextBtn";
                this.nextBtn.Size = new System.Drawing.Size(86, 29);
                this.nextBtn.TabIndex = 8;
                this.nextBtn.Text = "Next";
                this.nextBtn.UseVisualStyleBackColor = true;
                this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
                this.Controls.Add(this.nextBtn);
            
        }


        private void Search_Load(object sender, EventArgs e)
        {
            
        }

        private async void addToCartBtn_Click(object sender, EventArgs e)
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

        private void cartPageBtn_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(this.cart);
            cart.Show();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {   
            if (pageNumber > 1) { pageNumber--;  populateTable2(); }
        }

        private void nextBtn_Click(object sender, EventArgs e)
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
