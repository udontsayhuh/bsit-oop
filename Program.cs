using System;

abstract class Vehicle
{
    //Encapsulation
    protected int year;
    protected string model;
    protected string make;

    // Abstraction
    public Vehicle(int year, string make, string model)
    {
        this.year = year;
        this.model = model;
        this.make = make;
    }

    // Abstraction
    public abstract void Display();
}

// Inheritance
class Car : Vehicle
{
    public Car(int year, string make, string model) : base(year, make, model)
    {
    }

    // Polymorphism
    public override void Display()
    {
       Console.WriteLine($"This CAR is an {make}, {model} of year {year}\n");
    }   
}

// Inheritance
class Motorcycle : Vehicle
{
    public Motorcycle(int year, string make, string model) : base(year, make, model)
    {
    }

    // Polymorphism
    public override void Display()
    {
       Console.WriteLine($"This MOTORCYCLE is a {make}, {model} of year {year}\n");
    }   
}

// Inheritance
class Tank : Vehicle
{
    public Tank(int year, string make, string model) : base(year, make, model)
    {
    }

    // Polymorphism
    public override void Display()
    {
       Console.WriteLine($"This TANK is a {make}, {model} of year {year}");
    }   
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle car1 = new Car(1997, "Mitsubishi", "Space gear");
        car1.Display();

        Vehicle motorcycle1 = new Motorcycle(2020, "BMW", "R18");
        motorcycle1.Display();

        Vehicle tank1 = new Tank(2008, "Hyundai Rotem", "K12 Black Panther");
        tank1.Display();
        
        Console.ReadKey();
    }
}
