/*
Write a C# program that demonstrates a list that contains 5 cars and display a sorted listed after. (Using ArrayList are LinkedList is allowed).

Dev by : Villesco, Bengie B.
Section : 2-1
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenges
{
    class SortingCarList
    {
        private static void DisplayArrayList(ArrayList car, string title)
        {
            Console.WriteLine(title);
            foreach (string item in car)
                Console.WriteLine(item);
        }

        public static void Main(string[] args)
        {
            // ArrayList that containing an initial value of 5 cars.
            ArrayList cars = ["Ford Ranger", "Toyota Hilux", "Nissan Navara", "Toyota Raize", "Ford Everest"];

            DisplayArrayList(cars, "Unsorted List of Cars:");   // Method call to DisplayArrayList method with a parameter of cars and an argument of string value.
            cars.Sort();    // Sorting the entire elements in the cars ArrayList.
            DisplayArrayList(cars, "\nSorted List of Cars:");   // Method call to DisplayArrayList method with a parameter of cars and an argument of string value.

            // The following statement is used when the user decides to run the "MainProgram.cs" file, which can execute all coding challenges.
            Console.Write("\nPress any key to go back to main...");
            Console.ReadKey();  // read the key that the user's input (similar to getch).
            Console.Clear();    // Clear the console screen.
        }
    }
}