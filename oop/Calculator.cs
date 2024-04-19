using System;

namespace CalculatorApp
{
    // Interface representing a calculator
    interface ICalculator
    {
        float Calculate(float num1, float num2, string operation);
    }

    // Basic calculator implementation
    class BasicCalculator : ICalculator
    {
        // Method to perform calculation based on operation
        public float Calculate(float num1, float num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    // Check for division by zero
                    if (num2 != 0)
                        return num1 / num2;
                    else
                        throw new DivideByZeroException("Error: Division by zero!");
                default:
                    // Handle invalid operations
                    throw new ArgumentException("Invalid operation!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinueCalculating = true;

            // Main loop for calculator
            while (shouldContinueCalculating)
            {
                try
                {
                    Console.WriteLine("Simple Calculator:");

                    // Input the first number
                    float num1 = GetValidNumber("Enter a number: ");
                    ICalculator calculator = new BasicCalculator(); // Using abstraction with interface

                    // Input the operator or '=' to calculate
                    string currentOperator = GetValidOperator("Enter the operator (+, -, *, /) or '=' to calculate: ");

                    // Loop to input numbers and operators until '=' is entered
                    while (currentOperator != "=")
                    {
                        // Check if the entered operator is valid
                        if (!IsValidOperator(currentOperator))
                        {
                            Console.WriteLine("Invalid operator! Please enter a valid operator (+, -, *, /) or '='.");
                            currentOperator = GetValidOperator("Enter the operator (+, -, *, /) or '=' to calculate: ");
                            continue;
                        }

                        // Input the next number
                        float num2 = GetValidNumber("Enter a number: ");

                        // Perform calculation based on current operator
                        num1 = calculator.Calculate(num1, num2, currentOperator);

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

                // Ask user if they want to calculate again
                Console.Write("Do you want to calculate again? (Y/N): ");
                string choice = Console.ReadLine().ToUpper();

                // Exit loop if 'N' is entered
                if (choice != "Y")
                    shouldContinueCalculating = false;
            }

            // Closing message
            Console.WriteLine("Thank you for using the calculator!");
            Console.ReadKey();
        }

        // Method to get a valid number input from the user
        static float GetValidNumber(string message)
        {
            float number;
            while (true)
            {
                Console.Write(message);
                if (float.TryParse(Console.ReadLine(), out number))
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
                if (IsValidOperator(op) || op == "=")
                    break;
                else
                {
                    Console.WriteLine("Invalid operator! Please enter a valid operator or '='.");
                }
            }
            return op;
        }

        // Method to check if the operator is valid
        static bool IsValidOperator(string op)
        {
            return op == "+" || op == "-" || op == "*" || op == "/";
        }
    }
}
