
using System.Text.Json.Serialization;

namespace MaxNewYorkInsurance.Models;

public class Policy{
    public string PolicyNumber {get; set;} = string.Empty;
    public string PolicyType{get; set;} = string.Empty;
    public string CustomerName{get; set;} = string.Empty;
    public decimal PolicyAmount{get; set;}
    public bool IsRenewed{get; set;} = false;

    public Policy(){ }

}