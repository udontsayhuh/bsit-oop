using System;

namespace Calculator
{
    // Base Class: Parent
    public class Calculator
    {
        // Method for performing arithmetic operation
        public virtual double Operation(double a, double b)
        {
            return a + b; // Addition as default operation
        }
    }

    // Derived Class: Child
    public class Subtraction : Calculator
    {
        // Inheritance principle by overriding operation method for Subtraction
        public override double Operation(double a, double b)
        {
            return a - b;
        }
    }

    // Derived Class: Child
    public class Multiplication : Calculator
    {
        // Inheritance principle by overriding operation method for Multiplication
        public override double Operation(double a, double b)
        {
            return a * b;
        }
    }

    // Derived Class: Child
    public class Division : Calculator
    {
        // Inheritance principle by overriding operation method for Division
        public override double Operation(double a, double b)
        {
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("===================================");
                Console.WriteLine("          Basic Calculator         ");
                Console.WriteLine("===================================\n");
                Console.WriteLine("Enter first number: ");
                double a;
                try // Try-Catch to make sure the user-input is a number/double data type
                {
                    a = double.Parse(Console.ReadLine()); // Parse converts string to number/double data type
                }
                catch (FormatException) // If the user-input is not a number/double data type
                {
                    Console.WriteLine("Error: Input must be a number.");
                    return; // Terminate the program
                }

                Console.WriteLine("Enter second number: ");
                double b;
                try // Repeating the same try-catch
                {
                    b = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Input must be a number.");
                    return; // Terminate the program
                }

                Console.WriteLine("Enter operator (+ for Addition, - for Substraction, * - Multiplication, / - Division): ");
                string op = Console.ReadLine();

                Calculator calculator;
                switch (op)
                {
                    case "+":
                        calculator = new Calculator();
                        break;
                    case "-":
                        calculator = new Subtraction();
                        break;
                    case "*":
                        calculator = new Multiplication();
                        break;
                    case "/":
                        calculator = new Division();
                        break;
                    default:
                        Console.WriteLine("Error: Invalid Operator entered.");
                        return; // Terminate program if operation is invalid
                }

                double result = calculator.Operation(a, b);
                Console.WriteLine($"Result: {a} {op} {b} = {result}");

                Console.WriteLine("Do you want to continue (Y/N): ");
                input = Console.ReadLine();
            } while (input.ToUpper() == "Y");
        }
    }
}