using System;

// Abstract class representing an arithmetic operator
abstract class Operator
{
    // Abstract method for performing an arithmetic operation
    public abstract double Perform(double firstNum, double secondNum);
}

// Inheritance was applied in the following subclasses
// Addition Operation Class
class Addition : Operator
{
    public override double Perform(double firstNum, double secondNum)
    {
        return firstNum + secondNum;
    }
}

// Subtraction Operation Class
class Subtraction : Operator
{
    public override double Perform(double firstNum, double secondNum)
    {
        return firstNum - secondNum;
    }
}

// Multiplication Operation Class
class Multiplication : Operator
{
    public override double Perform(double firstNum, double secondNum)
    {
        return firstNum * secondNum;
    }
}

// Division Operation Class
class Division : Operator
{
    public override double Perform(double firstNum, double secondNum)
    {
        // Check for division by zero
        if (secondNum != 0)
            return firstNum / secondNum;
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
    public double firstNum, secondNum;
    public char symbol;
    public bool answer;
    private Operator chosenOpe;

    // Method to get the input number from the user with exception handling
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
        if (symbol == '/' && secondNum == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        else
        {
            double result = chosenOpe.Perform(firstNum, secondNum);
            firstNum = result; // Update num1 for further calculations
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

            calculator.firstNum = calculator.InputNum(); // Get the first input number from user

            // Loop to get the operator symbol and perform the calculations
            while (true)
            {
                calculator.symbol = calculator.OperatorSymbol(); // Get the operator symbol from user

                // Check if '=' is entered so it can display the result
                if (calculator.symbol == '=')
                {
                    Console.WriteLine($"\nResult: {calculator.firstNum}");
                    break;
                }

                calculator.secondNum = calculator.InputNum(); // Get the second (or further) number/s from user
                calculator.Calculate(); // Perform the calculation based on the operator
            }

            calculator.AskAgain(); // Ask the user if they want to perform another calculation

        } while (calculator.answer); // Repeat the loop if user wants to continue

        Console.WriteLine("\nEnd of Program.\n");
        Console.WriteLine("+----------+----------+----------+----------+----------+");
    }
}
