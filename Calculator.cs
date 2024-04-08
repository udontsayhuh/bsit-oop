using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    // Encapsulation and Inheritance: Abstract class defining a contract for binary operations
    abstract class BinaryOperation
    {
        // Encapsulation: Method to perform the operation
        public abstract float Calculate(float num1, float num2);
    }

    // Inheritance: Concrete operation classes implementing the BinaryOperation abstract class
    class Addition : BinaryOperation
    {
        // Encapsulation: Override method to perform addition
        public override float Calculate(float num1, float num2) => num1 + num2;
    }

    class Subtraction : BinaryOperation
    {
        public override float Calculate(float num1, float num2) => num1 - num2;
    }

    class Multiplication : BinaryOperation
    {
        public override float Calculate(float num1, float num2) => num1 * num2;
    }

    class Division : BinaryOperation
    {
        public override float Calculate(float num1, float num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                return 0;
            }
            return num1 / num2;
        }
    }

    // Calculator class encapsulating the calculation logic
    class Calculator
    {
        private List<string> inputs = new List<string>();

        public void PerformCalculation()
        {
            inputs.Clear();

            // Collect inputs until '=' is entered
            bool expectNumber = true; // Flag to track whether the next input is expected to be a number
            while (true)
            {
                if (expectNumber)
                    Console.WriteLine("Enter a number:");
                else
                    Console.WriteLine("Enter an operator (+, -, *, /), For the result enter Equal sign (=): ");

                string input = Console.ReadLine();
                if (input == "=")
                    break;

                if (expectNumber && float.TryParse(input, out _))
                {
                    inputs.Add(input);
                    expectNumber = false; // After a number is entered, expect an operator next
                }
                else if (!expectNumber && "+-*/".Contains(input))
                {
                    inputs.Add(input);
                    expectNumber = true; // After an operator is entered, expect a number next
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            if (inputs.Count > 0)
            {
                float result = CalculateResult();
                Console.WriteLine("Result: " + result);
            }
        }

        private float CalculateResult()
        {
            float result = float.Parse(inputs[0]);

            // Iterate through pairs of operator and number
            for (int i = 1; i < inputs.Count; i += 2)
            {
                string op = inputs[i];
                float num = float.Parse(inputs[i + 1]);

                switch (op)
                {
                    case "+":
                        result += num;
                        break;
                    case "-":
                        result -= num;
                        break;
                    case "*":
                        result *= num;
                        break;
                    case "/":
                        if (num != 0)
                            result /= num;
                        else
                            Console.WriteLine("Error: Division by zero!");
                        break;
                    default:
                        Console.WriteLine("Invalid operator: " + op);
                        break;
                }
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            char choice;

            do
            {
                calculator.PerformCalculation();

                // Ask user if they want to perform another calculation
                Console.WriteLine("Do you want to perform another calculation? (Y/N)");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (char.ToUpper(choice) == 'Y');
        }
    }
}
