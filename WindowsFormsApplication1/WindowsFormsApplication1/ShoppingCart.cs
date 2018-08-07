using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ShoppingCart
    {

        List<Item> cart;

        public ShoppingCart()
        {
            cart = new List<Item>();
        }

        public void addItem(String name, int number, decimal price)
        {
            Item newItem = new Item(name, number, price);
        }

        public void removeItem(int at)
        {
            cart.RemoveAt(at);
        }

    }
}
