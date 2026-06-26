namespace AccountInterface.Deposit;

public interface IDepositOperation
{
    void Deposit(int accNumber,double amount);
}