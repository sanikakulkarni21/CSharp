using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("hello " + args[i]);
            }
           
            Console.WriteLine("welcome to dotnet programming");
            int count = 45;
            count = count++;
            if (count <= 300)
            {
                while (count < 299)
                { 
                Console.WriteLine("count={0}",count);
                    count++;
                }
            }
            Console.WriteLine("enter your name");
            
            String name =Console.ReadLine();
            Console.WriteLine("godmorning{0}", name);
            Console.ReadLine();

        }
    }
}
