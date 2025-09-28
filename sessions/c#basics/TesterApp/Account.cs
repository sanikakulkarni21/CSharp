using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Account
    {
        public float Balance { get; set; }

        public Account(float amount)
        {
            Balance = amount;
        }
         
        public void Deposit(float amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(float amount)
        {
            Balance = Balance - amount;
        }

       
    }
}
