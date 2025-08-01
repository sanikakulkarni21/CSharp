
using System.Text.Json;
using System.IO;
using jsonSreializationApp.Entities;

Product product1 = new Product();

product1.Id = 1;
product1.Name = "Laptop";
product1.Description = "Asus";
product1.Price = 60000;

Product product2 = new Product();
product2.Id = 2;
product2.Name = "mobile";
product2.Description = "one plus";
product2.Price = 20000;

Product product3 = new Product();
product3.Id = 3;
product3.Name = "Tv";
product3.Description = "hier";
product3.Price = 50000;

Product product4 = new Product();   
product4.Id = 4;
product4.Name = "Tablet";
product4.Description = "Samsung";
product4.Price = 60000;

List<Product> allProducts = new List<Product>();
allProducts.Add(product1);
allProducts.Add(product2);
allProducts.Add(product3);
allProducts.Add(product4);



string filePath = @"D:\Tap\CSharp\c#debugging\product.json";
string jsonString = JsonSerializer.Serialize(allProducts);
Console.WriteLine(jsonString);
File.WriteAllText(filePath, jsonString);



string retrivredJsonString = File.ReadAllText(filePath);
List<Product> allRestoredProducts= JsonSerializer.Deserialize<List<Product>>(retrivredJsonString); 

foreach(Product retrivedProduct in allRestoredProducts)
{
    Console.WriteLine(retrivedProduct.Id + " " + retrivedProduct.Name + " " + retrivedProduct.Description + " " + retrivedProduct.Price);
}
