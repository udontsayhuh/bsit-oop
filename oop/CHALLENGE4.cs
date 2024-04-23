//Coding Challenge 4
// April 23, 2024

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number to be multiplied: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("ERROR! Please enter a valid integer number.");
            Console.WriteLine("Enter number to be multiplied: ");
        }

        Console.WriteLine("Enter its multiplier: ");
        int multiplier;
        while (!int.TryParse(Console.ReadLine(), out multiplier) || multiplier <= 0)
        {
            Console.WriteLine("ERROR! Please enter a valid positive integer multiplier.");
            Console.WriteLine("Enter the multiplier:");
        }

        Console.WriteLine($"Multiplication table for {number} up to {multiplier}:");
        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
