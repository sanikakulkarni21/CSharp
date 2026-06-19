using MaxNewYorkInsurance.Models;
using MaxNewYorkInsurance.Departments;
using MaxNewYorkInsurance.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();

var app = builder.Build();

app.MapPost("/api/policies/purchase", (Policy policy) =>
{  
        AccountsManager accountmanager = new AccountsManager();
        AccountsDepartment accounts = new AccountsDepartment();
        accountmanager.policyPurchased += accounts.OnPolicyPurchased;
        accountmanager.PurchasePolicy(policy);
        return "Policy Purchased Successfully";
});

app.Run();