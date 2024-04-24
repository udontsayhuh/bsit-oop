/* Write a C# program that takes two numbers as input: the first
number will be the number to be multiplied and the second
number will be the multiplier, and prints its multiplication table up
to the given second number (the multiplier). */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Multiplication table up to {num2}");
        for (int i = 1; i <= num2; i++)
        {
            int result = num1 * i;
            Console.WriteLine($"{num1} x {num2} = {result}");
        }
    }
}
