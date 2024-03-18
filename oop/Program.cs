using System;
using System.Reflection;

// abstract class therefore cannot be created as an object
abstract class Vehicle //Parent Class
{
    //Attributes
    public int Wheels;

    public virtual void Drive()
    {

    }
}

class Motorbike : Vehicle //Child Class
{
    public Motorbike() // Constructor to set the wheels for Motorbike
    {
        Wheels = 2; //Inheritance
    }
    public override void Drive() // polymorphism
    {
        System.Console.WriteLine("The Motorbike is moving.");
    }

}

class Car : Vehicle //Child Class
{
    public Car()
    {
        Wheels = 4; //Inheritance
    }
    public override void Drive() // polymorphism
    {
        System.Console.WriteLine("The Car is moving.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Motorbike and Car
        Motorbike motorbike = new Motorbike();
        Car car = new Car();

        // array vehicle to iterate over
        Vehicle[] vehicles = { car, motorbike };

        // array iteration
        foreach (Vehicle vehicle in vehicles)
        {
            // print the wheels
            if (vehicle is Car)
            {

                Console.WriteLine(((Car)vehicle).Wheels);
            }
            else if (vehicle is Motorbike)
            {

                Console.WriteLine(((Motorbike)vehicle).Wheels);
            }

            // printing 
            vehicle.Drive();
        }
    }

}

// Encapsulation: the keyword public demonstrates encapsulation
// Abstraction: used in vehicle class 
// Inheritance: "wheels" field was inherited by the child classes
// Polymorphism: the method drive was used to demonstrate this principle

/*  Expected Output:
    4
    The Car is moving.
    2
    The Motorbike is moving. */
