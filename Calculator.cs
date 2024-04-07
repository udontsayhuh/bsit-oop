using System;

namespace Calculator
{
    // Abstract class for mathematical operation
    // parent
    public abstract class Operation
    {
        // Method to perform the operation
        public abstract double PerformOperation(double num1, double num2);
    }

    // Addition 
    public class Addition : Operation
    {
        // Override the PerformOperation method from the base class
        public override double PerformOperation(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    // Subtraction 
    public class Subtraction : Operation
    {
        // Override the PerformOperation method from the base class
        public override double PerformOperation(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    // Multiplication 
    public class Multiplication : Operation
    {
        // Override the PerformOperation method from the base class
        public override double PerformOperation(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    // Division 
    public class Division : Operation
    {
        // Override the PerformOperation method from the base class
        public override double PerformOperation(double num1, double num2)
        {
            if (num2 == 0)
            {
                // Handle division by zero
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("=============================");
                Console.WriteLine("WELCOME TO CALCULATOR PROGRAM");
                Console.WriteLine("=============================");

                // Attempt to parse the next number
                // new method learned: tryParse -  returns a boolean value indicating whether the conversion was successful or not.
                // tryParse will return true if conversion succeeds, if fail nextNumber will remain 0

                //declaring variables
                double result = 0;
                double nextNumber = 0;

                // while loop:  while user do not put right input (must be a number) it will loop.
                bool validInput = false;
                while (!validInput)
                {
                    Console.WriteLine("Enter your first number: ");
                    if (!double.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine("INVALID INPUT, Enter a valid number!");
                    }
                    else
                    {
                        validInput = true;
                    }
                }

                //while loop: while user do not put the right operator or = it will loop.
                while (true)
                {
                    Console.WriteLine("Enter an operator (+, -, *, /) or = to get the result: ");
                    string operation = Console.ReadLine();
                    if (operation == "=")
                    {
                        // if the user only put the first number and proceed to input "=" without inputing a second number, it will prompt error message.
                        if (nextNumber == 0) 
                        {
                            Console.WriteLine("You need to enter the second number before getting the result."); // if input "=" without second number, prompt this.
                            continue;
                        }

                        Console.WriteLine($"Your result: {result}");
                        break;
                    }


                    // Check if the input is a valid operator
                    if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                    {
                        Console.WriteLine("INVALID OPTION! Please enter a valid operator.");
                        continue; // Skip to the next iteration of the loop
                    }

                    // Attempt to parse the next number
                    // new method learned: tryParse -  returns a boolean value indicating whether the conversion was successful or not.
                    // tryParse will return true if conversion succeeds, if fail nextNumber will remain 0

                    // while loop:  while user do not put right input (must be a number) it will loop.
                    validInput = false;  // Update the existing validInput variable
                    while (!validInput)
                    {
                        Console.WriteLine("Enter the next number: ");
                        if (!double.TryParse(Console.ReadLine(), out nextNumber))
                        {
                            Console.WriteLine("INVALID INPUT, Enter a valid number!");
                        }
                        else
                        {
                            validInput = true;  
                        }
                    }

                    // Perform the operation based on the operator entered
                    switch (operation)
                    {
                        case "+":
                            result += nextNumber;
                            break;
                        case "-":
                            result -= nextNumber;
                            break;
                        case "*":
                            result *= nextNumber;
                            break;
                        case "/":
                            // Check for division by zero
                            if (nextNumber == 0)
                            {
                                Console.WriteLine("Cannot divide by zero");
                                continue ;
                            }
                            result /= nextNumber;
                            break;
                    }
                }

                // After displaying the result, ask the user if they want to continue
                Console.WriteLine("Would you like to continue? (Y)/(N)");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("==========================================");
            Console.WriteLine("THANK YOU FOR USING THE CALCULATOR PROGRAM");
            Console.WriteLine("==========================================");

            Console.ReadKey();
        }


    }
}
