using System;

namespace CalculatorApp
{
    // Class to perform basic arithmetic operations on multiple numbers
    class Calculator
    {
        private double[] numbers;
        private char[] operations;

        // Constructor to initialize class variables
        public Calculator()
        {
            numbers = new double[5];
            operations = new char[4]; // We need 4 operations between 5 numbers
        }

        // Method to input numbers and select operations from the user
        public void InputNumbersAndOperators()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Number {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }

                if (i < 4)
                {
                    Console.Write("Enter Operator (+, -, *, /): ");
                    operations[i] = Console.ReadLine()[0];
                }
            }
        }

        // Method to perform the selected arithmetic operations
        public void PerformCalculations()
        {
            // Compute sum of integers
            int sumIntegers = 0;
            for (int i = 0; i < 5; i++)
            {
                sumIntegers += (int)numbers[i]; // Casting to int for summing integers
            }
            Console.WriteLine($"Sum of integers: {sumIntegers}");

            // Compute sum of doubles
            double sumDoubles = 0;
            for (int i = 0; i < 5; i++)
            {
                sumDoubles += numbers[i]; // Summing doubles
            }
            Console.WriteLine($"Sum of doubles: {sumDoubles}");

            // Compute product of the sums
            double product = sumIntegers * sumDoubles;
            Console.WriteLine($"Product of sums: {product}");

            // Perform the sequence of operations on the numbers
            double result = numbers[0];
            for (int i = 0; i < 4; i++)
            {
                switch (operations[i])
                {
                    case '+':
                        result += numbers[i + 1];
                        break;
                    case '-':
                        result -= numbers[i + 1];
                        break;
                    case '*':
                        result *= numbers[i + 1];
                        break;
                    case '/':
                        if (numbers[i + 1] != 0)
                            result /= numbers[i + 1];
                        else
                            Console.WriteLine("Cannot divide by zero.");
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }
            }

            Console.WriteLine($"Result: {result}");
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

                calculator.InputNumbersAndOperators();
                calculator.PerformCalculations();

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
