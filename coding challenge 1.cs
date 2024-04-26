using System;

public class SumAndProduct
{
    public static void Main(string[] args)
    {
        // Get integer inputs
        Console.Write("Enter first integer: ");
        int int1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int int2 = Convert.ToInt32(Console.ReadLine());

        // Get double inputs
        Console.Write("Enter first double: ");
        double double1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second double: ");
        double double2 = Convert.ToDouble(Console.ReadLine());

        // Calculate integer sum and double sum
        int integerSum = int1 + int2;
        double doubleSum = double1 + double2;

        // Display sums
        Console.WriteLine("Sum of integers: {0}", integerSum);
        Console.WriteLine("Sum of doubles: {0}", doubleSum);
        // Calculate and display product of sums (cast integer sum to double for accurate calculation)
        double product = (double)integerSum * doubleSum;
        Console.WriteLine("Product of sums: {0}", product);
    }
}
