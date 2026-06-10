using Handlers;
using Taxation;



namespace Banking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NotificationManager notifyMgr = new NotificationManager();
            TaxManager taxMgr = new TaxManager();
            Account acct123 = new Account();

            acct123.notify += notifyMgr.SendEmail;
            acct123.notify += notifyMgr.SendSMS;
            acct123.notify += notifyMgr.SendWhatsappMessage;

            acct123.overBalance += taxMgr.PayIncomeTax;
            acct123.overBalance += taxMgr.Block;

            acct123.Balance = 89000;

            // acct123.Withdraw(80000);
            // acct123.Deposit(7000);
            // acct123.Deposit(9000);
            // acct123.Withdraw(8000);

            acct123.Deposit(300000);
        }
    }
}