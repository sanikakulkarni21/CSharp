
namespace MaxNewYorkInsurance.Models;

public class Customer{

    public int CustomerId {get; set;}
    public string CustomerCode {get; set; } = string.Empty;

    public string FirstName {get; set;} = string.Empty;
    public string LastName {get; set;} = string.Empty;
    public DateTime DateOfBirth {get; set;}
    public string Gender {get; set;} = string.Empty;

    public string Email {get; set;} = string.Empty;
    public long MobileNumber {get; set;}
    public long AlternateMobileNumber{get; set;}

    public string AddressLine1 {get; set;} = string.Empty; 
    public string AddressLine2 {get; set;} = string.Empty;
    public string City {get; set;} = string.Empty;
    public string State {get; set;} = string.Empty;
    public string PostalCode {get; set;} = string.Empty;
    public string Country {get;set;} = string.Empty;

    public string PanNumber {get; set;} = string.Empty;
    public string AadharNumber{get;set;} = string.Empty;

    public string Occupation {get; set;} = string.Empty;
    public decimal AnnualIncome {get; set;}

    public string NomineeName {get; set;} = string.Empty;
    public string NomineeRelationship{get; set;} = string.Empty;
    public string NomineeContactNumber{get; set;} = string.Empty;

    public DateTime RegistrationDate {get; set;}
    public bool IsActive{get; set;}
    public int TotalPoliciesPurchased{get; set;}

    public string FullName => $"{FirstName} {LastName}";

    public override string ToString(){
        return$"{CustomerId}- {FullName} ({Email}, {MobileNumber})";
    }

}