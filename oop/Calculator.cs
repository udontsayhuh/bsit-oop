using System;

namespace BestCalculatorInCebu
{
    // Abstract base class for mathematical operations
    public abstract class Operation
    {
        // Method to perform the calculation
        public abstract int Calculation(int num1, int num2);
    }

    // Child class for Addition operation
    public class Addition : Operation
    {
        // Override method to perform addition
        public override int Calculation(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    // Child class for Subtraction operation
    public class Subtraction : Operation
    {
        // Override method to perform subtraction
        public override int Calculation(int num1, int num2)
        {
            return num1 - num2;
        }
    }

    // Child class for Multiplication operation
    public class Multiplication : Operation
    {
        // Override method to perform multiplication
        public override int Calculation(int num1, int num2)
        {
            return num1 * num2;
        }
    }

    // Child class for Division operation
    public class Division : Operation
    {
        // Override method to perform division
        public override int Calculation(int num1, int num2)
        {
            // Check for division by zero
            if (num2 == 0)
            {
                throw new ArgumentException("Error: Division by zero!");
            }
            return num1 / num2;
        }
    }

    // Calculator class responsible for the main logic
    public class Calculator
    {
        // Method to perform the calculation based on operator symbol
        public int PerformCalculation(int num1, int num2, char opSymbol)
        {
            // Declare an instance of the Operation class
            Operation operation;

            // Determine the operation based on the operator symbol
            switch (opSymbol)
            {
                // Addition operation
                case '+':
                    operation = new Addition();
                    break;
                // Subtraction operation
                case '-':
                    operation = new Subtraction();
                    break;
                // Multiplication operation
                case '*':
                    operation = new Multiplication();
                    break;
                // Division operation
                case '/':
                    operation = new Division();
                    break;
                // Invalid operator
                default:
                    throw new ArgumentException("Invalid operator. Please use +, -, *, or /.");
            }

            // Perform the calculation using the selected operation
            return operation.Calculation(num1, num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Calculator class
            Calculator calculator = new Calculator();

            // Main loop for calculator program
            while (true)
            {
                // Display calculator header
                Console.WriteLine("The Best Calculator in Cebu");

                // Prompt the user to enter the first value
                Console.Write("Enter a value: ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    // Handle invalid input
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                    continue;
                }

                // Initialize the result with the first value entered
                int result = num1;

                // Loop for additional calculations
                while (true)
                {
                    // Prompt the user to choose an operator
                    Console.Write("Choose an operator (+, -, *, /) and use '=' to calculate: ");
                    char opSymbol = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    // Check for termination condition
                    if (opSymbol == '=')
                        break;

                    // Validate the operator symbol
                    if (opSymbol != '+' && opSymbol != '-' && opSymbol != '*' && opSymbol != '/')
                    {
                        // Handle invalid operator
                        Console.WriteLine("Invalid operator. Please use +, -, *, /, or =.");
                        continue;
                    }

                    // Prompt the user to enter the second value
                    Console.Write("Enter another value: ");
                    if (!int.TryParse(Console.ReadLine(), out int num2))
                    {
                        // Handle invalid input
                        Console.WriteLine("Invalid input. Please enter a numerical value.");
                        continue;
                    }

                    try
                    {
                        // Perform the calculation using the selected operation
                        result = calculator.PerformCalculation(result, num2, opSymbol);
                    }
                    catch (ArgumentException e)
                    {
                        // Handle division by zero exception
                        Console.WriteLine(e.Message);
                        break;
                    }
                }

                // Display the result of the calculation
                Console.WriteLine($"Result: {result}");

                // Prompt the user to perform another calculation or exit
                Console.Write("Do you want to perform another calculation? (Y/N): ");
                char choice = Console.ReadKey().KeyChar;
                if (char.ToUpper(choice) != 'Y')
                {
                    // Exit the program
                    Console.WriteLine("\nThank you for using the best Calculator in Cebu. Goodbye!");
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
