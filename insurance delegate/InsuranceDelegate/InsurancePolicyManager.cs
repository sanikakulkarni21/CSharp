
using PolicyManager;

class InsurancePolicyManager
{
    public event Insurance PolicyPurchased;
    public event Insurance PremiumPaid;
    public event Insurance ClaimRegistered;
    public event Insurance PolicyRenewed;
}


public void PurchasePolicy(){
    Console.Writeline("Policy Purchased Successfully");
    PolicyPurchased.Invoke();
}

public void PremiumPaid(){
    Console.Writeline("Premium is Paid Successfully");
    PremiumPaid.Invoke();
}

public void Registerlaim(){
    Console.WriteLine("Claim Registered Successfully");
    ClaimRegistered.Invoke();
}

public void RenewPolicy(){
    Console.WriteLine("Policy is Renewed Successfully")
}