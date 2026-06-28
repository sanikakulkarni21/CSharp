
using  AccountInterface.MiniStatement;
using AccountInterface.Deposit;
using AccountInterface.Withdraw;
using AccountInterface.FundTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using AccountInterface.Repositories;
using AccountInterface.Models;
using AccountInterface.NotificationService;
using AccountInterface.Listeners;

namespace AccountInterface.Managers;
public class AccountManager : IDepositOperation, IWithdrawOperation, IFundTransfer,  ICalculateInterestOperation, IApplyInterestOperation
    , ICreateAccountOperation,IMiniStatement
{
    public List<Account> accounts { get; set; }
    public List<IAccountListener> listeners = new List<IAccountListener>();
    private INotificationService notificationService;
        private IAccountsRepository accountsRepository;
        private IOperationsRepository operationsRepository;

     private int InterestRate=7;

    public AccountManager(List<Account> accounts, INotificationService notificationService, IAccountsRepository accountsRepository, IOperationsRepository operationsRepository)
        {
            this.notificationService = notificationService;
            this.accountsRepository = accountsRepository;
            this.operationsRepository = operationsRepository;
        this.accounts = accounts;
    }

    public double GetBalance(int accountNo)
    {
        foreach (Account account in accounts)
        {
            if (account.AccountNumber == accountNo)
            {
                account.LastTransactionDate = DateTime.Now;
                Console.WriteLine($"Balance in account for {account.AccountHolderName} is {account.Balance}");
                accountsRepository.SaveAllAccounts(accounts);
                return account.Balance;
            }
        }
        return 0;
    }

    public void Deposit(int accountNumber, double amount)
    {
        var acc = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

        if (acc == null)
        {
            Console.WriteLine("Account not found");
            return;
        }

        acc.Balance += amount;
        acc.LastTransactionDate = DateTime.Now;

        CheckBalance(acc);

        SaveOperation(0, accountNumber, amount, "Deposit");

        accountsRepository.SaveAllAccounts(accounts);

        Console.WriteLine($"Amount {amount} deposited successfully");
    }

    public void Withdraw(int accountNumber, double amount)
    {
        var acc = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

        if (acc == null)
        {
            Console.WriteLine("Account not found");
            return;
        }

        if (acc.Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        acc.Balance -= amount;
        acc.LastTransactionDate = DateTime.Now;

        CheckBalance(acc);

        SaveOperation(accountNumber, 0, amount, "Withdraw");

        accountsRepository.SaveAllAccounts(accounts);

        Console.WriteLine($"Amount {amount} withdrawn successfully");
    }
    public void TransferFunds(string fromAccount,
                              string toAccount,
                              double amount)
    {
        if (!int.TryParse(fromAccount, out int fromAccNo))
        {
            Console.WriteLine("Invalid sender account");
            return;
        }

        if (!int.TryParse(toAccount, out int toAccNo))
        {
            Console.WriteLine("Invalid receiver account");
            return;
        }

        var sender = accounts.FirstOrDefault(a => a.AccountNumber == fromAccNo);
        var receiver = accounts.FirstOrDefault(a => a.AccountNumber == toAccNo);

        if (sender == null)
        {
            Console.WriteLine("Sender account not found");
            return;
        }

        if (receiver == null)
        {
            Console.WriteLine("Receiver account not found");
            return;
        }

        if (sender.Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        sender.Balance -= amount;
        receiver.Balance += amount;

        sender.LastTransactionDate = DateTime.Now;
        receiver.LastTransactionDate = DateTime.Now;

        CheckBalance(sender);
        CheckBalance(receiver);
        SaveOperation(fromAccNo, toAccNo, amount, "Transfer");
        accountsRepository.SaveAllAccounts(accounts);

        Console.WriteLine("Fund transferred successfully");
    }

   
    private void SaveOperation(int fromAcc, int toAcc, double amount, string type)
    {
        var operations = operationsRepository.GetAllOperations();


        operations.Add(new Operations
        {
            WithdrawAccNum = fromAcc,
            DepositAccNum = toAcc,
            Amount = amount,
            OperationType = type,
            TransactionDate = DateTime.Now

        });

        operationsRepository.SaveAllOperations(operations);
    }

    private void CheckBalance(Account account)
    {
        IAccountListener listener = new AccountDepartment();

        if (account.Balance < 1000)
        {
            listener.OnUnderBalance(account.Balance);
        }
        else if (account.Balance > 100000)
        {
            listener.OnOverBalance(account.Balance);
        }
    }

     public List<Operations> MiniStatement (int accountId){

        List<Operations> ministatement =new List<Operations>();
        List<Operations> allOperations = operationsRepository.GetAllOperations();
        ministatement=allOperations
                      .Where(operations => operations.DepositAccNum == accountId ||
                                           operations.WithdrawAccNum == accountId)
                      .OrderByDescending(op => op.TransactionDate)
                      .Take(5)
                      .ToList();

         return ministatement;             
     }

     public double CalculateInterest(int accountId)
{
    List<Operations> allOperations = operationsRepository.GetAllOperations();

    List<Operations> accountOperations = allOperations
        .Where(op => op.DepositAccNum == accountId ||
                     op.WithdrawAccNum == accountId)
        .ToList();

    if (accountOperations.Count == 0)
    {
        Console.WriteLine("Account not found or no transactions available.");
        return 0;
    }

    double finalInterest = Calculate(accountOperations);

    return finalInterest;
}

        private double Calculate(List<Operations> accountOperations)
        {
            Operations firstOperation = new Operations();
            Operations secondOperation = new Operations();
            double totalInterestNow = 0;

            firstOperation = accountOperations[0];

            double finalInterset = 0;
            for (int i = 1; i < accountOperations.Count(); i++)
            {
                secondOperation = accountOperations[i];
                TimeSpan consecutiveOperationsTimeSpan = secondOperation.TransactionDate - firstOperation.TransactionDate;

                double totalDays = consecutiveOperationsTimeSpan.TotalDays;
                // Console.WriteLine("" + totalDays);

                double baseAmount = 1 + (InterestRate / 100.0 / 365.0); //formula for calcuating  daily balance
                // Console.WriteLine(baseAmount);

                double afterpower = Math.Pow(baseAmount, totalDays);
                // Console.WriteLine(afterpower);

                totalInterestNow = firstOperation.CurrentBalance * afterpower;
             

                double interset = totalInterestNow - firstOperation.CurrentBalance;
                finalInterset += interset;
                firstOperation = secondOperation;

            }
            return finalInterset;
        }

public bool ApplyInterest()
{
    foreach (Account account in accounts)
    {
        double interest = CalculateInterest(account.AccountNumber);

        account.Balance += interest;
        account.LastTransactionDate = DateTime.Now;
    }

    accountsRepository.SaveAllAccounts(accounts);

    Console.WriteLine("Interest applied successfully.");

    return true;
}

public bool CreateAccount(Account account)
{
    var existingAccount = accounts.FirstOrDefault(a => a.AccountNumber == account.AccountNumber);

    if (existingAccount != null)
    {
        Console.WriteLine("Account already exists.");
        return false;
    }

    account.LastTransactionDate = DateTime.Now;

    accounts.Add(account);

    accountsRepository.SaveAllAccounts(accounts);

    Console.WriteLine("Account created successfully.");

    return true;
}
}
