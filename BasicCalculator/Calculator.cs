// Darben V. Lamonte
// BSIT 2-2

using System;
using System.Reflection.Emit;


class Calculate
{
    // implementing encapsulation
    private double num1;
    private double num2;
    private char operand;
    private double result;

    // use properties to access the private fields
    public double Num1
    {
        get { return num1; }
        set { num1 = value; }
    }

    public double Num2
    {
        get { return num1; }
        set { num2 = value; }
    }

    public char Operand
    {
        get { return operand; }
        set { operand = value; }
    }

    // constructor
    public Calculate(double num1, double num2, char operand)
    {
        Num1 = num1;
        Num2 = num2;
        Operand = operand;
    }

    // a method that calculates and display the result
    // implementing abstraction
    // the calculation is hidden from the user and only display the result
    public virtual void DisplayResult()
    {
        switch (operand)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                break;
        }

        Console.WriteLine("\nResult:");
        Console.WriteLine($"{num1} {operand} {num2} = {result}");
    }

}

// implementing inheritance
class CalculateAgain : Calculate
{
    private int numberOfTries;

    public int NumberOfTries
    {
        get { return numberOfTries; }
        set { numberOfTries = value; }
    }

    public CalculateAgain(double num1, double num2, char operand, int numberOfTries) : base(num1, num2, operand)
    {
        Num1 = num1;
        Num2 = num2;
        Operand = operand;
        NumberOfTries = numberOfTries;
    }

    // implementing polymorphism
    public override void DisplayResult()
    {
        base.DisplayResult();
        Console.WriteLine($"\nNumber of times you have calculated: {numberOfTries}");
    }

}


class BasicCalculator
{
    // declaring variables as global to be accessed by all methods
    static double num1;
    static double num2;
    static char operand;

    static void Main(string[] args)
    {
        // calls the method to get the user input
        UserInput();

        // create an object of the Calculate class
        Calculate firstCalculation = new Calculate(num1, num2, operand);

        // display the result
        firstCalculation.DisplayResult();

        // asks the user if they want to do another calculation
        // initialize the number of tries to 1 because we already did one calculation
        int numberOfTries = 1;

        while (true)
        {
            Console.Write("\nDo you want to do another calculation? (y/n): ");
            string stringChoice = Console.ReadLine().ToLower();

            char choice = Convert.ToChar(stringChoice);

            if (choice == 'y')
            {
                numberOfTries += 1; // increment the number of tries

                Console.Clear(); // clear the previous display on the screen for cleanliness of output

                UserInput(); // calls the method to get the user input
                
                // create an object of the Calculate again class
                CalculateAgain anotherCalculation = new CalculateAgain(num1, num2, operand, numberOfTries);

                // displays the result
                anotherCalculation.DisplayResult();

            }
            else if (choice == 'n')
            {
                Console.WriteLine("\nExiting the program...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter y or n.");
            }
        }
    }

    // a method for displaying the header
    static void Header()
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("           Basic Calculator         ");
        Console.WriteLine("------------------------------------");
    }

    // a method to ask for user input
    static void UserInput()
    {
        // calls the Header() method
        Header();

        // ask the user for input 
        Console.Write("Enter the first number: ");
        string stringNum1 = Console.ReadLine();

        // checks if the input is a valid number
        if (ValidNumber(stringNum1))
        {
            num1 = double.Parse(stringNum1);

            // calls the method to ask user for operator
            InputOperator();
        }
        else
        {
            // display error message and terminate the program
            Console.WriteLine("invalid input. Must be a numeric value.");
            Environment.Exit(0);
        }
    }

    // a method to check if the input is a valid number
    static bool ValidNumber(string userInput)
    {
        if (double.TryParse(userInput, out double number))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // a method to get the user input for the operator
    static void InputOperator()
    {
        // prompts the user to input the operator until its valid
        while (true)
        {
            Console.Write("Enter the operator (+ , - , * , / ): ");
            string userOperator = Console.ReadLine();

            // checks if the input is a valid operator
            if (userOperator == "+" || userOperator == "-" || userOperator == "*" || userOperator == "/")
            {
                operand = Convert.ToChar(userOperator);

                // calls the method to ask the user input for the second number
                InputSecondNumber();

                break;
            }
            else
            {
                Console.WriteLine("Invalid operator. Please choose from +, -, *, /.\n");
            }

        }
    }

    // a method to get the user input for second number
    static void InputSecondNumber()
    {
        Console.Write("Enter the second number: ");
        string stringNum2 = Console.ReadLine();

        // prompts the user to input a valid number
        while (true)
        {
            if (ValidNumber(stringNum2))
            {
                num2 = double.Parse(stringNum2);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.\n");
            }
        }

    }
}
