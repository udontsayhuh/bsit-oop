// C# Coding Challenges (Compiled in a Menu)
// Palaje BSIT 2-2

using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            // Menu for the Challenges
            Console.WriteLine("C# Coding Challenges");
            Console.WriteLine("\nMENU");
            Console.WriteLine();
            Console.WriteLine("1. Sum and Product of Integers and Doubles");
            Console.WriteLine("2. Count Words in String and Print in Uppercase");
            Console.WriteLine("3. Basic Arithmetic Functions");
            Console.WriteLine("4. Multiplication Table");
            Console.WriteLine("5. Sort Cars List");
            Console.WriteLine("6. Exit");
            Console.Write("\nEnter your choice: ");

            string input = Console.ReadLine();     // to handle invalid string inputs
            Console.Clear();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("\nInvalid input! Please enter a valid integer option.");
                Console.Write("\nPress Enter to Continue...");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            // choice = Convert.ToInt32(Console.ReadLine());     // only handles integer inputs

            // Switch case for the choices
            switch (choice)
            {
                case 1:     
                    Console.WriteLine("1. Compute for Sums and Product\n");
                    ComputeSumsAndProduct();
                    Console.Clear();
                    break;
                case 2:     
                    Console.WriteLine("2. Count Words and Print in Uppercase\n");
                    CountWordsAndPrintUppercase();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("3. Basic Arithmetic Functions\n");
                    BasicArithmetic();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("4. Multiplication Table\n");
                    PrintMultiplicationTable();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("5. Sort Car List\n");
                    SortCarsList();
                    Console.Clear();
                    break;
                case 6:     // Exit
                    Console.WriteLine("Thank you!\nExiting program...");
                    break;
                default:    // other integer input
                    Console.WriteLine("\nInvalid choice! Please enter a valid option.");
                    Console.Write("\nPress Enter to Continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (choice != 6);
    }

    // #1. Compute Sum of two integers and two doubles separately, and Product of the Sums.
    // Method to Compute Sums and Product.
    static void ComputeSumsAndProduct()
    {
        // Ask for user input and perform addition
        Console.Write("Enter the first integer: ");
        int int1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int int2 = Convert.ToInt32(Console.ReadLine());
        int intSum = int1 + int2;
        Console.WriteLine($"Sum of integers: {intSum}");

        Console.Write("\nEnter the first double: ");
        double double1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second double: ");
        double double2 = Convert.ToDouble(Console.ReadLine());
        double doubleSum = double1 + double2;
        Console.WriteLine($"Sum of doubles: {doubleSum}");

        // Multiply the sum and print the result
        double product = intSum * doubleSum;
        Console.WriteLine($"\nProduct of sums: {product}");
        Console.Write("\nPress Enter to go back to Menu.");
        Console.ReadKey();
    }

    // #2. Count the number of Words and print the string in Uppercase.
    // Method to Count the Words and print in uppercase.
    static void CountWordsAndPrintUppercase()
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");
        // Store and Read the input
        string input = Console.ReadLine();
        // Split the string into words using the Split() method which will result to an array of words
        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        // Count the number of words by accessing the Length property of the array.
        Console.WriteLine($"Number of words: {words.Length}");
        // Print the string in Uppercase
        Console.WriteLine($"Uppercase string: {input.ToUpper()}");
        Console.Write("\nPress Enter to go back to Menu.");
        Console.ReadKey();
    }

    // #3. Perform Basic Arithmetic Functions.
    static void BasicArithmetic()
    {
        string answer;
        // Perform the block of code as long as the answer is equal to "yes"
        do
        {
            Console.Clear();
            // Prompt the user to select form the operations
            Console.WriteLine("Select arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("\nEnter your choice: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            // Enter two numbers
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            switch (operation)
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
                        Console.WriteLine("Error: Division by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
            // Print the Result
            Console.WriteLine($"\nResult: {result}");

            // Ask the user if they want to calculate again
            Console.Write("\nDo you want to perform another action? (yes/no): ");
            answer = Console.ReadLine().ToLower();    // convert the input to lowercase
            if (answer != "yes")   // exit the program if the user inputs anything besides yes
                Console.WriteLine("\nExiting arithmetic program...");

        } while (answer == "yes");  // do the loop while the answer is yes

        Console.Write("\nPress Enter to go back to Menu.");
        Console.ReadKey();
    }

    // #4. Multiplication table.
    static void PrintMultiplicationTable()
    {
        // Ask for user input
        Console.Write("Enter the number to be multiplied: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the multiplier: ");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        // iterate from 1 up to the multiplier
        for (int i = 1; i <= multiplier; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }

        Console.Write("\nPress Enter to go back to Menu.");
        Console.ReadKey();
    }

    // #5. Sort a List of 5 Cars.
    static void SortCarsList()
    {
        // initialize a list of cars
        List<string> cars = new List<string> { "BMW", "Toyota", "Porsche", "Subaru", "Audi" };
        cars.Sort();    // Sort the cars alphabetically (ascending order) using the Sort() method
        //Display the Sorted List
        Console.WriteLine("Sorted Cars List:"); 
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }

        Console.Write("\nPress Enter to go back to Menu.");
        Console.ReadKey();
    }
}
