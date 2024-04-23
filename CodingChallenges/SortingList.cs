using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenges
{
    class SortingList
    {
        public void Header()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(" Sorting an ArrayList ");
            Console.WriteLine("----------------------------------------------------\n");

        }
        public void Sort()
        {
            Header();

            // initialize an empty arraylist
            ArrayList cars = new ArrayList();

            // add cars on the arraylist
            cars.Add("Toyota");
            cars.Add("Honda");
            cars.Add("BMW");
            cars.Add("Ford");
            cars.Add("Suzuki");

            // prints the original list
            Console.WriteLine("-----------------------");
            Console.WriteLine("Original list: ");
            Console.WriteLine("-----------------------")
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // sort the arraylist
            cars.Sort();

            //prints the sorted list
            Console.WriteLine("\n----------------------");
            Console.WriteLine("Sorted list: ");
            Console.WriteLine("----------------------");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }



    }
}
