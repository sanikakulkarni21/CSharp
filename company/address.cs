using System;

public class Address
{
    private string city;
    private string state;
    private string zip;

    public Address(string city, string state, string zip)
    {
        this.city = city;
        this.state = state;
        this.zip = zip;
    }

    public void Display()
    {
        Console.WriteLine($"Address: {city}, {state} - {zip}");
    }
}
