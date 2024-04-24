using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to the Multiplication Table Generator!");

        // Prompt user for input
        Console.Write("Enter the number to be multiplied: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the multiplier: ");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        // Display multiplication table
        Console.WriteLine($"Multiplication table for {number} up to {multiplier}:");
        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
