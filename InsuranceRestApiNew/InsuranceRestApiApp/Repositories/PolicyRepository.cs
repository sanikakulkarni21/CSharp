
using MaxNewYorkInsurance.Models;
using System.Text.Json;

namespace MaxNewYorkInsurance.Repositories;

public class PolicyRepository{

    public List<Policy> GetAllPolicies(){
        string filename= @"D:\Tap\CSharp\InsuranceRestApiNew\InsuranceRestApiApp\Data\policies.json";
        string jsonString = File.ReadAllText(filename);
        var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};        
        List<Policy>? policies = JsonSerializer.Deserialize<List<Policy>>(jsonString, options);
        return policies ?? new List<Policy>();

    }

    public bool SaveAllPolicies(List<Policy> policies){

        string filename = @"D:\Tap\CSharp\InsuranceRestApiNew\InsuranceRestApiApp\Data\policies.json";
        var options = new JsonSerializerOptions{PropertyNameCaseInsensitive= true };
        string jsonString= JsonSerializer.Serialize(policies, options);
        File.WriteAllText(filename, jsonString);
        return true; 

    }
}