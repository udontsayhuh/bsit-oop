using System;
using System.Collections.Generic;

// Abstract class representing a generic calculator
abstract class Calculator
{
    // Abstract method to perform a single calculation
    public abstract double PerformCalculation(double num1, double num2);
}

// Derived class for basic calculator, inherits from Calculator
class BasicCalculator : Calculator
{
    // Method overriding to perform addition operation
    public override double PerformCalculation(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Derived class for subtraction calculator, inherits from Calculator
class SubtractionCalculator : Calculator
{
    // Method overriding to perform subtraction operation
    public override double PerformCalculation(double num1, double num2)
    {
        return num1 - num2;
    }
}

// Derived class for multiplication calculator, inherits from Calculator
class MultiplicationCalculator : Calculator
{
    // Method overriding to perform multiplication operation
    public override double PerformCalculation(double num1, double num2)
    {
        return num1 * num2;
    }
}

// Derived class for division calculator, inherits from Calculator
class DivisionCalculator : Calculator
{
    // Method overriding to perform division operation
    public override double PerformCalculation(double num1, double num2)
    {
        // Handle division by zero
        if (num2 == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return num1 / num2;
    }
}

// Derived class for power calculator, inherits from Calculator
class PowerCalculator : Calculator
{
    // Method overriding to perform power operation
    public override double PerformCalculation(double num1, double num2)
    {
        return Math.Pow(num1, num2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" = Calculator App = ");

        while (true)
        {
            List<double> numbers = new List<double>();
            List<char> operators = new List<char>();

            // Input collection loop
            while (true)
            {
                Console.WriteLine("Enter a numerical value, operator (+, -, *, /, ^), or '=' to calculate:");
                string input = Console.ReadLine();

                // Check for termination condition
                if (input == "=")
                {
                    if (numbers.Count < 2 || operators.Count == 0)
                    {
                        Console.WriteLine("Insufficient values/operators for calculation.");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                // Check for numerical input
                if (double.TryParse(input, out double value))
                {
                    numbers.Add(value);
                }
                // Check for operator input
                else if (input.Length == 1 && "+-*/^".Contains(input))
                {
                    operators.Add(input[0]);
                }
                // Invalid input
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value, operator (+, -, *, /, ^), or '=' to calculate.");
                }
            }

            // Calculation loop
            double result = numbers[0];
            string expression = numbers[0].ToString();
            for (int i = 0; i < operators.Count; i++)
            {
                expression += $" {operators[i]} {numbers[i + 1]}";
                Calculator calculator = null;

                // Select appropriate calculator based on operator
                switch (operators[i])
                {
                    case '+':
                        calculator = new BasicCalculator();
                        break;
                    case '-':
                        calculator = new SubtractionCalculator();
                        break;
                    case '*':
                        calculator = new MultiplicationCalculator();
                        break;
                    case '/':
                        calculator = new DivisionCalculator();
                        break;
                    case '^':
                        calculator = new PowerCalculator();
                        break;
                    default:
                        throw new ArgumentException("Invalid operator.");
                }

                // Perform calculation using selected calculator
                result = calculator.PerformCalculation(result, numbers[i + 1]);
            }

            // Display result
            Console.WriteLine($"Result: {expression} = {result}");

            // Ask if the user wants to perform another calculation
            Console.WriteLine("Do you want to perform another calculation? (yes/no)");
            string choice = Console.ReadLine().ToLower();
            if (choice != "yes")
                break;
        }
    }
}
