using System;

class Program
{
    static void Main(string[] args)
    {
        // Accept inputs from the user for two integers
        Console.WriteLine("Enter the first integer:");
        int int1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int int2 = Convert.ToInt32(Console.ReadLine());

        // Accept inputs from the user for two doubles
        Console.WriteLine("Enter the first double:");
        double double1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second double:");
        double double2 = Convert.ToDouble(Console.ReadLine());

        // Compute the sum of two integers and two doubles separately
        int intSum = int1 + int2;
        double doubleSum = double1 + double2;

        // Display the sums
        Console.WriteLine($"Sum of two integers: {intSum}");
        Console.WriteLine($"Sum of two doubles: {doubleSum}");

        // Compute the product of the sums
        double product = intSum * doubleSum;

        // Display the product
        Console.WriteLine($"Product of the sums: {product}");
    }
}


// Count words in a string and print it in uppercase:

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Count words
        int wordCount = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

        // Print number of words
        Console.WriteLine($"Number of words: {wordCount}");

        // Print string in uppercase
        Console.WriteLine($"Uppercase string: {input.ToUpper()}");
    }
}


// Perform basic arithmetic functions:

using System;

class Program
{
    static void Main(string[] args)
    {
        bool repeat = true;
        while (repeat)
        {
            Console.WriteLine("Select arithmetic function:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            // Accept user's choice
            int choice = Convert.ToInt32(Console.ReadLine());

            // Prompt for two numbers
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            // Perform arithmetic based on user's choice
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
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            // Print result
            Console.WriteLine($"Result: {result}");

            // Ask if the user wants to perform another action
            Console.WriteLine("Do you want to perform another action? (yes/no)");
            string answer = Console.ReadLine();
            repeat = (answer.ToLower() == "yes");
        }
    }
}

//Multiplication table program:

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number to be multiplied:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the multiplier:");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Multiplication table for {number} up to {multiplier}:");

        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}

//Display sorted list of cars:
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the cars
        List<string> cars = new List<string>();

        // Add cars to the list
        cars.Add("Toyota");
        cars.Add("Honda");
        cars.Add("BMW");
        cars.Add("Ford");
        cars.Add("Chevrolet");

        // Display the unsorted list
        Console.WriteLine("Unsorted list of cars:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

        // Sort the list
        cars.Sort();

        // Display the sorted list
        Console.WriteLine("\nSorted list of cars:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the cars
        List<string> cars = new List<string>();

        // Add cars to the list
        cars.Add("Toyota");
        cars.Add("Honda");
        cars.Add("BMW");
        cars.Add("Ford");
        cars.Add("Chevrolet");

        // Display the unsorted list
        Console.WriteLine("Unsorted list of cars:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

        // Sort the list
        cars.Sort();

        // Display the sorted list
        Console.WriteLine("\nSorted list of cars:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}


