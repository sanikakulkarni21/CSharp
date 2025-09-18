using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task<int> task = CalculateAsync();
        Console.WriteLine("Main continues...");
        Console.WriteLine("Result: " + task.Result); // blocks until ready
    }

    static async Task<int> CalculateAsync()
    {
        await Task.Delay(1000); // simulate slow work
        return 42;
    }
}

