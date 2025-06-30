
using CRM;

namespace Membership
{

    public static class AccountManager
    {
        public static bool Login(string userName, string password)
        {
            bool ststus = false;
            if (userName == "sanika" && password == "san")
            {
                status = true;

            }
            return status;
        }


        public static bool Register(string loginId, string password, string name, string email, string contactNumber, string location)
        {
            bool status = false;
            Customer theCustomer = new Customer();
            theCustomer.Fullname = name;
            theCustomer.UserId = loginId;
            theCustomer.Password = password;
            theCustomer.Email = email;
            theCustomer.ContactNumber = contactNumber;
            theCustomer.Location = location;

            if (theCustomer != null)
            {

                status = true;
            }
            return status;
        }

        public static bool ChangePassword(string loginId, string existingPassword, string newPassword)
        {
            bool status = false;
            //set new password for the user
            //if 
        }             
     }
 }

