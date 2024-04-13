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
            double result = 0;
            bool isFirstInput = true;

            while (true)
            {
                double num;
                char op;

                // Prompt user for input
                if (isFirstInput)
                {
                    Console.Write(" Enter a number: ");
                }
                else
                {
                    Console.Write(" Enter an operator (+, -, *, /, or =): ");
                }

                string input = Console.ReadLine().Trim();

                if (input == "=")
                {
                    // Display result when equal sign is entered
                    Console.WriteLine(" Result: " + result);
                    break;
                }

                if (isFirstInput)
                {
                    if (!double.TryParse(input, out num))
                    {
                        // If parsing fails, display error message and prompt again
                        Console.WriteLine(" Invalid input. Please enter a numerical value.");
                        continue;
                    }
                    isFirstInput = false;
                    result = num;
                    continue;
                }

                // Code optimization: short-circuiting logical operators are used.
                if (!char.TryParse(input, out op) || (op != '+' && op != '-' && op != '*' && op != '/'))
                {
                    // If parsing fails or operator is invalid, display error message and prompt again
                    Console.WriteLine(" Invalid operator. Please enter one of the following:");
                    Console.WriteLine(" +, -, *, =");
                    continue;
                }

                // Prompt user for number
                Console.Write(" Enter the next number: ");
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    // If parsing fails, display error message and prompt again
                    Console.WriteLine(" Invalid input. Please enter a numerical value.");
                    continue;
                }

                // Perform calculation
                result = Calculate(result, num, op);
            }
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

// All the data and behavior related to the calculator are encapsulated within the Calculator class.
// that contains the methods to perform calculations and interacts with the user.

// Used abstraction which abstract away the implementation details of the calculator operations,
//allowing users to interact with it through a simple interface.
