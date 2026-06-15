

using HR.Interfaces;

partial class Program
{
    static void Main(string[] args)
    {
SalesManager manager = new SalesManager(35,"sanika","kulkarni",80000,5000,150000,20000);

IAppraisable appraisable = manager;
appraisable.ConductAppraisal();

IBonusEligible bonusEligible = (IBonusEligible)manager;
Console.WriteLine("Bonus: " + bonusEligible.CalculateBonus());

IInterviewPanel panel = manager;
panel.TakeInterview();

ITrainer trainer = manager;
trainer.Train();
    






//////////////////////////////////////////////////////////////////////////////
SalesManager salesManager = new SalesManager(   1, "Sanika", "kulkarni", 60000, 7000, 150000, 10000);

SalesEmployee salesEmployee = new SalesEmployee( 2, "Sejal","kulkarni", 60000, 7000, 150000);

   

salesManager.Achieved = 160000;

Console.WriteLine(salesManager.ToString());
Console.WriteLine(salesEmployee.ToString());
salesManager.DoWork();
salesEmployee.DoWork();
double totalPay = salesManager.ComputePay();
Console.WriteLine($"Total Pay: {totalPay}");

    }
}
