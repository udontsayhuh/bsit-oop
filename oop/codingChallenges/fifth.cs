using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create and add list of cars
            List<string> cars = new List<string>();

            cars.Add("Ford");
            cars.Add("Kia");
            cars.Add("Chevrolet");
            cars.Add("Mercedes Benz");
            cars.Add("Rolls Royce");

            Console.WriteLine("Unsorted list of cars:");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            cars.Sort();
            Console.WriteLine("\nSorted list of cars: ");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
