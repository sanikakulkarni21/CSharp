
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using AccountInterface.Models;

namespace AccountInterface.Repositories;

public class OperationsRepository : IOperationsRepository
{
    public List<Operations> GetAllOperations()
    {
        string filepath = @"D:\Tap\CSharp\AccountInterface\Data\operation.json";
        string jsonString = File.ReadAllText(filepath);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        List<Operations>? operations = JsonSerializer.Deserialize<List<Operations>>(jsonString, options);
        return operations ?? new List<Operations>();
    }

    public bool SaveAllOperations(List<Operations> operations)
    {
        bool status = false;
        string fileName = @"D:\Tap\CSharp\AccountInterface\Data\operation.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(operations, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }
}