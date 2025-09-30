using Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Item
    {
        public Product theProduct { get; set; }
        public int quantity { get; set; }


        public Item(Product theProduct, int Quantity)
        {
            theProduct = theProduct;
            Quantity = quantity;
        }
    }
}
