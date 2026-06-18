
using System.Text.Json.Serialization;
namespace MaxNewyorkInsurance.models;

public class Policy{
    public string PolicyNumber {get; set;}
    public string PolicyType{get; set;}
    public string CustomerName{get; set;}
    public decimal PolicyAmount{get; set;}
    public decimal IsRenewed{get; set;}=false;

    public Policy(){
        
    }


}