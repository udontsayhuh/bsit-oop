using System;
using System.Collections;

namespace CrystalynDanga
{
    class Program
    {

        /*Write a C# program that demonstrates a list that contains 5 cars and display
        a sorted listed after. (Using ArrayList are LinkedList is allowed).*/
    static void Main(string[] args)
        {
            ArrayList cars = new ArrayList();
            cars.Add("Toyota");
            cars.Add("Mitsubishi");
            cars.Add("Honda");
            cars.Add("Ford");
            cars.Add("Nissan");

            Console.WriteLine(cars);
            foreach (var car in cars) // iterate to display list
            {
                Console.WriteLine(car);
            }

            cars.Sort(); // sorts the list
            Console.WriteLine("\nSorted list: ");

            foreach (var car in cars) // iterate to display list
            {
                Console.WriteLine(car);
            }
        }

    }
}
