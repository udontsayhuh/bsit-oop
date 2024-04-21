using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of cars
        List<string> carList = new List<string>
        {
            "Ford", "Toyota", "Volkswagen", "Honda", "BMW"
        };

        // Display the original list
        Console.WriteLine("Original list of cars:");
        foreach (string car in carList)
        {
            Console.WriteLine(car);
        }

        // Sort the list
        carList.Sort();

        // Display the sorted list
        Console.WriteLine("\nSorted list of cars:");
        foreach (string car in carList)
        {
            Console.WriteLine(car);
        }
    }
}
