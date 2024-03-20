using System;

// Abstract class Vehicle
abstract class Vehicle {
    // Attributes
    public string Model { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }

    // Abstract method
    public abstract void Drive();
}

// Car class inherits from Vehicle
class Car : Vehicle {
    // Constructor
    public Car(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    //Implementation of abstract method
    public override void Drive() {
        Console.WriteLine("The car is now running.");
        Console.WriteLine("That's my dream car.");
    }

    public void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}

// DreamCar class inherits from myCar
class DreamCar : Car {
    // Constructor
    public DreamCar(string model, string make, int year) : base(model, make, year) {
    }

    // Override method
    public override void Drive() {
        Console.WriteLine("The dream car is now running silently.");
        Console.WriteLine("That's my dream car.");
    }
}

class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model} \n   \n Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();

        DreamCar myDreamCar = new DreamCar("Porche", "Taycan", 2022);
        Console.WriteLine($"Model: {myDreamCar.Model} \n   \n Make: {myDreamCar.Make}, Year: {myDreamCar.Year}");
        myDreamCar.Drive();
    }
}
