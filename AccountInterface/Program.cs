
using AccountInterface.Repositories;
using AccountInterface.Managers;
using AccountInterface.NotificationService;
using AccountInterface.UIManager;

var accountsRepo = new AccountsRepository();
var accounts = accountsRepo.GetAllAccounts();

INotificationService notify = new EmailService();
var accountManager = new AccountManager(accounts, notify);

var ui = new UIManager(accountManager);
ui.Run();

