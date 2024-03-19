using System;

abstract class Vehicle
{
    public abstract void Drive();
    public abstract void Stop();
    public abstract string Model { get; set; } //getting and setting the info based on the main (program)
    public abstract string Make { get; set; }
    public abstract int Year { get; set; }
}

//inheritance
class Car : Vehicle
{
    public override string Model { get; set; }
    public override string Make { get; set; }
    public override int Year { get; set; }

    //Constructor
    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    //Methods
    public override void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public override void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //accessing the car and putting details about car
        Vehicle carnum1 = new Car("Toyota", "Corolla", 2023);
        Vehicle carnum2 = new Car("Audi", "R8", 2006);

        carnum1.Drive();
        carnum1.Stop();
        Console.WriteLine($"Model: {carnum1.Model}, Make: {carnum1.Make}, Year: {carnum1.Year}");

        carnum2.Drive();
        carnum2.Stop();
        Console.WriteLine($"Model: {carnum2.Model}, Make: {carnum2.Make}, Year: {carnum2.Year}");
    }
}
