using System;
using System.Collections.Generic;
using AccountInterface.Managers;
using AccountInterface.Models;

namespace AccountInterface.UIManager;

public class UIManager
{
    private AccountManager accmanager;

    public UIManager(AccountManager manager)
    {
        accmanager = manager;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\n========== Banking System ==========");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Fund Transfer");
            Console.WriteLine("5. Mini Statement");
            Console.WriteLine("6. Calculate Interest");
            Console.WriteLine("7. Apply Interest");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your Choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid Choice");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateAccountUI();
                    break;

                case 2:
                    DepositUI();
                    break;

                case 3:
                    WithdrawUI();
                    break;

                case 4:
                    FundTransferUI();
                    break;

                case 5:
                    MiniStatementUI();
                    break;

                case 6:
                    CalculateInterestUI();
                    break;

                case 7:
                    ApplyInterestUI();
                    break;

                case 8:
                    Console.WriteLine("Thank You!");
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    private void CreateAccountUI()
    {
        Console.Write("Enter Account Number: ");

        if (!int.TryParse(Console.ReadLine(), out int accountNo))
        {
            Console.WriteLine("Invalid Account Number");
            return;
        }

        Console.Write("Enter Account Holder Name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter Opening Balance: ");

        if (!double.TryParse(Console.ReadLine(), out double balance))
        {
            Console.WriteLine("Invalid Balance");
            return;
        }

        Account account = new Account
        {
            AccountNumber = accountNo,
            AccountHolderName = name,
            Balance = balance,
            LastTransactionDate = DateTime.Now
        };

        bool status = accmanager.CreateAccount(account);

        if (status)
            Console.WriteLine("Account Created Successfully.");
        else
            Console.WriteLine("Account Already Exists.");
    }

    private void DepositUI()
    {
        Console.Write("Enter Account Number: ");

        if (!int.TryParse(Console.ReadLine(), out int accNumber))
            return;

        Console.Write("Enter Amount: ");

        if (!double.TryParse(Console.ReadLine(), out double amount))
            return;

        accmanager.Deposit(accNumber, amount);
    }

    private void WithdrawUI()
    {
        Console.Write("Enter Account Number: ");

        if (!int.TryParse(Console.ReadLine(), out int accNumber))
            return;

        Console.Write("Enter Amount: ");

        if (!double.TryParse(Console.ReadLine(), out double amount))
            return;

        accmanager.Withdraw(accNumber, amount);
    }

    private void FundTransferUI()
    {
        Console.Write("From Account: ");

        if (!int.TryParse(Console.ReadLine(), out int fromAcc))
            return;

        Console.Write("To Account: ");

        if (!int.TryParse(Console.ReadLine(), out int toAcc))
            return;

        Console.Write("Amount: ");

        if (!double.TryParse(Console.ReadLine(), out double amount))
            return;

        accmanager.TransferFunds(
            fromAcc.ToString(),
            toAcc.ToString(),
            amount);
    }

    private void MiniStatementUI()
    {
        Console.Write("Enter Account Number: ");

        if (!int.TryParse(Console.ReadLine(), out int accountNo))
            return;

        List<Operations> statement = accmanager.MiniStatement(accountNo);

        if (statement.Count == 0)
        {
            Console.WriteLine("No Transactions Found.");
            return;
        }

        Console.WriteLine("\n----------- Mini Statement -----------");

        foreach (Operations op in statement)
        {
            Console.WriteLine($"Date               : {op.TransactionDate}");
            Console.WriteLine($"Operation Type     : {op.OperationType}");
            Console.WriteLine($"Deposit Account    : {op.DepositAccNum}");
            Console.WriteLine($"Withdraw Account   : {op.WithdrawAccNum}");
            Console.WriteLine($"Amount             : {op.Amount}");

            // Uncomment if CurrentBalance exists
            // Console.WriteLine($"Current Balance    : {op.CurrentBalance}");

            Console.WriteLine("--------------------------------------");
        }
    }

    private void CalculateInterestUI()
    {
        Console.Write("Enter Account Number: ");

        if (!int.TryParse(Console.ReadLine(), out int accountNo))
        {
            Console.WriteLine("Invalid Account Number");
            return;
        }

        double interest = accmanager.CalculateInterest(accountNo);

        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Calculated Interest : {interest:F2}");
        Console.WriteLine("--------------------------------");
    }

    private void ApplyInterestUI()
    {
        bool status = accmanager.ApplyInterest();

        if (status)
            Console.WriteLine("Interest Applied Successfully.");
        else
            Console.WriteLine("Interest Could Not Be Applied.");
    }
}