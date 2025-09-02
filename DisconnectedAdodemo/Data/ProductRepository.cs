using System.Data;
using MySql.Data.MySqlClient;
using DisconnectedAdoDemo.Models;

namespace DisconnectedAdoDemo.Data;

public class ProductRepository
{
    
    private string connectionString =
        "Server=localhost;Port=3307;Database=ado_demo;Uid=root;Pwd=root;SslMode=None;";

    private MySqlDataAdapter GetDataAdapter(MySqlConnection connection)
    {
        var selectCommand = new MySqlCommand("SELECT * FROM Products", connection);
        var adapter = new MySqlDataAdapter(selectCommand);

        // Let the builder auto-generate Insert/Update/Delete commands
            new MySqlCommandBuilder(adapter);

        return adapter;
    }

    public DataTable GetProducts()
    {
        using var connection = new MySqlConnection(connectionString);
        var adapter = GetDataAdapter(connection);

        var table = new DataTable("Products");
        adapter.Fill(table); // loads all rows of table into memory
        return table;
    }

    public void InsertProduct(Product product)
    {
        using var connection = new MySqlConnection(connectionString);
        var adapter = GetDataAdapter(connection);

        var table = new DataTable("Products");
        adapter.Fill(table);

        var newRow = table.NewRow();
        newRow["Name"] = product.Name;
        newRow["Price"] = product.Price;
        table.Rows.Add(newRow);

        adapter.Update(table); // pushes changes (insert) back to DB
    }

    public void UpdateProduct(Product product)
    {
        using var connection = new MySqlConnection(connectionString);
        var adapter = GetDataAdapter(connection);

        var table = new DataTable("Products");
        adapter.Fill(table);

        // Find row by PK in DataTable
        var rows = table.Select($"Id = {product.Id}");
        if (rows.Length > 0) 
        {
            rows[0] ["Name"]=product.Name;
             rows[0] ["Price"]=product.Price;
             adapter.Update(table);
        }
    }

    public void DeleteProduct(int productId)
    {
        using var connection = new MySqlConnection(connectionString);
        var adapter = GetDataAdapter(connection);

        var table = new DataTable("Products");
        adapter.Fill(table);

        var rows = table.Select($"Id = {productId}");
        if (rows.Length > 0)
        {

        rows[0].Delete();          // marks as Deleted in memory
        adapter.Update(table);     // pushes delete back to DB
        
        }
    }
}