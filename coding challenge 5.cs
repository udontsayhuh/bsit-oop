using System;
using System.Collections;

class Cars
{
    static void Main(string[] args)
    {
        // Creating an ArrayList to store cars
        ArrayList cars = new ArrayList();

        // Adding cars to the ArrayList
        cars.Add("Toyota");
        cars.Add("Honda");
        cars.Add("Ford");
        cars.Add("Chevrolet");
        cars.Add("BMW");

        // Sorting the ArrayList
        cars.Sort();

        // Displaying the sorted list of cars
        Console.WriteLine("Sorted List of Cars:");
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
