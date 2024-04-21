using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, intSum;
        double num3, num4, doubleSum, product;

        // Accept integer inputs from the user
        Console.Write("Enter the first integer number: ");
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write("Enter the first integer number: ");
        }

        Console.Write("Enter the second integer number: ");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write("Enter the second integer number: ");
        }

        // Accept double inputs from the user
        Console.Write("Enter the first double number: ");
        while (!double.TryParse(Console.ReadLine(), out num3))
        {
            Console.WriteLine("Invalid input. Please enter a valid double.");
            Console.Write("Enter the first double number: ");
        }

        Console.Write("Enter the second double number: ");
        while (!double.TryParse(Console.ReadLine(), out num4))
        {
            Console.WriteLine("Invalid input. Please enter a valid double.");
            Console.Write("Enter the second double number: ");
        }

        // Sum of the integer inputs
        intSum = num1 + num2;

        // Sum of the double inputs
        doubleSum = num3 + num4;

        // Product of the sum of integer and double
        product = intSum * doubleSum;

        // Display the sums and product
        Console.WriteLine($"\nSum of Integer Inputs: {intSum}");
        Console.WriteLine($"Sum of Double Inputs: {doubleSum}");
        Console.WriteLine($"Product of the Sums: {product}");
    }
}
