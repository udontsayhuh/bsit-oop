using System;

// Encapsulation
public class Car
{
    // Private fields
    private string model;
    private string make;
    private int year;

    // Properties to access private fields
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

    // Abstraction
    public void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}

// Inheritance The ElectricCar inherits from the parent class Car
public class ElectricCar : Car
{
    // Additional attribute
    public int Price { get; set; }

    // Constructor
    public ElectricCar(string model, string make, int year, int price) : base(model, make, year)
    {
        Price = price;
    }

    // Polymorphism
    public override void Drive()
    {
        Console.WriteLine("The electric car is now running silently.");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Create an instance of ElectricCar
        ElectricCar myElectricCar = new ElectricCar("Tesla", "Model S", 2024, 80000);

        // Access and display properties
        Console.WriteLine($"Model: {myElectricCar.Model}, Make: {myElectricCar.Make}, Year: {myElectricCar.Year}, Price: {myElectricCar.Price}");

        // Call methods
        myElectricCar.Drive();
        myElectricCar.Stop();
    }
}

