// DAVID, BERNARD ANDREI C.
// BSIT-CM 2-1
// CALCULATOR

using System;

namespace Calculator
{
    // Abstract class for simple calculator
    abstract class SimpleCalculator
    {
        // Method to run the calculator
        public void Run()
        {
            while (true)
            {
                // Arrays to store numbers and operators
                string[] numbers = new string[100]; // Maximum number of input numbers - Changed data type to string
                string[] operators = new string[100]; // Maximum number of input operators - Changed data type to string

                // Get input until "=" is entered
                int numCount = 0; // Changed variable name to camelCase
                int opCount = 0; // Changed variable name to camelCase
                while (true)
                {
                    // Get number
                    string num = NumberInput("Enter a number: "); // Changed method name to camelCase
                    numbers[numCount++] = num;

                    // Get operator
                    string op = OperatorInput(); // Changed method name to camelCase
                    operators[opCount++] = op;

                    // If "=" is entered, calculate the result
                    if (op == "=")
                    {
                        // Perform calculation and display result
                        double result = Calculate(numbers, operators, numCount, opCount);
                        Console.WriteLine("Result: " + result);
                        break;
                    }
                }

                // Ask if the user wants to perform another calculation
                Console.Write("Do you want to perform another calculation? (Type Y or N): ");
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    // If the input is not 'Y' or 'y', exit the loop
                    break;
                }
            }
        }

        // Private method for performing calculations
        private double Calculate(string[] numbers, string[] operators, int numCount, int opCount)
        {
            double result = Convert.ToDouble(numbers[0]);
            for (int i = 0; i < opCount; i++)
            {
                switch (operators[i])
                {
                    case "+":
                        result += Convert.ToDouble(numbers[i + 1]);
                        break;
                    case "-":
                        result -= Convert.ToDouble(numbers[i + 1]);
                        break;
                    case "/":
                        if (Convert.ToDouble(numbers[i + 1]) == 0)
                        {
                            // Handle division by zero
                            Console.WriteLine("Cannot divide by zero.");
                            return 0;
                        }
                        result /= Convert.ToDouble(numbers[i + 1]);
                        break;
                    case "*":
                        result *= Convert.ToDouble(numbers[i + 1]);
                        break;
                }
            }
            return result;
        }

        // Common method for getting numerical input
        private string NumberInput(string prompt)
        {
            string num;
            while (true) // Loop until valid input is provided
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out double result))
                {
                    // If parsing was successful, return the number
                    return result.ToString();
                }
                else
                {
                    // If parsing failed, display error message and continue loop
                    Console.WriteLine("Input is invalid. Please enter a valid number.");
                }
            }
        }

        // Method for getting operator input
        private string OperatorInput()
        {
            string op;
            while (true) // Loop until valid input is provided
            {
                Console.WriteLine("Enter an operator (+, -, /, *, =):");
                string input = Console.ReadLine();

                // Check if the input is a single character
                if (input.Length == 1)
                {
                    op = input; // Get the first character
                    // Check if the character is a valid operator
                    if (op == "+" || op == "-" || op == "/" || op == "*" || op == "=")
                    {
                        // If it's a valid operator, return the operator
                        return op;
                    }
                }

                // If it's not a valid operator, display error message and continue loop
                Console.WriteLine("Invalid operator. Please enter one of the following: (+, -, /, *, =)");
            }
        }
    }

    // Derived class inheriting from SimpleCalculator
    class Calculator : SimpleCalculator
    {
        // No need to override Calculate method
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Calculator and running it
            Calculator calculator = new Calculator();
            calculator.Run();
        }
    }
}

