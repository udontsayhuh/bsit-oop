using System;

class Program
{
    static void Main(string[] args)
    {
        // Get input for integers
        Console.WriteLine("Enter the first integer:");
        int firstInt = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int secondInt = Convert.ToInt32(Console.ReadLine());

        // Get input for doubles
        Console.WriteLine("Enter the first double:");
        double firstDouble = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second double:");
        double secondDouble = Convert.ToDouble(Console.ReadLine());

        // Compute sums
        int intSum = Sum(firstInt, secondInt);
        double doubleSum = Sum(firstDouble, secondDouble);

        // Display sums
        Console.WriteLine($"Sum of integers: {intSum}");
        Console.WriteLine($"Sum of doubles: {doubleSum}");

        // Compute product of sums
        double product = intSum * doubleSum;

        // Display product
        Console.WriteLine($"Product of the sums: {product}");
    }

    // Method to compute sum of two integers
    static int Sum(int a, int b)
    {
        return a + b;
    }

    // Method to compute sum of two doubles
    static double Sum(double a, double b)
    {
        return a + b;
    }
}
