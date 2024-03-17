using System;

// ABSTRACTION base class
abstract class Car
{
    // ENCAPSULATION
    private string Model;
    private string Make;
    private int Year;

    // Constructor
    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    // encapsulation -- accessing private fields
    public string getModel() => Model;
    public string getMake() => Make;
    public int getYear() => Year;

    // abstract method
    public abstract void DisplayCarInfo();

    // virtual method (POLYMORPHISM)
    public virtual void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public void Stop()
    {
        Console.WriteLine("\n>>The car has stopped.");
    }
}

// derived class
class Jeepney : Car
{
    // additional properties 
    public int PassengerCapacity { get; set; }
    public double Fare { get; set; }

    // calls base class constructor
    public Jeepney(string model, string make, int year, int passengerCapacity, double fare)
        : base(model, make, year)
    {
        PassengerCapacity = passengerCapacity;
        Fare = fare;
    }

    // POLYMORPHISM -- overriding DisplayCarInfo method
    public override void DisplayCarInfo()
    {
        Console.WriteLine($">>Model: {getModel()}, Make: {getMake()}, Year: {getYear()}, Passenger Capacity: {PassengerCapacity}, Fare: PHP{Fare}");
    }

    // pvverriding Drive() method
    public override void Drive()
    {
        Console.WriteLine("\n>>The jeepney is cruising through the streets, picking up passengers! :)\n");
    }

    // new method for Jeepney (encapsulation)
    public void CollectFare(double amount)
    {
        Console.WriteLine($">>Collecting PHP{amount} from a passenger.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // implementing changes using the Encapsulation, Inheritance, Abstraction, and Polymorphism.
        Jeepney myJeepney = new Jeepney("2nd-generation jeepney", "Traditional", 1990, 20, 14.00);
        myJeepney.DisplayCarInfo(); // polymorphism for JEepney DisplayCarInfo() method
        myJeepney.Drive(); // polymorphism -- for Jeepney Drive() method
        myJeepney.CollectFare(14.00); // encapsulation -- method specific for Jeepney
        myJeepney.Stop(); // inherited method from Car

        // waits for a key press before ending the app and closing the window
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadLine();
    }
}
