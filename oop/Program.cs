﻿class Car {

    //Encapsulation: Making attributes private and providing public
    //Attributes
    public string Model;
    public string Make;
    public int Year;

    //Constructor
    public Car(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    // Abstraction: Implementing methods that can be overridden by subclasses.
    public virtual void Start() {
        Console.WriteLine("The Car is now started.");
    }

    public virtual void Rev() {
        Console.WriteLine("The Car has started revving to 6,000 RPM (VTEC)");
    }
    public virtual void Stop()
    {
        Console.WriteLine("The Car has now stopped after running out of gas");
    }
}

// Inheritance: Creating a subclass that inherits from Car.
class ElectricCar : Car
{
    public ElectricCar(string model, string make, int year) : base(model, make, year)
    {
    }

    // Polymorphism: Overriding methods from the base class.
    public override void Start()
    {
        Console.WriteLine("The Electric Car is now running silently.");
    }

    public override void Rev()
    {
        Console.WriteLine("The Electric car has revved to 15,000 RPM");
    }
    public override void Stop()
    {
        Console.WriteLine("The Electric car has now stopped after running out of charge");
    }
}

class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Honda", "Civic", 2000);
        Console.WriteLine($"\nModel: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Start();
        myCar.Rev();
        myCar.Stop();


        ElectricCar myElectricCar = new ElectricCar("Tesla", "Model S", 2024);
        Console.WriteLine($"\nModel: {myElectricCar.Model}, Make: {myElectricCar.Make}, Year: {myElectricCar.Year}");
        myElectricCar.Start();
        myElectricCar.Rev();
        myElectricCar.Stop();
    }
}
//Lennox Macadangdang BSIT 2-1
