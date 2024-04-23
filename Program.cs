using System;
using System.Security.Cryptography.X509Certificates;

//Implementing Abstraction
abstract class Car
{
    private string Model;
    private string Make;
    private int Year;
    //Implementing Encapsulation that changed it from public into private set
    private string model;
    private string make;
    private int year;

    public Car(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
        this.model = model;
        this.make = make;
        this.year = year;
    }

    public string GetModel()
    public string Model
    {
        return Model;
        get { return model; }
        set { model = value; }
    }
    public string GetMake()

    public string Make
    {
        return Make;
        get { return make; }
        set { make = value; }
    }

    public int GetYear()
    public int Year
    {
        return Year;
        get { return year; }
        set { year = value; }
    }

    //display car details using abstraction
    //Adding abstract method to display the details of a car
    public abstract void DisplayDetails();

    public void Drive()
    {
        Console.WriteLine("The car is now running.");
        Console.WriteLine("\nThe car is now running.");
    }

    public void Stop()
    {
        Console.WriteLine("The car has stopped.");
        Console.WriteLine("The car has stopped.\n");
    }
}

class SUVCar : Car
//Implementing Inheritance from Car Class
class RacingCar : Car
{
    private int Price;
    private string modelName;
    private int racingCarNumber;

    public SUVCar(string model, string make, int year, int price) : base(model, make, year)
    //Constructor
    public RacingCar(string model, string make, int year, string modelName, int racingCarNumber)
        : base(model, make, year)
    {
        Price = price;
        this.modelName = modelName;
        this.racingCarNumber = racingCarNumber;
    }

    public override void DisplayDetails() 
    { 
        Console.WriteLine($"Model: {GetModel()}, Make: {GetMake()}, Year: {GetYear()}, Price: {Price}");
    public override void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, \nMake: {Make}, \nYear: {Year}, \nModel Name: {modelName}, \nRacing Car Number: {racingCarNumber}");
    }
}

class Program
{
    static void Main(string[] args)
    class Program
    {
        SUVCar newCar = new SUVCar("Mitsubishi", "Xpander", 2024, 1068000);
        newCar.DisplayDetails();
        static void Main(string[] args)
        {   //Implementing Polymorphism
            RacingCar newCar = new RacingCar("Toyota", "Corolla", 2023, "Toyota Supra GT4", 22);
            newCar.DisplayDetails();

            newCar.Drive();
            newCar.Stop();
        }

        newCar.Drive();
        newCar.Stop();
    }
}
