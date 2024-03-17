// Encapsulation
public class Car
//git
//attributes
{
    public string Model { get; private set; }
    public string Make { get; private set; }
    public int Year { get; private set; }

    // Constructor
    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    // Abstraction
    public virtual void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}

// Inheritance
public class Mslayer : Car
{
    public int CarCapacity { get; private set; }
    public Mslayer(string model, string make, int year, int carCapacity) : base(model, make, year)
    {

    }
    // Polymorphism
    public override void Drive()
    {
        Console.WriteLine("The car is now running silently.");
    }
}

public class Another : Car
{
    public int CarCapacity { get; private set; }
    public Another(string model, string make, int year, int carCapacity) : base(model, make, year)
    {

    }
    // Polymorphism
    public override void Drive()
    {
        Console.WriteLine("The car is now running very fast.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        DisplayCarInfo(myCar);

        Mslayer myElectricCar = new Mslayer(" Lamborghini Aventador", "Aventador S", 2017, 100);
        DisplayCarInfo(myElectricCar);

        Another myAnother = new Another("Porsche 911", "Porsche", 2023, 100);
        DisplayCarInfo(myAnother);

    }

    // Abstraction
    static void DisplayCarInfo(Car car)
    {
        Console.WriteLine($"Model: {car.Model}, Make: {car.Make}, Year: {car.Year}");
        car.Drive();
        car.Stop();
        Console.WriteLine();
    }
}
