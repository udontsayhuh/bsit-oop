using System;
using System.Security.Cryptography.X509Certificates;

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

    //display car details using abstraction
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
    private int Price;

    public SUVCar(string model, string make, int year, int price) : base(model, make, year)
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
        SUVCar newCar = new SUVCar("Mitsubishi", "Xpander", 2024, 1068000);
        newCar.DisplayDetails();

        newCar.Drive();
        newCar.Stop();
    }
}
