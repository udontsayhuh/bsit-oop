using System;
using System.Collections.Generic;

namespace BasicCalculator
{
    // Base Class: Parent
    public class CalculatorOperations
    {
        // Method for performing arithmetic operation
        public virtual double Operation(double a, double b)
        {
            return a + b; // Addition as default operation
        }
    }

    // Derived Class: Child
    public class Subtraction : CalculatorOperations
    {
        // Inheritance principle by overriding operation method for Subtraction
        public override double Operation(double a, double b)
        {
            return a - b;
        }
    }

    // Derived Class: Child
    public class Multiplication : CalculatorOperations
    {
        // Inheritance principle by overriding operation method for Multiplication
        public override double Operation(double a, double b)
        {
            return a * b;
        }
    }

    // Derived Class: Child
    public class Division : CalculatorOperations
    {
        // Inheritance principle by overriding operation method for Division
        public override double Operation(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN; // Return NaN (Not a Number) for division by zero
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            List<char> operators = new List<char>();
            string input;

            do
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("          Basic Calculator         ");
                Console.WriteLine("===================================\n");

                // Prompt the user to enter the first number
                double number;
                do
                {
                    Console.WriteLine("Enter the first number:");
                } while (!double.TryParse(Console.ReadLine(), out number));

                numbers.Add(number);

                // Loop for entering subsequent numbers and operators
                while (true)
                {
                    // Prompt the user to enter an operator or '=' to calculate
                    Console.WriteLine("Enter an operator (+, -, *, /) or '=' to calculate:");
                    string opInput = Console.ReadLine();

                    if (opInput != "=" && (opInput.Length != 1 || !"+-*/".Contains(opInput[0]))) // Validating operator input
                    {
                        Console.WriteLine("Invalid input! Please enter a valid operator or '=' to calculate.");
                        continue; // Continue prompting the user until a valid operator or '=' is entered
                    }

                    // If the input is '=', calculate the result
                    if (opInput == "=")
                    {
                        CalculateResult(numbers, operators);
                        break;
                    }

                    operators.Add(opInput[0]);

                    // Prompt the user to enter the next number
                    do
                    {
                        Console.WriteLine("Enter the next number:");
                    } while (!double.TryParse(Console.ReadLine(), out number));

                    numbers.Add(number);
                }

                Console.WriteLine("Do you want to continue (Y/N): ");
                input = Console.ReadLine();
            } while (input.ToUpper() == "Y");
        }

        static void CalculateResult(List<double> numbers, List<char> operators)
        {
            // Perform multiplication and division first
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '*' || operators[i] == '/')
                {
                    double result = PerformOperation(numbers[i], numbers[i + 1], operators[i]);
                    // Replace the first operand and the operator with the result
                    numbers[i] = result;
                    // Remove the second operand and the operator
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    // Decrement the index to account for the removed items
                    i--;
                }
            }

            // Perform addition and subtraction
            double finalResult = numbers[0];
            for (int i = 0; i < operators.Count; i++)
            {
                finalResult = PerformOperation(finalResult, numbers[i + 1], operators[i]);
            }

            Console.WriteLine($"Result: {finalResult}");
        }

        static double PerformOperation(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return new CalculatorOperations().Operation(a, b);
                case '-':
                    return new Subtraction().Operation(a, b);
                case '*':
                    return new Multiplication().Operation(a, b);
                case '/':
                    return new Division().Operation(a, b);
                default:
                    Console.WriteLine("Error: Invalid Operator.");
                    return double.NaN; // Return NaN (Not a Number) for invalid operator
            }
        }
    }
}