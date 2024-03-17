// Abstraction: creating an abstract class for the car
class Car
{
    // Attributes
    // Encapsulation: Making attributes private 
    private string model;
    private string make;
    private int year;

    // Encapsulation: Using properties to access private attributes
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

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Constructor
    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    // Abstraction: Abstract method for driving 
    // Methods
    public virtual void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}

// Inheritance: creating a car subclass
class SportsCar : Car
{
    public SportsCar(string model, string make, int year) : base(model, make, year)
    {
    }

    // Polymorphism: override drive method for car
    public override void Drive()
    {
        Console.WriteLine("The Sports Car is now accelerating.");
    }

    public override void Stop()
    {
        Console.WriteLine("The Sports Car is now drifting.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();


        SportsCar mySportsCar = new SportsCar("Nissan", "GT-R Skyline", 1957);
        Console.WriteLine($"Model: {mySportsCar.Model}, Make: {mySportsCar.Make}, Year: {mySportsCar.Year}");
        mySportsCar.Drive();
        mySportsCar.Stop();
    }
}
