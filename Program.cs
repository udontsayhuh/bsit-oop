using System;

abstract class Vehicle {
    private string model;
    private string make;
    private int year;

    public Vehicle(string model, string make, int year) {
        this.model = model;
        this.make = make;
        this.year = year;
    }

    public string GetModel() {
        return model;
    }

    public string GetMake() {
        return make;
    }

    public int GetYear() {
        return year;
    }

    public abstract void Start();

    public virtual void Drive() {
        Console.WriteLine("The vehicle is now running.");
    }

    public void Stop() {
        Console.WriteLine("The vehicle has stopped.");
    }
}

class Car : Vehicle {
    public Car(string model, string make, int year) : base(model, make, year) {
    }

    public override void Start() {
        Console.WriteLine("The car engine is starting.");
    }

    public override void Drive() {
        Console.WriteLine("The car is now running.");
    }
}

class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.GetModel()}, Make: {myCar.GetMake()}, Year: {myCar.GetYear()}");
        myCar.Start();
        myCar.Drive();
        myCar.Stop();
    }
}
