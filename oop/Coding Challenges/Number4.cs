/*Write a C# program that takes two numbers as input: the first number will 
be the number to be multiplied and the second number will be the multiplier, 
and prints its multiplication table up to the given second number (the multiplier).*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int multiplicand, multiplicator;
        while (true)
        {
            Console.Write("Multiplicand: ");
            if (!int.TryParse(Console.ReadLine(), out multiplicand))
            {
                Console.WriteLine("Invalid input. Please enter a number.\n");
                continue;
            }
            break;
        }
        while (true)
        {
            Console.Write("Multiplicator: ");
            if (!int.TryParse(Console.ReadLine(), out multiplicator))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }
            break;
        }
        Console.WriteLine("\nMultiplication table:");
        for (int i = 1; i <= multiplicator; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", multiplicand, i, multiplicand * i);
        }
    }
}
