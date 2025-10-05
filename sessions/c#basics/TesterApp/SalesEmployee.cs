using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
     class SalesEmployee:Employee
    {
        public float Incentive { get; set; }
        public SalesEmployee() : base() //default constructor
        {
            this.Incentive = 0;
        }

        public SalesEmployee(string fName, string lName, DateTime bdate, int id, string dept, decimal salary, int daysWorked,float incentive)
            : base(fName, lName, bdate, id, dept, salary, daysWorked)//parameterized constructor
        {
            this.Incentive = incentive;
        }

        public override decimal CalculateSalary()
        {
            
            return base.CalculateSalary() + (decimal)Incentive;
        } 
        public override string ToString()
        {
            return base.ToString() + " " + this.Incentive;
        }
    }
}
