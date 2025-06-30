using System;

public class SalesEmployee : Employee
{
    private double commission;

    public SalesEmployee(int id, string name, double salary, double commission,Address address)
        : base(id, name, salary, address)
    {
        this.commission = commission;
    }

    public override void Display()
    {

        {
        Console.WriteLine($"ID: {id}, Name: {name}, Salary: {salary}");
        if (address != null)
        {
            address.Display();
        }
        else
        {
            Console.WriteLine("Address: Not provided");
        }
    }
        
        Console.WriteLine($"Commission: {commission}");
    }
}