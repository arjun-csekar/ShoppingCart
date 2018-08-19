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
        /// <summary>
        /// Shopping cart object.
        /// </summary>
        public ShoppingCart()
        {
            cart = new List<Item>();
        }

        /// <summary>
        /// Add item to the cart
        /// </summary>
        /// <param name="name">Item Name</param>
        /// <param name="number">Item Number</param>
        /// <param name="price">Item Price</param>
        public void addItem(String name, int number, decimal price)
        {
            Item newItem = new Item(name, number, price);
            cart.Add(newItem);
        }

        /// <summary>
        /// Remove from cart
        /// </summary>
        /// <param name="at">Index</param>
        public void removeItem(int at)
        {
            try {
                cart.RemoveAt(at);
            }
            catch (Exception e)
            {

            }
        }
        /// <summary>
        /// Returns cart
        /// </summary>
        /// <returns>Shopping cart</returns>
        public List<Item> returnCart()
        {
            return cart;
        }
        
        /// <summary>
        /// Shopping Cart Object
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Shopping Cart</returns>
        public Item this[int index]
        {
            get { return cart[index]; }
            set { cart[index] = value; }
        }
    }
}
