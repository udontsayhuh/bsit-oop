using System;
using System.Threading;

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
                throw new DivideByZeroException("WARNING: Cannot divide by zero!");
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
                Console.ForegroundColor = ConsoleColor.Cyan;
			    Console.WriteLine("==============================");
			    Console.WriteLine("||        CALCULATOR        ||");
				Console.WriteLine("==============================");
                Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("	");
                Console.Write("> Enter the First number: ");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Invalid input! Program Terminated. =");
                    return;
                }

                Console.Write("> Enter the Second number: ");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Invalid input! Program Terminated. =");
                    return;
                }

                Operation operation;
				Console.WriteLine("	");
                Console.WriteLine("————————————————————————————");
                Console.WriteLine("|   Choose an operation:    |");
                Console.WriteLine("|   >> Addition (+)         |");
                Console.WriteLine("|   >> Subtraction (-)      |");
                Console.WriteLine("|   >> Multiplication (*)   |");
                Console.WriteLine("|   >> Division (/)	       	|");
				Console.WriteLine("————————————————————————————");

                Console.WriteLine(" ");
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
                        Console.WriteLine("= WARNING: Invalid choice! Program Restarting =");
						int milliseconds = 2000;
						Thread.Sleep(milliseconds);
						Console.Clear();
                        continue;
                }

                try
                {
                    double result = calculator.PerformOperation(operation, num1, num2);
					Console.WriteLine(" ");
					Console.WriteLine("==========");
				    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Result: " + result);
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("==========");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }

                bool validChoice = false;
                while (!validChoice)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(">> Do you want to Calculate again (y/n)?");
					Console.Write(">> ");
                    string contchoice = Console.ReadLine().ToLower();

                    if (contchoice == "n" || contchoice == "no")
                    {
                        keepCalculating = false;
                        validChoice = true;
                        Console.WriteLine(">> Calculator closed.");
                    }
                    else if (contchoice == "y" || contchoice == "yes")
                    {
                        validChoice = true;
						Console.Clear();
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
