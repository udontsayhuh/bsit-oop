//REGINE MAE G. HAMBIOL
//BSIT2-2
using System;

namespace Calculator
{
    // Class for addition operation
    class Addition
    {
        public static double Perform(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    // Class for subtraction operation
    class Subtraction
    {
        public static double Perform(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    // Class for multiplication operation
    class Multiplication
    {
        public static double Perform(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    // Class for division operation
    class Division
    {
        public static double Perform(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero. Please enter a number or operator");
                return double.NaN; // Returning NaN (Not a Number) for division by zero
            }
            return num1 / num2;
        }
    }

    // Base class for calculator functionality
    class Calculator
    {
        private double result;

        // Method to perform calculation based on operator
        protected double Calculate(double num1, double num2, char op)
        {
            switch (op)
            {
                case '+':
                    return Addition.Perform(num1, num2);
                case '-':
                    return Subtraction.Perform(num1, num2);
                case '*':
                    return Multiplication.Perform(num1, num2);
                case '/':
                    return Division.Perform(num1, num2);
                default:
                    return double.NaN; // Returning NaN for invalid operator
            }
        }

        // Method to check if input is an operator
        protected bool IsOperator(string input)
        {
            return input == "+" || input == "-" || input == "*" || input == "/";
        }

        // Method to perform calculation and display result
        public void PerformCalculation()
        {
            string userInput = "";

            Console.WriteLine("-----------------------");
            Console.WriteLine(" Calculator Activity");
            Console.WriteLine("-----------------------");

            do
            {
                Console.Write("Enter number or operator (Enter '=' to see the result): ");
                string input = Console.ReadLine();

                if (input == "=")
                {
                    break;
                }

                if (double.TryParse(input, out double number))
                {
                    if (userInput == "")
                        result = number;
                    else
                    {
                        if (!IsOperator(userInput))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid operator.");
                            continue;
                        }
                        result = Calculate(result, number, userInput[0]);
                    }
                }
                else if (IsOperator(input))
                {
                    userInput = input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or operator.");
                    continue;
                }

            } while (true);

            PrintResult();
        }

        // Method to print the result
        public void PrintResult()
        {
            Console.WriteLine($"Result: {result}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Calculator calculator = new Calculator();
                calculator.PerformCalculation();

                Console.Write("Do you want to continue? (YES/NO): ");
                string continueInput = Console.ReadLine();

                if (continueInput.ToUpper() != "YES")
                    break;

            } while (true);

            Console.WriteLine("Thank you for using the calculator!!!");
            Console.ReadKey();
        }
    }
}
