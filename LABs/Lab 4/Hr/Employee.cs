
abstract class Employee{

    public int Id{get;set;}
    public string Name{get;set;}
    public double Salary{get; set;}
    


    public Employee(int id , string name, double salary)
    {
        Id=id;
        Name=name;
        Salary=salary;
    }
    
    
    
    
    public abstract void DoWork();



    public virtual double ComputePay()
    {
        return Salary;
    }


    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
    }
}