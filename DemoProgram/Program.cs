using System;
using MyApp;
 
 class Program {

    static void Main()
    {
        Date joining =new Date (22,8,2024);
        Date leaving =new Date (23,8,2025);

        Employee emp = new Employee(25, "sanika", joining , leaving);

        Console.WriteLine(emp);

    }
 }