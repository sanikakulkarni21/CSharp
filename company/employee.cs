using System;

public abstract class Employee
{
    protected int id;
    protected string name;
    protected double salary;
    protected Address address;
    
    public int Id { get; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public Address Address { get; set; }

    public Employee(int id, string name, double salary, Address address)
    {
        Id = id;
        Name = name;
        Salary = salary;
        Address = address;
    }


    public abstract void Display();
    
}

