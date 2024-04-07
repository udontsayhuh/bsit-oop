// DAVID, BERNARD ANDREI C.
// BSIT-CM 2-1
// CALCULATOR

using System;

namespace Calculator
{
    // Abstract
    abstract class SimpleCalculator
    {
        // Method to run the calculator
        public void Run()
        {
            while (true)
            {
                // Arrays to store numbers and operators
                double[] numbers = new double[100]; // Maximum number of input numbers
                char[] operators = new char[100]; // Maximum number of input operators

                // Get input until "=" is entered
                int num_count = 0;
                int op_count = 0;
                while (true)
                {
                    // Get number
                    double num = number_input("Enter a number: ");
                    numbers[num_count++] = num;

                    // Get operator
                    char op = operator_input();
                    operators[op_count++] = op;

                    // If "=" is entered, calculate the result
                    if (op == '=')
                    {
                        // Perform calculation and display result
                        double result = Calculate(numbers, operators, num_count, op_count);
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
        private double Calculate(double[] numbers, char[] operators, int num_count, int op_count)
        {
            double result = numbers[0];
            for (int i = 0; i < op_count; i++)
            {
                switch (operators[i])
                {
                    case '+':
                        result += numbers[i + 1];
                        break;
                    case '-':
                        result -= numbers[i + 1];
                        break;
                    case '/':
                        if (numbers[i + 1] == 0)
                        {
                            // Handle division by zero
                            Console.WriteLine("Cannot divide by zero.");
                            return 0;
                        }
                        result /= numbers[i + 1];
                        break;
                    case '*':
                        result *= numbers[i + 1];
                        break;
                }
            }
            return result;
        }

        // Common method for getting numerical input
        private double number_input(string prompt)
        {
            double num;
            while (true) // Loop until valid input is provided
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out num))
                {
                    // If parsing was successful, return the number
                    return num;
                }
                else
                {
                    // If parsing failed, display error message and continue loop
                    Console.WriteLine("Input is invalid. Please enter a valid number.");
                }
            }
        }

        // Method for getting operator input
        private char operator_input()
        {
            char op;
            while (true) // Loop until valid input is provided
            {
                Console.WriteLine("Enter an operator (+, -, /, *, =):");
                string input = Console.ReadLine();

                // Check if the input is a single character
                if (input.Length == 1)
                {
                    op = input[0]; // Get the first character
                    // Check if the character is a valid operator
                    if (op == '+' || op == '-' || op == '/' || op == '*' || op == '=')
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
