using System.Reflection.Metadata.Ecma335;

class Car {
    //test
    //git
    //Attributes
    public string Model;
    public string Make;
    public int Year;

    //Encapsulated attributes
    private string Model;
    private string Make;
    private int Year; 

    //Constructor
    public Car(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }

    // Public properties for encapsulation
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

    // Abstract methods for abstraction
    public virtual void Drive();
    public virtual void Stop();

    //Polymorphism
    public virtual void Drive()
    {
        Console.WriteLine("The car is now running.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The car has stopped running.");
    }

} 

// INHERITANCE (SportsCar from Car)
class SportsCar : Car {

    public string Brand { get; set; }

    public SportsCar(string model, string make, int year, string brand) : base(model, make, year)
        public string Brand = "Chevrolet"

    public SportsCar(string model, string make, int year, string brand) : base(model, make, year)
    { 
        Brand = brand; 
    }

    //Polymorphism
    public override void Drive() {

        base.Drive();
        Console.WriteLine("The sports car is now running at high speed.");
    }
    
    public override void Stop() {

        base.Stop();
        Console.WriteLine("The sports car has stopped abruptly.");
    }

}

}

class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();

        SportsCar luxCar = new SportsCar("Corvette Stingray", "Chevrolet", 2024);
        Console.WriteLine($"\nSports Car \nModel: {eCar.Model}, Brand: {eCar.Brand}, Year: {eCar.Year}");

    }
}


//ASSIGNMENT#01 executed by ABABA, JULIA E. --> BSIT 2-1, 03-20-2024
