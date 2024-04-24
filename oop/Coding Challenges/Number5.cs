/*Write a C# program that demonstrates a list that contains 5 cars and 
display a sorted listed after. (Using ArrayList are LinkedList is allowed).*/

using System;
using System.Collections;//for arraylist

class Program
{
    static void Main(string[] args)
    {
        //initialized arraylist
        ArrayList cars = new ArrayList() { "Honda", "Chevrolet", "Ferrari", "Porsche", "Ford" };
        //displays the unsorted arraylist
        Console.WriteLine("Unsorted list of cars:");
        PrintList(cars);
        //sorts the arraylist
        cars.Sort();
        //displays the sorted arraylist
        Console.WriteLine("\nSorted list of cars:");
        PrintList(cars);
    }
    //method for printing the contents of the arraylist
    static void PrintList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
