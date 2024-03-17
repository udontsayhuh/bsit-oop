using System;

class Vehicle
{
    //Attributes
    public string Model;
    public string Make;
    public int Year;

    //Constructor
    public Vehicle(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    //Methods
    public virtual void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped.\n");
    }
}

    //Abstraction
abstract class Transportation
{
    public abstract void Travel();
}

    //Inheritance from class vehicle
class Car : Vehicle
{
    public Car(string model, string make, int year) : base(model, make, year)
    {
    }
        //Polymorphism
    public override void Drive()
    {
        Console.WriteLine("Our red car is now running.\n");
    }
}

class Bus : Transportation
{
    public override void Travel()
    {
        Console.WriteLine("Bus: PITX/MOA");
    }
}

class EJeep : Transportation
{
    public override void Travel()
    {
        Console.WriteLine("EJeep: Litex/Commonwealth Market");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Vehicle myVehicle = new Vehicle("Toyota", "Corolla", 2023);
        Vehicle myCar = new Car("Honda", "Civic", 2024);
        Transportation myBus = new Bus();
        Transportation myEJeep = new EJeep();

        Console.WriteLine($"Model: {myVehicle.Model}, Make: {myVehicle.Make}, Year: {myVehicle.Year}");
        myVehicle.Drive();
        myVehicle.Stop();

        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();

        myBus.Travel();
        myEJeep.Travel();
    }
}
