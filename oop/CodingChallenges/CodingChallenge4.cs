using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.CodingChallenges
{
    internal class CodingChallenge4
    {
        public void MultiplicationTableResult()
        {
            Console.WriteLine("\nCoding Challenge #4");
            Console.Write("\nEnter the base number: ");
            int baseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the multiplier: ");
            int multiplier = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nMultiplication table for {baseNumber} up to {multiplier}:");
            for (int i = 1; i <= multiplier; i++)
            {
                int result = baseNumber * i;
                Console.WriteLine($"{baseNumber} x {i} = {result}");
            }
            Console.WriteLine(" ");
        }
        
    }
}
