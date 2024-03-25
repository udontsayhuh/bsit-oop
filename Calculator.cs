using System;

abstract class Calculator
{
    // Method to perform a single calculation (Abstraction)
    public abstract double PerformCalculation(double num1, double num2);
}

// Derived class for basic calculator (Inheritance)
class BasicCalculator : Calculator
{
    // Method overriding to perform addition operation (Polymorphism)
    public override double PerformCalculation(double num1, double num2)
    {
        return num1 + num2;
    }
}

class ScientificCalculator : Calculator
{
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
            Console.WriteLine("Enter a numerical value:");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a numerical value.");
                continue;
            }

            Console.WriteLine("Enter one of the following operators: +, -, *, /, ^");
            char op = Console.ReadLine()[0];

            // Validate operator input
            if (op != '+' && op != '-' && op != '*' && op != '/' && op != '^')
            {
                Console.WriteLine("Invalid operator. Please enter one of the following: +, -, *, /, ^");
                continue;
            }

            Console.WriteLine("Please enter another numerical value:");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a numerical value.");
                continue;
            }

            Calculator calculator;
            switch (op)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    calculator = new BasicCalculator();
                    break;
                case '^':
                    calculator = new ScientificCalculator();
                    break;
                default:
                    throw new ArgumentException("Invalid operator.");
            }

            double result = calculator.PerformCalculation(num1, num2);

            // Display the result
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");

            // Ask if the user wants to perform another calculation
            Console.WriteLine("Do you want to perform another calculation? (yes/no)");
            string choice = Console.ReadLine().ToLower();
            if (choice != "yes")
                break;
        }
    }
}
