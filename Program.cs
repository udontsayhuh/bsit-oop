using System;

// Encapsulation: Using private access modifiers to encapsulate the internal state of the Car class.
class Car {
    // Attributes
    private string Model;
    private string Make;
    private int Year;

    // Constructor
    public Car(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    // Abstraction: Hiding internal implementation details and providing only essential features through public methods.
    // Methods
    public void Drive() {
        Console.WriteLine("The car is now running.");
    }

    public void Stop() {
        Console.WriteLine("The car has stopped.");
    }

    // The Repair method without the virtual keyword
    public void Repair() {
        Console.WriteLine("The car is being repaired.");
    }
}

// Inheritance: Creating a new class Bus that inherits from the Car class.
class Bus : Car {
    // Constructor calling base constructor
    public Bus(string model, string make, int year) : base(model, make, year) {
    }

    // Overriding the Repair method from the base class with a different implementation.
    public override void Repair() {
        Console.WriteLine("The bus is being repaired.");
    }
}

class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();
        myCar.Repair(); // Demonstrating polymorphism

        Bus myBus = new Bus("Mercedes", "Sprinter", 2024);
        Console.WriteLine($"Model: {myBus.Model}, Make: {myBus.Make}, Year: {myBus.Year}");
        myBus.Drive();
        myBus.Stop();
        myBus.Repair(); // Demonstrating polymorphism
    }
}
