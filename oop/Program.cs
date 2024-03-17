using System.Xml.Schema;

abstract class Vihicle
{
    //attributes
    public static int speed = 0;
    public static int wheels = 0;


    //methods
    public void Drive()
    {
        Console.WriteLine("The vihicle is now running.");
        speed = 50;
        Console.WriteLine($"Speed: {speed}");
    }

    public void Stop()
    {
        Console.WriteLine("The vihicle has stopped.");
        speed = 0;
        Console.WriteLine($"Speed: {speed}");
    }

    public void Start()
    {
        Console.WriteLine("The engine has started.");
    }
}

class Car: Vihicle {
    //git
    //Attributes
    public string Model;
    public string Make;
    public int Year;
    public int wheels = 4;
    public int speed = 0;
    //Constructor
    public Car(string model, string make, int year) {
        Model = model;
        Make = make;
        Year = year;
    }
}

class Airplane: Vihicle
{
    public int wheels = 3;
    private string Pilot = "Bongbong";
    //methods
    public void Drive()
    {
        Console.WriteLine("The airplane is now flying.");
        speed = 100;
        Console.WriteLine($"Speed: {speed}");
    }

    public void Stop()
    {
        Console.WriteLine("The airplane has landed.");
        speed = 0;
        Console.WriteLine($"Speed: {speed}");
    }
}

class Boat: Vihicle
{
    public int wheels = 0;
    public void Drive()
    {
        Console.WriteLine("The Boat is now sailing.");
        speed = 50;
        Console.WriteLine($"Speed: {speed}");
    }

    public void Stop()
    {
        Console.WriteLine("The boat has docked.");
        speed = 0;
        Console.WriteLine($"Speed: {speed}");
    }

}


class Program {
    static void Main(string[] args) {
        //car
        Car myCar = new Car("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}, Wheels: {myCar.wheels}");
        myCar.Start();
        myCar.Drive();
        myCar.Stop();

        //airplane
        Console.WriteLine("");
        Airplane myAirplane = new Airplane();
        Console.WriteLine($"Airplane Wheels: {myAirplane.wheels}");
        myAirplane.Start();
        myAirplane.Drive();
        myAirplane.Stop();

        //boat
        Console.WriteLine("");
        Boat myBoat = new Boat();
        Console.WriteLine($"Boat Wheels: {myBoat.wheels}");
        myBoat.Start();
        myBoat.Drive();
        myBoat.Stop();
    }
}
