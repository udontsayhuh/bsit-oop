using System;

class Program
{
    static void Main()
    {
        // Get the number to be multiplied and the multiplier from the user
        Console.Write("Enter the number to be multiplied: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the multiplier (up to which you want the table): ");
        int multiplier = int.Parse(Console.ReadLine());

        // Print the multiplication table
        Console.WriteLine($"Multiplication table for {number} up to {multiplier}:");
        for (int i = 1; i <= multiplier; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}
