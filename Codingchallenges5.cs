using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store cars
        ArrayList carList = new ArrayList();

        // Add cars to the list
        carList.Add("Aston Martin");
        carList.Add("Ferrari");
        carList.Add("Ducati");
        carList.Add("Rolls Royce");
        carList.Add("Mercedes Benz");

        // Display the unsorted list
        Console.WriteLine("List of cars before sorting:");
        PrintList(carList);

        // Sort the list
        carList.Sort();

        // Display the sorted list
        Console.WriteLine("\nList of cars after sorting:");
        PrintList(carList);
    }

    // Method to print the list
    static void PrintList(ArrayList list)
    {
        foreach (var car in list)
        {
            Console.WriteLine(car);
        }
    }
}
