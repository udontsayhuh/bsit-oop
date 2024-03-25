// Palaje BSIT 2-2
// Calculator Program

using System;

// Base class for Calculator
public class Calculator
{
    // Method to calculate based on operator and operands
    protected virtual double Calculate(double firstNumber, double secondNumber, char operatorSymbol)
    {
        switch (operatorSymbol)
        {
            case '+':
                return firstNumber + secondNumber;
            case '-':
                return firstNumber - secondNumber;
            case '*':
                return firstNumber * secondNumber;
            case '/':
                if (secondNumber == 0)
                {
                    Console.WriteLine("Error: Division by zero");
                }
                return firstNumber / secondNumber;
            default:
                Console.WriteLine("Invalid operator. Please enter one of the four operators: +, -, *, /");
                return double.NaN; // Return NaN for invalid operation
        }
    }
}

// Subclass representing a mathematical expression
public class Expression : Calculator
{
    // Properties to store the expression components
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }
    public char OperatorSymbol { get; set; }

    // Constructor to initialize the expression components
    public Expression(double firstNumber, double secondNumber, char operatorSymbol)
    {
        FirstNumber = firstNumber;
        SecondNumber = secondNumber;
        OperatorSymbol = operatorSymbol;
    }
    // Method to evaluate the expression using Calculator's Calculate method
    public double Evaluate()
    {
        try
        {
            // Try to calculate the expression
            return Calculate(FirstNumber, SecondNumber, OperatorSymbol);
        }
        catch (ArgumentException ex)
        {
            // Handle the ArgumentException
            Console.WriteLine(ex.Message);
            // Return a suitable value or throw the exception further
            throw new ArgumentException("Invalid expression.");
        }
    }
}

// Main class
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=====================================================");
        Console.WriteLine("                 Calculator Program");
        Console.WriteLine("=====================================================");

        while (true)
        {
            // Input for first number
            Console.Write("\nEnter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double firstNumber))
            {
                Console.WriteLine("Invalid input. Please enter a numerical value.");
                break; // Terminate program if input is invalid
            }

            // Input for operator
            Console.Write("Enter operator (+, -, *, /): ");
            char operatorSymbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operatorSymbol != '+' && operatorSymbol != '-' && operatorSymbol != '*' && operatorSymbol != '/')
            {
                Console.WriteLine("Invalid operator. Please enter one of the four operators: +, -, *, /");
                break; // Terminate program if input is invalid
            }

            // Input for second number
            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double secondNumber))
            {
                Console.WriteLine("Invalid input. Please enter a numerical value.");
                break; // Terminate program if input is invalid
            }

            // Create an instance of Expression and evaluate the expression
            Expression expression = new Expression(firstNumber, secondNumber, operatorSymbol);
            double result = expression.Evaluate();
            Console.WriteLine($"Result: {expression.FirstNumber} {expression.OperatorSymbol} {expression.SecondNumber} = " + result);

            // Check if the user wants to perform another calculation
            Console.Write("\nWould you like to calculate again? (Y/N): ");
            string choice = Console.ReadLine().ToUpper();
            // Terminate the program if the user does not input 'Y' or 'y'.
            if (choice != "Y")
            {
                break;
            }
        }
        Console.WriteLine("\nExiting program...\nThank you for using this Calculator!");

    }
}
