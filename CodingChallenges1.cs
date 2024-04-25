using System;

class Program
{
    static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter the first integer: ");
        int int1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int int2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the first double: ");
        double double1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second double: ");
        double double2 = double.Parse(Console.ReadLine());

        // Compute sum of integers and sum of doubles
        int sumIntegers = int1 + int2;
        double sumDoubles = double1 + double2;

        // Results
        Console.WriteLine($"Sum of integers: {sumIntegers}");
        Console.WriteLine($"Sum of doubles: {sumDoubles}");

        // Compute product of sums
        double product = sumIntegers * sumDoubles;

        // Display the product
        Console.WriteLine($"Product of the sums: {product}");
    }
}
