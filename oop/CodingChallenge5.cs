using System;
using System.Collections;

namespace CodingChallenge5
{
    class CodingChallenege5
    {
        static void Main()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("WELCOME TO MY CODING CHALLENGE #5 PROGRAM");
            Console.WriteLine("-------------------------------------");

            //declare linked list
            LinkedList<string> cars = new LinkedList<string>();

            //add nodes to the linked list
            cars.AddLast("Porche");
            cars.AddLast("Range Rover");
            cars.AddLast("Mustang");
            cars.AddLast("Bentley");
            cars.AddLast("Rolls Royce");

            //sorting
            string[] array = new string[cars.Count];
            cars.CopyTo(array, 0);

            Array.Sort(array);

            //printing of every sorted node
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }

        }
    }
}
