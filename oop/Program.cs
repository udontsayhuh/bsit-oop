using System;
class Vehicle { // base class (parent)
    //test
    //git
    //Attributes
    public string Model;
    public string Make;
    public int Year;
     
    //Constructor
    public Vehicle(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    //Methods
    public virtual void Drive() {
        Console.WriteLine("The car is now running.");
    }

    public virtual void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}
    //Abstraction
    abstract class TravelMode
    {
    public string Mode;
    public TravelMode(string mode)
    {
        Mode = mode;
    }
    public abstract void Travel();
    }

    // Derived class / Inheritance (child)
class Car: Vehicle {
    public Car(string model, string make, int year) : base (model, make, year)
    {
        
    }
    //Polymorphism
    public override void Drive()
    {    Console.WriteLine("Our car is now running.");
     
    }
}
    
class Tricycle : TravelMode
{
    public Tricycle() : base ("Tricycle")
    {
    
    }
    public override void Travel()
    {
        Console.WriteLine($"Tricycle: SM FAIRVIEW / ROBINSONS / FAIRVIEW TERRACES");
    }
}

class Jeep : TravelMode
{
    public Jeep() : base ("Jeep")
    {

    }
    public override void Travel()
    {
        Console.WriteLine($"Jeep: ROBINSONS / SM FAIRVIEW IKOT-LOOB / LAGRO LOOB-DULO");
    }
}


class Program {
    static void Main(string[] args) {
        Vehicle myVehicle = new Vehicle("Toyota", "Corolla", 2023);
        Vehicle myCar = new Car("Ford", "Tesla", 2024);
        TravelMode myTricycle = new Tricycle();
        TravelMode myJeep = new Jeep();

        Console.WriteLine($"Model: {myVehicle.Model}, Make: {myVehicle.Make}, Year: {myVehicle.Year}");
        myVehicle.Drive();
        myVehicle.Stop();
        
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();

        myTricycle.Travel();
        myJeep.Travel();

    }
}
