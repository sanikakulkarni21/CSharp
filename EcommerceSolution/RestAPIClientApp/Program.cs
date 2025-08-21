

//inbuilt REST API Client

using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Text;

var client = new HttpClient();
client.BaseAddress = new Uri("https://localhost:5007/");


try
{
    //get request
    var response = await client.GetAsync("api/products");
    response.EnsureSuccessStatusCode();
    var content = await response.Content.ReadAsStringAsync();
    Console.WriteLine("Get Response:" + content);



}

catch (Exception ex)
{ 
Console.WriteLine("An error occurred: " + ex.Message);
}
finally
{
    client.Dispose();
}