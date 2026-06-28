
using AccountInterface.Models;
namespace AccountInterface.Deposit;

 public interface ICalculateInterestOperation
    {
        double CalculateInterest(int accountId);
    }