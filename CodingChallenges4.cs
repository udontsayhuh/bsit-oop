using System;

class Program
{
    static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter number to be multiplied: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the multiplier: ");
        int multiplier = int.Parse(Console.ReadLine());

        // Print the multiplication table
        Console.WriteLine($"Multiplication table for {number} up to {multiplier}:");
        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
