using System;
using System.Threading; // Importing the System.Threading namespace for using Thread.Sleep()

namespace OOP_works
{
    // Abstract class for different arithmetic operations
    abstract class Operation
    {
        public abstract double Calculate(double num1, double num2); // Abstract method for calculation
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
                throw new DivideByZeroException("WARNING: Cannot divide by zero!"); // Throw exception for division by zero
        }
    }

    // Calculator class encapsulating the calculator logic
    class Calculator
    {
        public double PerformOperation(Operation operation, double num1, double num2)
        {
            return operation.Calculate(num1, num2); // Perform calculation based on selected operation
        }
    }

    class Program
    {
        static void Main(string[] args)
        {   
            Calculator calculator = new Calculator(); // Instantiate Calculator object

            bool keepCalculating = true;

            while (keepCalculating)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("==============================");
                Console.WriteLine("||        CALCULATOR        ||");
                Console.WriteLine("==============================");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("    ");
                Console.Write("> Enter the First number: ");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1)) // Validate and parse user input for the first number
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Invalid input! Program Terminated. =");
                    return;
                }

                Console.Write("> Enter the Second number: ");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2)) // Validate and parse user input for the second number
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Invalid input! Program Terminated. =");
                    return;
                }

                Operation operation;
                Console.WriteLine("    ");
                Console.WriteLine("————————————————————————————");
                Console.WriteLine("|   Choose an operation:    |");
                Console.WriteLine("|   >> Addition (+)         |");
                Console.WriteLine("|   >> Subtraction (-)      |");
                Console.WriteLine("|   >> Multiplication (*)   |");
                Console.WriteLine("|   >> Division (/)         |");
                Console.WriteLine("————————————————————————————");

                Console.WriteLine(" ");
                Console.Write("Enter the symbol of your choice: ");
                string choice = Console.ReadLine(); // Get user's choice for the operation

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
                        Console.WriteLine("= WARNING: Invalid choice! Program Restarting =");
                        int milliseconds = 2000;
                        Thread.Sleep(milliseconds); // Pause execution for 2000 milliseconds
                        Console.Clear(); // Clear the console screen
                        continue; // Continue to the next iteration of the loop
                }

                try
                {
                    double result = calculator.PerformOperation(operation, num1, num2); // Perform the selected operation
                    Console.WriteLine(" ");
                    Console.WriteLine("==========");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Result: " + result); // Display the result
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("==========");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message); // Handle division by zero exception
                }

                bool validChoice = false;
                while (!validChoice)
                {
                    Console.WriteLine(" ");
					Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(">> Do you want to Calculate again? (y/n)");
                    Console.Write(">> ");
                    string contchoice = Console.ReadLine().ToLower(); // Get user's choice to continue or exit

                    if (contchoice == "n" || contchoice == "no")
                    {
                        keepCalculating = false; // Exit the loop if user chooses 'n' or 'no'
                        validChoice = true;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(" ");
                        Console.WriteLine(">> Calculator closed. <<");
                    }
                    else if (contchoice == "y" || contchoice == "yes")
                    {
                        validChoice = true; // Continue the loop if user chooses 'y' or 'yes'
                        Console.Clear(); // Clear the console screen
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("= WARNING: Invalid Choice! Please type 'y' or 'n'... =");
                    }
                }
            }
        }
    }
}
