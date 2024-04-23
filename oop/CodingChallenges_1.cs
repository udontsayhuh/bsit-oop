using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for two integer
        Console.WriteLine("Enter the first integer:");
        int int1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int int2 = Convert.ToInt32(Console.ReadLine());

        // Sum of the two integers
        int intSum = Add(int1, int2);
        Console.WriteLine($"Sum of the integers: {intSum}");

        // Ask user for two double
        Console.WriteLine("Enter the first double:");
        double double1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second double:");
        double double2 = Convert.ToDouble(Console.ReadLine());

        // Sum of the two double
        double doubleSum = Add(double1, double2);
        Console.WriteLine($"Sum of the doubles: {doubleSum}");

        // Compute the product of the sums
        double product = intSum * doubleSum;
        Console.WriteLine($"Product of the sums: {product}");
    }

    // Method to compute the sum of two integers
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method to compute the sum of two doubles
    static double Add(double a, double b)
    {
        return a + b;
    }
}
