using System;
// Encapsulation
// The Calculator class encapsulates methods for performing mathematical operations 
class Calculator
{
    // Abstraction
    // Methods to perform mathematical operations hide the complex implementation details
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
        double num1 = 0, num2, ans = 0; // Initialize variables
        char operation = '+'; // Initialize operation as addition

        Calculator calculator = new Calculator(); // Creating an instance of Calculator

        Console.WriteLine("----WELCOME TO MY CALCULATOR----");

        // Loop to ask if the user wants to start a new calculation session
        while (true)
        {
            // Loop to accept values and operations until "=" is entered
            while (true)
            {
                // Prompt user to input a number or "="
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine().Trim();

                // Check if input is "=" to compute and break the loop
                if (input == "=")
                    break;

                // Parse the input as a number
                if (!double.TryParse(input, out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                    continue;
                }

                // Perform the appropriate calculation based on the previous operation
                switch (operation)
                {
                    case '+':
                        ans = calculator.Add(num1, num2); // Polymorphism Calling Add method with different parameters
                        break;
                    case '-':
                        ans = calculator.Subtract(num1, num2); // Polymorphism Calling Subtract method with different parameters
                        break;
                    case '*':
                        ans = calculator.Multiply(num1, num2); // Polymorphism Calling Multiply method with different parameters
                        break;
                    case '/':
                        ans = calculator.Divide(num1, num2); // Polymorphism Calling Divide method with different parameters
                        break;
                }

                // Store the result for subsequent calculations
                num1 = ans;

                // Prompt user to input an operation or "="
                string opInput;
                do
                {
                    Console.WriteLine("Enter an operation (+, -, *, /) or '=' to compute:");
                    opInput = Console.ReadLine().Trim();
                } while (opInput != "+" && opInput != "-" && opInput != "*" && opInput != "=" && opInput != "/");

                // Check if input is "=" to compute and break the loop
                if (opInput == "=")
                    break;

                operation = opInput[0];
            }

            // Display the final result
            Console.WriteLine($"The result is: {ans}");

            // Ask if the user wants to start a new calculation session
            Console.WriteLine("Do you want to start a new calculation session? (yes/no)");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
                break;

            // Reset variables for a new session
            num1 = 0;
            operation = '+';
            ans = 0;
        }

        // Display a thank you message
        Console.WriteLine("Thank you for using the calculator. Press Enter to exit.");
        Console.ReadLine(); // Wait for user to press Enter before exiting
    }
}
