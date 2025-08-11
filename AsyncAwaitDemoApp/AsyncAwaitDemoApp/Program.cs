
//System.Threading.Thread.Sleep(10000); // raw level multithraeading ......Simulating some work before printing the message
using System.Threading.Tasks;


Console.WriteLine("welcome to transflower.....");
Task.Delay(10000).Wait(); // Simulating some work before printing the message
Console.WriteLine("Hello,World");
Console.WriteLine("Press any key to exit!.....");
