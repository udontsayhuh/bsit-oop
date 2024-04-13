using System;

namespace CalculatorApp
{
    // Class to perform basic arithmetic operations on multiple numbers
    class Calculator
    {
        private double num1;
        private double num2;
        private double num3;
        private double num4;
        private double num5;
        private char operation;

        // Constructor to initialize class variables
        public Calculator()
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            num4 = 0;
            num5 = 0;
            operation = ' ';
        }

        // Method to input numbers and select operation from the user
        public void InputNumbersAndOperator()
        {
            Console.Write("Enter First Number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.Write("Enter Operator (+, -, *, /): ");
            operation = Console.ReadLine()[0];

            Console.Write("Enter Second Number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.Write("Enter Operator (+, -, *, /): ");
            operation = Console.ReadLine()[0];

            Console.Write("Enter Third Number: ");
            if (!double.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.Write("Enter Operator (+, -, *, /): ");
            operation = Console.ReadLine()[0];

            Console.Write("Enter Fourth Number: ");
            if (!double.TryParse(Console.ReadLine(), out num4))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.Write("Enter Operator (+, -, *, /): ");
            operation = Console.ReadLine()[0];

            Console.Write("Enter Fifth Number: ");
            if (!double.TryParse(Console.ReadLine(), out num5))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
        }

        // Method to perform the selected arithmetic operation
        public void PerformCalculation()
        {
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2 + num3 + num4 + num5;
                    Console.WriteLine($"Result: {result}");
                    break;
                case '-':
                    result = num1 - num2 - num3 - num4 - num5;
                    Console.WriteLine($"Result: {result}");
                    break;
                case '*':
                    result = num1 * num2 * num3 * num4 * num5;
                    Console.WriteLine($"Result: {result}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2 / num3 / num4 / num5;
                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }

    // Main program class to run the calculator
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Welcome to The Calculator");

                calculator.InputNumbersAndOperator();
                calculator.PerformCalculation();

                Console.Write("Do you want to perform another calculation? (Y/N): ");
                char choice = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (choice != 'Y')
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
