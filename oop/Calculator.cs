//Code to perform basic arithmetic operations(Calculator)
//Mier, Elisha Reign
//BSIT 2-2

using System;
using System.Collections.Generic;

// Parent class for operations
abstract class Operation
{
    public abstract double PerformOperation(double num1, double num2);
}

// Addition operation
class Addition : Operation
{
    public override double PerformOperation(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Subtraction operation
class Subtraction : Operation
{
    public override double PerformOperation(double num1, double num2)
    {
        return num1 - num2;
    }
}

// Multiplication operation
class Multiplication : Operation
{
    public override double PerformOperation(double num1, double num2)
    {
        return num1 * num2;
    }
}

// Division operation
class Division : Operation
{
    public override double PerformOperation(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return num1 / num2;
    }
}

class Calculator
{
    // Method to get user input, validate, and display output
    public void PerformCalculation()
    {
        List<double> numbers = new List<double>();
        List<char> operators = new List<char>();

        Console.WriteLine("\nEnter numbers and operators alternately, end with '=':");

        bool expectNumber = true; // Input should be a number

        // Loop for user input
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "=")
            {
                break;
            }

            double number;
            if (double.TryParse(input, out number))
            {
                if (expectNumber)
                {
                    numbers.Add(number);
                    expectNumber = false; // Input should be an operator
                }
                else
                {
                    Console.WriteLine("Invalid input. Input an operator.");
                }
            }
            else if (input.Length == 1 && "+-*/".IndexOf(input[0]) != -1)
            {
                if (!expectNumber)
                {
                    operators.Add(input[0]);
                    expectNumber = true; // Next input should be a number
                }
                else
                {
                    Console.WriteLine("Invalid input. Input a number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        // Check if the expression is incomplete
        if (numbers.Count != operators.Count + 1)
        {
            Console.WriteLine("Invalid input. Input an operator.");
            return;
        }

        // Perform calculation of the expression
        double result = numbers[0];
        for (int i = 0; i < operators.Count; i++)
        {
            char op = operators[i];
            double nextNumber = numbers[i + 1];
            result = PerformOperation(result, nextNumber, op);
        }

        Console.WriteLine($"Result: {result}"); // Display result

        // Prompt the user if they want to perform another calculation
        Console.Write("\nDo you want to perform another calculation? (y/n): ");
        string response = Console.ReadLine().ToLower();
        if (response == "n")
        {
            Environment.Exit(0);
        }
        else if (response != "y")
        {
            Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
        }
    }

    // Method to perform arithmetic operation based on operator
    private double PerformOperation(double num1, double num2, char op)
    {
        Operation operation;
        switch (op)
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
            default:
                throw new ArgumentException("Invalid operator");
        }

        return operation.PerformOperation(num1, num2);
    }
}

// Main 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Basic Arithmetic Calculator");
        Console.WriteLine("----------------------------");

        Calculator calculator = new Calculator();
        while (true)
        {
            calculator.PerformCalculation();
        }
    }
}
