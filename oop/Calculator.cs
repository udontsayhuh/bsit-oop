using System;
using System.Collections.Generic;

// Base class for operations
abstract class Operation
{
    public abstract int Calculate(int num1, int num2);
}

// Derived class for addition
class Addition : Operation
{
    public override int Calculate(int num1, int num2)
    {
        return num1 + num2;
    }
}

// Derived class for subtraction
class Subtraction : Operation
{
    public override int Calculate(int num1, int num2)
    {
        return num1 - num2;
    }
}

// Derived class for multiplication
class Multiplication : Operation
{
    public override int Calculate(int num1, int num2)
    {
        return num1 * num2;
    }
}

// Derived class for division
class Division : Operation
{
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
        bool exit = false;

        do
        {
            List<int> numbers = new List<int>();
            List<string> operations = new List<string>();

            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int num))
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

                        if (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "=")
                        {
                            Console.WriteLine("Invalid operation. Please choose +, -, *, /, or =.");
                        }
                        else if (operation == "=" && numbers.Count < 2)
                        {
                            Console.WriteLine("Insufficient numbers to calculate. Please enter at least two numbers.");
                        }
                        else
                        {
                            operations.Add(operation);
                            break;
                        }
                    } while (true);

                    if (operation == "=")
                    {
                        break;
                    }
                }
            }

            // Perform the calculations if there are at least two numbers
            if (numbers.Count >= 2)
            {
                int result = numbers[0];
                for (int i = 0; i < operations.Count; i++)
                {
                    Operation op;
                    if (operations[i] == "=")
                    {
                        break;
                    }
                    else
                    {
                        op = GetOperation(operations[i]);
                    }
                    result = op.Calculate(result, numbers[i + 1]);
                }

                Console.WriteLine($"Result: {result}");
            }

            Console.WriteLine("----------------------------------------------");
            Console.Write("Do you want to perform another calculation? (Y/N): ");
            string choice = Console.ReadLine();
            if (choice.ToLower() != "y" && choice.ToLower() != "yes")
            {
                exit = true;
            }
        } while (!exit);
    }

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
