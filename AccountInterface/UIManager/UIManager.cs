
using System;
using System.Collections.Generic;
using AccountInterface.Managers;
using AccountInterface.Models;
using AccountInterface.NotificationService;

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
            Console.WriteLine("Enter your Choice");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. FundTransfer");
            Console.WriteLine("4. exit");

            if (!int.TryParse(Console.ReadLine(), out int choice)) continue;

            switch (choice)
            {
                case 1:
                    DepositUI();
                    break;
                case 2:
                    WithdrawUI();
                    break;
                case 3:
                    FundTransferUI();
                    break;
                case 4:
                    MiniStatementUI();
                    break;

                case 5 :
                     return;

            }
        }
    }

    private void DepositUI()
    {
        Console.WriteLine("Enter Account number:");
        if (!int.TryParse(Console.ReadLine(), out int accNumber)) return;

        Console.WriteLine("Enter Amount to Deposit");
        if (!double.TryParse(Console.ReadLine(), out double amount)) return;

        accmanager.Deposit(accNumber, amount);
        Console.WriteLine($"Amount {amount} Deposited to Account number {accNumber}");
    }

    private void WithdrawUI()
    {
        Console.WriteLine("Enter Account Number:");
        if (!int.TryParse(Console.ReadLine(), out int accNumber)) return;

        Console.WriteLine("Enter Amount to Withdraw:");
        if (!double.TryParse(Console.ReadLine(), out double amount)) return;

        accmanager.Withdraw(accNumber, amount);
        Console.WriteLine($"Amount {amount} withdrawn from account number {accNumber}");
    }

    private void FundTransferUI()
    {
        Console.WriteLine("From Account:");
        if (!int.TryParse(Console.ReadLine(), out int fromAcc)) return;

        Console.WriteLine("To Account");
        if (!int.TryParse(Console.ReadLine(), out int toAcc)) return;

        Console.WriteLine("Enter Amount to Transfer:");
        if (!double.TryParse(Console.ReadLine(), out double amount)) return;

        accmanager.TransferFunds(fromAcc.ToString(), toAcc.ToString(), amount);
        Console.WriteLine($"Amount {amount} is Transferred from account {fromAcc} to account No {toAcc}");
    }

    private void MiniStatementUI(){
        Console.WriteLine("Enter account Number");
        int accno=Convert.ToInt32(Console.ReadLine());
         accmanager.MiniStatement(accno);
    }
}