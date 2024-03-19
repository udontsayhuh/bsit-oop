using System;

// ENCAPSULATION
class Car {
    // Attributes
    public string model; // Stores the model of the car
    public string make;  // Stores the make of the car
    public int year;     // Stores the year of the car

    // Constructor
    public Car(string model, string make, int year) {
        this.model = model; // Initializes the model attribute
        this.make = make;   // Initializes the make attribute
        this.year = year;   // Initializes the year attribute
    }

    // ABSTRACTION
    // Methods
    public virtual void Drive() {
        Console.WriteLine("The car is now running.");
    }

    public void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}

// INHERITANCE
class SchoolBus : Car {
    // Additional attribute
    public int capacity;

    // Constructor
    public SchoolBus(string model, string make, int year, int capacity) : base(model, make, year) {
        this.capacity = capacity;
    }

    // POLYMORPHISM
    public override void Drive() {
        Console.WriteLine("The school bus is now running with children aboard.");
    }
}

class Program {
    static void Main(string[] args) {
        // ABSTRACTION: Using Car class without needing to know its internal details
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.model}, Make: {myCar.make}, Year: {myCar.year}");
        
        myCar.Drive();
        myCar.Stop();
        
        // POLYMORPHISM: Treating SchoolBus object as Car object 
        Car myBus = new SchoolBus("Volvo", "SchoolBus Inc.", 2024, 45);
        Console.WriteLine($"Model: {myBus.model}, Make: {myBus.make}, Year: {myBus.year}, Capacity: {(myBus as SchoolBus).capacity}");

        myBus.Drive();
        myBus.Stop();
    }
}
