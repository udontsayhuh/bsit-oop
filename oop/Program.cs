using System;

abstract class Car
{
    // Encapsulated attributes
    private string model;
    private string make;
    private int year;

    // Public properties to access the encapsulated attributes
    // getters and setters, for encapsulation
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Constructor
    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
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
    public Carfunc(string model, string make, int year)
        : base(model, make, year)
    {
    }

    // Implementation of abstract Drive method
    //polymorphism attributes
    public override void Drive()
    { // method overriding
        if (Make == "Ferrari")
            Console.WriteLine($"The {Make} is now running at 140kph.");
        else if (Make == "Toyota")
            Console.WriteLine($"The {Make} is now running at 110kph.");
        else if (Make == "Mitsubishi")
            Console.WriteLine($"The {Make} is now running at 100kph");
        else
            Console.WriteLine($"The {Make} is now running at 90kph.");
    }

    // Implementation of abstract Stop method
    public override void Stop()
    {
        Console.WriteLine($"The {Make} has stopped.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carfunc myCar = new Carfunc("SF90", "Ferrari", 2019);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();
    }
}
