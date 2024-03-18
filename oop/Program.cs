using System;

public class Car
{
    //Attributes
    //Encapsulation
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

    //Methods
    //Abstraction
    public virtual void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}

//Inheritance
public class Jeep : Car
{
    public Jeep(string model, string make, int year) : base(model, make, year) { }

    // Polymorphism
    public override void Drive()
    {
        Console.WriteLine("The Jeep is now running.");
    }
    public override void Stop()
    {
        Console.WriteLine("The Jeep has stopped.");
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

        Jeep myJeep = new Jeep("Jeep", "Wrangler", 2024);
        Console.WriteLine($"\nModel: {myJeep.Model}, Make: {myJeep.Make}, Year: {myJeep.Year}");
        myJeep.Drive();
        myJeep.Stop();
    }
}
