
namespace MaxNewYorkInsurance.Models;

public class Agent {

    public int AgentId {get; set;}
    public string AgentCode {get; set;} = string.Empty;

    public string FullName {get; set;} = string.Empty;

    public string MobileNumber {get;set;} = string.Empty;

    public string LicensNumber {get; set;} = string.Empty;

    public string Branch {get;set;} = string.Empty;

    public string Destination {get; set;} = string.Empty;

    public decimal CommissionRate {get; set;}

    public decimal TotalCommissionEarned {get; set;}

    public DateTime DateOfJoining {get; set;}

    public bool IsActive {get; set;}

    public override string ToString (){
        return $"{AgentCode} - {FullName} ({Destination})";
    }
}