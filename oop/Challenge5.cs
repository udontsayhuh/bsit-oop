/* Write a C# program that demonstrates a list that contains 5 cars
and display a sorted listed after. (Using ArrayList are LinkedList is
allowed).*/

using System;
using System.Collections;

class Program
    {
        static void Main()
        {

            List<string> carsList = new List<string>()
            {
                "Tesla Model S", "Tesla Model 3", "Tesla Model X", "Tesla Model Y", "Tesla Cybertruck"
            };

            Console.WriteLine("Original List:");
            foreach (string car in carsList)
            {
                Console.WriteLine(car);
            }

            carsList.Sort();
            Console.WriteLine("\nSorted List:");
            foreach (string car in carsList)
            {
            Console.WriteLine(car);
            }
    }
}
