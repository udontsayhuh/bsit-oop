using System;

// Encapsulation: Making attributes private and providing protected properties for access.
class Car {
    private string model;
    private string make;
    private int year;

    public Car(string model, string make, int year) {
        this.model = model;
        this.make = make;
        this.year = year;
    }

    // Protected properties for encapsulation
    public string Model {
        get { return model; }
        protected set { model = value; }
    }

    public string Make {
        get { return make; }
        protected set { make = value; }
    }

    public int Year {
        get { return year; }
        protected set { year = value; }
    }

    // Abstraction: Drive and Stop methods are abstracted as the behaviors of the Car.
    public virtual void Drive() {
        Console.WriteLine("The car is now running.");
    }

    public virtual void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}

// Inheritance: Truck class inherits from Car class.
class Truck : Car {
    public Truck(string model, string make, int year) : base(model, make, year) {
    }

    // Polymorphism: Override Drive method for Truck to provide specific behavior.
    public override void Drive() {
        Console.WriteLine("The truck is now moving.");
    }
}

class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();

        Truck myTruck = new Truck("Ford", "F-150", 2024);
        Console.WriteLine($"Model: {myTruck.Model}, Make: {myTruck.Make}, Year: {myTruck.Year}");
        myTruck.Drive(); // Polymorphism in action
        myTruck.Stop(); // Inherited behavior
    }
}
