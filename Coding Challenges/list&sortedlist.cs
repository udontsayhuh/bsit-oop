/*Write a C# program that demonstrates a list that contains 5 cars
and display a sorted listed after. (Using ArrayList are LinkedList is allowed).*/

using System;

class Program
{
  public static void Main()
  {
    //create an arraylist to store the cars
    ArrayList cars = new ArrayList();

    //add 5 cars to the arraylist
    cars.Add("Toyota");
    cars.Add("Honda");
    cars.Add("BMW");
    cars.Add("Ford");
    cars.Add("Corolla");

    //Display the original/unsorted list of cars
    Console.WriteLine("Original List of Cars: ");
    //iterate each car in the original/unsorted arraylist
    for (int i = 0; i < cars.Count; i++)
    {
      Console.WriteLine(cars[i]); //display each car in the original/unsorted arraylist
    }
    cars.Sort(); //sort the cars in the arraylist
    Console.WriteLine("\n---------------------");
    //display the sorted list of cars
    Console.WriteLine("\nSorted List of Cars: ");
    //iterate each car in the sorted arraylist
    for (int i = 0; i < cars.Count; i++)
    {
      Console.WriteLine(cars[i]); //display each car in the sorted arraylist
    }
  }
}
