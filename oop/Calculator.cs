using System;

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
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            string operation;
            Operation op;
            do
            {
                Console.Write("Choose an operation: +, -, *, /: ");
                operation = Console.ReadLine();
                op = GetOperation(operation);
                if (op == null)
                {
                    Console.WriteLine($"Invalid operation: {operation}");
                }
            } while (op == null);

            int result;
            try
            {
                result = op.Calculate(num1, num2);
                Console.WriteLine($"Result: {result}");

                Console.WriteLine("----------------------------------------------");
                Console.Write("Do you want to perform another calculation? (Y/N): ");
                string choice = Console.ReadLine();
                if (choice.ToLower() != "y" && choice.ToLower() != "yes")
                {
                    exit = true;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Division by zero error: {ex.Message}");

                Console.WriteLine("----------------------------------------------");
                Console.Write("Do you want to perform another calculation? (Y/N): ");
                string choice = Console.ReadLine();
                if (choice.ToLower() != "y" && choice.ToLower() != "yes")
                {
                    exit = true;
                }
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
                return null;
        }
    }
}
