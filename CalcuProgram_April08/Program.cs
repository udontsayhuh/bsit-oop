﻿using System;
using System.Collections.Generic;

// Base class representing a calculator operation
//Implementing Encapsulation
abstract class CalculatorOperation //Abstraction
{
    public abstract double Calculate(double currentResult, double nextNumber);
}

// Derived class representing addition operation
class AdditionOperation : CalculatorOperation //Inheritance 
{
    public override double Calculate(double currentResult, double nextNumber)
    {
        return currentResult + nextNumber;
    }
}

// Derived class representing subtraction operation
class SubtractionOperation : CalculatorOperation //Inheritance
{
    public override double Calculate(double currentResult, double nextNumber)
    {
        return currentResult - nextNumber;
    }
}

// Derived class representing multiplication operation
class MultiplicationOperation : CalculatorOperation //Inheritance
{
    public override double Calculate(double currentResult, double nextNumber)
    {
        return currentResult * nextNumber;
    }
}

// Derived class representing division operation
class DivisionOperation : CalculatorOperation //inheritance
{
    public override double Calculate(double currentResult, double nextNumber) //Polymorphism
    {
        if (nextNumber == 0)
        {
            Console.WriteLine("\n\tCannot divide by zero");
            return currentResult; // Return current result unchanged
        }
        else
        {
            return currentResult / nextNumber;
        }
    }
}

class Calculator
{
    static void Main()
    {
        bool restart = true;

        while (restart)
        {
            Console.WriteLine("\t\t\tWelcome to Calculator!\n       ");

            List<double> numbers = new List<double>();
            List<CalculatorOperation> operations = new List<CalculatorOperation>();

            while (true)
            {
                Console.Write("\tEnter a number to calculate: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double num))
                {
                    numbers.Add(num);

                    // Ask the user for operator 
                    while (true)
                    {
                        Console.Write("\tEnter an operator: ");
                        string op_str = Console.ReadLine();

                        CalculatorOperation operation = null;
                        switch (op_str)
                        {
                            case "+":
                                operation = new AdditionOperation();
                                break;
                            case "-":
                                operation = new SubtractionOperation();
                                break;
                            case "*":
                                operation = new MultiplicationOperation();
                                break;
                            case "/":
                                operation = new DivisionOperation();
                                break;
                            case "=":
                                if (numbers.Count == 0 || operations.Count == 0)
                                {
                                    Console.WriteLine("\tInvalid input. Please enter at least one number and one operator before using '='.");
                                    break; // Restart the loop if lists are empty
                                }
                                else
                                {
                                    double result = numbers[0]; // Initialize result with the first number

                                    for (int i = 0; i < operations.Count; i++)
                                    {
                                        result = operations[i].Calculate(result, numbers[i + 1]);
                                    }

                                    Console.WriteLine($"\n\tResult: {result}");
                                    goto tryAgain;
                                }
                            default:
                                Console.WriteLine("\n\tInvalid operator! Please enter a valid operator!");
                                continue;
                        }

                        if (operation != null)
                        {
                            operations.Add(operation);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\tInvalid input. Please enter a valid number");
                    continue; // Restart the loop if invalid number format
                }
            }

        tryAgain:
            Console.WriteLine("\n\tDo you want to use the calculator again? (Y/N)");
            string choice = Console.ReadLine();

            if (choice.ToUpper() != "Y")
            {
                restart = false;
            }
            else
            {
                Console.Clear();
                numbers.Clear(); // Clear the list of numbers
                operations.Clear(); // Clear the list of operations
            }
        }
    }
}
