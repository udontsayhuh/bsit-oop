//Regine Mae G. Hambiol
//BSIT2-2
//Coding Challenges Activity

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---Coding Challenges No.1---");
        // Get inputs for two integers
        Console.WriteLine("\n Enter the first integer:");
        int int1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the second integer:");
        int int2 = Convert.ToInt32(Console.ReadLine());
        
        // Get inputs for two doubles
        Console.WriteLine("\n Enter the first double:");
        double double1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the second double:");
        double double2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("-----------------------------");
        // Calculate sum of two integers
        int intSum = AddIntegers(int1, int2);
        Console.WriteLine($"\nSum of integers: {intSum}");
        
        // Calculate sum of two doubles
        double doubleSum = AddDoubles(double1, double2);
        Console.WriteLine($"Sum of doubles: {doubleSum}");
        
        // Calculate product of the sums(int and double)
        double product = CalculateProduct(intSum, doubleSum);
        Console.WriteLine($"\n Product of the Sums: {product}");
    }
    
    static int AddIntegers(int a, int b)
    {
        return a + b;
    }
    
    static double AddDoubles(double a, double b)
    {
        return a + b;
    }
    
    static double CalculateProduct(int intSum, double doubleSum)
    {
        return intSum * doubleSum;
    }
}
----------------------------------------------------------------
using System;

class Program
{
    static void Main(string[] args)
    {  
        Console.WriteLine("Coding Challenges No.2");

        // Prompt of the User
        Console.WriteLine("\n Enter a String:");
        string input = Console.ReadLine();

        // Count the number of words
        int wordCount = CountWords(input);

        // Print the number of words
        Console.WriteLine($"\n Number of words: {wordCount}");

        // Convertion
        string upperCaseString = input.ToUpper();
        Console.WriteLine($"\n Uppercase string: {upperCaseString}");
    }

    static int CountWords(string str)
    {
        // Split the string into words using whitespace...
        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        // Return the number of words
        return words.Length;
    }
}
--------------------------------------------------------------------------
using System;

class Program
{
    static void Main(string[] args)
    {

        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("\n Select an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            // Read user's choice
            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            // Perform arithmetic operation statement
            switch (choice)
            {
                case 1:
                    PerformAddition();
                    break;
                case 2:
                    PerformSubtraction();
                    break;
                case 3:
                    PerformMultiplication();
                    break;
                case 4:
                    PerformDivision();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            // Ask user if they want to continue
            Console.Write("Do you want to perform another action? (yes/no): ");
            string answer = Console.ReadLine().ToLower();
            if (answer != "yes")
            {
                continueProgram = false;
            }
        }
    }

    static void PerformAddition()
    {
        Console.Write("\n Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("\n Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 + num2;
        Console.WriteLine($"\n Result: {result}");
    }

    static void PerformSubtraction()
    {
        Console.Write("\n Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("\n Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 - num2;
        Console.WriteLine($"\n Result: {result}");
    }

    static void PerformMultiplication()
    {
        Console.Write("\n Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("\n Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = num1 * num2;
        Console.WriteLine($"\n Result: {result}");
    }

    static void PerformDivision()
    {
        Console.Write("\n Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("\n Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero. Please input a valid number...");
            return;
        }

        double result = num1 / num2;
        Console.WriteLine($"\n Result: {result}");
    }
}
--------------------------------------------------------------------------------
using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Coding Challenges No.4");
            // Get input from user
            Console.Write("\n Enter the number to be Multiplied: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("\n Enter the multiplier: ");
            int multiplier = int.Parse(Console.ReadLine());

            // Print multiplication table
            Console.WriteLine($"\n Multiplication table for {number} up to {multiplier}:");
            for (int i = 1; i <= multiplier; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            // Ask user if they want to continue
            Console.Write("\n Do you want to continue? (yes/no): ");
            string answer = Console.ReadLine().ToLower();
            if (answer != "yes")
            {
                continueProgram = false;
            }
        }
    }
}
--------------------------------------------------------------------
  using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   Console.Write("Coding Challenges No.5");
        try
        {
            // Create a list to store cars
            List<string> cars = new List<string>();

            // Add cars to the list, pre-define input
            cars.Add("Toyota");
            cars.Add("Honda");
            cars.Add("Ford");
            cars.Add("BMW");
            cars.Add("Porche");

            // Display the original list
            Console.WriteLine("\n Original list of cars:");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // Sort the list
            cars.Sort();

            // Display the sorted list
            Console.WriteLine("\n Sorted list of cars:");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
