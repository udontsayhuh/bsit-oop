using System;

abstract class Car
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

    public virtual void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}

class MuscleCar : Car
{
    public MuscleCar(string model, string make, int year) : base(model, make, year) { }

    public override void Drive()
    {
        Console.WriteLine("The muscle car is now running silently.");
    }

    public override void Stop()
    {
        Console.WriteLine("The muscle car has stopped.");
    }
}

class Program
{
    static void TestDrive(Car car)
    {
        car.Drive();
        car.Stop();
    }

    static void Main(string[] args)
    {
       

        MuscleCar myMuscleCar = new MuscleCar("Dodge", "Challenger", 2024);
        Console.WriteLine($"Model: {myMuscleCar.Model}, Make: {myMuscleCar.Make}, Year: {myMuscleCar.Year}");
        TestDrive(myMuscleCar);
    }
}
