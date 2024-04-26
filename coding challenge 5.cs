using System;

public class MultiplicationTable
{
    public static void Main(string[] args)
    {
        // Get number to be multiplied
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Get multiplier
        Console.Write("Enter the multiplier (up to which to print): ");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        // Print multiplication table
        Console.WriteLine("Multiplication Table of {0}:", number);
        for (int i = 1; i <= multiplier; i++)
        {
            int product = number * i;
            Console.WriteLine("{0} x {1} = {2}", number, i, product);
        }
    }
}
