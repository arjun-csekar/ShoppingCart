using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Account
    {
        private string username = "";
        private string password = "";
        public bool dataExists;

        public Account() { }

        public async Task loginUser(string username, string password)
        {
            Database db = new Database();

            bool result = await db.ifExists(username);

            if (result)
            {
                if (db.password == password)
                {
                    this.username = username;
                    this.password = password;
                    dataExists = true;
                }
                else
                {
                    dataExists = false;
                }
                
            }
            else
            {
                dataExists = false;
            }
        }
    }
}
