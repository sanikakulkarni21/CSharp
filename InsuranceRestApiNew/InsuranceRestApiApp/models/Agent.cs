
namespace MaxNewYorkInsurance.Models;

public class Agent {

    public int AgentId {get; set;}
    public string AgentCode {get; set;}

    public string FullName {get; set;}

    public string MobileNumber {get;set;}

    public string LicensNumber {get; set;}

    public string Branch {get;set;}

    public string Destination {get; set;}

    public decimal CommissionRate {get; set;}

    public decimal TotalCommissionEarned {get; set;}

    public DateTime DateOfJoining {get; set;}

    public bool IsActive {get; set;}

    public override string Tostring (){
        return $"{AgentCode} - {FullName} ({Destination})";
    }
}