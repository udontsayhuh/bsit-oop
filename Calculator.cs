using System;

using System.Linq;



namespace Calculator
{
    // Abstract class for basic calculator operations
    public abstract class Calculator
    {
        public abstract double PerformOperation(double num1, double num2);
    }

    // Concrete class for addition operation
    public class Addition : Calculator
    {
        public override double PerformOperation(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    // Concrete class for subtraction operation
    public class Subtraction : Calculator
    {
        public override double PerformOperation(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    // Concrete class for multiplication operation
    public class Multiplication : Calculator
    {
        public override double PerformOperation(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    // Concrete class for division operation
    public class Division : Calculator
    {
        public override double PerformOperation(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
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
                Console.WriteLine("WELCOME TO CALCULATOR APP!\n");
                Console.WriteLine("\nEnter the first numerical value:");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("\033[0;31mNO! I only accept NUMBERS! Again!\033[0;31m");
                    return;
                }

                Console.WriteLine("Enter one of the four fundamental operators (+, -, *, /):");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                // Check if the operator is one of the four fundamental operators
                if (op != '+' && op != '-' && op != '*' && op != '/')
                {
                    Console.WriteLine("\033[0;36mSorry, is that even valid? Enter another operator again! (+, -, *, /)\033[0;36m");
                    continue;
                }

                Console.WriteLine("Enter the second numerical value:");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("\033[0;31mOh no, invalid input! Please enter a numerical value. Try again!\033[0;31m");
                    return;
                }

                // Perform operation based on the operator provided
                Calculator calculator;
                switch (op)
                {
                    case '+':
                        calculator = new Addition();
                        break;
                    case '-':
                        calculator = new Subtraction();
                        break;
                    case '*':
                        calculator = new Multiplication();
                        break;
                    case '/':
                        calculator = new Division();
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operator.");
                }

                // Display result
                try
                {
                    double result = calculator.PerformOperation(num1, num2);
                    Console.WriteLine($"Result: {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                // Ask user if they want to perform another calculation
                Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                string response = Console.ReadLine().ToLower();
                if (response != "yes")
                {
                    Console.WriteLine("\n\033[0;32mBye bye! Come back anytime!\033[0;32m");
                    break;
                }
            }
        }
    }
}

//ASSIGNMENT#02 executed by ABABA, JULIA E. --> BSIT 2-1, 03-25-2024
