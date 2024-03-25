﻿using System;

namespace CalculatorApp
{
    // Encapsulation and Inheritance: Abstract class defining a contract for binary operations
    abstract class BinaryOperation
    {
        // Encapsulation: Method to perform the operation
        public abstract float Calculate(float num1, float num2);
    }

    // Inheritance: Concrete operation classes implementing the BinaryOperation abstract class
    class Addition : BinaryOperation
    {
        // Encapsulation: Override method to perform addition
        public override float Calculate(float num1, float num2)
        {
            return num1 + num2;
        }
    }

    class Subtraction : BinaryOperation
    {
        public override float Calculate(float num1, float num2)
        {
            return num1 - num2;
        }
    }

    class Multiplication : BinaryOperation
    {
        public override float Calculate(float num1, float num2)
        {
            return num1 * num2;
        }
    }

    class Division : BinaryOperation
    {
        public override float Calculate(float num1, float num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                return 0;
            }
            return num1 / num2;
        }
    }

    // Calculator class encapsulating the calculation logic
    class Calculator
    {
        public float PerformOperation(BinaryOperation operation, float num1, float num2)
        {
            return operation.Calculate(num1, num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            char choice;

            do
            {
                // Prompt user for input
                float num1, num2;
                char operationSymbol;

                Console.WriteLine("Enter the first number:");
                while (!float.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                }

                Console.WriteLine("Enter the operation (+, -, *, /):");
                while (!char.TryParse(Console.ReadLine(), out operationSymbol) ||
                       (operationSymbol != '+' && operationSymbol != '-' && operationSymbol != '*' && operationSymbol != '/'))
                {
                    Console.WriteLine("Invalid operation. Please choose from '+', '-', '*', or '/'.");
                }

                Console.WriteLine("Enter the second number:");
                while (!float.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                }

                // Select operation based on user input
                BinaryOperation operation = null;
                switch (operationSymbol)
                {
                    case '+':
                        operation = new Addition();
                        break;
                    case '-':
                        operation = new Subtraction();
                        break;
                    case '*':
                        operation = new Multiplication();
                        break;
                    case '/':
                        operation = new Division();
                        break;
                }

                // Perform calculation
                if (operation != null)
                {
                    float result = calculator.PerformOperation(operation, num1, num2);
                    Console.WriteLine("Result: " + result);
                }

                // Ask user if they want to perform another calculation
                Console.WriteLine("Do you want to perform another calculation? (Y/N)");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (char.ToUpper(choice) == 'Y');
        }
    }
}
