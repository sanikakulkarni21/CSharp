
class SalesManager : SalesEmployee
{
    public double Bonus { get; set; }

    public SalesManager(int id, string name, double salary, double incentive, double targetAchieved, double bonus)
        : base(id, name, salary, incentive, targetAchieved)
    {
        Bonus = bonus;
    }

    public override void DoWork()
    {
        Console.WriteLine($"SalesManager Working");
    }

    public override double ComputePay()
    {
        return base.ComputePay() + Bonus;
    }

    public override string ToString()
    {
        return base.ToString() + $" Bonus: {Bonus}";
    }
}