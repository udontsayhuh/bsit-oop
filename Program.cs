// Abstraction 
public abstract class Vehicle
{
    public string Model { get; set; }
    public string Make { get; set; }

    // Encapsulation 
    public abstract void Drive();
    public abstract void Stop();
}

// Inheritance 
public class Car : Vehicle
{
    public int Year { get; set; }

    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    public override void Drive() // Polymorphism 
    {
        Console.WriteLine("The car is now running.");
    }

    public override void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Encapsulation 
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();
    }
}
