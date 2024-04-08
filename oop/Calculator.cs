// Palaje BSIT 2-2
// Laboratory #3
// Calculator Program Modification

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
                    throw new DivisionByZeroException("Error: Division by zero");
                }
                return firstNumber / secondNumber;
            default:
                throw new InvalidOperationException("Invalid operator. Please enter one of the four operators: +, -, *, /");
        }
    }
}

// Custom exception class for division by zero
public class DivisionByZeroException : Exception
{
    public DivisionByZeroException(string message) : base(message)
    {
    }
}

// Subclass representing a mathematical expression
public class Expression : Calculator
{
    // Properties to store the expression components
    public double FirstNumber { get; set; }
    public char OperatorSymbol { get; set; }

    // Constructor to initialize the expression components
    public Expression(double firstNumber, char operatorSymbol)
    {
        FirstNumber = firstNumber;
        OperatorSymbol = operatorSymbol;
    }

    // Method to evaluate the expression using Calculator's Calculate method
    public double Evaluate(double secondNumber)
    {
        try
        {
            return Calculate(FirstNumber, secondNumber, OperatorSymbol);
        }
        catch (DivisionByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            throw; // Rethrow the exception to be caught in the Main method
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return double.NaN;
        }
    }
}

// Main class
class MainClass
{
    public static void Main(string[] args)
    {
        while (true)
        {
            double result = 0;
            double firstNumber = 0;
            char operatorSymbol = ' ';
            bool isFirstIteration = true;

            Console.Clear(); // Clear the console screen
            Console.WriteLine("=====================================================");
            Console.WriteLine("                 Calculator Program");
            Console.WriteLine("=====================================================");

            while (true)
            {
                // Input for first number
                if (isFirstIteration)
                {
                    Console.Write("Enter a numerical value: ");
                    if (!double.TryParse(Console.ReadLine(), out firstNumber))
                    {
                        Console.WriteLine("Invalid input. Please enter a numerical value.");
                        continue;
                    }
                    isFirstIteration = false;
                }
                else
                {
                    while (true)
                    {
                        Console.Write("Enter operator (+, -, *, /) or '=' to get result: ");
                        char.TryParse(Console.ReadLine(), out operatorSymbol);

                        if (operatorSymbol == '=')
                            break;

                        if (operatorSymbol != '+' && operatorSymbol != '-' && operatorSymbol != '*' && operatorSymbol != '/')
                        {
                            Console.WriteLine("Invalid operator. Please enter one of the four operators: +, -, *, /");
                            continue;
                        }

                        break;
                    }

                    if (operatorSymbol == '=')
                    {
                        result = firstNumber;
                        break;
                    }

                    double secondNumber;
                    while (true)
                    {
                        Console.Write("Enter a numerical value: ");
                        string input = Console.ReadLine();

                        if (!double.TryParse(input, out secondNumber))
                        {
                            Console.WriteLine("Invalid input. Please enter a numerical value.");
                            continue;
                        }

                        break;
                    }

                    Expression expression = new Expression(firstNumber, operatorSymbol);
                    try
                    {
                        result = expression.Evaluate(secondNumber);
                    }
                    catch (DivisionByZeroException)
                    {
                        // Reset calculation loop if division by zero occurs
                        Console.WriteLine("\nResetting calculation due to division by zero...\nPress any key to continue...");
                        Console.ReadLine(); // to stay before clearing the screen for a reset
                        isFirstIteration = true;
                        break;
                    }
                    // Console.WriteLine($"Intermediate result: {result}"); //if you want to see the answers for each calculation

                    firstNumber = result; // if the user inputs '=' after the first value
                }
            }

            if (isFirstIteration) // If calculation reset, continue to the next iteration
                continue;

            // Console.WriteLine($"Final result: {result}"); // result without rounding off
            Console.WriteLine($"Final result: {Math.Round(result, 2)} "); // Round the result to 2 decimal places

            // Check if the user wants to perform another calculation
            Console.Write("\nWould you like to calculate again?\nEnter Y or y if yes: ");
            string choice = Console.ReadLine().ToUpper();
            if (choice != "Y")
            {
                Console.WriteLine("\nExiting program...\nThank you for using this Calculator!");
                break;
            }
        }
    }
}
