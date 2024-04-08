using System;

namespace Calculator
{
    // Absclass representing a calculator
    abstract class Calculator
    {
        protected int result;

        // Abs method to calculate operation between two numbers
        public abstract int Calculate(int num1, int num2, string operation);
    }

    // Calculations of basic arithmetic operations
    class BasicCalculator : Calculator // Inheritance: BasicCalculator inherits from Calculator
    {
        // Method to calculate operation between two numbers
        public override int Calculate(int num1, int num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        throw new DivideByZeroException("Error: Division by zero!");
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Loop to calculate again
            bool shouldContinueCalculating = true;

            // Main loop for calculator
            while (shouldContinueCalculating)
            {
                try
                {
                    // Start of calculation process
                    Console.WriteLine("Simple Calculator:");

                    // Input the first number
                    int num1 = GetValidNumber("Enter a number: ");

                    BasicCalculator calculator = new BasicCalculator(); // Abstraction: Calculations are abstracted behind Calculator interface

                    // Input the operator or '=' to calculate
                    string currentOperator = GetValidOperator("Enter the operator (+, -, *, /) or '=' to calculate: ");

                    // Loop to input numbers and operators until '=' is entered
                    while (currentOperator != "=")
                    {
                        // Check if the entered operator is valid
                        if (currentOperator != "+" && currentOperator != "-" && currentOperator != "*" && currentOperator != "/")
                        {
                            Console.WriteLine("Invalid operator! Please enter a valid operator (+, -, *, /) or '='.");
                            currentOperator = GetValidOperator("Enter the operator (+, -, *, /) or '=' to calculate: ");
                            continue;
                        }

                        // Input the next number
                        int num2 = GetValidNumber("Enter a number: ");

                        // Calculate based on current operator
                        num1 = calculator.Calculate(num1, num2, currentOperator); // Polymorphism: The actual method called depends on the object type

                        // Input the next operator or '=' to calculate
                        currentOperator = GetValidOperator("Enter the operator (+, -, *, /) or '=' to calculate: ");
                    }

                    // Output the result
                    Console.WriteLine($"Result: {num1}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                // Ask user to calculate again
                Console.Write("Do you want to calculate again? (Y/N): ");
                string choice = Console.ReadLine().ToUpper();

                // Exit loop if 'N' is entered
                if (choice != "Y")
                    shouldContinueCalculating = false;
            }

            // Just a closing message
            Console.WriteLine("Thank you for using the calculator!");
            Console.ReadKey();
        }

        // Method to get a valid number input from the user
        static int GetValidNumber(string message)
        {
            int number;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }
            return number;
        }

        // Method to get a valid operator input from the user
        static string GetValidOperator(string message)
        {
            string op;
            while (true)
            {
                Console.Write(message);
                op = Console.ReadLine();
                if (op == "+" || op == "-" || op == "*" || op == "/" || op == "=")
                    break;
                else
                {
                    Console.WriteLine("Invalid operator! Please enter a valid operator or '='.");
                }
            }
            return op;
        }
    }
}
