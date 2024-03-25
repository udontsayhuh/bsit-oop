using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to my Calculator!");

        // Loop to allow multiple calculations
        while (true)
        {
            // Input for the first number
            Console.Write("Enter the first number: ");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; // Restart the loop if input is invalid
            }

            // Input for the second number
            Console.Write("Enter the second number: ");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; // Restart the loop if input is invalid
            }

            // Prompt user to select an operator
            Console.WriteLine("Select an operator:");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");

            // Input for the operator choice
            Console.Write("Enter your choice : ");
            string operatorChoice = Console.ReadLine();
            double result = 0;

            // Perform calculation based on operator choice
            switch (operatorChoice)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        continue; // Restart the loop if division by zero is attempted
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice!"); // Display error message for invalid operator choice
                    continue; // Restart the loop if operator choice is invalid
            }

            // Display the result of the calculation
            Console.WriteLine("Result: " + result);

            // Ask the user if they want to perform another calculation
            Console.Write("Do you want to perform another calculation? (yes/no): ");
            string again = Console.ReadLine();
            if (again.ToLower() != "yes")
                break; // Exit the loop if the user does not want to perform another calculation
        }
    }
}
