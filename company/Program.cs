using System;

class Program
{
    static void Main()
    {
        Address addr = new Address("chakan", "Maharashtra", "410501");


        Console.WriteLine("\nSales Employee Info:");
        SalesEmployee salesEmp = new SalesEmployee(24, "sejal kulkarni", 60000, 5000, addr);
        salesEmp.Display();
    }
}


