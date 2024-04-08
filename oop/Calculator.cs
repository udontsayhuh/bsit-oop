using System;

namespace MyCalculator
{
    class Calculator // Demonstrates Encapsulation with private members
    {
        private double accumulator;

        public Calculator() // Constructor
        {
            accumulator = 0;
        }

        public double Accumulator
        {
            get { return accumulator; }
            set { accumulator = value; }
        }

        public double PerformOperation(double number, char op)
        {
            switch (op)
            {
                case '+':
                    accumulator += number;
                    break;
                case '-':
                    accumulator -= number;
                    break;
                case '*':
                    accumulator *= number;
                    break;
                case '/':
                    if (number == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                        return double.NaN; // Indicate error by returning NaN
                    }
                    accumulator /= number;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return double.NaN;
            }
            return accumulator;
        }
    }

    class CalculatorProgram
    {
        static void Main(string[] args) // Change startup object to this point
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Basic Calculator Program");

            double currentNumber;
            char currentOp = '+';

            while (true)
            {
                double num = GetUserNumber("Enter a numerical value: ");
                if (num == double.NaN) 
                    continue;

                calculator.PerformOperation(num, currentOp);

                char op = GetOperation();
                if (op == '=')
                {
                    Console.WriteLine("Final result: " + calculator.Accumulator);
                    if (!PromptForAnotherCalculation())
                        break;
                    calculator.Accumulator = 0;
                    currentOp = '+';
                    Console.Clear();
                    continue;
                }

                currentOp = op;
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
            char op = ' ';
            while (true)
            {
                Console.Write("Enter an operation (+, -, *, /, =): ");
                string input = Console.ReadLine().Trim();
                if (input.Length == 1 && (input[0] == '+' || input[0] == '-' || input[0] == '*' || input[0] == '/' || input[0] == '=')) // Check validity of input
                {
                    op = input[0];
                    break;
                }
                else
                    Console.WriteLine("Invalid operation. Please enter a valid operation.");
            }
            return op;
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
