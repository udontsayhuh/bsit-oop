using System;

abstract class Vehicle  // Base class (parent) 
{
    public int Year { get; set; }
    public string Model { get; set; }
    public string Manufacturer { get; set; }

    public Vehicle(string model, string manufacturer)
    {
        this.Year = 2023;
        this.Model = model;
        this.Manufacturer = manufacturer;
    }
    public abstract void VehicleSound();
}

class Car : Vehicle   // Derived class (child) 
{
    public Car(string model, string manufactuer) : base(model, manufactuer) { }
    public override void VehicleSound()
    {
        Console.WriteLine("Broom Broom");
    }
}

class Plane : Vehicle  // Derived class (child) 
{
    public Plane(string model, string manufacturer) : base(model, manufacturer) { }
    public override void VehicleSound()
    {
        Console.WriteLine("Skrrt Skrrt");
    }
}

class Bergado_Assignment
{
    static void Main(string[] args)
    {

        Car myCar = new Car("Raize", "Toyota");
        Plane myPlane = new Plane("A380", "Airbus");
        Console.WriteLine(myCar.Manufacturer + "  " + myCar.Model + "  " + myCar.Year);
        myCar.VehicleSound();
        Console.WriteLine(myPlane.Manufacturer + "  " + myPlane.Model + "  " + myPlane.Year);
        myPlane.VehicleSound();
    }
}