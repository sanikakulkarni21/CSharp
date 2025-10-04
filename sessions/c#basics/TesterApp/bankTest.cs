using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class bankTest
    {

        static void Main(string[] args)
        {
            Account acct1 = new Account(56000);
            Console.WriteLine("1. withdraw");
            Console.WriteLine("2. deposit");
            int option= int.Parse(Console.ReadLine());

            Console.WriteLine("please Enter Amount");
                        float amount = float.Parse(Console.ReadLine());

            switch (option) {

                case 1:
                    {
                        acct1.Withdraw(amount);
                    }
                    break;
                case 2:
                    {
                        acct1 .Deposit(amount);
                    } break;

            }
            float balance= acct1.Balance;
            Console.WriteLine("your remaining Balance = {0}", balance);
            Console.ReadLine();
        }
    }
}
