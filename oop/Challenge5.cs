using System;
class Program
{
    static void Main(string[] args)
    {
        string[] car = { "Honda", "BMW", "Toyota", "Mazda", "Nissan", "Geely" }; //array of cars
        Console.WriteLine("Original List:");
        for (int i = 0; i < car.Length; i++) //loops the array of cars
        {
            Console.WriteLine(car[i]); //prints the car per line
        }

        Array.Sort(car); //sort the array
        Console.WriteLine("\nSorted List:");
        foreach (string i in car) //loops the sorted array
        {
            Console.WriteLine(i); //prints the sorted car per line
        }
    }