//SOLANO, CEDRIC MARK G.
//BSIT 2-2
//Modify Calculator.cs

using System;

public class DivisionByZeroException : Exception
{
    public DivisionByZeroException(string message) : base(message)
    {
    }
}

// Base class for Calculator demonstrating basic arithmetic operations
public class Calculator
{
    // Encapsulation: The Calculate method encapsulates the logic for performing arithmetic operations.
    // It takes two numerical values and an operator symbol as input and performs the corresponding calculation.
    protected virtual double Calculate(double firstNumber, double secondNumber, char operatorSymbol)
    {
        switch (operatorSymbol)
        {
            case '+': // Addition
                return firstNumber + secondNumber;
            case '-': // Subtraction
                return firstNumber - secondNumber;
            case '*': // Multiplication
                return firstNumber * secondNumber;
            case '/': // Division
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

// Subclass representing a mathematical expression inheriting from Calculator
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

    // Abstraction: The Evaluate method abstracts the process of evaluating a mathematical expression.
    // It calls the Calculate method from the base class to perform the actual calculation.
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

// Main class demonstrating a simple calculator program
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

            Console.WriteLine("=====================================================");
            Console.WriteLine("         CALCULATOR THAT ACCEPTS ANY USER INPUT!     ");
            Console.WriteLine("=====================================================");

            while (true)
            {
                // Input for first numerical value
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
                        Console.Write("Enter operator (+, -, *, /) or '=' Display the result when equal sign is entered: ");
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
                        // Reset calculation loop
                        Console.WriteLine("Resetting calculation due to division by zero...\nPress any key to continue...");
                        Console.ReadLine(); // to stay before clearing the screen for a reset
                        isFirstIteration = true;
                        break;
                    }

                    firstNumber = result;
                }
            }

            if (isFirstIteration) // If calculation reset
                continue;

            // Polymorphism: The code utilizes polymorphism by calling the Evaluate method of the Expression class,
            // which internally invokes the Calculate method from the base class Calculator.
            // This allows for different expressions to be evaluated using the same method signature.
            
            // Console.WriteLine($"Final result: {result}"); // result without rounding off
            Console.WriteLine($"Final result: {Math.Round(result, 2)} "); // Round the result to 2 decimal places

            // If the user wants to perform another calculation
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Do you want to do another calculation? (Y/N)");
            Console.WriteLine("----------------------------------------------");
            string choice2 = Console.ReadLine().ToUpper();
            if (choice2 != "Y")
            {
                Console.WriteLine("\n==========    Calculator Closed    ==========\n");
                break;
            }
        }
    }
}
