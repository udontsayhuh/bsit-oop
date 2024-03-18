using System;

abstract class Car
{
    private string model;
    private string make;
    private int year;

    public Car(string model, string make, int year)
    {

        Model = model;
        Make = make;
        Year = year;
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

    public void Drive()
    {
        Console.WriteLine("The sports car is now running.");
    }

    public void Stop()
    {
        Console.WriteLine("The sports car has stopped.");
    }
}

class SportsCar : Car
{
    public SportsCar(string model, string make, int year) : base(model, make, year)
    {
    }
} 

class Program
{
    static void Main(string[] args)
    {

        SportsCar mySportsCar = new SportsCar("Porsche", "911 GT3 RS", 2003);
        Console.WriteLine($"Model: {mySportsCar.Model}, Make: {mySportsCar.Make}, Year: {mySportsCar.Year}");
        mySportsCar.Drive();
        mySportsCar.Stop();
    }
}
