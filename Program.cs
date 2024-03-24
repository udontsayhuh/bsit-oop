using System;

//*** Abstraction :3
abstract class Car {
    //git
    //*** Encapsulation :3
    //Private Attributes
    private string Model;
    private string Make;
    private int Year;

    //Properties
    //The Capsule
    public string model
    {
        get { return Model; }
        set { Model = value; }
    }

    public string make
    {
        get { return Make; }
        set { Make = value; }
    }

    public int year
    {
        get { return Year; }
        set { Year = value; }
    }
    //Encapsulation :3 ***

    //Constructor
    public Car(string model, string make, int year) 
    {

        Model = model;
        Make = make;
        Year = year;
    }

    //Methods
    public void Drive() {
        Console.WriteLine("is now running.");
    }

    public void Stop() {
        Console.WriteLine("has stopped.");
    }

    //*** Polymorphism :3
    virtual public void Horn() {
        Console.WriteLine("The car makes horn sound.");
    }

    //Abstract Method
    public abstract void Engine();

}


    //*** Inheritance :3
class Truck : Car 
{
    //Inherited Constructor
    public Truck(string model, string make, int year) : base(model,make,year)
    {

    }

    //Inherited Method
    public void Drive() {
        Console.Write("The Truck ");
        base.Drive();
    }

    public void Stop() {
        Console.Write("The Truck ");
        base.Stop();
    }

    //Polymorphed Method
    override public void Horn() {
        Console.WriteLine("The truck makes truck-horn sound.");
    }

    //Inherited Abstract Method
    public override void Engine()
    {
        Console.WriteLine("Truck-engine starts");
    }


}

class Van : Car
{
    //Inherited Constructor
    public Van(string model, string make, int year) : base(model,make,year)
    {

    }

    //Inherited Method
    public void Drive() {
        Console.Write("The Van ");
        base.Drive();
    }

    public void Stop() {
        Console.Write("The Van ");
        base.Stop();
    }

    //Polymorphed Method
    override public void Horn() {
        Console.WriteLine("The van makes van-horn sound.");
    }

    //Inherited Abstract Method
    public override void Engine()
    {
        Console.WriteLine("Van-engine starts");
    }

}


    //Inheritance :3 ***
    //Polymorphism :3 ***
    //Abstraction :3 ***


class Program {
    static void Main(string[] args) {
        //Abstract Superclass Removed

        //Subclass 1
        Truck myTruck = new Truck("Ford", "F-150", 2024);
        Car T = new Truck("Toyota", "Corolla", 2023);
        Car Te = new Truck("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myTruck.model}, Make: {myTruck.make}, Year: {myTruck.year}");
        T.Horn();
        Te.Engine();
        myTruck.Drive();
        myTruck.Stop();

        //Subclass 2
        Van myVan = new Van("Volkswagen", "trasporter", 2021);
        Car V = new Van("Toyota", "Corolla", 2023);
        Car Ve = new Van("Toyota", "Corolla", 2023);
        Console.WriteLine($"Model: {myVan.model}, Make: {myVan.make}, Year: {myVan.year}");
        V.Horn();
        Ve.Engine();
        myVan.Drive();
        myVan.Stop();

    }
}

//*Objectives check*
//Encapsulation : DONE
//Inheritance : DONE
//Polymorphism : DONE
//Abstraction : DONE
