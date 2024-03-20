using System;

// Base class representing a vehicle
abstract class Vehicle
{
    public abstract string Model { get; set; }
    public abstract string Make { get; set; }
    public abstract int Year { get; set; }
    public abstract void Drive();
    public abstract void Stop();
}

// Concrete class representing a car
class Car : Vehicle
{
    public override string Model { get; set; }
    public override string Make { get; set; }
    public override int Year { get; set; }

    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    public override void Drive()
    {
        Console.WriteLine("Car is moving.");
    }

    public override void Stop()
    {
        Console.WriteLine("Car has stopped.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle car1 = new Car("Toyota", "Corolla", 2023);
        Vehicle car2 = new Car("Porsche", "Lamborghini", 2016);

        car1.Drive();
        car1.Stop();
        Console.WriteLine($"Car 1: Model - {car1.Model}, Make - {car1.Make}, Year - {car1.Year}");

        car2.Drive();
        car2.Stop();
        Console.WriteLine($"Car 2: Model - {car2.Model}, Make - {car2.Make}, Year - {car2.Year}");
    }
}
