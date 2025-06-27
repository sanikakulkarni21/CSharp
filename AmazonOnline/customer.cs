namespace CRM
{
    public class Customer
    {
        private string userId;
        /* public string userID
         { 
             get { return userId; }
             set { userId = value; }
         }*/
        //new method of writing property is auto property
        public string UserId { get; set; } //auto property
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Location { get; set; }

    }
}