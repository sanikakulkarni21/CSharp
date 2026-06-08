//Array

// int [] numbers= {1, 2, 3, 4, 5};

// foreach(int num in numbers)
// {
//     Console.WriteLine(num);
//     }

//list example

// List<string> names = new List<string>{"sanika", "sejal", "rutuja", "pranita"};

// foreach(string name in names)
// {
//     Console.WriteLine(name);
//     Console.WriteLine(name.Length);
//     Console.WriteLine(name + " soham");
//     names.Add("sayali");
// }

//with params
using System.Collections.Generic;

public class Program
{
    public static void PrintNames( List<string>[] names)
    {
        foreach(var nameList in names)
        {
            foreach(var name in nameList)
            {
                Console.WriteLine(name);
                Console.WriteLine(name.Length);
            //PrintNames.Add("sayali");
            }
        }
    }
    public static void Main(string[] args )
    {
        List<string> names = new List<string>{"sanika", "sejal", "rutuja", "pranita"};
       // List<string> newNames = new List<string>{"sayali", "siddhi"};
        PrintNames(names);
        // PrintNames(newNames);
    }
    
}




