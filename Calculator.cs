using System;
using System.Collections.Generic;

abstract class Calculator
{
    // Method to perform a single calculation (Abstraction)
    public abstract double PerformCalculation(double num1, double num2);
}

// Derived class for basic calculator (Inheritance)
class AddCalculator : Calculator
{
    // Method overriding to perform addition operation (Polymorphism)
    public override double PerformCalculation(double num1, double num2)
    {
        return num1 + num2;
    }
}

class SubtractCalculator : Calculator
{
    // Method overriding to perform subtraction operation (Polymorphism)
    public override double PerformCalculation(double num1, double num2)
    {
        return num1 - num2;
    }
}

class MultiplyCalculator : Calculator
{
    // Method overriding to perform multiplication operation (Polymorphism)
    public override double PerformCalculation(double num1, double num2)
    {
        return num1 * num2;
    }
}

class DivideCalculator : Calculator
{
    // Method overriding to perform division operation (Polymorphism)
    public override double PerformCalculation(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return num1 / num2;
    }
}

class PowerCalculator : Calculator
{
    // Method overriding to perform power operation (Polymorphism)
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

            while (true)
            {
                Console.WriteLine("Enter a numerical value, operator (+, -, *, /, ^), or '=' to calculate:");
                string input = Console.ReadLine();

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

                if (double.TryParse(input, out double value))
                {
                    numbers.Add(value);
                }
                else if (input.Length == 1 && "+-*/^".Contains(input))
                {
                    operators.Add(input[0]);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value, operator (+, -, *, /, ^), or '=' to calculate.");
                }
            }

            double result = numbers[0];
            string expression = numbers[0].ToString();
            for (int i = 0; i < operators.Count; i++)
            {
                expression += $" {operators[i]} {numbers[i + 1]}";
                Calculator calculator = null;
                switch (operators[i])
                {
                    case '+':
                        calculator = new AddCalculator();
                        break;
                    case '-':
                        calculator = new SubtractCalculator();
                        break;
                    case '*':
                        calculator = new MultiplyCalculator();
                        break;
                    case '/':
                        calculator = new DivideCalculator();
                        break;
                    case '^':
                        calculator = new PowerCalculator();
                        break;
                    default:
                        throw new ArgumentException("Invalid operator.");
                }

                result = calculator.PerformCalculation(result, numbers[i + 1]);
            }

            Console.WriteLine($"Result: {expression} = {result}");

            // Ask if the user wants to perform another calculation
            Console.WriteLine("Do you want to perform another calculation? (yes/no)");
            string choice = Console.ReadLine().ToLower();
            if (choice != "yes")
                break;
        }
    }
}
