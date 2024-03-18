using System;

//Implementing Abstraction
abstract class Car
{
    //Implementing Encapsulation that changed it from public into private set
    private string model;
    private string make;
    private int year;

    public Car(string model, string make, int year)
    {
        this.model = model;
        this.make = make;
        this.year = year;
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

    //Adding abstract method to display the details of a car
    public abstract void DisplayDetails();

    public void Drive()
    {
        Console.WriteLine("\nThe car is now running.");
    }

    public void Stop()
    {
        Console.WriteLine("The car has stopped.\n");
    }
}
//Implementing Inheritance from Car Class
class RacingCar : Car
{
    private string modelName;
    private int racingCarNumber;

    //Constructor
    public RacingCar(string model, string make, int year, string modelName, int racingCarNumber)
        : base(model, make, year)
    {
        this.modelName = modelName;
        this.racingCarNumber = racingCarNumber;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, \nMake: {Make}, \nYear: {Year}, \nModel Name: {modelName}, \nRacing Car Number: {racingCarNumber}");
    }

    class Program
    {
        static void Main(string[] args)
        {   //Implementing Polymorphism
            RacingCar newCar = new RacingCar("Toyota", "Corolla", 2023, "Toyota Supra GT4", 22);
            newCar.DisplayDetails();

            newCar.Drive();
            newCar.Stop();
        }

    }
}
