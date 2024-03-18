
using System;

//  encapsulate the attributes and protect properties
class Car
{
    private string model;
    private string make;
    private int year;

    public Car(string model, string make, int year)
    {
        this.model = model;
        this.make = make;
        this.year = year;
    }

    // Protected properties for encapsulation
    public string Model
    {
        get { return model; }
        protected set { model = value; }
    }

    public string Make
    {
        get { return make; }
        protected set { make = value; }
    }

    public int Year
    {
        get { return year; }
        protected set { year = value; }
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


class Sedan : Car // Inheritance: Sedan class inherits from Car class.
{
    public Sedan(string model, string make, int year) : base(model, make, year)
    {
    }

    
    public override void Drive() // Polymorphism: 
    {
        Console.WriteLine("The sedan car is now running.");
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

        Sedan mySedan = new Sedan("Honda", "Accord", 2024);
        Console.WriteLine($"Model: {mySedan.Model}, Make: {mySedan.Make}, Year: {mySedan.Year}");
        mySedan.Drive(); // Polymorphism in action
        mySedan.Stop(); // Inherited behavior
    }
}

