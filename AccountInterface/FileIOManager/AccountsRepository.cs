
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using AccountInterface.Models;

namespace AccountInterface.Repositories;

public class AccountsRepository
{
    public List<Account> GetAllAccounts()
    {
        string filename = @"D:\Tap\CSharp\AccountInterface\Data\Accounts.json";
        string jsonString = File.ReadAllText(filename);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        List<Account>? accounts = JsonSerializer.Deserialize<List<Account>>(jsonString, options);
        return accounts ?? new List<Account>();
    }

    public bool SaveAllAccounts(List<Account> accounts)
    {
        bool status = false;
        string fileName = @"D:\Tap\CSharp\AccountInterface\Data\Accounts.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(accounts, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }
}