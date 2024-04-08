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

    // Method to get the second number from the user with exception handling
    public double InputNum()
    {
        double number;

        while (true)
        {
            Console.Write("\nEnter a number: ");
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
            Console.Write("\nEnter an operation (+, -, *, /, =): ");
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
                case '=':
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please try again.");
                    continue;
            }
            break;
        }
        return choice;
    }

    // Method to calculate the input numbers
    public void Calculate()
    {
        if (symbol == '/' && num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        else
        {
            double result = chosenOpe.Perform(num1, num2);
            num1 = result; // Update num1 for further calculations
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

            calculator.num1 = calculator.InputNum();

            while (true)
            {
                calculator.symbol = calculator.OperatorSymbol();

                if (calculator.symbol == '=')
                {
                    Console.WriteLine($"\nResult: {calculator.num1}");
                    break;
                }

                calculator.num2 = calculator.InputNum();
                calculator.Calculate();
            }

            calculator.AskAgain();

        } while (calculator.answer);

        Console.WriteLine("\nEnd of Program.\n");
        Console.WriteLine("+----------+----------+----------+----------+----------+");
    }
}
