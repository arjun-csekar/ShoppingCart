using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WindowsFormsApplication1
{
    class Database
    {

        public bool checkVal;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0aYQJJHRuD0tv6mVDyVEnfRwF0gsdyT6ruakuaYD",
            BasePath = "https://fir-test-6d602.firebaseio.com/"
        };

        IFirebaseClient client;

        public Database()
        {
            client = new FireSharp.FirebaseClient(config);
        }

        public async Task<bool> ifExists(string name)
        {
            try
            {
                FirebaseResponse response = await client.GetTaskAsync("Information/" + name);
                response.ResultAs<Data>();
                checkVal = true;
                System.Diagnostics.Debug.WriteLine("Inside");
                return true;
            }
            catch
            {
                checkVal = false;
                System.Diagnostics.Debug.WriteLine("outside");
                return false;
            }
        }

        public async Task addUser(string username, string password)
        {
            var data = new Data
            {
                Username = username,
                Password = password
            };

            SetResponse response = await client.SetTaskAsync("Information/" + username, data);
            Data result = response.ResultAs<Data>();
        }
    }
}
