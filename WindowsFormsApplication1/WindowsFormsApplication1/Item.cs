using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Item
    {

        public Item()
        {
            ItemName = "";
            ItemNum = 0;
            ItemPrice = 0.0m;
        }

        public Item(String name, int number, decimal price)
        {
            ItemName = name;
            ItemNum = number;
            ItemPrice = price;
        }

        public String ItemName { get; set; }

        public int ItemNum { get; set; }

        public decimal ItemPrice { get; set; }
    }
}
