using System;
using System.Dynamic;


// Encapsulation
// The Calculator class encapsulates methods for performing mathematical operations 
class Calculator
{
// Abstraction
// Methods to perform mathematical operations hide the complex implementation details
    // Method to add two numbers
    public double PerformAddition(double num1, double num2)
    {
        return num1 + num2;
    }

    // Method to subtract two numbers
    public double PerformSubtraction(double num1, double num2)
    {
        return num1 - num2;
    }
    // Method to multiply two numbers
    public double PerformMultiplication(double num1, double num2)
    {
        return num1 * num2;
    }
    // Method to divide two numbers, handles division by zero
    public double PerformDivision(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero.");
            return double.NaN;
        }
        return num1 / num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double currentResult = 0; // Initialize variables
        double currentOperand;
        char currentOperation = '+'; // Initialize operation as addition

        Calculator calculator = new Calculator();

        Console.WriteLine("---- WELCOME TO MY CALCULATOR ----");  // Creating an instance of Calculator
        // Loop to ask if the user wants to start a new calculation session
        
        while (true)
        {
            while (true)
            {// Prompt user to input a number or "="
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine().Trim();

                // Parse the input as a number
                if (!double.TryParse(input, out currentOperand))
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                    continue;
                }
                // Perform the appropriate calculation based on the previous operation
                switch (currentOperation)
                {
                    case '+':
                        currentResult = calculator.PerformAddition(currentResult, currentOperand); // Polymorphism Calling Add method with different parameters
                        break;
                    case '-':
                        currentResult = calculator.PerformSubtraction(currentResult, currentOperand); // Polymorphism Calling Subtract method with different parameters

                        break;
                    case '*':
                        currentResult = calculator.PerformMultiplication(currentResult, currentOperand); // Polymorphism Calling Multiply method with different parameters

                        break;
                    case '/':
                        currentResult = calculator.PerformDivision(currentResult, currentOperand); // Polymorphism Calling Divide method with different parameters
                        break;
                }
                // Prompt user to input an operation or "="
                string operationInput;
                do
                {
                    Console.WriteLine("Enter an operation (+, -, *, /) or '=' to compute:");
                    operationInput = Console.ReadLine().Trim();
                } while (operationInput != "+" && operationInput != "-" && operationInput != "*" && operationInput != "=" && operationInput != "/");

                // Check if input is "=" to compute and break the loop
                if (operationInput == "=")
                    break;

                currentOperation = operationInput[0];
            }
            // Display the final result
            Console.WriteLine($"The result is: {currentResult}");

            // Ask if the user wants to start a new calculation session
            Console.WriteLine("Do you want to start a new calculation session? (yes/no)");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
                break;

            currentResult = 0;
            currentOperation = '+';
        }
        // Display a thank you message
        Console.WriteLine("Thank you for using the calculator. Press Enter to exit.");
        Console.ReadLine(); // Wait for user to press Enter before exiting
    }
}
