using System;

class Car {
    // Encapsulation
    private string Model;
    private string Make;
    private int Year;
    
    // Constructor
    public Car(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    // Encapsulation
    public void Drive() {
        Console.WriteLine("The car is now running.");
    }

    public void Stop() {
        Console.WriteLine("The car has stopped.");
    }

    // Abstraction
    public abstract void StartEngine();
}
    // Inheritance
class SportsCar : Car {
    public int Horsepower;

    // Constructor for SportsCar
    public SportsCar(string model, string make, int year, int horsepower)
        : base(model, make, year) {
        Horsepower = horsepower;
    }

    // Polymorphism
    public override void Drive() {
        Console.WriteLine($"The sports car accelerates with {Horsepower} horsepower!!!");
    }

    // Abstraction     
    public override void StartEngine() {
        Console.WriteLine("Sports car engine started.");
    }
}

class Program {
    static void Main(string[] args) {
        SportsCar mySportsCar = new SportsCar("Chevrolet", "Corvette", 2024, 495);
        Console.WriteLine($"Model: {mySportsCar.Model}, Make: {mySportsCar.Make}, Year: {mySportsCar.Year}");
        mySportsCar.StartEngine(); 
        mySportsCar.Drive(); 
        mySportsCar.Stop();
    }
}
