using AccountInterface.Models;

namespace AccountInterface.Repositories;

public interface IOperationsRepository
{
    List<Operations> GetAllOperations();

     bool SaveAllOperations(List<Operations> operations);
}