/* #1
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter two integers:");
        int int1 = Convert.ToInt32(Console.ReadLine());
        int int2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter two doubles:");
        double double1 = Convert.ToDouble(Console.ReadLine());
        double double2 = Convert.ToDouble(Console.ReadLine());

        // Sum of integers
        int intSum = Sum(int1, int2);

        // Sum of doubles
        double doubleSum = Sum(double1, double2);

        // Show results
        Console.WriteLine($"Sum of integers: {intSum}");
        Console.WriteLine($"Sum of doubles: {doubleSum}");

        // Product of sums
        double product = intSum * doubleSum;

        Console.WriteLine($"Product of the sums: {product}");

        Console.ReadLine();
    }

    // Method to compute sum of two integers
    static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    // Method to compute sum of two doubles
    static double Sum(double num1, double num2)
    {
        return num1 + num2;
    }
}

/* #2
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();

        // Count the number of words in the string
        int wordCount = CountWords(inputString);

        // Print the string in uppercase
        string uppercaseString = inputString.ToUpper();
        Console.WriteLine($"Uppercase String: {uppercaseString}");

        // Print the number of words in the string
        Console.WriteLine($"Number of words: {wordCount}");
    }

    // Method to count the number of words in a string
    static int CountWords(string input)
    {
        // Split the string by whitespace to count words
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
*/

/* #3
using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            try
            {
                Console.WriteLine("Select an arithmetic operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                Console.Write("Enter your choice (1-4): ");
                int choice;

                // Try-catch for user's choice
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    continue;
                }

                Console.Write("Enter first number: ");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input for the first number. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter second number: ");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input for the second number. Please enter a valid number.");
                    continue;
                }

                // Check for division by zero
                if (choice == 4 && num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    continue;
                }

                // Perform selected arithmetic operation
                double result = 0;
                string operation = "";
                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        operation = "Addition";
                        break;
                    case 2:
                        result = num1 - num2;
                        operation = "Subtraction";
                        break;
                    case 3:
                        result = num1 * num2;
                        operation = "Multiplication";
                        break;
                    case 4:
                        result = num1 / num2;
                        operation = "Division";
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }

                // Print result
                Console.WriteLine($"{operation} result: {result}");

                // Ask user if they want to continue
                Console.Write("Do you want to perform another operation? (Y/N): ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput != "y")
                {
                    continueProgram = false;
                }

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
*/

/* 4
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number to be multiplied: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the multiplier: ");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        // Print the multiplication table
        Console.WriteLine($"Multiplication table for {number} up to {multiplier}:");

        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
*/

/* #5
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> cars = new List<string>();

        Console.WriteLine("Enter the names of 5 cars:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Car {i + 1}: ");
            string carName = Console.ReadLine();
            cars.Add(carName);
        }

        // Display the unsorted list
        Console.WriteLine("\nUnsorted List of Cars:");
        DisplayList(cars);

        // Sort the list
        cars.Sort();

        // Display the sorted list
        Console.WriteLine("\nSorted List of Cars:");
        DisplayList(cars);

        Console.ReadLine();
    }

    // Method to display the list
    static void DisplayList(List<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
*/