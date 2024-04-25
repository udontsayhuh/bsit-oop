using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create and initialize a list of car
        List<string> cars = new List<string>
        {
            "Rolls-Royce",
            "Bentley",
            "Lamborghini",
            "Ferrari",
            "Bugatti"
        };

        // Original list
        Console.WriteLine("Original list of luxury cars:");
        DisplayList(cars);

        // Sort the list
        cars.Sort();

        // Display the sorted list
        Console.WriteLine("\nSorted list of luxury cars:");
        DisplayList(cars);
    }

    // Method to display a list
    static void DisplayList(List<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
