using System;

namespace MyFirstCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("|                 My Calculator                 |");
            Console.WriteLine("------------------------------------------------");

            // Create an instance of the Calculator class
            Calculator calculator = new Calculator();

            // Perform calculation
            calculator.PerformCalculation();

            // Wait for the user to press Enter before exiting
            WaitForEnterKey();
        }

        static void WaitForEnterKey()
        {
            // Display message prompting user to press Enter to exit
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" Press Enter to exit...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }

    class Calculator
    {
        // Private fields to store the numbers and operator
        private double num1;
        private double num2;
        private char op;

        // Method to perform calculation
        public void PerformCalculation()
        {
            // Prompt user for first number
            Console.Write(" Enter the first number: ");
            // Try to parse user input into a double, store in num1
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                // If parsing fails, display error message and return
                Console.WriteLine(" Invalid input. Please enter a numerical value.");
                return;
            }

            // Prompt user for operator
            Console.Write(" Enter an operator \n ( +, -, *, /): ");
            // Read the first character of user input as the operator
            op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Validate operator
            if (op != '+' && op != '-' && op != '*' && op != '/')
            {
                // If operator is invalid, display error message and return
                Console.WriteLine(" Invalid operator. Please enter one of the following: +, -, *, / \n");
                return;
            }

            // Prompt user for second number
            Console.Write(" Enter the second number: ");
            // Try to parse user input into a double, store in num2
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                // If parsing fails, display error message and return
                Console.WriteLine(" Invalid input. Please enter a numerical value. \n");
                return;
            }

            // Perform calculation
            double result = Calculate();

            // Display result
            Console.WriteLine("\n Result: " + result);
        }

        // Method to perform actual calculation based on operator
        private double Calculate()
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)
                    {
                        // Handle division by zero error
                        Console.WriteLine(" Cannot divide by zero.");
                        return double.NaN; // Return NaN (Not a Number) for invalid division
                    }
                    return num1 / num2;
                default:
                    // Handle invalid operator
                    return double.NaN; // Return NaN for invalid operator
            }
        }
    }
}
