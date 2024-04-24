/*Write a C# program that demonstrates a list that contains 5 cars and 
display a sorted listed after. (Using ArrayList are LinkedList is allowed).*/

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList cars = new ArrayList() { "Honda", "Chevrolet", "Ferrari", "Porsche", "Ford" };

        Console.WriteLine("Unsorted list of cars:");
        PrintList(cars);

        cars.Sort();

        Console.WriteLine("\nSorted list of cars:");
        PrintList(cars);
    }

    static void PrintList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
