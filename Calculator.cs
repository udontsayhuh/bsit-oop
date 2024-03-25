using System;

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
                Console.WriteLine("Enter a number:");
                string input1 = Console.ReadLine();

                if (!IsValidNumber(input1))
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                    return;
                }

                double num1 = double.Parse(input1);

                Console.WriteLine("Enter one of the four fundamental mathematical operators (+-*/):");
                char op = char.Parse(Console.ReadLine());

                if (!IsValidOperator(op))
                {
                    Console.WriteLine("Invalid operator. Please enter one of the four fundamental mathematical operators.");
                    return;
                }

                Console.WriteLine("Enter another number:");
                string input2 = Console.ReadLine();

                if (!IsValidNumber(input2))
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                    return;
                }

                double num2 = double.Parse(input2);

                try
                {
                    double result = PerformCalculation(num1, num2, op);
                    Console.WriteLine($"Result: {result}");

                    Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                    string choice = Console.ReadLine().ToLower();

                    if (choice != "yes")
                        repeat = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return;
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
