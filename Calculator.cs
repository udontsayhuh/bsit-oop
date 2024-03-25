using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator calculator = new BasicCalculator(); // Encapsulation: Create an object of BasicCalculator class to encapsulate all calculator functionality

            while (true)
            {
                // Prompt the user to enter the first numerical value
                Console.WriteLine("Please enter a numerical value: ");
                string userInput1 = Console.ReadLine();

                // Validate if the user input is numeric
                if (!calculator.IsNumeric(userInput1)) // Abstraction: Check if the user input is numeric, abstracting away the details of numeric validation
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                    return;
                }

                double number1 = Convert.ToDouble(userInput1);

                // Prompt the user to enter an operator
                Console.WriteLine("Please enter one of the four fundamental operators (+, -, /, *): ");
                string userInput2 = Console.ReadLine();

                // Validate if the entered operator is valid
                if (!calculator.IsValidOperator(userInput2)) // Abstraction: Validate the operator, abstracting away the details of operator validation
                {
                    Console.WriteLine("Invalid operator. Please enter one of the following operators: +, -, /, *");
                    return;
                }

                // Prompt the user to enter the second numerical value
                Console.WriteLine("Please enter another numerical value: ");
                string userInput3 = Console.ReadLine();

                // Validate if the user input is numeric
                if (!calculator.IsNumeric(userInput3)) // Abstraction: Check if the user input is numeric, abstracting away the details of numeric validation
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                    return;
                }

                double number2 = Convert.ToDouble(userInput3);

                // Perform calculation based on user inputs
                double result = calculator.Calculate(number1, number2, userInput2);

                // Display the result of the calculation
                Console.WriteLine($"Result: {result}");

                // Ask the user if they want to perform another calculation
                Console.WriteLine("Do you want to do another calculation? (yes/no)");
                string userInput4 = Console.ReadLine();

                if (userInput4 == "no")
                {
                    break;
                }
            }
        }
    }

    // Calculator class
    public class BasicCalculator
    {
        // Method to check if a string represents a numeric value
        public bool IsNumeric(string input)
        {
            double number;
            return double.TryParse(input, out number);
        }

        // Method to validate if an operator is one of the four fundamental operators
        public bool IsValidOperator(string @operator)
        {
            return @operator == "+" || @operator == "-" || @operator == "*" || @operator == "/";
        }

        // Method to perform arithmetic calculation based on the operator
        public double Calculate(double num1, double num2, string @operator)
        {
            switch (@operator)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    return num1 / num2;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
