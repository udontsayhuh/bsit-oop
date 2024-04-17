using System;
using System.Collections.Generic;

namespace MyCalculatorApp
{
    // Class representing a calculator
    class Calculator
    {
        /* Method for addition and Encapsulation - methods encapsulate behavior */
        public double Add(double x, double y) 
        {
            return x + y;
        }

        /* Method for subtraction and Encapsulation - methods encapsulate behavior */
        public double Subtract(double x, double y) 
        {
            return x - y;
        }

        /* Method for multiplication and Encapsulation - methods encapsulate behavior */
        public double Multiply(double x, double y) 
        {
            return x * y;
        }

        /* Method for division and Encapsulation - methods encapsulate behavior */
        public double Divide(double x, double y) 
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return x / y;
        }
    }

    // Main program class
    class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(); // Instantiation - Creating an object of class Calculator.

            bool performAnotherCalculation = true;

            while (performAnotherCalculation)
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("* \t\tCALCULATOR\t\t *");
                Console.WriteLine("**************************************");

                List<double> numbers = new List<double>();
                List<char> operators = new List<char>();

                while (true)
                {
                    double number = isValid("Enter a number: ");
                    numbers.Add(number);

                    char choice = GetOperator();

                    if (choice == '=')
                    {
                        if (numbers.Count == operators.Count + 1)
                        {
                            double result = CalculateExpression(calc, numbers, operators);
                            Console.WriteLine($"Result: {result}\n");

                            performAnotherCalculation = AskAnotherCalculation();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid expression: Missing operator or number.");
                            numbers.Clear();
                            operators.Clear();
                            continue;
                        }
                    }

                    operators.Add(choice);
                }
            }
        }

        private static double isValid(string message) // checking if input is a number, if not; it is invalid
        {
            double number;
            bool isTrue;
            do
            {
                Console.Write(message);
                isTrue = double.TryParse(Console.ReadLine(), out number);
                if (!isTrue)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.\n");
                    //ClearScreen();
                }
            } while (!isTrue);
            return number;
        }

        private static char GetOperator() // getting the operator and checks if input is an operator, else it is invalid
        {
            Console.WriteLine("Choose Operator [ +  - / * = ] : ");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (choice != '+' && choice != '-' && choice != '*' && choice != '/' && choice != '=')
            {
                Console.WriteLine("Invalid operator. Please try again.\n");
                //ClearScreen();
                return GetOperator();
            }

            return choice;
        }

        private static bool AskAnotherCalculation() 
        {
            Console.WriteLine("Do you want to perform another calculation? (yes / no): ");
            string input = Console.ReadLine()!.Trim().ToLower(); // converting capitalize input into lowercase
            ClearScreen();
            return input == "yes" || input == "y";
            //ClearScreen();
        }

        private static double CalculateExpression(Calculator calculateNumber, List<double> numbers, List<char> operators) // calculation once "=" is entered
        {
            double result = numbers[0];
            int operatorIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                switch (operators[operatorIndex])
                {
                    case '+':
                        result = calculateNumber.Add(result, numbers[i]);
                        break;
                    case '-':
                        result = calculateNumber.Subtract(result, numbers[i]);
                        break;
                    case '*':
                        result = calculateNumber.Multiply(result, numbers[i]);
                        break;
                    case '/':
                        try
                        {
                            result = calculateNumber.Divide(result, numbers[i]);
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine($"Error: {e.Message}");
                            return 0; // Return 0 if division by zero occurs
                        }
                        break;
                }
                operatorIndex++;
            }

            return result;
        }
        private static void ClearScreen() // Abstraction - Hides the details of clearing the screen., user defined getch() + system("cls") like
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}