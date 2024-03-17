//Abstraction: creating an abstract class for the car
class Car
{
    //test
    //git
    //Attributes
    //Encapsulation: Making attributes private 
    private string Model;
    private string Make;
    private int Year; 

    //Encapsulation: Using properties to access private attributes
    public string model
    {
        get {return Model;}
        set {Model = value;}
    }

    public string make
    {
        get {return Make;}
        set {Make = value;}
    }

    public int year
    {
        get {return Year;}
        set {Year = value;}
    }

    //Constructor
    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    //Abstraction: Abstract method for driving 
    //Methods
    public virtual void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}

    //Inheritance: creating a car subclass
    class SportsCar : Car
{
    public SportsCar(string model, string make, int year) : base (model,make,year)
    { 
    }

    //Polymorphism: override drive method for car
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
        Console.WriteLine($"Model: {myCar.model}, Make: {myCar.make}, Year: {myCar.year}");
        myCar.Drive();
        myCar.Stop();


        SportsCar mySportsCar = new SportsCar("Nissan", "GT-R Skyline", 1957);
        Console.WriteLine($"Model: {mySportsCar.model}, Make: {mySportsCar.make}, Year: {mySportsCar.year}");
        mySportsCar.Drive();
        mySportsCar.Stop();
    }
}
