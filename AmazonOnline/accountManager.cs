

namespace Membership
{

    public static class AccountManager
    {
        public bool Login(string userName, string password)
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
            
        }

     }

}