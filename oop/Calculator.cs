using System;

namespace oop;

// Calculator class
abstract class Operation
{
    // Abstract method to perform the operation
    public abstract double OpCompute(double num1, double num2);

}

// Derived class for addition operation
class Addition : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Derived class for subtraction operation
class Subtraction : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        return num1 - num2;
    }
}

// Derived class for multiplication operation
class Multiplication : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        return num1 * num2;
    }
}

// Derived class for division operation
class Division : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return double.NaN;
        }
        else
        {
            return num1 / num2;
        }
    }
}

class Calculator
{
    // Method to perform the selected operation
    public double Compute(double num1, double num2, Operation operation)
    {
        return operation.OpCompute(num1, num2);
    }
    public char GetOperatorChoice()
    {
        // Get user choice of operation
        char choice;

        // Keep prompting the user until a valid input is provided
        while (true)
        {
            // Display menu of operations
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("[+] ADDITION");
            Console.WriteLine("[-] SUBTRACTION");
            Console.WriteLine("[*] MULTIPLICATION");
            Console.WriteLine("[/] DIVISION");
            Console.Write("\nEnter your choice: ");

            // Try to parse the input to a char
            if (!char.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input.");
                continue; // Restart the loop
            }

            // Check if the input is one of the specified operators
            if (choice == '+' || choice == '-' || choice == '/' || choice == '*')
            {
                return choice; // Exit the loop if a valid input is provided
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter one of the specified operators: +, -, /, *.");
            }
        }
    }

    class CalculatorAssignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("                    WELCOME TO C# CALCULATOR\n");
            Console.WriteLine("--------------------------------------------------------------");

            Calculator calculator = new Calculator();
            while (true)
            {

                // Get user input for the first number
                Console.Write("Enter the first number: ");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                    Environment.Exit(0);
                }
                char choice = calculator.GetOperatorChoice();
                // Get user input for the second number
                Console.Write("Enter the second number: ");
                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                    Environment.Exit(0);
                }
                // Perform the selected operation and display the result
                Operation operation;
                double result = 0;
                switch (choice)
                {
                    case '+':
                        operation = new Addition();
                        result = calculator.Compute(num1, num2, operation);
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case '-':
                        operation = new Subtraction();
                        result = calculator.Compute(num1, num2, operation);
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case '*':
                        operation = new Multiplication();
                        result = calculator.Compute(num1, num2, operation);
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case '/':
                        operation = new Division();
                        result = calculator.Compute(num1, num2, operation);
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        break;
                    default:
                        operation = null;
                        break;
                }
                Console.WriteLine("Do you want to do another calculation? (Y/N).");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain != "y")
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("                    THANK YOU FOR USING C# CALCULATOR\n                            BY: CARL BERGADO");
                    Console.WriteLine("--------------------------------------------------------------");
                    break;
                }
            }
        }
    }
}
