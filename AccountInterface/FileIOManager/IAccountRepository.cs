using AccountInterface.Models;

namespace AccountInterface.Repositories;

public interface IAccountsRepository
{
    List<Account> GetAllAccounts();

      bool SaveAllAccounts(List<Account> accounts);
}