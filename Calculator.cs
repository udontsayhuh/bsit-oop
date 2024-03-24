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
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("=============================");
                Console.WriteLine("WELCOME TO CALCULATOR PROGRAM");
                Console.WriteLine("=============================");

                // attempt to convert input1 to double num1
                // new method learned: tryParse -  returns a boolean value indicating whether the conversion was successful or not.
                // tryParse will return true if conversion succeeds, if fail num1 will remain 0

                // Input validation for num1
                Console.WriteLine("Enter your first number: ");
                string input1 = Console.ReadLine();
                if (!double.TryParse(input1, out num1))
                {
                    Console.WriteLine("INVALID INPUT, Enter a valid number!");
                    return; // Terminate
                }

                // Input validation for num2
                Console.WriteLine("Enter your second number: ");
                string input2 = Console.ReadLine();
                if (!double.TryParse(input2, out num2))
                {
                    Console.WriteLine("INVALID INPUT. Enter a valid number!");
                    return; // Terminate
                }

                // Ask for the operation until valid is entered
                bool checkOperation = false;
                while (!checkOperation)
                {
                    Console.WriteLine("PLEASE PICK YOUR OPTION: ");
                    Console.WriteLine("===================");
                    Console.WriteLine("= + : ADD         =");
                    Console.WriteLine("= - : SUBTRACT    =");
                    Console.WriteLine("= * : MULTIPLY    =");
                    Console.WriteLine("= / : DIVIDE      =");
                    Console.WriteLine("===================");
                    Console.WriteLine("Enter an option: ");

                    string operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "+": // Addition operation
                            result = num1 + num2;
                            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                            checkOperation = true;
                            break;

                        case "-": // Subtraction operation
                            result = num1 - num2;
                            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                            checkOperation = true;
                            break;

                        case "*": // Multiplication operation
                            result = num1 * num2;
                            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                            checkOperation = true;
                            break;

                        case "/": // Division operation
                                  // If user inputs 0 (cannot divide zero)
                            if (num2 == 0)
                            {
                                Console.WriteLine("You cannot divide by zero!");
                            }
                            else
                            {
                                result = num1 / num2;
                                Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                            }
                            checkOperation = true;
                            break;

                        default: // Invalid operation
                            Console.WriteLine("INVALID OPTION! Please enter a valid option.");
                            break;
                    }

                }

                // After result ask the user if they want to continue
                Console.WriteLine("Would you like to continue? (Y)/(N)");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("==========================================");
            Console.WriteLine("THANK YOU FOR USING THE CALCULATOR PROGRAM");
            Console.WriteLine("==========================================");

            Console.ReadKey();
        }
    }
}
