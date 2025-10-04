using Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
     class SecurityTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("login Demo");
            Console.WriteLine("Enter UserId :");
            string userId = Console.ReadLine();

            Console.WriteLine("Enter Password :");
            string password = Console.ReadLine();

            bool status =AccountManager .Login(userId, password);
            if (status)
            {
                Console.WriteLine("Login Success");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
            Console.ReadLine();

            
            // Unit Test for registration


            Console.WriteLine("Customer registration");
            Console.WriteLine("Enter FullName :");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter UserId :");
            int userId1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enyer your Email :");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Contact Number :");
            string ContactNumber = Console.ReadLine();

            Console.WriteLine("Enter Location :");
            string location = Console.ReadLine();

            bool statuss= AccountManager.Register(userId1, password, fullName, email, ContactNumber, location);
            if (statuss)
            {
                Console.WriteLine("Registration Success");
            }
            else
            {
                Console.WriteLine("Registration Failed");
            }
            Console.ReadLine();

        }

    }
}
