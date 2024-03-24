using System;

// Abstract class representing an arithmetic operator
abstract class Operator
{
    // Abstract method for performing an arithmetic operation
    public abstract double Perform(double num1, double num2);
}

// Inheritance was applied in the following subclasses
// Addition Operation Class
class Addition : Operator
{
    public override double Perform(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Subtraction Operation Class
class Subtraction : Operator
{
    public override double Perform(double num1, double num2)
    {
        return num1 - num2;
    }
}

// Multiplication Operation Class
class Multiplication : Operator
{
    public override double Perform(double num1, double num2)
    {
        return num1 * num2;
    }
}

// Division Operation Class
class Division : Operator
{
    public override double Perform(double num1, double num2)
    {
        // Check for division by zero
        if (num2 != 0)
            return num1 / num2;
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return double.NaN; // Return NaN for division by zero
        }
    }
}

// Encapsulates the data and logic for handling user interactions and calculation
class Calculator
{
    // Fields for storing user inputs and operator
    public double num1, num2;
    public char symbol;
    public bool answer;
    private Operator chosenOpe;

    // Method to get the first number from the user with exception handling
    public double FirstNum(string prompt)
    {
        double number;

        while (true)
        {
            Console.Write(prompt);
            try
            {
                number = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid input. Program will now exit.");
                Console.WriteLine("Press any key to exit...");
                Console.WriteLine("\n+----------+----------+----------+----------+----------+");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        return number;
    }

    // Method to get the second number from the user with exception handling
    public double SecondNum(string prompt)
    {
        double number;

        while (true)
        {
            Console.Write(prompt);
            try
            {
                number = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
        return number;
    }


    // Method to get the operator symbol from the user
    public char OperatorSymbol()
    {
        char choice;

        while (true)
        {
            Console.Write("\nEnter an operation (+, -, *, /): ");
            choice = Convert.ToChar(Console.ReadLine());

            // Instantiate the appropriate operator class based on user choice; Polymorphism was applied
            switch (choice)
            {
                case '+':
                    chosenOpe = new Addition();
                    break;
                case '-':
                    chosenOpe = new Subtraction();
                    break;
                case '*':
                    chosenOpe = new Multiplication();
                    break;
                case '/':
                    chosenOpe = new Division();
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please try again.");
                    continue;
            }
            break;
        }
        return choice;
    }


    // Method to display the calculation result
    public string DisplayResult()
    {
        if (symbol == '/' && num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return null; // Return null when division by zero occurs
        }
        else
        {
            double result = chosenOpe.Perform(num1, num2);
            return $"\n{num1} {symbol} {num2} = {result}";
        }
    }

    // Method to ask the user if they want to perform another calculation
    public void AskAgain()
    {
        Console.Write("\nWould you like to perform another calculation? (Y/N): ");
        char reply = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

        // Check the user's input
        if (reply == 'Y')
        {
            answer = true;
        }
        else if (reply == 'N')
        {
            answer = false;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'Y' for Yes or 'N' for No.");
            AskAgain();
        }
    }
}

// Main program class
class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        // Main loop for performing calculations
        do
        {
            Console.WriteLine("\n+----------+----------+----------+----------+----------+");
            // Get user inputs
            calculator.num1 = calculator.FirstNum("\nEnter the first number: ");
            calculator.symbol = calculator.OperatorSymbol();
            calculator.num2 = calculator.SecondNum("\nEnter the second number: ");

            // Display and handle calculation result
            Console.WriteLine(calculator.DisplayResult());
            calculator.AskAgain();

        } while (calculator.answer);

        Console.WriteLine("\nEnd of Program.\n");
        Console.WriteLine("+----------+----------+----------+----------+----------+");
    }
}
