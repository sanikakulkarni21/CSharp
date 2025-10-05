using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;

namespace TesterApp
{
     class InheritanceTest
    {
        static void Main(string[] args)
        {
            DateTime birthDate = new DateTime(2002, 5, 15);
            Person thePerson = new Person("John" , "Doe" , birthDate);
            Console.WriteLine(thePerson);

            Employee emp1 = new Employee("Jane", "Smith", new DateTime(1990, 3, 22), 101, "IT", 60000m, 220);
            //new method to create object ....when we to create 2 object
            decimal salary1 = emp1.CalculateSalary();
            Console.WriteLine("jane Smith={0}",salary1);


            Employee emp2 = new SalesEmployee("Jane", "Smith", new DateTime(1990, 3, 22), 101, "IT", 60000m, 220);
            //new method to create object ....when we to create 2 object
            decimal salary2 = emp2.CalculateSalary();
            Console.WriteLine("jane Smith={0}", salary2);


           // Person prn = thePerson;//pointing to instance of person
            //polymorphism for ToString method will be worked
            Person prn = emp1;//pointing to instance of employee
            Person prn1 = emp2;//pointing to instance of sales employee
            Console.WriteLine(prn);

            Console.ReadLine();

        }
    }
}
