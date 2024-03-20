using System;
abstract class Car // Abstraction
{
    // Encapsulation
    private string model = ""; // Empty string to avoid warning.
    private string make = "";
    public int Year;
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    // Constructor
    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    // Polymorphism 
    public virtual void Drive() // Virtual Method
    {
        Console.WriteLine("The car is now running.");
    }
    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
    class ElectricCar : Car
    {
        public string Brand = "Tesla";
        public ElectricCar(string model, string brand, int year)
            : base(model, brand, year)
        {
            Brand = brand;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Car myCar = new Car("Toyota", "Corolla", 2023);
            // Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}\n");
            // myCar.Drive();
            // myCar.Stop();

            ElectricCar eCar = new ElectricCar("Cybertruck", "Tesla", 2024);
            Console.WriteLine($"\nElectric Car \nModel: {eCar.Model}, Brand: {eCar.Brand}, Year: {eCar.Year}");
        }
    }
}

