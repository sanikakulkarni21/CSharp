
namespace MaxNewyorkInsurance.Models;

public class Customer{

    public int CustomerId {get; set;}
    public string CustomerCode {get; set;}

    public string FirstName {get; set;}
    public string LastName {get; set;}
    public DateTime DateOfBirth {get; set;}
    public string Gender {get; set;}

    public string Email {get; set;}
    public int MobileNumber {get; set;}
    public int AlternateMobileNumber{get; set;}

    public string AddressLine1 {get; set;} 
    public string AddressLine2 {get; set;}
    public string City {get; set;}
    public string State {get; set;}
    public string PostalCode {get; set;}
    public string Country {get;set;}

    public string PanNumber {get; set;}
    public string AadharNumber{get;set;}

    public string Occupation {get; set;}
    public string AnnualIncome {get; set;}

    public string NomineeName {get; set;}
    public string NomineeRelationship{get; set;}
    public string NomineeContactNumber{get; set;}

    public DateTime RegistrationDate {get; set;}
    public bool IsActive{get; set;}
    public int TotalPoliciesPurchased{get; set;}

    public string FullName => $"{FirstName} {LastName}";

    public override string ToString(){
        return$"{CustomerId}- {FullName} ({Email}, {MobileNumber})";
    }

}