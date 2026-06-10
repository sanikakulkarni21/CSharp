
namespace Banking;

public class Account
{
    public double Balance { get; set; }

    public event Notify notify;
    public event TaxInspector overBalance;

    public void Withdraw(double amount)
    {
        Balance -= amount;
        notify?.Invoke("Amount has been deducted from your account");
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        notify?.Invoke("Amount has been deposited to your account");

        if (Balance >= 250000)
        {
            overBalance?.Invoke(Balance);
        }
    }
}
