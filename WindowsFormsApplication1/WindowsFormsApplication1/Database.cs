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

        //public bool checkVal;
        public string username;
        public string password;

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
                Data obj = response.ResultAs<Data>();
                username = obj.Username;
                password = obj.Password;
                return true;
            }
            catch
            {
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

        //public async Task getAttributes()
        //{

        //}
    }
}
