abstract class Car //abstract class
{
    //test
    //git
    //Attributes
    public string Model;
    public string Make;
    public int Year;
    private string plateNum; // data that will be hidden for implementing encapsulation

    //Constructor
    public Car(string model, string make, int year, string platenum)
    {
        Model = model;
        Make = make;
        Year = year;
        plateNum = platenum;
    }

    // abstract methods
    public abstract void Drive();
    public abstract void Stop(); 

}

class Sedan : Car { // class "Sedan" inheriting from parent class "Car"
    public Sedan(string model, string make, int year, string platenum): base(model, make, year, platenum) { }

    //Polymorphism -> method in this class overrides the method defined in parent class 
    public override void Drive() {
        Console.WriteLine("The car is now running.");
     }

    public override void Stop() {
        Console.WriteLine("The car has stopped.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Sedan("Toyota", "Corolla", 2023, "ABC 123");

        //displaying plateNum will produce an error as it is inaccessible due to protection level
        Console.WriteLine($"Model: {myCar.Model}, Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Drive();
        myCar.Stop();
    }
}
