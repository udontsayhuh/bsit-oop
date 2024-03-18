// Palaje BSIT 2-2
using System;

// Abstract base class for Car
abstract class Car {
    // Encapsulation: Private Attributes 
    private string model;
    private string make;
    private int year;

    // Encapsulation: Properties for controlled access to attributes
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
   
    // Constructor
    public Car(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    // Abstract method for driving - data hiding
    public abstract void Drive();

    // Method for Stop 
    // Polymorphism: overridden in derived classes
    public virtual void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}

// Inheritance: Car1 and Car2 inheriting from Car
class Car1 : Car {
    public Car1(string model, string make, int year) : base(model, make, year) {
        // Additional constructor logic specific to Car1
    }

    // Override the Drive() method
    public override void Drive() {
        Console.WriteLine("The car is now running.");
    }
    // Polymorphism : implementing different form  
    public override void Stop() {
        Console.WriteLine("Toyota Corolla has stopped.");
    }
}

class Car2 : Car {
    public Car2(string model, string make, int year) : base(model, make, year) {
        // Additional constructor logic specific to Car2
    }

    // Override the Drive() method
    public override void Drive() {
        Console.WriteLine("Ford Mustang is now running.");
    }
    // Polymorphism : implementing different form  
    public override void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}

class Program {
    static void Main(string[] args) {
        // Creating an instance of Car1
        Car myCar1 = new Car1("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar1.Model}, Make: {myCar1.Make}, Year: {myCar1.Year}");
        myCar1.Drive();
        myCar1.Stop();
        // Instance of Car2
        Car myCar2 = new Car2("Mustang", "Ford", 2023);
        Console.WriteLine($"\nModel: {myCar2.Model}, Make: {myCar2.Make}, Year: {myCar2.Year}");
        myCar2.Drive();
        myCar2.Stop();
    }
}
