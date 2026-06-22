
using AccountInterface.Deposit;
using AccountInterface.Withdraw;
using AccountInterface.FundTransfer;

public class Account : IDepositOperation, IWithdrawOperation, IFundTransfer{



    List<Account> accounts { get; set; }
    NotificationService _service;

    public Account(List<Account> accounts, NotificationService notificationService)
    {
        this._service = notificationService;
        this.accounts = accounts;
    }
    IOManager iomanager = new IOManager();
    public List<AccountListener> listeners = new List<AccountListener>();


    public double getBalance(int AccountNo)
    {
        foreach (Account account in accounts)
        {
            if (account.AccountNumber == AccountNumber)
            {
                account.LastTransactionDate = DateTime.Now;
                Console.WriteLine($"Balance in account with id {account.AccountHolderName} is {account.Balance}");
                iomanager.SaveAllAccounts(accounts);

                return account.Balance;
            }

        }
        return 0;
    }

    public void deposit(double AccountNumber, double amount)
    {
        foreach (Account account in accounts)
        {
            if (account.AccountNumber == AccountNumber)
            {
                account.Balance += amount;
            }
            account.LastTransactionDate = DateTime.Now;
            Console.WriteLine($"Balance in account with id {account.AccountNumber} after deposit is {account.Balance}");
            checkBalance(account);
            iomanager.SaveAllAccounts(accounts);
        }
    }
    public void withdraw(double AccountNumber, double amount)
    {
        foreach (Account account in accounts)
        {
            if (account.AccountNumber == AccountNumber)
                account.Balance -= amount;
            account.LastTransactionDate = DateTime.Now;
            Console.WriteLine($"Balance in account with id {account.AccountNumber} after Withdraw is {account.Balance}");
            iomanager.SaveAllAccounts(accounts);
        }
    }
    }


    public void checkBalance(Account account)
    {
      IAccountListener listener= new AccountDepartment();

      if (account.Balance< 1000)
      {
        listener.OnUnderBalance(account.Balance);
      }
      else if (account.Balance>100000)
      {
        listener.OnOverBalance(account.Balance);
      }
        
    }



    public void TransferFunds(double fromAccout, double toAccount, double amount)

    {
        foreach (Account account in accounts)
        {
            if (account.AccountNumber == fromAccout)
            {
                withdraw(fromAccout, amount);
                account.LastTransactionDate = DateTime.Now;
                accountRepository.SaveAllAccounts(accounts);
                Console.WriteLine($"Balance in account with id {account.AccountNumber} after Withdraw is {account.Balance}");
         
            }
        }

        foreach (Account a in accounts)
        {
            if (a.AccountNumber == toAccount)
            {
                deposit(toAccount, amount);
                a.LastTransactionDate = DateTime.Now;
                accountRepository.SaveAllAccounts(accounts);
                Console.WriteLine($"Balance in account with id {account.AccountNumber} after Withdraw is {account.Balance}");

            }
        }



    }

   





