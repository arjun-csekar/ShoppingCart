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
    public partial class Signup : Form
    {
        /// <summary>
        /// Signup Form
        /// </summary>
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            bool result = await db.ifExists(textBox1.Text);
            if (!result)
            {
                await db.addUser(textBox1.Text, textBox2.Text);
                Login login = new Login();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already exists");
            }
        }
    }
}
