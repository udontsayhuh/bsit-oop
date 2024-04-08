using System;

namespace CalculatorApp
{
    // Abstract base class for mathematical operations
    public abstract class Operation
    {
        // Encapsulation: The PerformOperation method is encapsulated within the Operation class.
        public abstract double PerformOperation(double num1, double num2);
    }

    // This is the Concrete classes for each mathematical operation
    // Inheritance: The Addition, Subraction, Multiplication, and Division class inherits from the Operation base class
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

                char op;
                do
                {
                    Console.WriteLine("Enter an operator (+, -, *, /), or = to display the result:");
                    op = GetValidOperator();

                    if (op != '=')
                    {
                        Console.WriteLine("Enter another number:");
                        double num2 = GetValidNumber();

                        // Perform the selected operation
                        double result = PerformCalculation(num1, num2, op);
                        Console.WriteLine("Intermediate Result: " + result);
                        num1 = result; // Update num1 with the intermediate result
                    }
                } while (op != '=');

                Console.WriteLine("Result: " + num1);

                Console.WriteLine("Do you want to perform another calculation? (Y/N)");
                string repeatInput = Console.ReadLine();

                repeat = (repeatInput.Trim().ToUpper() == "Y");
            }
        }

        private double GetValidNumber()
        {
            double number;
            bool isValid;

            do
            {
                isValid = double.TryParse(Console.ReadLine(), out number);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }
            } while (!isValid);

            return number;
        }

        private char GetValidOperator()
        {
            char op;
            bool isValid;

            do
            {
                isValid = char.TryParse(Console.ReadLine(), out op);

                if (!isValid || (op != '+' && op != '-' && op != '*' && op != '/' && op != '='))
                {
                    Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, /), or = to display the result:");
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
