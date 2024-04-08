using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    // Main program class
    class Program
    {
        // Main method
        static void Main(string[] args)
        {
            // Encapsulation: Create an instance of the BasicCalculator class to encapsulate all calculator functionality
            BasicCalculator calculator = new BasicCalculator();

            // Loop to allow for multiple calculations
            while (true)
            {
                List<double> numbers = new List<double>();
                List<string> operators = new List<string>();

                // Prompt the user to enter numerical values and operators
                Console.WriteLine("Enter numerical values and operators. Enter '=' to calculate.");

                // Inner loop to gather user input for one calculation
                while (true)
                {
                    string userInput = Console.ReadLine();

                    // Check if user input is to calculate
                    if (userInput == "=")
                    {
                        try
                        {
                            // Abstraction: Calculate the result using the BasicCalculator
                            double result = calculator.Calculate(numbers, operators);
                            // Display the result
                            Console.WriteLine($"Result: {result}");
                        }
                        catch (Exception ex)
                        {
                            // Handle errors and display error message
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                        break; // Exit inner loop
                    }
                    else if (calculator.IsNumeric(userInput))
                    {
                        // Abstraction: Add numeric input to the list of numbers
                        numbers.Add(Convert.ToDouble(userInput));
                    }
                    else if (calculator.IsValidOperator(userInput))
                    {
                        // Abstraction: Add operator input to the list of operators
                        operators.Add(userInput);
                    }
                    else
                    {
                        // Display error message for invalid input
                        Console.WriteLine("Invalid input.");
                    }
                }

                // Ask the user if they want to perform another calculation
                Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                string userInput4 = Console.ReadLine();

                // Check if the user wants to perform another calculation
                if (userInput4.ToLower() != "yes")
                {
                    break; // Exit the outer loop if the user does not want to perform another calculation
                }
            }
        }
    }

    // Calculator class
    public class BasicCalculator
    {
        // Abstraction: Method to check if a string represents a numeric value
        public bool IsNumeric(string input)
        {
            double number;
            return double.TryParse(input, out number);
        }

        // Abstraction: Method to validate if an operator is one of the four fundamental operators
        public bool IsValidOperator(string @operator)
        {
            return @operator == "+" || @operator == "-" || @operator == "*" || @operator == "/";
        }

        // Abstraction: Method to perform arithmetic calculation based on the numbers and operators provided
        public double Calculate(List<double> numbers, List<string> operators)
        {
            // Encapsulation: Check if the number of numbers is one more than the number of operators
            if (numbers.Count == operators.Count + 1)
            {
                double result = numbers[0];
                for (int i = 0; i < operators.Count; i++)
                {
                    // Encapsulation: Perform the calculation based on the operator
                    switch (operators[i])
                    {
                        case "+":
                            result += numbers[i + 1];
                            break;
                        case "-":
                            result -= numbers[i + 1];
                            break;
                        case "*":
                            result *= numbers[i + 1];
                            break;
                        case "/":
                            // Encapsulation: Check for division by zero
                            if (numbers[i + 1] == 0)
                            {
                                throw new DivideByZeroException("Cannot divide by zero.");
                            }
                            result /= numbers[i + 1];
                            break;
                        default:
                            // Encapsulation: Throw exception for invalid operator
                            throw new InvalidOperationException("Invalid operator.");
                    }
                }
                return result;
            }
            else
            {
                // Encapsulation: Throw exception for invalid expression
                throw new InvalidOperationException("Invalid expression.");
            }
        }
    }
}
