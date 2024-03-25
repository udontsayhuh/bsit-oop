using System;

namespace oop
{
    abstract class Operation // Abstract class for Pillars.
    {
        // Protected property.
        protected int Num1 { get; }
        protected int Num2 { get; }
        protected Operation (int num1, int num2) // For Operation Class.
        {
            // Initializing Num with value.
            Num1 = num1; 
            Num2 = num2;
        }

        public abstract int PerformOperation(); // Abstract Method.
    }

    // Inheritance for the Pillars.
    class Addition : Operation // Defining class that inherits from Operation.
    {
        public Addition(int num1, int num2) : base(num1, num2) { } // Constructor for this class.

        public override int PerformOperation() {
            return Num1 + Num2; // Returning the result with formula.
        }

    }
    class Subtraction : Operation
    {
        public Subtraction(int num1, int num2) : base(num1, num2) { }

        public override int PerformOperation()
        {
            return Num1 - Num2;
        }

    }
    class Multiplication : Operation
    {
        public Multiplication(int num1, int num2) : base(num1, num2) { }

        public override int PerformOperation()
        {
            return Num1 * Num2;
        }
        //  I don't include the division because it needs to return a value, and I just want it to "break;", but it is not working too.
    }
    class Calculator // Class for the Calculator.
    {
        static void Main(string[] args) // Entry point.
        {
            while (true) // I prefer the while loop because I don't want to terminate the program if the user enters the wrong input.
            {
                Console.Write("\nEnter first number: "); // User will enter the first number.
                int num1;
                while (!int.TryParse(Console.ReadLine(), out num1)) // It will loop until the input is correct.
                {
                    Console.WriteLine("Invalid input. Please enter a valid number."); // It will display if it is wrong.
                    Console.Write("Enter first number: ");
                }

                Console.Write("Enter second number: "); // Second number.
                int num2;
                while (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter second number: ");
                }

                Console.Write("Enter symbol (+, -, *, /): "); // Symbol
                string symbol = Console.ReadLine();
                while (true) // While loop for Symbol.
                {
                    if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/") // It will check if the input is valid.
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid symbol.");
                        Console.Write("Enter symbol (+, -, *, /): ");
                        symbol = Console.ReadLine();
                    }
                }

                Operation operation; // Declaring a variable of type Operation from the abstract class.
                int result = 0; // Initialize result varaible.

                // Switch-Case Statement for the symbols.
                switch (symbol)
                {
                    case "+":
                        operation = new Addition(num1, num2); // Creating an instance for the Addition Class.
                        result = operation.PerformOperation(); // Performing the addition operation (from the abstract class).
                        break; // Break
                    case "-": // Subtraction
                        operation = new Subtraction(num1, num2);
                        result = operation.PerformOperation();
                        break;
                    case "*": // Multiplication
                        operation = new Multiplication(num1, num2);
                        result = operation.PerformOperation();
                        break;
                    case "/": // Division
                        if (num2 != 0) // if and else statement for the result, and if num2 is 0, it will display the else statement. 
                        {
                            result = num1 / num2;
                            Console.WriteLine("Division: " + result);
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid symbol."); // If the user inputs an invalid symbol.
                        continue;
                }

                {
                    if (symbol != "/" || num2 != 0) // It will check if the num2 in the division is not zero; if it is, then it will not print the result.
                    {
                        Console.WriteLine($"Result of {num1} {symbol} {num2} is {result}");
                    }
                }
                while (true) // While loop for continuing.
                {
                    Console.Write("\nDo you want to continue (yes/no): ");
                    string value = Console.ReadLine();
                    if (value.ToLower() == "yes")
                    {
                        break;
                    }
                    else if (value.ToLower() == "no")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input: ");
                    }
                }
            }
        }
    }
}