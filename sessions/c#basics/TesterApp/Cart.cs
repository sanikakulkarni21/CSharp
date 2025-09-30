using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Cart
    {
        private List<Item> items = new List<Item>();//generic list collection of items


        public List<Item> Items { 
        get { return items; }
            set { items = value; }
        }


        public void AddTocart(Item newItem)
        {
            items.Add(newItem);
        }

        public void RemoveFromCart(Item oldItem)
        {
            items.Remove(oldItem);
        }
    }
}
