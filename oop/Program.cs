
class Car
{
    //Attributes
    public string Model;
    public string Make;
    public int Year;

    //Private Attribute
    private string Plate_num;

    //Constructor
    public Car(string model, string make, int year, string plate_num)
    {
        Model = model;
        Make = make;
        Year = year;
        Plate_num = plate_num;
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

    public void Accelerate()
    {
        Console.WriteLine("Speed can go up to 225 km/h");
    }

    // encapsulation key
    public string Get_plate_num()
    {
        return Plate_num;
    }
}

abstract class four_wheeled_vehicle
{   
    //abstract method
    public abstract void move();
}

// Inheritance
class convertible_car : Car
{
    public convertible_car(string model, string make, int year, string plate_num) : base(model, make, year, plate_num) { }

    // exclusive method to convertible car
    public void Retract_roof()
    {
        Console.WriteLine("roof is now retracted");
    }

}
class race_car : Car
{
    public race_car(string model, string make, int year, string plate_num) : base(model, make, year, plate_num) { }

    // Polymorphed method of race_car
    public void Accelerate()
    {
        Console.WriteLine("Speed can go up to 360 km/h");
    }
}
class Program
{
    static void Main(string[] args)
    {   
        // Base
        Car myCar = new Car("Toyota", "Corolla", 2023, "M4RC-O627");
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        Console.WriteLine($"Plate number: {myCar.Get_plate_num()}"); //encapsulation
        myCar.Drive();
        myCar.Stop();
        myCar.Accelerate();

        // Inherited
        convertible_car myConvertible = new convertible_car("nissan", "Murano", 2022, "R341-AA89");
        Console.WriteLine($"Model: {myConvertible.Model}, Make: {myConvertible.Make}, Year: {myConvertible.Year}");
        Console.WriteLine($"Plate number: {myConvertible.Get_plate_num()}"); //encapsulation
        myConvertible.Drive();
        myConvertible.Stop();
        myConvertible.Accelerate();
        myConvertible.Retract_roof();


        // Polymorphed
        race_car myRace = new race_car("McLaren", "570S", 2015, "C0R3-0912");
        Console.WriteLine($"Model: {myRace.Model}, Make: {myRace.Make}, Year: {myRace.Year}");
        Console.WriteLine($"Plate number: {myRace.Get_plate_num()}"); //encapsulation
        myRace.Drive();
        myRace.Stop();
        myRace.Accelerate(); //polymorphed trait
    }
}