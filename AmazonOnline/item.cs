using Catalog;
 
namespace ShopingCart
{
    public class Item
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Item(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}    
