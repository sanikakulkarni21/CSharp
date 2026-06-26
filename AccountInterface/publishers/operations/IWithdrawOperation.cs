namespace AccountInterface.Withdraw;

public interface IWithdrawOperation
{
    void Withdraw(int accountNumber, double amount);
}