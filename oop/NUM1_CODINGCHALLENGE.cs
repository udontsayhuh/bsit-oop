using System;

class Program
{
    static void Main()
    {
        //Input two integers and two doubles
        int int1 = GetIntegerInput("Enter first integer: ");
        int int2 = GetIntegerInput("Enter second integer: ");
        double double1 = GetDoubleInput("\nEnter first double: ");
        double double2 = GetDoubleInput("Enter second double: ");

        //Compute the sums of the integers and doubles
        int sumIntegers = SumInt(int1, int2);
        double sumDoubles = SumDoubles(double1, double2);

        //Display the results of the sums
        Console.WriteLine($"\nSum of two integers: {sumIntegers}");
        Console.WriteLine($"Sum of two doubles: {sumDoubles}");

        //Compute the product of the integer and double sums
        double product = ComputeProduct(sumIntegers, sumDoubles);
        Console.WriteLine($"\nProduct of the integer and double sums: {product}");
    }

    //Method to compute the sum of two integers
    static int SumInt(int a, int b)
    {
        return a + b; 
    }

    // Method to compute the sum of two doubles
    static double SumDoubles(double a, double b)
    {
        return a + b;
    }

    // Method to compute the product of the sum of integer and double
    static double ComputeProduct(int sumInt, double sumDoubles)
    {
        return sumInt * sumDoubles;
    }

    // Method to read integer input 
    static int GetIntegerInput(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    // Method to read double input 
    static double GetDoubleInput(string prompt)
    {
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }
}
