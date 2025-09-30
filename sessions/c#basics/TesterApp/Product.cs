using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int ProductId { get;  }
        public decimal ProductPrice { get; set; }


        public Product(string Name, string Discription, string Category, int ProductId, decimal ProductPrice)
        { 
        this.Name = Name;
            this.Description = Discription;
            this.Category = Category;
            this.ProductId = ProductId;
            this.ProductPrice = ProductPrice;

        }
        ~Product() { }// destructor

        public override string ToString()// override method
        {
            return this.Name+" "+this.Description+""+this.Category+""+ this.ProductId+" "+this.ProductPrice;
        }

    }
}
