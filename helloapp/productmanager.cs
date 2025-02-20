namespace Catalog;

public class ProductManager{
    public bool Insert(Product prd){
        return false;
    }
    public bool Update(Product prd){
       
        return true;
    }
    public bool Delete(int productId){
        return false;
    }
    public List<Product> GetAll(){

      List<Product> allProducts=new List<Product>();  //empty list
        
        allProducts.Add(new Product{
            Id = 1,
            Title = "Rose",
            Description = "Valentine Flower",
            Quantity = 6000,
            Price = 12
        });
        allProducts.Add(new Product{
            Id = 2,
            Title = "Tulip",
            Description = "Spring Flower",
            Quantity = 3000,
            Price = 8
        });
        allProducts.Add(new Product{
            Id = 3,
            Title = "Sunflower",
            Description = "Summer Flower",
            Quantity = 1500,
            Price = 10
        });
        return allProducts;
    }

    public Product GetProductById(int productId){
       
        return new Product{
            Id = productId,
            Title = "Rose",
            Description = "Valentine Flower",
            Quantity = 6000,
            Price =12
        };
    }
}