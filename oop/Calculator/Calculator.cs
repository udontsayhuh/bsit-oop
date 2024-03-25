using System;
using System.Threading;

namespace Calculator
{
    abstract class HomePage {
        public abstract void DisplayOperations();
    }

    // Encapsulation: All functionalities are encapsulated within the Calculator class.
    class Calculator : HomePage
    {
        // Abstraction: Internal implementation details are abstracted away from the user.

        // Base abstract class for operations
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
                    throw new ArgumentException("Cannot divide by zero");
                }
                return num1 / num2;
            }
        }

        // Display operations
        public override void DisplayOperations() {
            Console.WriteLine(" ===============================================");
            Console.WriteLine("|                  CALCULATOR                   |");
            Console.WriteLine(" ===============================================");
            Console.WriteLine("|                       |                       |");
            Console.WriteLine("|         ( + )         |         ( - )         |");
            Console.WriteLine("|                       |                       |");
            Console.WriteLine("|         ( x )         |         ( / )         |");
            Console.WriteLine("|                       |                       |");
            Console.WriteLine(" ===============================================");
        }

        static void ClearConsole()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.WindowWidth * Console.WindowHeight));
            Console.SetCursorPosition(0, 0);
        }

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            while (true) // Loop to allow multiple calculations
            {
                try
                {
                    calculator.DisplayOperations(); // this displays the operations
                    Console.Write("\nEnter the first number: ");
                    // Prompt user for input and convert it to double
                    double num1;
                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        throw new ArgumentException("Invalid input. It must be a valid number.");
                    }

                    Console.Write("Enter the operator (+, -, *, /): ");
                    string opInput = Console.ReadLine();
                    if (string.IsNullOrEmpty(opInput) || opInput.Length != 1)
                    {
                        throw new ArgumentException("Invalid input. It must be a valid operator.");
                    }
                    
                    char opChar = opInput[0];

                    // Check if operator is one of the valid ones
                    if (opChar != '+' && opChar != '-' && opChar != '*' && opChar != '/')
                    {
                        throw new ArgumentException("Invalid input. It must be a valid operator.");
                    }

                    string op = opChar.ToString(); // Convert char to string

                    Console.Write("Enter the second number: ");
                    // Prompt user for input and convert it to double
                    double num2;
                    if (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        throw new ArgumentException("Invalid input. It must be a valid number.");
                    }

                    double result = 0;

                    // Perform calculation based on operator using polymorphism
                    Operation operation;
                    switch (op)
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
                            throw new ArgumentException("Invalid input. Invalid operator");
                    }

                    result = operation.PerformOperation(num1, num2);

                    // display the result
                    Console.WriteLine("Calculating...");
                    Thread.Sleep(1000);
                    Console.Write("\nRESULT: ");
                    Console.WriteLine($"{num1} {op} {num2} = {result}");

                    Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                    string choice = Console.ReadLine().ToLower();
                    if (choice != "yes")
                    {
                        // Clear console and exit loop if user does not want to continue
                        ClearConsole();
                        Console.Write("Program exiting in ");
                        for (int i = 3; i > 0; i--)
                        {
                            Thread.Sleep(1000);
                            Console.Write(i + " ");
                        }
                        Console.WriteLine("\nEnd of Program.");
                        break;
                    }
                    else
                    {
                        // Clear console and continue loop if user wants to continue
                        Console.WriteLine("\nLoading...");
                        Thread.Sleep(2000);
                        ClearConsole();
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    // Terminate the program if there's an error
                    Console.Write("\nProgram exiting in ");
                    for (int i = 3; i > 0; i--)
                    {
                        Thread.Sleep(1000);
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("\nEnd of Program.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    // Terminate the program if there's an error
                    Console.Write("\nProgram exiting in ");
                    for (int i = 3; i > 0; i--)
                    {
                        Thread.Sleep(1000);
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("\nEnd of Program.");
                    break;
                }
            }
        }
    }
}