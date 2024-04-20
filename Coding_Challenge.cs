using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Display menu options
            Console.WriteLine("Select a program to run:");
            Console.WriteLine("1. Compute sums and product");
            Console.WriteLine("2. Count words and print in uppercase");
            Console.WriteLine("3. Basic arithmetic functions");
            Console.WriteLine("4. Multiplication table");
            Console.WriteLine("5. Sort a list of cars");
            Console.WriteLine("6. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ComputeSumsAndProduct(); // Call the method to compute sums and product
                    break;
                case 2:
                    CountWordsAndPrintUppercase(); // Call the method to count words and print in uppercase
                    break;
                case 3:
                    BasicArithmeticFunctions(); // Call the method to perform basic arithmetic functions
                    break;
                case 4:
                    MultiplicationTable(); // Call the method to print multiplication table
                    break;
                case 5:
                    SortListOfCars(); // Call the method to sort a list of cars
                    break;
                case 6:
                    Environment.Exit(0); // Exit the program
                    break;
                default:
                    Console.WriteLine("Invalid choice."); // Display message for invalid input
                    break;
            }
        }
    }

    // Method to compute sums of integers and doubles and their product
    static void ComputeSumsAndProduct()
    {
        int int1, int2;
        double double1, double2;

        // Input two integers
        Console.WriteLine("Enter two integers:");
        int1 = Convert.ToInt32(Console.ReadLine());
        int2 = Convert.ToInt32(Console.ReadLine());

        // Input two doubles
        Console.WriteLine("Enter two doubles:");
        double1 = Convert.ToDouble(Console.ReadLine());
        double2 = Convert.ToDouble(Console.ReadLine());

        // Compute sums
        int sumIntegers = int1 + int2;
        double sumDoubles = double1 + double2;

        // Display sums and product
        Console.WriteLine($"Sum of integers: {sumIntegers}");
        Console.WriteLine($"Sum of doubles: {sumDoubles.ToString("0.0")}"); // Format doubles with one decimal place

        double product = sumIntegers * sumDoubles;
        Console.WriteLine($"Product of the sums: {product.ToString("0.0")}"); // Format product with one decimal place
    }

    // Method to count words and print in uppercase
    static void CountWordsAndPrintUppercase()
    {
        // Input a string
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Count words
        int wordCount = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

        // Display word count and string in uppercase
        Console.WriteLine($"Number of words: {wordCount}");
        Console.WriteLine($"Uppercase string: {input.ToUpper()}");
    }

    // Method to perform basic arithmetic functions
    static void BasicArithmeticFunctions()
    {
        while (true)
        {
            // Display arithmetic function options
            Console.WriteLine("Select an arithmetic function:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit to main menu");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 5)
                break;

            // Input two numbers
            Console.WriteLine("Enter two numbers:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Perform selected arithmetic function
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1 / num2}");
                    else
                        Console.WriteLine("Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            // Ask user if they want to perform another arithmetic function
            Console.WriteLine("Do you want to perform another arithmetic function? (yes/no)");
            string input = Console.ReadLine().ToLower();
            if (input != "yes")
                break;
        }
    }

    // Method to print multiplication table
    static void MultiplicationTable()
    {
        // Input number to be multiplied and multiplier
        Console.WriteLine("Enter the number to be multiplied:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the multiplier:");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        // Display multiplication table
        Console.WriteLine($"Multiplication table for {number}:");

        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }

    // Method to sort a list of cars
    static void SortListOfCars()
    {
        // Create a list of cars
        List<string> cars = new List<string> { "Lexus", "Porsche", "BMW", "Kia", "Tesla" };

        // Sort the list of cars
        cars.Sort();

        // Display sorted list of cars
        Console.WriteLine("Sorted list of cars:");
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
