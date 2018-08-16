namespace WindowsFormsApplication1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLbl = new System.Windows.Forms.Label();
            this.usrNameTxtBox = new System.Windows.Forms.TextBox();
            this.usrNameLbl = new System.Windows.Forms.Label();
            this.passwrdLbl = new System.Windows.Forms.Label();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(39, 21);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(105, 40);
            this.loginLbl.TabIndex = 0;
            this.loginLbl.Text = "Login";
            // 
            // usrNameTxtBox
            // 
            this.usrNameTxtBox.Location = new System.Drawing.Point(46, 132);
            this.usrNameTxtBox.Name = "usrNameTxtBox";
            this.usrNameTxtBox.Size = new System.Drawing.Size(171, 26);
            this.usrNameTxtBox.TabIndex = 1;
            // 
            // usrNameLbl
            // 
            this.usrNameLbl.AutoSize = true;
            this.usrNameLbl.Location = new System.Drawing.Point(43, 90);
            this.usrNameLbl.Name = "usrNameLbl";
            this.usrNameLbl.Size = new System.Drawing.Size(83, 20);
            this.usrNameLbl.TabIndex = 2;
            this.usrNameLbl.Text = "Username";
            // 
            // passwrdLbl
            // 
            this.passwrdLbl.AutoSize = true;
            this.passwrdLbl.Location = new System.Drawing.Point(43, 181);
            this.passwrdLbl.Name = "passwrdLbl";
            this.passwrdLbl.Size = new System.Drawing.Size(78, 20);
            this.passwrdLbl.TabIndex = 3;
            this.passwrdLbl.Text = "Password";
            // 
            // passTxtBox
            // 
            this.passTxtBox.Location = new System.Drawing.Point(47, 221);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.PasswordChar = '*';
            this.passTxtBox.Size = new System.Drawing.Size(170, 26);
            this.passTxtBox.TabIndex = 4;
            this.passTxtBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Signup";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passTxtBox);
            this.Controls.Add(this.passwrdLbl);
            this.Controls.Add(this.usrNameLbl);
            this.Controls.Add(this.usrNameTxtBox);
            this.Controls.Add(this.loginLbl);
            this.Name = "Login";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox usrNameTxtBox;
        private System.Windows.Forms.Label usrNameLbl;
        private System.Windows.Forms.Label passwrdLbl;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}