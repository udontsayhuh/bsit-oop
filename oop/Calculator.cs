using System;
using System.Collections.Generic;

abstract class Operation
{
    public abstract int Calculate(int num1, int num2);
}

class Addition : Operation
{
    public override int Calculate(int num1, int num2) => num1 + num2;
}

class Subtraction : Operation
{
    public override int Calculate(int num1, int num2) => num1 - num2;
}

class Multiplication : Operation
{
    public override int Calculate(int num1, int num2) => num1 * num2;
}

class Division : Operation
{
    public override int Calculate(int num1, int num2)
    {
        if (num2 == 0)
            throw new DivideByZeroException("Cannot divide by zero.");

        return num1 / num2;
    }
}

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            List<int> numbers = new List<int>();
            List<string> operations = new List<string>();

            while (true)
            {
                Console.Write("Enter a number: ");
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                numbers.Add(num);

                if (numbers.Count > operations.Count) // Check if there's enough numbers for an operation
                {
                    string operation;
                    do
                    {
                        Console.Write("Choose an operation (+, -, *, /, =): ");
                        operation = Console.ReadLine();

                        if (!IsValidOperation(operation))
                            Console.WriteLine("Invalid operation. Please choose +, -, *, /, or =.");
                        else if (operation == "=" && numbers.Count < 2)
                            Console.WriteLine("Insufficient numbers to calculate. Please enter at least two numbers.");
                        else
                        {
                            operations.Add(operation);
                            break;
                        }
                    } while (true);

                    if (operation == "=")
                        break;
                }
            }

            if (numbers.Count < 2)
                continue;

            int result = numbers[0];
            try
            {
                for (int i = 0; i < operations.Count; i++)
                {
                    if (operations[i] == "=")
                        break;

                    Operation op = GetOperation(operations[i]);
                    result = op.Calculate(result, numbers[i + 1]);
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("----------------------------------------------");
            Console.Write("Do you want to perform another calculation? (Y/N): ");
            string choice = Console.ReadLine();
            if (!IsAffirmative(choice))
                break;
        }
    }

    static bool IsValidOperation(string operation) =>
        operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "=";

    static bool IsAffirmative(string input) =>
        input?.Trim().ToLower() == "y" || input?.Trim().ToLower() == "yes";

    static Operation GetOperation(string operation)
    {
        switch (operation)
        {
            case "+":
                return new Addition();
            case "-":
                return new Subtraction();
            case "*":
                return new Multiplication();
            case "/":
                return new Division();
            default:
                throw new ArgumentException("Invalid operation");
        }
    }
}
