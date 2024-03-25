using System;

namespace OOP_works
{
    // Abstract class for different arithmetic operations
    abstract class Operation
    {
        public abstract double Calculate(double num1, double num2);
    }

    // Concrete class for addition operation
    class Addition : Operation
    {
        public override double Calculate(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    // Concrete class for subtraction operation
    class Subtraction : Operation
    {
        public override double Calculate(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    // Concrete class for multiplication operation
    class Multiplication : Operation
    {
        public override double Calculate(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    // Concrete class for division operation
    class Division : Operation
    {
        public override double Calculate(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("Cannot divide by zero!");
        }
    }

    // Calculator class encapsulating the calculator logic
    class Calculator
    {
        public double PerformOperation(Operation operation, double num1, double num2)
        {
            return operation.Calculate(num1, num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            bool keepCalculating = true;

            while (keepCalculating)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter the First number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the Second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Operation operation;

                Console.WriteLine("Choose an operation:");
                Console.WriteLine(">> Addition (+)");
                Console.WriteLine(">> Subtraction (-)");
                Console.WriteLine(">> Multiplication (*)");
                Console.WriteLine(">> Division (/)");

                Console.Write("Enter the symbol of your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "+":
                        operation = new Addition();
                        break;
                    case "-":
                        operation = new Subtraction();
                        break;
                    case "*":
                        operation = new Multiplication();
                        break;
                    case "/":
                        operation = new Division();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice!");
                        continue;
                }

                try
                {
                    double result = calculator.PerformOperation(operation, num1, num2);
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }

                bool validChoice = false;
                while (!validChoice)
                {
                    Console.WriteLine("Do you want to Calculate again (y/n)?");
                    string contchoice = Console.ReadLine().ToLower();

                    if (contchoice == "n" || contchoice == "no")
                    {
                        keepCalculating = false;
                        validChoice = true;
                        Console.WriteLine("Calculator closed.");
                    }
                    else if (contchoice == "y" || contchoice == "yes")
                    {
                        validChoice = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Choice! Please type 'y' or 'n'...");
                    }
                }
            }
        }
    }
}
