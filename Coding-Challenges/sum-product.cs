using System;

class Program
{
    static void Main()
    {
        // Accept inputs from the user
        Console.WriteLine("Enter two integers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter two doubles:");
        double double1 = double.Parse(Console.ReadLine());
        double double2 = double.Parse(Console.ReadLine());

        // Compute the sum of two integers and two doubles separately
        int intSum = SumIntegers(num1, num2);
        double doubleSum = SumDoubles(double1, double2);

        // Show the results
        Console.WriteLine($"Sum of integers: {intSum}");
        Console.WriteLine($"Sum of doubles: {doubleSum}");

        // Compute the product of the sums
        double product = ComputeProduct(intSum, doubleSum);
        Console.WriteLine($"Product of sums: {product}");
    }

    static int SumIntegers(int a, int b)
    {
        return a + b;
    }

    static double SumDoubles(double a, double b)
    {
        return a + b;
    }

    static double ComputeProduct(int intSum, double doubleSum)
    {
        return intSum * doubleSum;
    }
}
