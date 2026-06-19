
namespace MaxNewYorkInsurance.Models;

public class Premium {  
    
    public int PremiumId {get; set;}
    public int PolicyId {get; set;}
    public string PolicyNumber {get; set;}= string.Empty;
    public int CustomerId {get; set;}
    public string? CustomerName{get; set;}
    public decimal AmountPaid {get; set;}
    public DateTime PaymentDate {get; set;}
    public string PaymentMode {get; set;}= string.Empty;
    public string TransactionId {get; set;}= string.Empty;
    public  string PaymentFrequency {get; set;}= string.Empty;
    public string PaymentStatus {get; set;}="success";
    public string Remarks {get; set;}=string.Empty;


    public override string ToString(){
        return $"PremiumId :{PremiumId},"+
               $"Policy: {PolicyNumber},"+
               $"Customer :{CustomerName},"+
               $"Amount : {AmountPaid:C} "+
               $"Status :{PaymentStatus}";
    }


}