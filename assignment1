using System;
using System.Security.Cryptography.X509Certificates;
using static Car;

class Car
{
    //test
    //git
    //Attributes
    public string Model;
    public string Make;
    public int Year;
    private int price; // data declared for encapsulation

    //Constructor
    public Car(string model, string make, int year, int price)
    {
        Model = model;
        Make = make;
        Year = year;
        this.price = price;
    }

   // added code for encapsulation
    public int Price
    {
    
        get { return price; }
        set { price = value; }
        
    }

    // added code for inheritance
    public class ElectricCar : Car
    {
        public double Time;
   
        // constructor
        public ElectricCar(string model, string make, int year, int price, double Time) : base(model, make, year, price)
        {
       
            this.Time = Time;
        }
    }

    // added code for abstraction
    public class Sound
    {
        public virtual void VehicleSound()
        {
            Console.WriteLine("This vehicle can make sound.");
        }

    }

    public class AllVehicle: Sound
    {
        public override void VehicleSound()
        {
            Console.WriteLine("Vroom Vroom!");
        }
    }
     // added code for polymorphism
    public class StopingSound : Sound
    {
        public override void VehicleSound()
        {
            Console.WriteLine("SCREEEEEECH SCREEEEEECH!");
        }
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
}

// main program
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Corolla", 2023 , 1000); 
        Car NadsCar = new Car("Ford", "Civic", 2000, 1000);
        ElectricCar newElectric = new ElectricCar("Hyundai", "Kona", 2017, 2500, 3.5);
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}"); // print from the original code
        Console.WriteLine($"Model: {NadsCar.Model}, Make: {NadsCar.Make}, Year: {NadsCar.Year}, Price: {NadsCar.Price}"); // print with encapsulation
        Console.WriteLine($"Model: {newElectric.Model}, Make: {newElectric.Make}, Year: {newElectric.Year}, Price: {newElectric.Price}, Charging Time: {newElectric.Time}"); // print with inheritance
        AllVehicle vehicleSounds = new AllVehicle(); // vrum vrum
        Sound vehicleStop = new StopingSound();
        Sound sound = new Sound();  

        sound.VehicleSound();
        myCar.Drive();
        vehicleSounds.VehicleSound();
        sound.VehicleSound();
        myCar.Stop();
        vehicleStop.VehicleSound();
        

    }
}

