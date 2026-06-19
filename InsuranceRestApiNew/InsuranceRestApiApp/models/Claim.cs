
namespace MaxNewYorkInsurance.Models;

public class Claim{

    public int ClaimId {get;set;}
    public string PolicyNumber{get;set;} = string.Empty;
    public string CustomerName{get; set;} = string.Empty;
    public string CustomerId{get;set;} = string.Empty;
    public DateTime ClaimDate{get; set;}
    public string ClaimType {get; set;} = string.Empty;
    public string Reason {get; set;} = string.Empty;
    public decimal ClaimAmount {get; set;}
    public decimal ApprovedAmount {get; set;}
    public string Status {get; set;} = string.Empty;
    public string Remarks {get; set;} = string.Empty;
    public DateTime SettlementDate{get; set;}

    public override string ToString (){
        return $"ClaimId: {ClaimId} - Policy: {PolicyNumber}";
    }  

}