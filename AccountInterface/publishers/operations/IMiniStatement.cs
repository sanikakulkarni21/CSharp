using AccountInterface.Models;
namespace AccountInterface.MiniStatement;

public interface IMiniStatement{

    List<Operations> MiniStatement(int accountId);
}