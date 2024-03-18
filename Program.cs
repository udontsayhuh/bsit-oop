using System;

abstract class Jet
{
    private string Model;
    private string Make;
    private int Year;

    public Jet(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    public string GetModel()
    {
        return Model;
    }

    public string GetMake()
    {
        return Make;
    }

    public int GetYear()
    {
        return Year;
    }


    public abstract void DisplayDetails();

    public void Flying()
    {
        Console.WriteLine("The jet is flying");
    }

    public void Stop()
    {
        Console.WriteLine("The Jet has landed.");
    }
}

class Plane : Jet
{
    private int Price;

    public Plane(string model, string make, int year, int price) : base(model, make, year)
    {
        Price = price;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Model: {GetModel()}, Make: {GetMake()}, Year: {GetYear()}, Price: {Price}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Plane newJet = new Plane("Embraer/FMA", "CBA 123 Vector", 1990, 15000000);
        newJet.DisplayDetails();

        newJet.Flying();
        newJet.Stop();
    }
}
