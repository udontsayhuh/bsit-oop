//Encapsulation used in base class Vehicle
//Abstraction to define common attributes and methods
abstract class Vehicle 
{
    //Attributes
    public string Model { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }

    //Constructor
    public Vehicle(string model, string make, int year) 
    {
        Model = model;
        Make = make;
        Year = year;
    }

    //Methods
    public abstract void Drive();
    public abstract void Stop();
}

//Inheritance from class Vehicle and Polymorphism using override modifier
class Car: Vehicle
{
    //Constructor
    public Car(string model, string make, int year) : base(model, make, year)
    {
    }

    public override void Drive()
    {
        Console.WriteLine($"The {Model} {Make} is now running.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {Model} {Make} has stopped.\n");
    }
}

//Inheritance from class Vehicle and Polymorphism using override modifier
class Van: Vehicle
{
    //Constructor
    public Van(string model, string make, int year) : base(model, make, year)
    {
    }

    public override void Drive()
    {
        Console.WriteLine($"The {Model} {Make} is now running.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {Model} {Make} has stopped.\n");
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        Vehicle myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();

        Vehicle myVan = new Van("Kia", "Carnival", 2024);
        Console.WriteLine($"Model: {myVan.Model}, Make: {myVan.Make}, Year: {myVan.Year}");
        myVan.Drive();
        myVan.Stop();
    }
}
