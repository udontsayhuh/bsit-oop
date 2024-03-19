using System;

class carBrand
{
    //ImplementingEncapsulation
    private string model;
    private string make;
    private int year;

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

 
    public carBrand(string model, string make, int year)
    {
        Model = model;
        Make = make;
        Year = year;
    }

    //AbstractionPrinciple
    public virtual void StartEngine()
    {
        Console.WriteLine($"Starting the engine of {Make}...");
    }

    public virtual void Drive()
    {
        Console.WriteLine($"The {Make} is now driving.");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"The {Make} has stopped.");
    }

    public virtual void Park()
    {
        Console.WriteLine($"The {Make} is now parked.");
    }
}

//ImplementingInheritancePrinciple
class Car : carBrand
{
 
    public Car(string model, string make, int year) : base(model, make, year)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Geely", "Coolray", 2024);
        Console.WriteLine("\nSee the details of the car below\n");
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"\tModel: {myCar.Model} \n\tMake: {myCar.Make} \n\tYear: {myCar.Year}\n--------------------------------\n");

        myCar.StartEngine();
        myCar.Drive();
        myCar.Stop();
        myCar.Park();

        while (true)
        {
            Console.WriteLine("\nDo you want to add another car detauls? (y/n):");
            string choice = Console.ReadLine().ToLower();
            if (choice == "n")
                break;
            else if (choice == "y")
            {
                Console.WriteLine("\nPlease Enter details for another car.\n");
                Console.Write("Enter model: ");
                string model = Console.ReadLine();
                Console.Write("Enter make: ");
                string make = Console.ReadLine();
                Console.Write("Enter year: \n");
                int year = int.Parse(Console.ReadLine());

                Car userCar = new Car(model, make, year);
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"\tModel: {userCar.Model},\n\tMake: {userCar.Make},\n\tYear: {userCar.Year}\n--------------------------------\n");
                userCar.StartEngine();
                userCar.Drive();
                userCar.Stop();
                userCar.Park();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'y' or 'n'.");
            }
        }
    }
}