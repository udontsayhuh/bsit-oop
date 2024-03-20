using System;

// Abstraction: Define an abstract base class Vehicle
abstract class Vehicle {
    // Encapsulation: Fields are private and accessible through properties
    private string model;
    private string make;
    private int year;

    // Encapsulation: Properties to access the fields
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

    // Abstraction: Abstract method Drive
    public abstract void Drive();

    // Abstraction: Abstract method Stop
    public abstract void Stop();
}

// Inheritance: Car class inherits from Vehicle
class Car : Vehicle {
    // Constructor
    public Car(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    // Implementation of abstract method Drive
    public override void Drive() {
        Console.WriteLine("The car is now running.");
    }

    // Implementation of abstract method Stop
    public override void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}

class Program {
    static void Main(string[] args) {
        // Polymorphism: Using base class reference to access derived class object
        Vehicle myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();
    }
}
