using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace CrystalynDanga
{
    class Program
    {
        /*Write a C# program that takes two numbers as input: the first number will be the number to be multiplied 
        and the second number will be the multiplier, and prints its multiplication table up to the given 
        second number (the multiplier).*/
        static void Main(string[] args)
        {
            int result = 0;
            Console.Write("Enter the number to be multiplied: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the multiplier: ");
            int multiplier = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= multiplier; i++) 
            {
                result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
                result = 0;
            }
        }
    }
}
