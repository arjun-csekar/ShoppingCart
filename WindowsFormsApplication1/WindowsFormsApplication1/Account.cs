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
        public Account(string username, string password)
        {
            /*Database db = new Database();

            bool result = await db.ifExists(username);

            System.Diagnostics.Debug.WriteLine(db.checkVal);
            if (db.checkVal)
            {
                this.username = username;
                this.password = password;
                dataExists = true;
                System.Diagnostics.Debug.WriteLine(dataExists);
            }
            else
            {
                dataExists = false;
            }*/
        }

        public async Task testing(string username, string password)
        {
            Database db = new Database();

            bool result = await db.ifExists(username);

            System.Diagnostics.Debug.WriteLine(db.checkVal);
            if (result)
            {
                this.username = username;
                this.password = password;
                dataExists = true;
                System.Diagnostics.Debug.WriteLine(dataExists);
            }
            else
            {
                dataExists = false;
            }
        }
    }
}
