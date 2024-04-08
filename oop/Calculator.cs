// Calculator
// >Program Checklist<
// Prompt user to enter valid input: /
// Input several values: /
// Applied OOP principles: Abstraction, Polymorphism, & Encapsulation

using System;

namespace BasicCalculator
{
    abstract class Operations // Abstraction
    {
        public abstract double Execute(double num1, double num2);
    }

    class Addition : Operations
    {
        public override double Execute(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    class Subtraction : Operations
    {
        public override double Execute(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    class Multiplication : Operations
    {
        public override double Execute(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    class Division : Operations
    {
        public override double Execute(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Undefined");
            }
            return num1 / num2;
        }
    }

    class Program
    {
        static string InputOperator() // Encapsulation
        {
            string op;
            do
            {
                Console.WriteLine("Enter Operator: ");
                op = Console.ReadLine().Trim();

                if (op != "+" && op != "-" && op != "*" && op != "/" && op != "=")
                {
                    Console.WriteLine("Invalid Operator. Please enter a valid operator.");
                }
            } while (op != "+" && op != "-" && op != "*" && op != "/" && op != "=");

            return op;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("          Basic Calculator");
            Console.WriteLine("====================================");
            Console.WriteLine(" Enter valid numbers and operations");
            Console.WriteLine(" (+, -, *, /) or '=' to calculate");
            Console.WriteLine("====================================");

            bool calculateAgain = true;

            while (calculateAgain)
            {
                double result = 0;
                double num1;

                Console.WriteLine("Enter Number: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number: ");
                }
                result = num1;

                while (true)
                {
                    string op = InputOperator();

                    if (op == "=")
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Result: " + result);
                        break;
                    }

                    double num2;

                    Console.WriteLine("Enter Number: ");
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Invalid Input. Please enter a valid number: ");
                    }

                    Operations operation;
                    switch (op) // Polymorphism
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
                            throw new ArgumentException("Invalid operator.");
                    }

                    try
                    {
                        result = operation.Execute(result, num2);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                Console.WriteLine("\nDo you want to calculate again? (Y/N)");
                string again = Console.ReadLine().Trim();
                Console.WriteLine("\n");

                calculateAgain = (again.Equals("Y", StringComparison.OrdinalIgnoreCase));
            }

            Console.WriteLine("Program Terminated.");
        }
    }
}
