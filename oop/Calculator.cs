using System;

namespace MyCalculator
{
    class Calculator // Demonstrates encapsulation with private members
    {
        private double _accumulator;

        public Calculator() // Constructor
        {
            _accumulator = 0;
        }

        public double Accumulator
        {
            get { return _accumulator; }
            set { _accumulator = value; }
        }

        public double PerformOperation(double number, char operation)
        {
            switch (operation)
            {
                case '+':
                    _accumulator += number;
                    break;
                case '-':
                    _accumulator -= number;
                    break;
                case '*':
                    _accumulator *= number;
                    break;
                case '/':
                    if (number == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                        return double.NaN; // Indicate error by returning NaN
                    }
                    _accumulator /= number;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return double.NaN;
            }
            return _accumulator;
        }
    }

    class CalculatorProgram
    {
        static void Main(string[] args) // Change startup object to this point
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Basic Calculator Program");

            double currentNumber;
            char currentOperation = '+';

            while (true)
            {
                double number = GetUserNumber("Enter a numerical value: ");
                if (double.IsNaN(number)) // Returns true if value is not a number.
                    continue;

                calculator.PerformOperation(number, currentOperation);

                char operation = GetOperation();
                if (operation == '=')
                {
                    Console.WriteLine("Final result: " + calculator.Accumulator);
                    if (!PromptForAnotherCalculation())
                        break;
                    calculator.Accumulator = 0;
                    currentOperation = '+';
                    Console.Clear();
                    continue;
                }

                currentOperation = operation;
            }

            Console.WriteLine("Goodbye");
        }

        static double GetUserNumber(string message)
        {
            double number;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine().Trim();
                if (double.TryParse(input, out number))
                    return number;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static char GetOperation()
        {
            char operation = ' ';
            while (true)
            {
                Console.Write("Enter an operation (+, -, *, /, =): ");
                string input = Console.ReadLine().Trim();
                if (input.Length == 1 && (input[0] == '+' || input[0] == '-' || input[0] == '*' || input[0] == '/' || input[0] == '=')) // Check validity of input
                {
                    operation = input[0];
                    break;
                }
                else
                    Console.WriteLine("Invalid operation. Please enter a valid operation.");
            }
            return operation;
        }

        static bool PromptForAnotherCalculation()
        {
            while (true)
            {
                Console.Write("Perform another calculation? Type 'Yes' or 'No': ");
                string prompt = Console.ReadLine().Trim().ToLower();
                if (prompt == "yes")
                    return true;
                else if (prompt == "no")
                    return false;
                else
                    Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
            }
        }
    }
}
