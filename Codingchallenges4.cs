using System;

class Program
{
    static void Main(string[] args)
    {
        // Get input for the number to be multiplied
        Console.Write("Enter the number to be multiplied: ");
        int baseNumber = int.Parse(Console.ReadLine());

        // Get input for the multiplier
        Console.Write("Enter the multiplier: ");
        int multiplier = int.Parse(Console.ReadLine());

        // Print the multiplication table
        Console.WriteLine($"Multiplication table for {baseNumber}:");

        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"{baseNumber} x {i} = {baseNumber * i}");
        }
    }
}
