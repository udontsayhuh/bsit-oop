// Encapsulation, Inheritance
using System;

// Encapsulation
class Vehicle
{
    private int year;
    private string model;
    private string make;
    private string type;

    public Vehicle(int year, string make, string model, string type)
    {
        this.year = year;
        this.model = model;
        this.make = make;
        this.type = type;
    }

    public void Display()
    {
        Console.WriteLine($"Vehicle details:\nVehicle type is {type}, {model}(model), {make}(make), {year}(year)");
    }
}

// Inheritance
class Car : Vehicle
{
    public Car(int year, string make, string model, string type) : base(year, make, model, type)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car(1997, "Mitsubishi", "Space gear", "car");
        car1.Display();
        Console.ReadKey();
    }
}
