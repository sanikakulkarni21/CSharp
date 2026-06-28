using AccountInterface.Repositories;
using AccountInterface.Managers;
using AccountInterface.NotificationService;
using AccountInterface.UIManager;

IAccountsRepository accountsRepo = new AccountsRepository();
IOperationsRepository operationsRepo = new OperationsRepository();

var accounts = accountsRepo.GetAllAccounts();

INotificationService notify = new EmailService();

var accountManager = new AccountManager(
    accounts,
    notify,
    accountsRepo,
    operationsRepo
);

var ui = new UIManager(accountManager);

ui.Run();