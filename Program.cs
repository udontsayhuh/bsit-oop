using System;

// Abstract class Vehicle
abstract class Vehicle 

    { // Declaring an abstract class called Vehicle
    public string Model { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }

    public abstract void Drive();
    }

class Car : Vehicle {
    // Constructor
    public Car(string model, string make, int year) 
    {
        Model = model;
        Make = make;
        Year = year;
    }
    
 public override void Drive() {
    Console.WriteLine("The car is now running.");}

    public void Stop() {
        Console.WriteLine("The car has stopped."); }
    }
    //Methods
    public void Drive() {
        Console.WriteLine("The car is now running.");
    }

    public void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}

class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();

    }
}
