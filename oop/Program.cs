using System;

class Car
{
    //Private attributes for encapsulation
    private string model;
    private string make;
    private int year;

    //Constructor
    public Car(string model, string make, int year)
    {
        this.model = model;
        this.make = make;
        this.year = year;
    }

    //Virtual methods for potential overriding
    public virtual void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }

    //Abstraction (To grant permission for accessing the Private attributes)
    public string GetModel()
    {
        return model;
    }

    public string GetMake()
    {
        return make;
    }

    public int GetYear()
    {
        return year;
    }
}

//Inheritance (Limousine inherits from Car)
class Limousine : Car
{
    public Limousine(string model, string make, int year) : base(model, make, year) { }

    //Polymorphism (Overrides Drive method)
    public override void Drive()
    {
        Console.WriteLine("The Limousine is now running.");
    }

    //Polymorphism (Overrides Stop method)
    public override void Stop()
    {
        Console.WriteLine("The Limousine has stopped.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.GetModel()}, Make: {myCar.GetMake()}, Year: {myCar.GetYear()}");
        myCar.Drive();
        myCar.Stop();

        Limousine myLimousine = new Limousine("Mercedes-Benz", "Limo", 2024);
        Console.WriteLine($"Model: {myLimousine.GetModel()}, Make: {myLimousine.GetMake()}, Year: {myLimousine.GetYear()}");
        myLimousine.Drive();
        myLimousine.Stop();
    }
}
