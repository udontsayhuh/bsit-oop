using System;

// Encapsulation: The CalculatorBase class encapsulates methods for performing mathematical operations 
class CalculatorBase
{
    // Method to add two numbers
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    // Method to subtract two numbers
    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    // Method to multiply two numbers
    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    // Method to divide two numbers, handles division by zero
    public double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero.");
            return double.NaN; // Not a number
        }
        return num1 / num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double num1, num2, ans; // Declare variables
        char operation; // Variable to store the operator

        CalculatorBase calculator = new CalculatorBase(); // Creating an instance of CalculatorBase
        
         Console.WriteLine("----WELCOME TO MY CALCULATOR----");

        // Prompt user to input the first number
        Console.WriteLine("Enter the first number:");
        
        // Read user input for the first number, validate if it's numerical
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a numerical value.");
            return;
        }

        // Prompt user to select the operation
        Console.WriteLine("Operator to use (* for multiplication, / for division, + for addition, or - for subtraction):");
        
        // Read user input for the operation, validate if it's one of the allowed operators
        if (!char.TryParse(Console.ReadLine(), out operation) || (operation != '*' && operation != '/' && operation != '+' && operation != '-'))
        {
            Console.WriteLine("Invalid operation selected.");
            return;
        }

        // Prompt user to input the second number
        Console.WriteLine("Enter the second number:");
        
        // Read user input for the second number, validate if it's numerical
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a numerical value.");
            return;
        }

        // Perform the appropriate calculation based on the selected operation
        switch (operation)
        {
            case '*':
                ans = calculator.Multiply(num1, num2);
                Console.WriteLine($"The product of {num1} and {num2} is {ans}.");
                break;
            case '/':
                ans = calculator.Divide(num1, num2);
                if (!double.IsNaN(ans)) // Check if division by zero occurred
                    Console.WriteLine($"The quotient of {num1} and {num2} is {ans}.");
                break;
            case '+':
                ans = calculator.Add(num1, num2);
                Console.WriteLine($"The sum of {num1} and {num2} is {ans}.");
                break;
            case '-':
                ans = calculator.Subtract(num1, num2);
                Console.WriteLine($"The difference of {num1} and {num2} is {ans}.");
                break;
        }

        // Ask the user if they want to perform another calculation
        Console.WriteLine("Do you want to perform another calculation? (yes/no)");
        string repeat = Console.ReadLine().ToLower();

        // If the user wants to perform another calculation, recursively call Main
        if (repeat == "yes")
        {
            Main(args);
        }
        else
        {
            // If the user doesn't want to perform another calculation, display a thank you message
            Console.WriteLine("Thank you for using the calculator. Press Enter to exit.");
            Console.ReadLine(); // Wait for user to press Enter before exiting
        }
    }
}
