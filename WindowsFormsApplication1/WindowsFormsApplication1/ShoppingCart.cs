using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class ShoppingCart
    {

        public List<Item> cart;

        public ShoppingCart()
        {
            cart = new List<Item>();
        }

        public void addItem(String name, int number, decimal price)
        {
            Item newItem = new Item(name, number, price);
            cart.Add(newItem);
        }

        public void removeItem(int at)
        {
            try {
                cart.RemoveAt(at);
            }
            catch (Exception e)
            {

            }
        }
        
        public List<Item> returnCart()
        {
            return cart;
        }
        
        public Item this[int index]
        {
            get { return cart[index]; }
            set { cart[index] = value; }
        }
    }
}
