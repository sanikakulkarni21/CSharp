using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;

namespace Membership
{
    public static class AccountManager
    {
        public static bool Login(string userName, string password)
        {
            bool status = false;
            if (userName == "admin" && password == "admin")
            {
                status = true;
            }
            return status;
        }

        public static bool Register(int loginId, string password,string name, string email, string contactNumner, string location)
        {
            bool status = false;
            Customer theCustomer= new Customer();
            theCustomer.FullName = name;
            theCustomer.UserId = loginId;
            theCustomer.Password = password;
            theCustomer.Email = email;
            theCustomer.ContactNumber= contactNumner;
            theCustomer.Location = location;

            if (theCustomer != null)
            status = true;
            return status;
        }


        public static bool ChangePassword(string loginId, string existingpassword, string newpassword)
        {

            bool status = false;


            return status;
        }

        public static bool ForgetPassword(string loginId)
        {
           bool status = false;
            return status;
        }
    }
} 
