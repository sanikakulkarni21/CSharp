using System.Data;
using DisconnectedAdoDemo.Data;
using DisconnectedAdoDemo.Models;

Console.WriteLine("=== Disconnected ADO.NET Demo (MySQL) ===");

var repo = new ProductRepository();

// Insert operation
repo.InsertProduct(new Product { Name = "Wireless Mouse", Price = 899.99m });
repo.InsertProduct(new Product { Name = "Keyboard", Price = 1000m });
Console.WriteLine("product inserted successfully");

// Fetch and Display
var products = repo.GetProducts();
foreach (DataRow row in products.Rows)
{
    Console.WriteLine($"{row["Id"]} - {row["Name"]} - ₹{row["Price"]}");
}


// Update
repo.UpdateProduct(new Product { Id = 1, Name = "Ergonomic Mouse", Price = 1099.00m });
Console.WriteLine("product updated successfully");


// Delete
repo.DeleteProduct(1);
Console.WriteLine("product has been deleted ");