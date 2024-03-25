using System;

namespace BestCalculatorInCebu
{
    // Abstract base class for mathematical operations
    public abstract class Operation
    {
        public abstract int Calculation(int num1, int num2);
    }

    // Child class for Addition
    public class Addition : Operation
    {
        public override int Calculation(int num1, int num2)
        {
            return num1 + num2;
        }
    }

   //Child class fo Subtraction
    public class Subtraction : Operation
    {
        public override int Calculation(int num1, int num2)
        {
            return num1 - num2;
        }
    }

    //Child class for Multiplication
    public class Multiplication : Operation
    {
        public override int Calculation(int num1, int num2)
        {
            return num1 * num2;
        }
    }

    //Child class for Division
    public class Division : Operation
    {
        public override int Calculation(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                Environment.Exit(0);
            }
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("The Best Calculator in Cebu");

                Console.Write("Enter a value: ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                    Environment.Exit(0);
                }

                Console.Write("Enter an operator (+, -, *, /): ");
                char opSymbol = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Operation operation;
                switch (opSymbol)
                {
                    case '+':
                        operation = new Addition();
                        break;
                    case '-':
                        operation = new Subtraction();
                        break;
                    case '*':
                        operation = new Multiplication();
                        break;
                    case '/':
                        operation = new Division();
                        break;
                    default:
                        Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                        Environment.Exit(0);
                        return;
                }

                Console.Write("Enter another value: ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                    Environment.Exit(0);
                }

                int result = operation.Calculation(num1, num2);
                Console.WriteLine($"Result: {result}");

                Console.Write("Do you want to perform another calculation? (Y/N): ");
                char choice = Console.ReadKey().KeyChar;
                if (char.ToUpper(choice) != 'Y')
                {
                    Console.WriteLine("\nThank you for using the best Calculator in Cebu. Goodbye!");
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
