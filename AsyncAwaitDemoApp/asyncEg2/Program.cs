using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncEg2
{
    async Task<string> FetchAsync()
    {
        await Task.Delay(2000); // doesn't block the thread
        return "data";
    }

    private async Task MainAsync()
    {
        Task<string> fetchTask = FetchAsync(); // starts work, returns immediately
        Console.WriteLine("Doing other work while fetch runs...");
        string result = await fetchTask;       // awaits completion without blocking the thread
        Console.WriteLine("Got: " + result);
    }

}
