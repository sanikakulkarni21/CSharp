using System;

class Program
{
    static void Main(string[] args)
    {
       Employee employee;

       Employee employee1=new SalesEmployee(1,"sanika",5000,2000,15000);

       Employee employee2=new SalesManager(2,"sneha",6000,3000,20000,5000);

       employee1.DoWork();
       Console.WriteLine($"Computed Pay: {employee1.ComputePay()}");

       employee2.DoWork();
       Console.WriteLine($"Computed Pay: {employee2.ComputePay()}");

       Console.WriteLine(employee1);
       Console.WriteLine(employee2);
      

    }
}
