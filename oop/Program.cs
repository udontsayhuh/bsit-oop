using System;

class Car
{
    //test
    //git
    // Attributes
    public string Model;
    private string make;
    public int Year;

    // Encapsulation
    public string Make
    {
        get { return make; }
        set { make = value; }
    }
    // Constructors
    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    // Methods
    // Abstraction
    public virtual void Drive()
    {
        Console.WriteLine("The car is now running.");
    }
    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}

// Inheritance
class SportsCar : Car
{
    public SportsCar(string model, string make, int year) : base(model, make, year)
    {
    }

    //Polymorphism
    public override void Drive()
    {
        Console.WriteLine("The sports car is now running fast.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();
    }
}
