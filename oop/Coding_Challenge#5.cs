using System;
using System.Collections;

public class Car : IComparable
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Year} {Make} {Model}";
    }

    public int CompareTo(object obj)
    {
        Car otherCar = (Car)obj;
        return Make.CompareTo(otherCar.Make);
    }
}

public class CarListDemo
{
    public static void Main(string[] args)
    {
        ArrayList cars = new ArrayList();

        cars.Add(new Car("Ford", "Raptor", 2023));
        cars.Add(new Car("Toyota", "Raize", 2022));
        cars.Add(new Car("Honda", "BR-V", 2022));
        cars.Add(new Car("Cherry", "Tiggo 2 Pro", 2018));
        cars.Add(new Car("Suzuki", "SPRESSO", 2024));

        Console.WriteLine("Original List:");
        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }

        cars.Sort(); // Now uses Car's CompareTo method for sorting

        Console.WriteLine("\nSorted List by Year:");
        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
