
namespace AccountDelegate.Operations;

public class AccountOperations {

    public event AccountAgent deposite;

    public event AccountAgent withdraw;


    public void DepositeOperation(Account account, decimal amount) {
        deposite.Invoke(account, amount);
        Console.WriteLine("Amount Deposited")
    }

     public void WithDrawOperation(Account account, decimal amount) {
        deposite.Invoke(account, amount);
        Console.WriteLine("Amount Deposited")
    }
}