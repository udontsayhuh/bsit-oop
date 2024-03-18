using System;

class Car
{
    // encapsulation (private fields)
    private string model;
    private string make;
    private int year;

    // constructor
    public Car(string model, string make, int year)
    {
        this.model = model;
        this.make = make;
        this.year = year;
    }

    // encapsulation (public properties for accessing private fields)
    public string Model
    {
        get { return model; }
    }

    public string Make
    {
        get { return make; }
    }

    public int Year
    {
        get { return year; }
    }

    // abstraction & polymorphism: start engine
    public virtual void StartEngine()
    {
        Console.WriteLine("The engine has started.");
    }

    // abstraction: stop engine
    public virtual void StopEngine()
    {
        Console.WriteLine("The engine has stopped.");
    }
}

class luxurySedan : Car
{
    // constructor for luxurySedan class
    public luxurySedan(string model, string make, int year) : base(model, make, year)
    {
    }

    // polymorphism 
    public override void StartEngine()
    {
        Console.WriteLine("The luxury sedan engine has started.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // inheritance
        luxurySedan myCar = new luxurySedan("Mercedes-Benz", "Turbo Diesel 300D", 1976);

        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");

        myCar.StartEngine();

        myCar.StopEngine();
    }
}
