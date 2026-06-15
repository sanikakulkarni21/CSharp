
class SalesEmployee: Employee{

    public double Incentive{get; set;}
    public double TargetAchieved{get; set;}

    public SalesEmployee(int id ,string name, double salary, double incentive, double targetAchieved): base( id , name,salary )
    {
        Incentive=incentive;
        TargetAchieved=targetAchieved;
    }

    public override void DoWork(){
        Console.WriteLine($"SalesEmployee Working");

    }

    public override double ComputePay(){
        double incentive=0;
        if(TargetAchieved>10000)
        {
            incentive=Incentive;
        }
        return base.ComputePay()+incentive;
    }

    public override string ToString()
    {
        return base.ToString()+$" Incentive: {Incentive}, TargetAchieved: {TargetAchieved}";
    }
}