using System;

// Encapsulation: Making attributes private and providing public properties for access.
public class Car {
    private string model;
    private string make;
    private int year;

    // Encapsulation: Properties for accessing private attributes.
    public string Model {
        get { return model; }
        set { model = value; }
    }

    public string Make {
        get { return make; }
        set { make = value; }
    }

    public int Year {
        get { return year; }
        set { year = value; }
    }

    // Abstraction: Drive and Stop methods abstract the behavior of a car.
    public void Drive() {
        Console.WriteLine("The car is now running.");
    }

    public void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}

// Inheritance: Sedan class inherits from Car class, demonstrating inheritance.
public class Sedan : Car {
    private int trunkCapacity;

    // Encapsulation: Property for accessing private attribute trunkCapacity.
    public int TrunkCapacity {
        get { return trunkCapacity; }
        set { trunkCapacity = value; }
    }

    // Abstraction & Polymorphism: Overriding Drive method to exhibit specific behavior for Sedan.
    public override void Drive() {
        Console.WriteLine("The sedan is now running smoothly.");
    }
}

class Program {
    static void Main(string[] args) {
        // Abstraction & Polymorphism: Creating a Sedan object, demonstrating abstraction and polymorphism.
        Sedan myCar = new Sedan();
        myCar.Model = "Toyota";
        myCar.Make = "Corolla";
        myCar.Year = 2023;
        myCar.TrunkCapacity = 500;

        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}, Trunk Capacity: {myCar.TrunkCapacity} liters");
        myCar.Drive();
        myCar.Stop();
    }
}