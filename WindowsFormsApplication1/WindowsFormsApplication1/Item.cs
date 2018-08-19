using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Item
    {
        /// <summary>
        /// Item Object
        /// </summary>
        public Item()
        {
            ItemName = "";
            ItemNum = 0;
            ItemPrice = 0.0m;
        }
        /// <summary>
        /// Item Object
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="number">Number</param>
        /// <param name="price">Price</param>
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
