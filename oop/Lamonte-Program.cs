using Microsoft.VisualBasic.FileIO;
using System;

// a modified version that implement 4 pillars of OOP
class Car
{
    //test
    //git
    //Attributes
    // implementing encapsulation by making the attributes private
    private string model;
    private string make;
    private int year;
    private double speed;

    // Properties
    // this will serve as the middle man or getter and setter for the private attributes
    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    //Constructor
    // since we use encapsulation, we need to use the properties to set the value of the attributes
    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    //Methods
    public virtual void ViewDetails()
    {
        Console.WriteLine("Make : " + make);
        Console.WriteLine("Model : " + model);
        Console.WriteLine("Year : " + year);
    }

    public void drive()
    {
        Console.WriteLine("\nYou are driving the car....");
    }
    // implementing abstraction
    // it hides the complex calculation of speed and only display the necessary information
    public void SpeedsUp(double vehiclespeed)
    {
        speed += vehiclespeed;
        Console.WriteLine($"You accelerated to {speed} km/h.");
    }

    public void SlowsDown(double vehiclespeed)
    {
        speed -= vehiclespeed;
        if (speed <= 0)
        {
            speed = 0;
            Console.WriteLine("You stopped.");
        }
        else
        {
            Console.WriteLine($"You slows down to {speed} km/h.");
        }
        
    }
}

// implementing inheritance
class AutomaticCar : Car
{
    private string transmissionType;

    public AutomaticCar(string make, string model, int year, string transmission) : base(make, model, year)
    {
        Make = make;
        Model = model;
        Year = year;
        transmissionType = transmission;
    }

    // this is a method demonstrating polymorphism
    // it overides the ViewDetails method of the Car class
    public override void ViewDetails()
    {
        base.ViewDetails();
        Console.WriteLine("Transmission Type : " + transmissionType);
    }
}

class ManualCar : Car
{
    private int numberOfGears;
    private bool hasClutchPedal;
    public ManualCar(string make, string model, int year, int noOfGears) : base(make, model, year)
    {
        Make = make;
        Model = model;
        Year = year;
        numberOfGears = noOfGears;
        hasClutchPedal = true;
    }

    public override void ViewDetails()
    {
        base.ViewDetails();
        Console.WriteLine("Number of Gears : " + numberOfGears);
        Console.WriteLine("Has Clutch Pedal : " + hasClutchPedal);
    }


}

class Program
{

    static void Main(string[] args)
    {
        // instance of AutomaticCar class
        AutomaticCar myAutoCar = new AutomaticCar("Toyota", "Camry", 2023, "Automatic");

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Details of the Automatic Car");
        Console.WriteLine("--------------------------------------------------");
        myAutoCar.ViewDetails();
        myAutoCar.drive();
        myAutoCar.SpeedsUp(40);
        myAutoCar.SlowsDown(30);
        myAutoCar.SlowsDown(50);

        // instance of ManualCar class
        ManualCar myManualCar = new ManualCar("Honda", "Civic", 2023, 5);

        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("Details of the Manual Car");
        Console.WriteLine("--------------------------------------------------");
        myManualCar.ViewDetails();
        myAutoCar.drive();
        myManualCar.SpeedsUp(60);
        myManualCar.SlowsDown(30);
        myManualCar.SlowsDown(40);

    }

}