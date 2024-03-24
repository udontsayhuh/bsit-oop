// DAVID, BERNARD ANDREI C.
// BSIT-CM 2-1
// CALCULATOR


 using System;
 namespace Calculator;

// Abstract
abstract class SimpleCalculator
{
    // Private method for performing calculations
    private double Calculate(double num1, double num2, char op)
    {
        // Perform calculation based on the operator
        switch (op)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '/':
                if (num2 == 0)
                {
                    // Handle division by zero
                    Console.WriteLine("Cannot divide by zero.");
                    return 0;
                }
                return num1 / num2;
            case '*':
                return num1 * num2;
        }
        return 0;
    }

    // Method to run the calculator
    public void Run()
    {
        while (true)
        {
            // Get first number
            double num1 = GetNumericInput("Enter the first number:");

            // Get operator
            char op = GetOperatorInput();

            // Get second number
            double num2 = GetNumericInput("Enter the second number:");

            // Perform calculation and display result
            double result = Calculate(num1, num2, op);
            Console.WriteLine("Result: " + result);

            // Ask if the user wants to perform another calculation
            Console.Write("Do you want to perform another calculation? (Type Y or N): ");
            if (Console.ReadLine().ToUpper() != "Y")
            {
                // If the input is not 'Y' or 'y', exit the loop
                break;
            }
        }
    }

    // Common method for getting numerical input
    private double GetNumericInput(string prompt)
    {
        double num;
        while (true) // Loop until valid input is provided
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out num))
            {
                // If parsing was successful, break the loop
                break;
            }
            else
            {
                // If parsing failed, display error message and terminate
                Console.WriteLine("Input is invalid.");
                Environment.Exit(0);
            }
        }
        return num;
    }

    // Method for getting operator input
    private char GetOperatorInput()
    {
        char op;
        while (true) // Loop until valid input is provided
        {
            Console.WriteLine("Enter an operator (+, -, /, *):");
            string input = Console.ReadLine();

            // Check if the input is a single character
            if (input.Length == 1)
            {
                op = input[0]; // Get the first character
                // Check if the character is a valid operator
                if (op == '+' || op == '-' || op == '/' || op == '*')
                {
                    // If it's a valid operator, break the loop
                    break;
                }
            }

            // If it's not a valid operator, display error message and continue loop
            Console.WriteLine("Invalid operator. Please enter one of the following: (+, -, /, *)");
        }
        return op;
    }
}

// Derived class inheriting from Simplecalculator
class Calculator : SimpleCalculator
{
    // No need to override Calculate method
}

// Main program class
class Activity
{
    static void Main(string[] args)
    {
        // Creating an instance of Calculator and running it
        Calculator calculator = new Calculator();
        calculator.Run();
    }
}
