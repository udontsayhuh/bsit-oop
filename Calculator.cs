using System;

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
        // Main method where the program execution begins
        do
        {
            int num1, num2;

            // Getting the first number with error handling
            Console.Write("Enter the first number: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter the first number: ");
            }

            // Getting the second number with error handling
            Console.Write("Enter the second number: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter the second number: ");
            }

            string operation;
            Operation op;

            // Getting the operation choice
            do
            {
                Console.WriteLine("Choose an operation: +, -, *, /");
                operation = Console.ReadLine();
                op = GetOperation(operation);

                if (op == null)
                {
                    Console.WriteLine("Invalid operation. Please try again.");
                }

            } while (op == null);

            // Performing the calculation
            int result = op.Calculate(num1, num2);
            Console.WriteLine($"Result: {result}");

            // Asking user if they want to perform another calculation
            Console.Write("Do you want to perform another calculation? (yes/no): ");
            string continueChoice = Console.ReadLine();

            if (continueChoice.ToLower() != "yes")
            {
                break;
            }

        } while (true);
    }

    // Method to get the appropriate operation based on user input
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
