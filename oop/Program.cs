//  class for vehicles
abstract class Vehicle
{
    // Encapsulated attributes
    private string Model { get; }
    private string Make { get; }
    private int Year { get; }

    // Constructor
    public Vehicle(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    // get model
    public string GetModel()
    {
        return Model;
    }

    // get make
    public string GetMake()
    {
        return Make;
    }

    // get year
    public int GetYear()
    {
        return Year;
    }

    // Method for driving
    public abstract void Drive();

    // Method for stopping
    public abstract void Stop();
}

// Class Tricycle inherits from Vehicle
class Tricycle : Vehicle
{
    // Constructor
    public Tricycle(string model, string make, int year) : base(model, make, year) { }

    // Implementation of Drive method
    public override void Drive()
    {
        Console.WriteLine("The tricycle is now running.");
    }

    // Implementation of Stop method
    public override void Stop()
    {
        Console.WriteLine("The tricycle has stopped.");
    }
}

// Class motorcycle inherits from Vehicle
class Motorcycle : Vehicle
{
    // Constructor
    public Motorcycle(string model, string make, int year) : base(model, make, year) { }

    // Implementation of Drive method
    public override void Drive()
    {
        Console.WriteLine("The PCX is now running and flying.");
    }

    // Implementation of Stop method
    public override void Stop()
    {
        Console.WriteLine("The PCX has stopped and get a ticket from an enforcer.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using polymorphism to create a Tricycle object
        Vehicle myTricycle = new Tricycle("XYZ", "ABC", 2020);

        // Using abstraction to access attributes
        Console.WriteLine($"Tricycle - Model: {myTricycle.GetModel()}, Make: {myTricycle.GetMake()}, Year: {myTricycle.GetYear()}");

        // Invoking Drive and Stop methods for Tricycle
        myTricycle.Drive();
        myTricycle.Stop();

        // Using polymorphism to create a Motorcycle object
        Vehicle myMotorcycle = new Motorcycle("HONDA", "PCX 10,000cc", 2019);

        // Using abstraction to access attributes
        Console.WriteLine($"Motorcycle - Model: {myMotorcycle.GetModel()}, Make: {myMotorcycle.GetMake()}, Year: {myMotorcycle.GetYear()}");

        // Invoking Drive and Stop methods for Motorcycle
        myMotorcycle.Drive();
        myMotorcycle.Stop();
       

    }

}

