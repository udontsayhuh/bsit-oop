using System;

abstract class Car
{
    private string Model;
    private string Make;
    private int Year;

    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    public string GetModel()
    {
        return Model;
    }

    public string GetMake()
    {
        return Make;
    }

    public int GetYear()
    {
        return Year;
    }

    // Abstract method for displaying car details
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

class ElectricCar : Car
{
    private int Price;

    public ElectricCar(string model, string make, int year, int price) : base(model, make, year)
    {
        Price = price;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Model: {GetModel()}, Make: {GetMake()}, Year: {GetYear()}, Price: {Price}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ElectricCar newCar = new ElectricCar("Tesla", "Cybertruck", 2024, 100000);
        newCar.DisplayDetails();

        newCar.Drive();
        newCar.Stop();
    }
}


