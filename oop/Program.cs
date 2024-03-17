abstract class Vehicle
{
    // Attributes
    public string Model;
    public string Make;
    public int Year;

    // Abstract method for driving
    public abstract void Drive();

    // Method for stopping
    public void Stop()
    {
        Console.WriteLine("The vehicle has stopped.");
    }
}

    //Inheritance: Car class inherits from Vehicle class
class Car : Vehicle
{
    // Private attribute for plate number (Encapsulation)
    private string plateNum;

    // Constructor
    public Car(string model, string make, int year, string plateNum)
    {
        Model = model;
        Make = make;
        Year = year;
       this.plateNum = plateNum; // Set plate number
    }

    // Encapsulation for plateNum
    public string PlateNum
    {
        get { return plateNum; }
        set { plateNum = value; }
    }

    // Polymorphism: overriding the Drive() method
    public override void Drive()
    {
        Console.WriteLine("The car is now running.");
    }
}

    // Inheritance: ElectricCar class inherits from Vehicle class
class ElectricCar : Vehicle
{
    // Public attribute for battery level
    public int BatteryLevel;

    // Constructor
    public ElectricCar(string model, string make, int year, int initialBatteryLevel)
    {
        Model = model;
        Make = make;
        Year = year;
        BatteryLevel = initialBatteryLevel; // Set initial battery level
    }

    // Polymorphism: overriding the Drive() method
    public override void Drive()
    {
        {
            Console.WriteLine("The Electric Car is now running.");
        }
       
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Sienna", 2013, "HEHE143");
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}, Plate Number: {myCar.PlateNum}");
        myCar.Drive();
        myCar.Stop();

        ElectricCar myElectricCar = new ElectricCar("Tesla", "Model A12", 2023, 80);
        Console.WriteLine($"Model: {myElectricCar.Model}, Make: {myElectricCar.Make}, Year: {myElectricCar.Year}");
        myElectricCar.Drive();
        myElectricCar.Stop();
    }
}
