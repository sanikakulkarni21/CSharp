
using MaxNewYorkInsurance.Models;
using MaxNewYorkInsurance.Agents;

public class AccountsManager {

    public event PremiumAgent? premiumPaid;

    public event AccountAgent? policyPurchased;

    public void PurchasePolicy (Policy policy){

        policyPurchased?.Invoke(policy);
        Console.WriteLine("Policy Purchased Successfully");
    }

    public void PayPremium (Premium premium)
       => premiumPaid?.Invoke(premium);
    

}