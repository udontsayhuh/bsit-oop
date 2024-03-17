using System;

abstract class Vehicle {
    // attributes
    public string Model { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }

    // Constructor
    public Vehicle(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;    
    }

    // methods 
    public abstract void Drive(); 
    public abstract void Stop();
}

class Car : Vehicle {
    // constructor
    public Car(string model, string make, int year) : base(model, make, year) {
    }
    public override void Drive() {
        Console.WriteLine("The car is now running.");
    }
    public override void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}

class SedanCar : Vehicle {
    // constructor
    public SedanCar(string model, string make, int year) : base(model, make, year) {
    }
    public override void Drive() {
        Console.WriteLine("Vroooom!!?!?! The sedan car is moving smoothly. ");
    }   
    public override void Stop() {
        Console.WriteLine("The sedan car has come to a stop.");
    }
}

class Program {
    static void Main(string[] args) {
        Vehicle myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();
        Console.WriteLine(); //pangspace lang po

        myCar = new SedanCar("BMW", "Sedan", 2024);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();
        Console.WriteLine(); //pangspace lang po ulit
    }
// explanation:
// encapsulation: ay yung mga access modifiers po i made like "public", example: yung model, make, year, drive, stop.
// inheritance: car and SedanCar are both inherited po sa vehicle class.
// abstraction: yung mga abstract methods po na ginawa ko sa vehicle class
// polymorphism: yung paggamit ko po ng vehicle class sa main method, na ginamit ko sa pagtawag ng car and SedanCar.
}

