using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Customer Relation module
//Namespace : logical collection of .net Types
namespace CRM
{
    public class Customer
    {
        public int UserId { get; set; }// auto implemented property
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Location { get; set; }



    }
}
