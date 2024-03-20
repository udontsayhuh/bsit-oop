using System;

abstract class Vehicle
{
    private string Brand;
    private string Model;
    private int Year;

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public string GetBrand()
    {
        return Brand;
    }

    public string GetModel()
    {
        return Model;
    }

    public int GetYear()
    {
        return Year;
    }

    public abstract void ShowDetails();

    public void StartEngine()
    {
        Console.WriteLine("The engine is now running.");
    }

    public void StopEngine()
    {
        Console.WriteLine("The engine has stopped.");
    }
}

class SportsCar : Vehicle
{
    private int Price;

    public SportsCar(string brand, string model, int year, int price) : base(brand, model, year)
    {
        Price = price;
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Brand: {GetBrand()}, Model: {GetModel()}, Year: {GetYear()}, Price: ${Price}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SportsCar myCar = new SportsCar("Ferrari", "F8 Tributo", 2024, 278000);
        myCar.ShowDetails();

        myCar.StartEngine();
        myCar.StopEngine();
    }
}