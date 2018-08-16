using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WindowsFormsApplication1
{
    class Database
    {
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

        public async Task addCart(string username, List<Item> items)
        {
            var data = new Item
            {
                ItemName = "",
                ItemPrice = 0.0m
            };
            
            foreach (Item i in items)
            {
                data.ItemName = i.ItemName;
                data.ItemPrice = i.ItemPrice;
                string newName = i.ItemName.Replace(".", "%");
                SetResponse response = await client.SetTaskAsync("Cart/" + username + "/" + newName, data);
                Item result = response.ResultAs<Item>();
            }
        }

        public async Task getCart(string username, List<Item> items)
        {
            var data = new Item
            {
                ItemName = "",
                ItemPrice = 0.0m
            };

            FirebaseResponse response = await client.GetTaskAsync("Cart/" + username);

            Dictionary<string, Item> detail = response.ResultAs<Dictionary<string, Item>>();
            
            foreach (KeyValuePair<string, Item> entry in detail)
            {
                Item item = new Item();
                item.ItemName = entry.Value.ItemName;
                item.ItemPrice = entry.Value.ItemPrice;
                items.Add(item);
            }
        }

        public async Task removeItemCart(string username, string name)
        {
            int j = 1;
            name = name.Replace(".", "%");
            FirebaseResponse response = await client.DeleteTaskAsync("Cart/" + username + "/" + name);
        }
    }
}
