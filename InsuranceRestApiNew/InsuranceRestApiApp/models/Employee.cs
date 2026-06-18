
namespace MaxNewYorkInsurance.Models;

public class Employee{

    public int EmployeeId {get; set;}

    public string EmployeeCode {set; set;}= string.Empty;

    public string FirstName {get; set;}= string.Empty;

    public string LastName {get; set;}= string.Empty;

    public string FullName => $"{FirstName}" {LastName};

    public string Email{get; set;}= string.Empty;

    public string MobieNumber{get; set;}= string.Empty;

    public string Department {get; set;}= string.Empty;

    public string Destination {get; set;}= string.Empty;

    public DateTime DateOfJoining {get;set;}

    public decimal Salary {get;set;}
    
    public bool IsActive {get;set;}

    public string Address {get; set;}= string.Empty;


    public override string ToString(){
        return $"{EmloyeeCode} - {FullName} - ({Department})";
    }







}