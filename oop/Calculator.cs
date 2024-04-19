using System;

// Calculator UI class responsible for user interaction and flow control
class CalculatorUI
{
    private readonly CalculatorEngine _calculatorEngine; // Calculator engine instance for computations

    // Constructor initializes the calculator engine
    public CalculatorUI()
    {
        _calculatorEngine = new CalculatorEngine();
    }

    // Method to run the calculator application
    public void RunCalculator()
    {
        // Welcome message
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("                    WELCOME TO C# CALCULATOR\n");
        Console.WriteLine("--------------------------------------------------------------");

        double firstNumber;
        double secondNumber;
        double result = 0;
        int counter = 1;
        char operatorChoice;

        // Main loop for running the calculator
        while (true)
        {
            // Input for the first number
            firstNumber = Input($"Enter the first number: ");

            // Loop for continuous calculations until user chooses to exit
            while (true)
            {
                // Get user's choice of operation
                operatorChoice = GetOperatorChoice();

                // If not equals operation, get the second number
                if (operatorChoice != '=')
                {
                    if (counter == 2)
                    {
                        firstNumber = result;
                    }

                    secondNumber = Input($"Enter the second number: ");
                }
                else
                {
                    Console.WriteLine($"The Final Answer is: {result}");
                    break; // Exit loop if equals operation
                }

                // Compute the result using the calculator engine
                result = _calculatorEngine.Compute(firstNumber, secondNumber, operatorChoice);
                Console.WriteLine($"Result: {firstNumber} {operatorChoice} {secondNumber} = {result}");

                counter = 2;
            }

            // Prompt user for another calculation or exit
            Console.WriteLine("Do you want to do another calculation? (Y/N).");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain != "y")
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("                    THANK YOU FOR USING C# CALCULATOR\n                            BY: CARL BERGADO");
                Console.WriteLine("--------------------------------------------------------------");
                break; // Exit the calculator application
            }
            else
            {
                Console.Clear();
                continue; // Restart the calculator
            }
        }
    }

    // Method to get user input for numbers
    private double Input(string prompt)
    {
        double number;
        while (true)
        {
            try
            {
                Console.Write(prompt);
                number = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch
            {
                Console.Write("Invalid input. Please enter a valid number: \n");
            }
        }
        return number;
    }

    // Method to get user input for operator choice
    private char GetOperatorChoice()
    {
        char choice;
        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("[+] ADDITION");
            Console.WriteLine("[-] SUBTRACTION");
            Console.WriteLine("[*] MULTIPLICATION");
            Console.WriteLine("[/] DIVISION");
            Console.WriteLine("[=] EQUALS (DISPLAY)");
            Console.Write("\nEnter your choice: ");

            if (!char.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            if (choice == '+' || choice == '-' || choice == '/' || choice == '*' || choice == '=')
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter one of the specified operators: +, -, /, *, =.");
            }
        }
    }
}

// Calculator engine class responsible for performing calculations
class CalculatorEngine
{
    // Method to compute the result based on the selected operation
    public double Compute(double firstNumber, double secondNumber, char operation)
    {
        Operation op;
        switch (operation)
        {
            case '+':
                op = new Addition();
                break;
            case '-':
                op = new Subtraction();
                break;
            case '*':
                op = new Multiplication();
                break;
            case '/':
                op = new Division();
                break;
            default:
                throw new ArgumentException("Invalid operator");
        }

        return op.OpCompute(firstNumber, secondNumber);
    }
}

// Operation abstract class representing mathematical operations
abstract class Operation
{
    // Abstract method to perform the operation
    public abstract double OpCompute(double firstNumber, double secondNumber);
}

// Derived class for addition operation
class Addition : Operation
{
    // Implementation of addition operation
    public override double OpCompute(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber;
    }
}

// Derived class for subtraction operation
class Subtraction : Operation
{
    // Implementation of subtraction operation
    public override double OpCompute(double firstNumber, double secondNumber)
    {
        return firstNumber - secondNumber;
    }
}

// Derived class for multiplication operation
class Multiplication : Operation
{
    // Implementation of multiplication operation
    public override double OpCompute(double firstNumber, double secondNumber)
    {
        return firstNumber * secondNumber;
    }
}

// Derived class for division operation
class Division : Operation
{
    // Implementation of division operation
    public override double OpCompute(double firstNumber, double secondNumber)
    {
        if (secondNumber == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return double.NaN;
        }
        else
        {
            return firstNumber / secondNumber;
        }
    }
}

// Main program
class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
        CalculatorUI calculatorUI = new CalculatorUI();
        calculatorUI.RunCalculator(); // Start the calculator application
    }
}
