class Car
{
    //Attributes
    public string Model;
    public string Make;
    public int Year;

    //Private attribute platenumber
    private string plate_num;

    //Encapsulation  getters-setters
    public string Plate_num
    {
        get { return plate_num; }
        set { plate_num = value; }
    }

    //Constructor
    public Car(string model, string make, int year, string aPlate_num)
    {
        Model = model;
        Make = make;
        Year = year;
        plate_num = aPlate_num;
    }

    //Methods
    public void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }

    public virtual void Show_info()
    {
        Console.WriteLine($"Model: {Model}, Make: {Make}, Year: {Year}, Platenumber: {Plate_num}");
    }
}

class Sports_car : Car
{
    //Unique Attribute
    public bool have_nitros;

    //Constructor
    public Sports_car(string model, string make, int year, string aPlate_num, bool aHave_nitros) : base(model, make, year, aPlate_num)
    {
        have_nitros = aHave_nitros;
    }

    //Methods
    public void Race()
    {
        Console.WriteLine("The car is now racing!! VROOOOOOM!");
    }

    public override void Show_info()
    {
        base.Show_info();
        Console.WriteLine($"Nitros Equiped?: {have_nitros}");
    }
}

abstract class Electric_car : Car
{
    //Unique Attribute
    public int Battery_percentage;

    //Constructor
    public Electric_car(string model, string make, int year, string aPlate_num, int battery_percentage) : base(model, make, year, aPlate_num)
    {
        Battery_percentage = battery_percentage;
    }

    //Abstract Method
    public abstract void Charge_battery();
}

class Tesla : Electric_car
{
    public Tesla(string model, string make, int year, string aPlate_num, int battery_percentage) : base(model, make, year, aPlate_num, battery_percentage)
    {

    }

    public override void Charge_battery()
    {
        Console.WriteLine("The car is now charging its battery.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Corolla", 2023, "PLZ-3569");
        myCar.Show_info();
        myCar.Drive();
        myCar.Stop();

        //Encapsulation test
        Console.WriteLine("\nEncapsulation:");
        myCar.Show_info();
        myCar.Plate_num = "TBW-5567"; //Set
        Console.WriteLine($"New Platenumber: {myCar.Plate_num}");//Get

        //Inheritance Test
        Console.WriteLine("\nInheritance:");
        Sports_car yourCar = new Sports_car("Audi", "Lamborghini", 2024, "BLT-F4ST", true);
        yourCar.Show_info(); // ---+
        yourCar.Drive();     //    |---> Inherited from class Car
        yourCar.Stop();      // ---+
        yourCar.Race();      // -------> Unique method

        //Polymorphism Test
        Console.WriteLine("\nPolymorphism:");
        Car hisCar = new Sports_car("Ford", "Mustang", 2015, "GRI-3767", false);
        Car herCar = new Sports_car("Toyota", "Supra", 2019, "QBF-6399", true);
        hisCar.Show_info();
        herCar.Show_info();

        //Abstraction Test
        Console.WriteLine("\nPolymorphism:");
        //Electric_car carA = new Electric_car();  - error
        Tesla carB = new Tesla("Tesla", "Tesla", 2020, "HDY-3486", 80);
    }
}

// GARCES, JOHN MARK A.
// BSIT 2-1