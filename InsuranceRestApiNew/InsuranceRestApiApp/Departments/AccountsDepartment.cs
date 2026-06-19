
using MaxNewYorkInsurance.Models;
using MaxNewYorkInsurance.Repositories;

namespace MaxNewYorkInsurance.Departments;

public class AccountsDepartment{

    public void OnPolicyPurchased(Policy policy){

        PolicyRepository PolicyRepo = new PolicyRepository();
        List<Policy> policylist = PolicyRepo.GetAllPolicies();
        policylist.Add(policy);
        PolicyRepo.SaveAllPolicies(policylist);
        Console.WriteLine("============================");
        Console.WriteLine("Accounts Department");
        Console.WriteLine($"New Policy Purchased : {policy.PolicyNumber}");
        Console.WriteLine("Financial records Updated");
        Console.WriteLine("============================");
    }

    public void OnPremiumPaid(Premium premium){
        Console.WriteLine("===============================");
        Console.WriteLine("Premium Payment Received");
        Console.WriteLine($"PolicyId : {premium.PolicyId}");
        Console.WriteLine($"Amount Paid : {premium.AmountPaid}");
        Console.WriteLine($"Payment Mode : {premium.PaymentMode}");
        Console.WriteLine("Payment Recorded successfully");
        Console.WriteLine("================================");
    }
}