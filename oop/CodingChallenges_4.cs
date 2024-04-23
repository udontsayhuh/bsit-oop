using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to enter the number to be multiplied
        Console.Write("Enter the number to be multiplied: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Ask the user to enter the multiplier
        Console.Write("Enter the multiplier: ");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        // Print the multiplication table
        Console.WriteLine($"Multiplication table for {number} up to {multiplier}:");
        for (int i = 1; i <= multiplier; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
        }
    }
}
