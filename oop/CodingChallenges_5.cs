using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Create an ArrayList for cars
        ArrayList cars = new ArrayList();

        // Add cars to the list
        cars.Add("Nissan");
        cars.Add("Vios");
        cars.Add("Porsche");
        cars.Add("BMW");
        cars.Add("Volkswagen");

        // Display the unsorted list
        Console.WriteLine("Unsorted list of cars:");
        DisplayList(cars);

        // Sort the list
        cars.Sort();

        // Display the sorted list
        Console.WriteLine("\nSorted list of cars:");
        DisplayList(cars);
    }

    // Method to display the contents of the list
    static void DisplayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
