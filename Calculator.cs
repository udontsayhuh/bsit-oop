using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    // Class to handle calculator operations
    public class Calculator
    {
        // Method to validate if input is a numerical value
        private static bool IsValidNumber(string input)
        {
            return double.TryParse(input, out _);
        }

        // Method to validate if input is one of the four fundamental operators: +-*/
        private static bool IsValidOperator(char op)
        {
            return op == '+' || op == '-' || op == '*' || op == '/';
        }

        // Method to perform calculation based on operator and operands
        private static double PerformCalculation(double num1, double num2, char op)
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
                    if (num2 != 0)
                        return num1 / num2;
                    else
                        throw new DivideByZeroException("Cannot divide by zero");
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }

        // Main calculation method
        public static void Calculate()
        {
            bool repeat = true;

            while (repeat)
            {
                List<double> numbers = new List<double>();
                List<char> operators = new List<char>();

                Console.WriteLine("Enter an equation (or '=' to calculate):");
                string input = Console.ReadLine();

                while (input != "=")
                {
                    if (!IsValidNumber(input) && input != "+" && input != "-" && input != "*" && input != "/")
                    {
                        Console.WriteLine("Invalid input. Please enter a numerical value, '+' '-' '*' '/' or '=' to calculate.");
                        input = Console.ReadLine();
                        continue;
                    }

                    if (IsValidNumber(input))
                    {
                        numbers.Add(double.Parse(input));
                    }
                    else
                    {
                        operators.Add(char.Parse(input));
                    }

                    input = Console.ReadLine();
                }

                if (numbers.Count == 0 || operators.Count == 0)
                {
                    Console.WriteLine("No equation to calculate.");
                    continue;
                }

                try
                {
                    double result = numbers[0];

                    for (int i = 0; i < operators.Count; i++)
                    {
                        result = PerformCalculation(result, numbers[i + 1], operators[i]);
                    }

                    Console.WriteLine($"Result: {result}");

                    Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                    string choice = Console.ReadLine().ToLower();

                    if (choice != "yes")
                        repeat = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }

    // Main class
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Calculate();
        }
    }
}
