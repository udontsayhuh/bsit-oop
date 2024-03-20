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

    public abstract void ShowDetails();

    public void Start()
    {
        Console.WriteLine($"Starting {Brand} {Model}...");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopping {Brand} {Model}...");
    }

    public void Move()
    {
        Console.WriteLine($"{Brand} {Model} is now moving.");
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
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Price: ${Price}");
    }
}

class Sedan : Vehicle
{
    private string Type;

    public Sedan(string brand, string model, int year, string type) : base(brand, model, year)
    {
        Type = type;
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Type: {Type}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SportsCar myCar = new SportsCar("Ferrari", "F8 Tributo", 2024, 278000);
        myCar.ShowDetails();

        myCar.Start();
        myCar.Stop();
        myCar.Move();

        Sedan mySedan = new Sedan("Toyota", "Camry", 2023, "Mid-size");
        mySedan.ShowDetails();

        mySedan.Start();
        mySedan.Stop();
        mySedan.Move();
    }
}