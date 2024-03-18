using System.Runtime.CompilerServices;

class Car
{
    //test
    //git
    //Attributes
    //Encapsulation
    private string Model = "";
    private string Make = "";
    public int Year;

    // Properties with proper encapsulation and naming convention
    public string ModelName
    {
        get { return Model; }
        set { Model = value; }
    }

    public string MakeName
    {
        get { return Make; }
        set { Make = value; }
    }

    // Constructor
    public Car(string model, string make, int year)
    {
        ModelName = model;
        MakeName = make;
        Year = year;
    }


    //Abstraction
    public virtual void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}
    //Inheritance
    class ElectricCar : Car
    {
        public string Brand { get; set; }

        public ElectricCar(string model, string make, int year, string brand)
            : base(model, make, year)
        {
            Brand = brand;
        }

        //Polymorphism
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("The electric car runs like any car.");
        }

        public override void Stop()
        { 
            base.Stop();
            Console.WriteLine("The electric car will stop when the battery runs out.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Corolla", 2023);
            Console.WriteLine($"Model: {myCar.ModelName}, Make: {myCar.MakeName}, Year: {myCar.Year}");
            myCar.Drive();
            myCar.Stop();
        }
    }

