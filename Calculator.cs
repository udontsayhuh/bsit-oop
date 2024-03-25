using System;

namespace CalculatorApp
{
    // Abstract base class for mathematical operations
    public abstract class Operation
    {
        //Encapsulation: The PerformOperation method is encapsulated within the Operation class,
        public abstract double PerformOperation(double num1, double num2);
    }

    // This is the Concrete classes for each mathematical operation
    // Inheritance: The Addition, Subraction, Nultiplication, and Division class inherits from the Operation base class
    public class Addition : Operation
    {
        public override double PerformOperation(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    public class Subtraction : Operation
    {
        public override double PerformOperation(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    public class Multiplication : Operation
    {
        public override double PerformOperation(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    public class Division : Operation
    {
        public override double PerformOperation(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            return num1 / num2;
        }
    }

    // Calculator class
    public class Calculator
    {
        private Operation[] operations;

        public Calculator()
        {
            // Encapsulation: The operations array is encapsulated within the Calculator class.
            // Abstraction: The operations array is an abstraction that hides the specific operations.
            // This will initialize the available operations
            operations = new Operation[]
            {
                new Addition(),
                new Subtraction(),
                new Multiplication(),
                new Division()
            };
        }

        public void Run()
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Enter a number:");
                double num1 = GetValidNumber();

                Console.WriteLine("Enter an operator (+, -, *, /):");
                char op = GetValidOperator();

                Console.WriteLine("Enter another number:");
                double num2 = GetValidNumber();

                // Polymorphism: The PerformCalculation method accepts an Operation object
                // Perform the selected operation
                double result = PerformCalculation(num1, num2, op);
                Console.WriteLine("Result: " + result);

                Console.WriteLine("Do you want to perform another calculation? (Y/N)");
                string repeatInput = Console.ReadLine();

                repeat = (repeatInput.Trim().ToUpper() == "Y");
            }
        }

        private double GetValidNumber()
        {
            double number;
            bool isValid = double.TryParse(Console.ReadLine(), out number);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Exiting...");
                Environment.Exit(0);
            }

            return number;
        }

        private char GetValidOperator()
        {
            char op;
            bool isValid = false;

            do
            {
                isValid = char.TryParse(Console.ReadLine(), out op);

                if (!isValid || (op != '+' && op != '-' && op != '*' && op != '/'))
                {
                    Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, /):");
                    isValid = false;
                }
            } while (!isValid);

            return op;
        }

        private double PerformCalculation(double num1, double num2, char op)
        {
            Operation selectedOperation = null;

            switch (op)
            {
                case '+':
                    selectedOperation = new Addition();
                    break;
                case '-':
                    selectedOperation = new Subtraction();
                    break;
                case '*':
                    selectedOperation = new Multiplication();
                    break;
                case '/':
                    selectedOperation = new Division();
                    break;
            }

            if (selectedOperation == null)
            {
                throw new InvalidOperationException("Invalid operation.");
            }

            return selectedOperation.PerformOperation(num1, num2);
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Run();
        }
    }
}
