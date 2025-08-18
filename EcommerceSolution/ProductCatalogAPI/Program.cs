
using ProductCatalogAPI.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

app.MapGet("/api", () => "welcome to the weather forecast API");
app.MapGet("/api/products", async() =>
{
    await Task.FromResult(new[]
    {
    new Product { Id = 1, Title = "Smart laptop ", Price = 5000.23f, Description = "smart laptop" },
    new Product { Id = 2, Title = "smartphone", Price = 12.99f, Description = "communication device" },
    new Product { Id = 3, Title = "Tablet", Price = 15.99f, Description = "Handy device" }
 });
});

app.MapGet("/api/products/{id}", async(int id) =>
{
    await Task.FromResult(new Product { Id = id, Title = "Smart laptop ", Price = 5000.23f, Description = "smart laptop" });
});

app.MapGet("/api/cart", async() => await Task.FromResult( "list of items available in cart"));Console.WriteLine("Product Catalog API is running...");
app.MapGet("/api/orders", async() => await Task.FromResult("list of items placed in last 6 months"));Console.WriteLine("Product Catalog API cart is running...");
app.MapGet("/api/delivery", async() => await Task.FromResult("your shipment will be deliveredin 24 hours"));

app.Run();
