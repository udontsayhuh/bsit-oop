using System;
using System.Collections.Generic;

class Calculator
{
    static void Main()
    {
        // Starting Loop
        while (true) 
        {
            List<double> numbers = new List<double>();
            List<char> operations = new List<char>();

            bool hasPerformedCalculation = false;

            while (true)
            {
                // Input Number
                while (true)
                {
                    Console.Write("\nEnter a number      : ");
                    string input = Console.ReadLine();
                    

                    if (input == "=" && numbers.Count >= 1 && numbers.Count == operations.Count)
                    {
                        break;
                    }

                    double num;
                    if (double.TryParse(input, out num))
                    {
                        if (num == 0 && operations.Count > 0 && operations[operations.Count - 1] == '/')
                        {
                            Console.WriteLine("Invalid! You cannot divide by 0, IDIOT! enter a non-zero number");
                            continue;
                        }
                        numbers.Add(num);
                        break;
                    }
                    else if (input == "=" && hasPerformedCalculation)
                    {
                        break;
                    }
                    else if (input == "=" && numbers.Count >= 1 && numbers.Count != operations.Count)
                    {
                        Console.WriteLine("Invalid! You must enter a number");
                    }
                    else if (input == "=")
                    {
                        Console.WriteLine("Invalid! You must enter a number");
                    }
                    else
                    {
                        Console.WriteLine("Invalid! You must enter a valid number");
                    }
                }

                // Equals
                if (numbers.Count >= 1 && numbers.Count == operations.Count && operations.Contains('='))
                {
                    break;
                }

                // Input Operation
                while (true)
                {
                    Console.Write("\nEnter an operation  : ");
                    string input = Console.ReadLine();
     

                    if (input.Length == 1 && "+-*/=".Contains(input))
                    {
                        if (input == "=" && numbers.Count == 0) // '=' is not allowed as the first operation
                        {
                            Console.WriteLine("Invalid! You must enter a valid number");
                        }
                        else if (input == "=" && operations.Count == 0)
                        {
                            Console.WriteLine("Invalid! first operation must not be");
                            continue;
                        }
                        else
                        {
                            operations.Add(input[0]);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid! You must enter +, -, *, /, or =");
                    }
                }

                // Calculations
                if (numbers.Count >= 2 && numbers.Count == operations.Count && operations.Contains('='))
                {
                    double result = numbers[0];
                    for (int i = 0; i < operations.Count; i++)
                    {
                        if (operations[i] == '/' && numbers[i + 1] == 0)
                        {
                            Console.WriteLine("Invalid! You cannot divide by 0, IDIOT! enter a non-zero number\n");
                            hasPerformedCalculation = false;
                            break;
                        }

                        switch (operations[i])
                        {
                            case '+':
                                result += numbers[i + 1];
                                break;
                            case '-':
                                result -= numbers[i + 1];
                                break;
                            case '*':
                                result *= numbers[i + 1];
                                break;
                            case '/':
                                result /= numbers[i + 1];
                                break;
                        }
                    }
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"Result              : {result}");
                    hasPerformedCalculation = true;

                    // Clear Index Values
                    numbers.Clear();
                    operations.Clear();

                    // Try Again
                    while (true)
                    {
                        Console.Write("\n\n\nDo you want to try again? (Yes/No): ");
                        string choice = Console.ReadLine();

                        // Start again
                        if (choice.ToLower() == "yes")
                        {
                            Console.WriteLine("\n\n\n");
                            break;
                        }

                        // Terminate
                        else if (choice.ToLower() == "no")
                        {
                            Console.WriteLine("\nCalculator Terminated!");
                            Environment.Exit(0);
                        }

                        // Ask
                        else
                        {
                            Console.WriteLine("Invalid! You must enter 'Yes' or 'No'\n");
                        }
                    }
                }
            }
        }
    }
}
