using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number to be multiplied: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the multiplier: ");
        int multiplier = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiplication table for {number} up to {multiplier}:");

        for (int i = 1; i <= multiplier; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}
