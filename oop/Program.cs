// Abstract base class for Car
abstract class Car {
    // Attributes
    private string model;
    private string make;
    private int year;
    private string money;

    // Encapsulated properties
    public string Model {
        get { return model; }
        set { model = value; }
    }

    public string Make {
        get { return make; }
        set { make = value; }
    }

    public int Year {
        get { return year; }
        set { year = value; }
    }

    public string Money {
        get { return money; }
        set { money = value; }
    }

    // Constructor
    public Car(string model, string make, int year, string money) {
        Model = model;
        Make = make;
        Year = year;
        Money = money;
    }

    // Abstract method Drive
    public abstract void Drive();

    // Abstract method Stop
    public abstract void Stop();
}

// Derived class ElectricCar
class ElectricCar : Car {
    // Constructor
    public ElectricCar(string model, string make, int year, string money) : base(model, make, year, money) {
    }

    // Implementing Drive method
    public override void Drive() {
        Console.WriteLine("The electric car is now up and running.");
    }

    // Implementing Stop method
    public override void Stop() {
        Console.WriteLine("The electric car has stopped.");
    }
}
// Derived class ManualCar
class ManualCar : Car {
    // Constructor
    public ManualCar(string model, string make, int year, string price) : base(model, make, year, price) {
    }

    // Implementing Drive method
    public override void Drive() {
        Console.WriteLine("The manual car is now up and running.");
    }

    // Implementing Stop method
    public override void Stop() {
        Console.WriteLine("The manual car has stopped.");
    }
}

class Program {
    static void Main(string[] args) {
        Car manuCar = new ManualCar("Suzuki", "Dzire", 2008, "$10,635");
        Car electCar = new ElectricCar("Tesla", "Model S", 2023, "$94,990");
        Console.WriteLine($"Model: {manuCar.Model}, Make: {manuCar.Make}, Year: {manuCar.Year}, Money: {manuCar.Money}");
        manuCar.Drive();
        manuCar.Stop();
        Console.WriteLine($"Model: {electCar.Model}, Make: {electCar.Make}, Year: {electCar.Year}, Money: {electCar.Money}");
        electCar.Drive();
        electCar.Stop();
    }
}
