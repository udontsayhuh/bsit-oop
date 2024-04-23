// CODING CHALLENGE 5
// April 23, 2024


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> cars = new List<string>();

        // Taking user input for car names
        Console.WriteLine("Enter the names of 5 cars:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter car {i + 1}: ");
            string car = Console.ReadLine();
            cars.Add(car);
        }

        // Displaying the unsorted list
        Console.WriteLine("\nUnsorted list of cars:");
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }

        // Sorting the list
        cars.Sort();

        // Displaying the sorted list
        Console.WriteLine("\nSorted list of cars:");
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
