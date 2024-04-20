/*C# program that contains method that accepts inputs from the user - that will
compute the sum of two integers and two doubles separately, and after showing the
result of the two sums, compute for the product of the sums - the result must be a
double data type.*/

using System;

class Calculator
{
    //method to sum the two integers
    public int SumIntegers(int num1, int num2)
    {
        return num1 + num2;
    }

   //method to sum the two doubles
    public double SumDoubles(double num1, double num2)
    {
        return num1 + num2;
    }

    //method to calculate the product sum integer and double
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

        //getting the input from the user
        int int1 = GetIntegerInput("Enter First Integer: ");
        int int2 = GetIntegerInput("Enter Second Integer: ");
        double double1 = GetDoubleInput("\nEnter First Double: ");
        double double2 = GetDoubleInput("Enter Second Double: ");

        //calculating the sum of integers and doubles
        int sumIntegers = calculator.SumIntegers(int1, int2);
        double sumDoubles = calculator.SumDoubles(double1, double2);

        //display the sums
        Console.WriteLine($"\nSum of Integers: {sumIntegers}");
        Console.WriteLine($"Sum of Doubles: {sumDoubles}");

        //calculate the product of the sums and display it
        double productofSums = calculator.ProductOfSums(sumIntegers, sumDoubles);
        Console.WriteLine($"Product of Sums: {productofSums}");
    }

    //method to get the integer input from the user
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
                //invalid if user did not put an integer 
                Console.WriteLine("Invalid input! Please enter an integer.");
            }
        }
    }
    

    //method to get the double input from the user
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
                //invalid if user did not put a double input
                Console.WriteLine("Invalid input! Please enter a double.");
            }
        }
    }
}

  
  
