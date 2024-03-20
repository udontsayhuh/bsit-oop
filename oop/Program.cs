using System;

// Abstraction
abstract class Vehicle // Base Class: Parent
{
    // Private attribute
    private string type;

    // Public attribute
    public string Model;
    public string Make;
    public int Year;
    public string PlateNum;

    // Getter and setter for type
    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    // Constructor
    public Vehicle(string type, string model, string make, int year, string plateNum)
    {
        Type = type;
        Model = model;
        Make = make;
        Year = year;
        PlateNum = plateNum;
    }

    // Abstract Method
    public abstract void CheckPlateNum();
}

class Car : Vehicle // Derived Class: Child
{
    // Constructor
    public Car(string type, string model, string make, int year, string plateNum) : base(type, model, make, year, plateNum)
    {
    }

    // Polymorphism 
    public override void CheckPlateNum()
    {
        if (PlateNum == "R")
        {
            Console.WriteLine("The car is registered.");
        }
        else
        {
            Console.WriteLine("The car is not registered.");
        }
    }
}

// Concrete implementation of a motorcycle
class Motorcycle : Vehicle // Derived Class: Child
{
    // Constructor
    public Motorcycle(string type, string model, string make, int year, string plateNum) : base(type, model, make, year, plateNum)
    {
    }

    // Polymorphism
    public override void CheckPlateNum()
    {
        if (PlateNum == "R")
        {
            Console.WriteLine("The motorcycle is registered.");
        }
        else
        {
            Console.WriteLine("The motorcycle is not registered.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Car myCar = new Car("Car", "Toyota", "Corolla", 2023, "R");
        Console.WriteLine($"Type: {myCar.Type}, Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.CheckPlateNum();

        Motorcycle myMotorcycle = new Motorcycle("Motorcycle", "Honda", "Click 160", 2024, "NR");
        Console.WriteLine($"Type: {myMotorcycle.Type}, Model: {myMotorcycle.Model}, Make: {myMotorcycle.Make}, Year: {myMotorcycle.Year}");
        myMotorcycle.CheckPlateNum();
    }
}