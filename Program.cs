using System;

// ENCAPSULATION
class Car {
    // Encapsulated Attributes
    private string model;
    private string make;
    private int year;

    // Constructor
    public Car(string model, string make, int year) {
        this.model = model;
        this.make = make;
        this.year = year;
    }

    // Public Properties to access Encapsulated Attributes
    public string Model {
        get { return model; }
    }

    public string Make {
        get { return make; }
    }

    public int Year {
        get { return year; }
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
        // ABSTRACTION
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        
        myCar.Drive();
        myCar.Stop();
        
        // POLYMORPHISM
        Car myBus = new SchoolBus("Volvo", "SchoolBus Inc.", 2024, 45);
        Console.WriteLine($"Model: {myBus.Model}, Make: {myBus.Make}, Year: {myBus.Year}, Capacity: {(myBus as SchoolBus).capacity}");

        myBus.Drive();
        myBus.Stop();
    }
}
