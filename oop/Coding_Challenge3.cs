using System;
using System.ComponentModel;

namespace CrystalynDanga
{
    /*   Write a C# program that can perform basic arithmetic functions. (Addition, Subtraction, Multiplication, and Division). 
         The user must be allowed to select which arithmetic function */


    class Program
    {
        // Calculates the addition
        public static double Add(double value1, double value2)
        {
            double result = value1 + value2;
            Console.WriteLine("The sum is: " + result);
            return result;
        }

        // Calculates for subtraction
        public static double Subtract(double value1, double value2)
        {
            double result = value1 - value2;
            Console.WriteLine("The difference is: " + result);
            return result;
        }

        // Calculates for Multiplication
        public static double Multiply(double value1, double value2)
        {
            double result = value1 * value2;
            Console.WriteLine("The product is: " + result);
            return result;
        }

        // Calculates for Division
        public static double Divide(double value1, double value2)
        {
            if (value2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN; // Return NaN (Not a Number) as a special value for division by zero
            }
            else
            {
                double result = value1 / value2;
                Console.WriteLine("The quotient is: " + result);
                return result;
            }
        }

        public static char OperatorChoice ()
        {
            char choice;
            while (true)
            {
                Console.WriteLine("\nChoose an operator (Enter the symbol)"); // Display operator choices to the user
                Console.WriteLine("1. Add (+)\n2. Subtract (-)\n3. Multiply (*)\n4. Divide (/)");
                Console.Write("\nEnter your choice: "); // Prompt the user to enter their choice

                if (!char.TryParse(Console.ReadLine(), out choice)) // Read user input and attempt to parse it as a character
                {
                    Console.WriteLine("Invalid input."); // Display error message for invalid input
                    continue; // Continue the loop to prompt user again
                }

                // Check if the entered choice is a valid operator
                if (choice == '+' || choice == '-' || choice == '/' || choice == '*' || choice == '=')
                {
                    return choice; // Return the valid operator choice
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid operator!"); // Display error message for invalid operator
                }
            }
        }
        public static void RunProgram ()
        {
            
            Console.Write("Enter first value: ");
            double value1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second value: ");
            double value2 = Convert.ToDouble(Console.ReadLine());

            char choice = OperatorChoice();

            switch (choice)
            {
                case '+':
                    Add(value1, value2);
                    break;
                case '-':
                    Subtract(value1, value2);
                    break;
                case '*':
                    Multiply(value1, value2);
                    break;
                case '/':
                    try
                    {
                        Divide(value1, value2);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return; 
                    }
                    break;
            }

        }
        static void Main(string[] args) 
        {
            RunProgram ();
           
        } // Main Method
    } // Program Class

} // Namespace
