using Catalog;

int count=45;
count++;

Console.WriteLine("Count="+count);
Console.WriteLine("Hello, World!");

Product p = new Product();
p.Id=1;
p.Title = "sapiens";
p.Description = "A brief history of humankind";
p.Price = 10.99f;
Console.WriteLine($"Product: {p.Id},{p.Title},{p.Description},{p.Price}");

Product p2 = new Product();
p2.Id=2;
p2.Title = "Rich dad poor dad";
p2.Description = "A book on personal finance";
p2.Price = 6.99f;
Console.WriteLine($"Product: {p2.Id},{p2.Title},{p2.Description},{p2.Price}");
