// Palaje BSIT 2-2
// Laboratory #4
// Calculator Program Optimization

using System;

public class Calculator
{
    // The Calculator class provides basic arithmetic operations

    // Method to perform addition
    protected virtual double Add(double firstNumber, double newNumber) => firstNumber + newNumber;

    // Method to perform subtraction
    protected virtual double Subtract(double firstNumber, double newNumber) => firstNumber - newNumber;

    // Method to perform multiplication
    protected virtual double Multiply(double firstNumber, double newNumber) => firstNumber * newNumber;

    // Method to perform division
    protected virtual double Divide(double firstNumber, double newNumber)
    {
        // Check for division by zero
        if (newNumber == 0)
        {
            // Throw an exception if division by zero is attempted
            throw new ArgumentException("Error: Division by zero");
        }
        return firstNumber / newNumber;
    }

    // Method to select the appropriate operation based on the operator symbol
    protected virtual double Calculate(double firstNumber, double newNumber, char operatorSymbol)
    {
        switch (operatorSymbol)
        {
            case '+':
                return Add(firstNumber, newNumber);
            case '-':
                return Subtract(firstNumber, newNumber);
            case '*':
                return Multiply(firstNumber, newNumber);
            case '/':
                return Divide(firstNumber, newNumber);
            default:
                // If an invalid operator is provided, throw an exception
                throw new ArgumentException("Invalid operator. Please enter one of the four operators: +, -, *, /");
        }
    }
}

public class Expression : Calculator
{
    // Expression class represents an arithmetic expression

    // Properties to store the first number and operator symbol
    public double FirstNumber { get; set; }
    public char OperatorSymbol { get; set; }

    // Constructor to initialize the Expression object with the first number and operator symbol
    public Expression(double firstNumber, char operatorSymbol)
    {
        FirstNumber = firstNumber;
        OperatorSymbol = operatorSymbol;
    }

    // Method to evaluate the expression and perform the calculation
    public double Evaluate(double newNumber)
    {
        // Call the Calculate method from the base class to perform the calculation
        return Calculate(FirstNumber, newNumber, OperatorSymbol);
    }
}

class MainClass
{
    // Main method is the entry point of the program
    public static void Main(string[] args)
    {
        while (true)
        {
            DisplayHeader();

            double firstNumber;
            if (!TryGetNumberInput("Enter the first number: ", out firstNumber))
                continue;

            char operatorSymbol = GetOperatorInput();

            double result = firstNumber;
            try
            {
                while (true)
                {
                    if (operatorSymbol == '=')
                    {
                        // Display the result if the '=' sign is entered
                        Console.WriteLine($"Result: {Math.Round(result, 2)}");
                        break;
                    }

                    double newNumber;
                    if (!TryGetNumberInput("Enter the next number: ", out newNumber))
                        continue;

                    // Evaluate the expression and update the result
                    result = new Expression(result, operatorSymbol).Evaluate(newNumber);
                    // Display intermediate result
                  //  Console.WriteLine($"Intermediate Result: {result}");

                    operatorSymbol = GetOperatorInput();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nResetting calculation...");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                continue;
            }

            if (!ShouldContinue())
                break;
        }

        Console.WriteLine("\nExiting program...\nThank you for using this Calculator!");
    }

    // Method to display the header
    private static void DisplayHeader()
    {
        Console.Clear();
        Console.WriteLine("=====================================================");
        Console.WriteLine("                 Calculator Program");
        Console.WriteLine("=====================================================");
    }

    // Method to get numerical input from the user
    private static bool TryGetNumberInput(string message, out double number)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (!double.TryParse(input, out number))
            {
                // Prompt the user to enter a numerical value if the input is not valid
                Console.WriteLine("Invalid input. Please enter a numerical value.");
                continue;
            }

            return true;
        }
    }

    // Method to get the operator symbol from the user
    private static char GetOperatorInput()
    {
        while (true)
        {
            Console.Write("Enter operator (+, -, *, /) or = : ");
            char operatorSymbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operatorSymbol != '+' && operatorSymbol != '-' && operatorSymbol != '*' && operatorSymbol != '/' && operatorSymbol != '=')
            {
                // Prompt the user to enter a valid operator if an invalid one is provided
                Console.WriteLine("Invalid input. Please enter one of the five operators: +, -, *, /, =");
            }
            else
            {
                return operatorSymbol;
            }
        }
    }

    // Method to ask the user if they want to perform another calculation
    private static bool ShouldContinue()
    {
        while (true)
        {
            Console.Write("\nWould you like to do another calculation? ('Y' or 'N'): ");
            string choice = Console.ReadLine().ToUpper();
            if (choice == "Y")
                return true;
            else if (choice == "N")
                return false;
            else
                Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
        }
    }
}
