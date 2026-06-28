
using AccountInterface.Models;
namespace AccountInterface.Deposit;

 public interface ICreateAccountOperation
    {
        bool CreateAccount(Account account);
    }