
using System;
class Car
{

    private string Model;
    private string Make;
    private int Year;

    // accessing the private attribute/field
    public string PModel
    {
        get { return Model; }
        set { Model = value; }
    }
    public string PMake
    {
        get { return Make; }
        set { Make = value; }
    }
    public int PYear
    {
        get { return Year; }
        set { Year = value; }
    }

    // constructor
    public Car(string model, string make, int year)
    {
        Model = model;
        PMake = make;
        PYear = year;
    }

    // methods
    public virtual void Drive()
    {
        Console.WriteLine("The car is now running...");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }

    public void Line()
    {
        Console.WriteLine("====================================================");
    }


} // class Car

class electricCar : Car
{
    public electricCar(string model, string make, int year) : base(model, make, year) { }

    public override void Drive()
    {
        Console.WriteLine("The electric car is now running.");
    }

    public override void Stop()
    {
        Console.WriteLine("The electric car will stop smoothly.");
    }
}

class engineCar : Car
{
    public engineCar(string model, string make, int year) : base(model, make, year) { }

    public override void Drive()
    {
        Console.WriteLine("The engine car is now running.");
    }

    public override void Stop()
    {
        Console.WriteLine("The engine car will now stop.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Car objectCar1 = new Car("Corolla", "Toyota", 2023); // creating an object     
        Console.WriteLine($"Model: {objectCar1.PModel}, Make: {objectCar1.PMake}, Year: {objectCar1.PYear}");
        objectCar1.Drive(); // calling the Drive() method to perform
        objectCar1.Stop();
        objectCar1.Line();

        electricCar objectCar2 = new electricCar("Tesla Model S", "Tesla", 2024); // creating an object     
        Console.WriteLine($"Model: {objectCar2.PModel}, Make: {objectCar2.PMake}, Year: {objectCar2.PYear}");
        objectCar2.Drive(); // calling the Drive() method to perform
        objectCar2.Stop();
        objectCar2.Line();

        engineCar objectCar3 = new engineCar("Mustang", "Ford", 2023); // creating an object     
        Console.WriteLine($"Model: {objectCar3.PModel}, Make: {objectCar3.PMake}, Year: {objectCar3.PYear}");
        objectCar3.Drive(); // calling the Drive() method to perform
        objectCar3.Stop();
        objectCar3.Line();



    }
}