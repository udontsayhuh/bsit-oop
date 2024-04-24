using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.CodingChallenges
{
    internal class CodingChallenge5
    {
        
        public void Vehicle()
        {
            ArrayList cars = new ArrayList();
            cars.Add("Toyota");
            cars.Add("Volvo");
            cars.Add("Ford");
            cars.Add("Honda");
            cars.Add("Mitsubishi");
            Console.Write($"\nThe Cars are: ");
            foreach (var i in cars)
            {
                if (i == cars[4])
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
            cars.Sort();

            Console.Write("\nSorted by Names: ");
            foreach (var x in cars)
            {
                if (x == cars[4])
                {
                    Console.Write(x + " \n");
                }
                else
                {
                    Console.Write(x + ", ");
                }

            }

        }
        
    }
}
