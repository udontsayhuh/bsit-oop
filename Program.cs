using System;

abstract class Car
{
    protected string Model { get; }
    protected string Make { get; }
    protected int Year { get; }

    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    public abstract void DisplayDetails();

    public void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}

class SUVCar : Car
{
    private int Price { get; }

    public SUVCar(string model, string make, int year, int price) : base(model, make, year)
    {
        Price = price;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, Make: {Make}, Year: {Year}, Price: {Price}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SUVCar newCar = new SUVCar("Mitsubishi", "Xpander", 2024, 1068000);
        newCar.DisplayDetails();

        newCar.Drive();
        newCar.Stop();
    }
}
