using System;
using System.Collections.Generic;

// Base class for operations
abstract class Operation
{
    // Abstract method for calculating operation
    public abstract int Calculate(int num1, int num2);
}

// Derived class for addition
class Addition : Operation
{
    // Overrides the Calculate method to perform addition
    public override int Calculate(int num1, int num2)
    {
        return num1 + num2;
    }
}

// Derived class for subtraction
class Subtraction : Operation
{
    // Overrides the Calculate method to perform subtraction
    public override int Calculate(int num1, int num2)
    {
        return num1 - num2;
    }
}

// Derived class for multiplication
class Multiplication : Operation
{
    // Overrides the Calculate method to perform multiplication
    public override int Calculate(int num1, int num2)
    {
        return num1 * num2;
    }
}

// Derived class for division
class Division : Operation
{
    // Overrides the Calculate method to perform division
    // Throws DivideByZeroException if num2 is 0
    public override int Calculate(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
}

class Calculator
{
    static void Main(string[] args)
    {
        do
        {
            // List to store input values and operations
            List<string> inputs = new List<string>();

            // Getting user input until equal sign is entered
            string input;
            do
            {
                input = Console.ReadLine();
                inputs.Add(input);
            } while (input != "=");

            try
            {
                // Calculating result
                int result = EvaluateExpression(inputs);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Asking user if they want to perform another calculation
            Console.Write("Do you want to perform another calculation? (yes/no): ");
            string continueChoice = Console.ReadLine();

            if (continueChoice.ToLower() != "yes")
            {
                break;
            }

        } while (true);
    }

    // Method to evaluate the expression provided by the user
    static int EvaluateExpression(List<string> inputs)
    {
        int result = 0;
        char currentOperator = '+';
        bool isFirst = true;

        foreach (var input in inputs)
        {
            if (input == "=")
                break;

            if (isFirst)
            {
                result = Convert.ToInt32(input);
                isFirst = false;
                continue;
            }

            if (input == "+" || input == "-" || input == "*" || input == "/")
            {
                currentOperator = Convert.ToChar(input);
            }
            else
            {
                int operand = Convert.ToInt32(input);
                switch (currentOperator)
                {
                    case '+':
                        result = result + operand;
                        break;
                    case '-':
                        result = result - operand;
                        break;
                    case '*':
                        result = result * operand;
                        break;
                    case '/':
                        result = result / operand;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operator.");
                }
            }
        }

        return result;
    }
}
