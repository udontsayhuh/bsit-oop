using System;

namespace MyCalculator
{
    // Define different mathematical operations
    public abstract class Operation
    {
        public abstract double Apply(double operand1, double operand2);
    }

    public class Addition : Operation
    {
        public override double Apply(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
    }

    public class Subtraction : Operation
    {
        public override double Apply(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
    }

    public class Multiplication : Operation
    {
        public override double Apply(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
    }

    public class Division : Operation
    {
        public override double Apply(double operand1, double operand2)
        {
            if (operand2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return operand1 / operand2;
        }
    }

    // Calculator class to perform calculations
    public class MyCalculator : IDisposable
    {
        private Operation[] operations = { new Addition(), new Subtraction(), new Multiplication(), new Division() };

        // Start the calculator application
        public void Start()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Hey there! Let's do some math!");

                // Get user input for first number
                Console.WriteLine("Enter the first number:");
                double num1 = GetNumberInput();

                // Get user input for operator
                Console.WriteLine("Enter the operator (+, -, *, /):");
                char op = GetOperatorInput();

                // Get user input for second number
                Console.WriteLine("Enter the second number:");
                double num2 = GetNumberInput();

                try
                {
                    // Perform calculation and display result
                    double result = Calculate(num1, op, num2);
                    Console.WriteLine($"The answer is: {result}");
                }
                catch (Exception ex)
                {
                    // Display error message if calculation fails
                    Console.WriteLine($"Oops! Something went wrong: {ex.Message}");
                }

                // Ask user if they want to perform another calculation
                Console.WriteLine("Do you want to do more math? (yes/no)");
                string again = Console.ReadLine();
                repeat = again.ToLower() == "yes";
            }
        }

        // Get valid number input from the user
        private double GetNumberInput()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Hmmm...that doesn't look like a number. Please enter a valid number:");
            }
            return number;
        }

        // Get valid operator input from the user
        private char GetOperatorInput()
        {
            char op;
            while (!char.TryParse(Console.ReadLine(), out op) || !IsOperator(op))
            {
                Console.WriteLine("Sorry, I didn't catch that. Please enter one of the following: +, -, *, /");
            }
            return op;
        }

        // Check if the given character is a valid operator
        private bool IsOperator(char op)
        {
            return op == '+' || op == '-' || op == '*' || op == '/';
        }

        // Perform calculation based on user input
        private double Calculate(double num1, char op, double num2)
        {
            Operation operation = GetOperation(op);
            return operation.Apply(num1, num2);
        }

        // Get the appropriate operation based on the operator
        private Operation GetOperation(char op)
        {
            switch (op)
            {
                case '+':
                    return new Addition();
                case '-':
                    return new Subtraction();
                case '*':
                    return new Multiplication();
                case '/':
                    return new Division();
                default:
                    throw new InvalidOperationException("Hmm...that's not a valid operator.");
            }
        }

        // Cleanup method
        public void Dispose()
        {
            // Thanks for using MyCalculator! Have a great day!
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
   
            using (var myCalculator = new MyCalculator())
            {
                myCalculator.Start();
            }
        }
    }
}
