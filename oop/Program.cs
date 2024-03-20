using System;

abstract class Car
{
    // Encapsulated attributes
    private string model;
    private string manufacturer;
    private int year;

    // Public properties to access the encapsulated attributes
    // getters and setters, for encapsulation
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Constructor
    public Car(string model, string manufacturer, int year)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
    }

    // Abstract method for Drive
    public abstract void Drive();

    // Abstract method for Stop
    public abstract void Stop();
}
// inheritance attributes
class Carfunc : Car
{ // Sub class Carfunc, superclass Car, (: means extends)
    // Constructor
    public Carfunc(string model, string manufacturer, int year)
        : base(model, manufacturer, year)
    {
    }

    // Implementation of abstract Drive method
    //polymorphism attributes
    public override void Drive()
    { // method overriding
        if (Manufacturer == "Ferrari")
            Console.WriteLine($"The {Manufacturer}  {Model} is now running at 140kph.");
        else if (Manufacturer == "Toyota")
            Console.WriteLine($"The {Manufacturer}  {Model} is now running at 110kph.");
        else if (Manufacturer == "Mitsubishi")
            Console.WriteLine($"The {Manufacturer}  {Model} is now running at 100kph");
        else
            Console.WriteLine($"The {Manufacturer}   {Model} is now running at 90kph.");
    }

    // Implementation of abstract Stop method
    public override void Stop()
    {
        Console.WriteLine($"The {Manufacturer} {Model} has stopped.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carfunc myCar = new Carfunc("SF90", "Ferrari", 2019);
        Console.WriteLine($"Model: {myCar.Model}, Manufacturer: {myCar.Manufacturer}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();
    }
}
