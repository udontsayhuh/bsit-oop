using System;

namespace MyFirstCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                // Display welcome message and header
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("|                     My Calculator                      |");
                Console.WriteLine("----------------------------------------------------------");

                // Create an instance of the Calculator class
                Calculator calculator = new Calculator();

                // Perform calculation
                calculator.PerformCalculation();

                // Ask user if they want to perform another calculation
                Console.WriteLine("----------------------------------------------------------");
                Console.Write(" Do you want to perform another calculation? (Y or N): ");
            } while (Console.ReadLine().Trim().ToLower() == "y");
        }
    }

    class Calculator
    {
        // Method to perform calculation
        public void PerformCalculation()
        {
            double num1, num2;
            char op;

            // Prompt user for first number
            Console.Write(" Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                // If parsing fails, display error message and return
                Console.WriteLine(" Invalid input. Please enter a numerical value.");
                return;
            }

            // Prompt user for operator
            Console.Write(" Enter an operator (+, -, *, /): ");
            if (!char.TryParse(Console.ReadLine(), out op) || (op != '+' && op != '-' && op != '*' && op != '/'))
            {
                // If parsing fails or operator is invalid, display error message and return
                Console.WriteLine(" Invalid operator. Please enter one of the following:");
                Console.WriteLine(" +, -, *, /");
                return;
            }

            // Prompt user for second number
            Console.Write(" Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                // If parsing fails, display error message and return
                Console.WriteLine(" Invalid input. Please enter a numerical value.");
                return;
            }

            // Perform calculation
            double result = Calculate(num1, num2, op);

            // Display result
            Console.WriteLine(" Result: " + result);
        }

        // Method to perform actual calculation based on operator
        private double Calculate(double num1, double num2, char op)
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
                    Console.WriteLine(" Invalid operator.");
                    return double.NaN; // Return NaN for invalid operator
            }
        }
    }
}
