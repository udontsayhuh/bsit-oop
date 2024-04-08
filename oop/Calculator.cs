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
                double num;
                string userInput;
                // Prompts for the first number then assigns it to result
                while (true)
                {
                    userInput = Console.ReadLine();
                    if (double.TryParse(userInput, out num))
                    {
                        result = num;
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
                    string operatr = Console.ReadLine();
                    if (operatr == "=") // Will check for (=) to exit the loop
                    {
                        break;
                    }
                    // will reiterate the loop if operator entered is invalid
                    if (operatr != "+" && operatr != "-" && operatr != "*" && operatr != "/")
                    {
                        Console.WriteLine("Invalid operator. Please enter (+, -, *, /) only or (=) to finish the calculation.");
                        continue;
                    }
                    // Prompts for the num to be calculated wit the result
                    double nextNum;
                    if (!double.TryParse(Console.ReadLine(), out nextNum))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }
                    // Calculations to do based of operator
                    switch (operatr)
                    {
                        case "+":// Addition
                            result += nextNum;
                            break;
                        case "-": // Subtraction
                            result -= nextNum;
                            break;
                        case "*": // Multiplication
                            result *= nextNum;
                            break;
                        case "/": // Division
                            if (nextNum != 0)
                            {
                                result /= nextNum;
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

                string another;
                while (true)// Will continue to prompt untill user inputs a valid choice
                {
                    Console.Write("Do you want to perform another calculation (y/n)? ");
                    another = Console.ReadLine().ToLower();
                    if (another == "n" || another == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    }
                }
                // Will only stop the program if the user enters N/n
                if (another == "n")
                {
                    Console.WriteLine("\nExiting the program...");
                    break;
                }
            }
        }
    }
}
