using System;

// Abstract class representing a calculator that can get the sum of two numbers
abstract class SumCalculator
{
    // Abstract method that derived classes must implement to define their specific sum calculation
    public abstract double GetSum();
}

// Class that calculates the sum of two integers
class IntegerSumCalculator : SumCalculator
{
    public override double GetSum()
    {
        Console.Write("Enter first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        return num1 + num2;
    }
}

// Class that calculates the sum of two doubles
class DoubleSumCalculator : SumCalculator
{
    public override double GetSum()
    {
        Console.Write("Enter first double: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second double: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        return num1 + num2;
    }
}

// Class that performs calculations involving integer and double sums
class SumAndProductCalculator
{
    private SumCalculator _integerSumCalculator; // Private field to hold an IntegerSumCalculator instance
    private SumCalculator _doubleSumCalculator;  // Private field to hold a DoubleSumCalculator instance

    public SumAndProductCalculator()
    {
        _integerSumCalculator = new IntegerSumCalculator();
        _doubleSumCalculator = new DoubleSumCalculator();
    }

    public double GetIntegerSum()
    {
        return _integerSumCalculator.GetSum();
    }

    public double GetDoubleSum()
    {
        return _doubleSumCalculator.GetSum();
    }

    public double CalculateProduct(double integerSum, double doubleSum)
    {
        return integerSum * doubleSum;
    }

    public static void Main(string[] args)
    {
        SumAndProductCalculator calculator = new SumAndProductCalculator();

        double integerSum = calculator.GetIntegerSum();
        double doubleSum = calculator.GetDoubleSum();

        Console.WriteLine($"Sum of integers: {integerSum}");
        Console.WriteLine($"Sum of doubles: {doubleSum}");

        double product = calculator.CalculateProduct(integerSum, doubleSum);
        Console.WriteLine($"Product of sums: {product}");
    }
}
