using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool repeat = true;
        while (repeat)
        {
            // Choose operation
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Compute Sum and Product");
            Console.WriteLine("2. Count Words and Uppercase");
            Console.WriteLine("3. Basic Arithmetic Operations");
            Console.WriteLine("4. Multiplication Table");
            Console.WriteLine("5. Sorted List of Cars");
            Console.WriteLine("6. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ComputeSumAndProduct();
                    break;
                case 2:
                    CountWordsAndUppercase();
                    break;
                case 3:
                    PerformArithmeticOperations();
                    break;
                case 4:
                    PrintMultiplicationTable();
                    break;
                case 5:
                    DisplaySortedListOfCars();
                    break;
                case 6:
                    repeat = false;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void ComputeSumAndProduct()
    {
        // Input integers
        Console.WriteLine("Enter two integers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Input doubles
        Console.WriteLine("Enter two doubles:");
        double double1 = Convert.ToDouble(Console.ReadLine());
        double double2 = Convert.ToDouble(Console.ReadLine());

        // Compute sum of integers and doubles
        int sumIntegers = num1 + num2;
        double sumDoubles = double1 + double2;

        // Print sums
        Console.WriteLine($"Sum of integers: {sumIntegers}");
        Console.WriteLine($"Sum of doubles: {sumDoubles}");

        // Compute product of sums
        double product = sumIntegers * sumDoubles;
        Console.WriteLine($"Product of sums: {product}");
    }

    static void CountWordsAndUppercase()
    {
        // Input string
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Count words
        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;
        Console.WriteLine($"Number of words: {wordCount}");

        // Print in uppercase
        string upperCaseString = input.ToUpper();
        Console.WriteLine($"Uppercase string: {upperCaseString}");
    }

    static void PerformArithmeticOperations()
    {
        // Choose operation
        Console.WriteLine("Choose an arithmetic operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Input numbers
        Console.WriteLine("Enter two numbers:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Perform operation
        double result = 0;
        switch (choice)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        // Print result
        Console.WriteLine($"Result: {result}");
    }

    static void PrintMultiplicationTable()
    {
        // Input number and multiplier
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the multiplier:");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        // Print multiplication table
        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }

    static void DisplaySortedListOfCars()
    {
        // Create list of cars
        List<string> cars = new List<string> { "Toyota", "Honda", "BMW", "Ford", "Chevrolet" };

        // Sort list
        cars.Sort();

        // Display sorted list
        Console.WriteLine("Sorted list of cars:");
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
