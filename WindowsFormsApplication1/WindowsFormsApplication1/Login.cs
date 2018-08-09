﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            await ac.loginUser(textBox1.Text, textBox2.Text);
            if (ac.dataExists)
            {
                Search s = new WindowsFormsApplication1.Search();
                s.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}
