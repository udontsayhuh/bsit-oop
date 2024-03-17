using System;
using System.Management.Instrumentation;

class Vehicle  // Base class (parent) 
{
    public int Year;
    public string Model;
    public string Manufacturer;

    public Vehicle(string model, string manufacturer)
    {
        Year = 2023;
        Model = model;
        Manufacturer = manufacturer;
    }


    public virtual void CarSound()
    {
        Console.WriteLine("Vehicle Sound:");
    }
}

class Car : Vehicle   // Derived class (child) 
{
    public Car(string model, string manufactuer) : base(model, manufactuer)
    {
    }


    public override void CarSound()
    {
        Console.WriteLine("Broom Broom");
    }
}

class Plane : Vehicle  // Derived class (child) 
{
    public Plane(string model, string manufacturer) : base(model, manufacturer)
    {

    }
    public override void CarSound()
    {
        Console.WriteLine("Skrrt Skrrt");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle myVehicle = new Vehicle("Model", "Manufacturer");
        Car myCar = new Car("Raize", "Toyota");
        Plane myPlane = new Plane("A380", "Airbus");

        Console.WriteLine(myCar.Manufacturer + "  " + myCar.Model + "  " + myCar.Year);
        Console.WriteLine(myPlane.Manufacturer + "  " + myPlane.Model + "  " + myPlane.Year);
        myVehicle.CarSound();
        myCar.CarSound();
        myPlane.CarSound();
    }
}