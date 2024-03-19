using System;

public abstract class Car // Parent class
{
    // Encapsulation
    private string model;
    private string make;
    private int year;

    public string Model { get; set; }
    public string Make { get; set; }
    public int Year { get; protected set; }

    // Constructor
    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    // Abstract methods
    public abstract void Drive();
    public abstract void Stop();
}

public class PickupTruck : Car //child class
{
    public PickupTruck(string model, string make, int year) : base(model, make, year)
    {
    }

    public override void Drive()
    {
        Console.WriteLine("The pickup truck is now running.");
    }

    public override void Stop()
    {
        Console.WriteLine("The pickup truck has stopped.");
    }
}

public class Sedan : Car  //child class
{
    public Sedan(string model, string make, int year) : base(model, make, year)
    {
    }

    public override void Drive()
    {
        Console.WriteLine("The sedan is now running.");
    }

    public override void Stop()
    {
        Console.WriteLine("The sedan has stopped.");
    }
}

class Program
{
    static void Main(string[] args)
    {   //object
        Sedan mySedan = new Sedan("Toyota", "Corolla", 2023);
        //display sedan
        Console.WriteLine("Sedan:");
        Console.WriteLine($"Model: {mySedan.Model}, Make: {mySedan.Make}, Year: {mySedan.Year}");
        mySedan.Drive();
        mySedan.Stop(); // call for method for sedan
        //object
        PickupTruck myPickuptruck = new PickupTruck("Dongfeng", "T38H", 2021);
        //display pickup truck
        Console.WriteLine("\nTricycle:");
        Console.WriteLine($"Model: {myPickuptruck.Model}, Make: {myPickuptruck.Make}, Year: {myPickuptruck.Year}");
        myPickuptruck.Drive(); //call for method for truck
        myPickuptruck.Stop();


    }
}