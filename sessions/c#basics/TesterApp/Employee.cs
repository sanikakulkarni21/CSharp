using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Employee: Person
    {
        public Employee():base() //default constructor
        {
            this.ID = 0;
            this.Department = "";
            this.BasicSalary = 0;
        }
        public Employee(string fName, string lName, DateTime bdate, int id, string dept, decimal salary, int daysWorked)
            : base(fName, lName, bdate)//parameterized constructor

        {
            this.ID = id;
            this.Department = dept;
            this.BasicSalary = salary;
            this.WorkingDays = daysWorked;
        }
        public int ID { get; set; }
        public string Department { get; set; }
        public decimal BasicSalary { get; set; }
        public int WorkingDays { get; set; }

        public virtual decimal CalculateSalary()
        {
            decimal salary = BasicSalary + (100 * WorkingDays);
            return salary;
        }

        override public string ToString()
        {
            return base.ToString() + " " +this. ID.ToString() + " " + this.Department + " " + this.BasicSalary + " " + this.WorkingDays;
        }
    }
}
