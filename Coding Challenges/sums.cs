/*C# program that contains method that accepts inputs from the user - that will
compute the sum of two integers and two doubles separately, and after showing the
result of the two sums, compute for the product of the sums - the result must be a
double data type.*/

using System;

class Calculator
{
    public int SumIntegers(int num1, int num2)
    {
        return num1 + num2;
    }

    public double SumDoubles(double num1, double num2)
    {
        return num1 + num2;
    }

    public double ProductOfSums(int sumIntegers, double sumDoubles)
    {
        return sumIntegers * sumDoubles;
    }
}

class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();

        int int1 = GetIntegerInput("Enter First Integer: ");
        int int2 = GetIntegerInput("Enter Second Integer: ");
        double double1 = GetDoubleInput("\nEnter First Double: ");
        double double2 = GetDoubleInput("Enter Second Double: ");

        int sumIntegers = calculator.SumIntegers(int1, int2);
        double sumDoubles = calculator.SumDoubles(double1, double2);

        Console.WriteLine($"\nSum of Integers: {sumIntegers}");
        Console.WriteLine($"Sum of Doubles: {sumDoubles}");

        double productofSums = calculator.ProductOfSums(sumIntegers, sumDoubles);
        Console.WriteLine($"Product of Sums: {productofSums}");
    }

    public static int GetIntegerInput(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter an integer.");
            }
        }
    }

    public static double GetDoubleInput(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a double.");
            }
        }
    }
}

  
  
