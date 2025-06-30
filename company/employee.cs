using System;

public abstract class Employee
{
    protected int id;
    protected string name;
    protected double salary;
    protected Address address;

    public Employee(int id, string name, double salary, Address address )
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
        this.address = address;
    }


    public abstract void Display();
    
}

