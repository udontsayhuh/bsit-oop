using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nCalculator. Press (=) to finish the calculation");
                double result = 0;
                double firstNumber;
                string userInput;
                // Prompts for the first number then assigns it to result
                while (true)
                {
                    userInput = Console.ReadLine();
                    if (double.TryParse(userInput, out firstNumber))
                    {
                        result = firstNumber;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
                // Prompts for an operator and number to be calculated with result
                while (true)
                {
                    string operationInput = Console.ReadLine();
                    if (operationInput == "=") // Will check for (=) to exit the loop
                    {
                        break;
                    }
                    // will reiterate the loop if operator entered is invalid
                    if (operationInput != "+" && operationInput != "-" && operationInput != "*" && operationInput != "/")
                    {
                        Console.WriteLine("Invalid operator. Please enter (+, -, *, /) only or (=) to finish the calculation.");
                        continue;
                    }
                    // Prompts for the num to be calculated wit the result
                    double nextNumber;
                    if (!double.TryParse(Console.ReadLine(), out nextNumber))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }
                    // Calculations to do based of operator
                    switch (operationInput)
                    {
                        case "+":// Addition
                            result += nextNumber;
                            break;
                        case "-": // Subtraction
                            result -= nextNumber;
                            break;
                        case "*": // Multiplication
                            result *= nextNumber;
                            break;
                        case "/": // Division
                            if (nextNumber != 0)
                            {
                                result /= nextNumber;
                            }
                            else
                            {
                                Console.WriteLine("Cannot divide by zero.");
                                continue;
                            }
                            break;
                    }
                }
                // Prints the result of the calculation
                Console.WriteLine("Result: " + result);

                string anotherCalculation;
                while (true)// Will continue to prompt untill user inputs a valid choice
                {
                    Console.Write("Do you want to perform another calculation (y/n)? ");
                    anotherCalculation = Console.ReadLine().ToLower();
                    if (anotherCalculation == "n" || anotherCalculation == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    }
                }
                // Will only stop the program if the user enters N/n
                if (anotherCalculation == "n")
                {
                    Console.WriteLine("\nExiting the program...");
                    break;
                }
            }
        }
    }
}
