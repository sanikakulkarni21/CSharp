using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HR
{
    //structure
    public struct Point
    {
        public int x;
        public int y;
    }
    public class Person
    {
        public Person() //default constructor
        {
            this.FirstName = "";
            this.LastName = "";
            this.BirthDaate = DateTime.Now;
        }

        public Person(string fName, string lName, DateTime bdate)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.BirthDaate = bdate;
        }

        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected DateTime BirthDaate { get; set; }


        override public string ToString()
        {
            return FirstName = "" + LastName + "" + BirthDaate + "";
        }
    }
}
