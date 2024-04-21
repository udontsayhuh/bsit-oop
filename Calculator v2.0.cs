using System;
using System.Linq;
using System.Collections.Generic;

namespace Calculator
{
    public interface IOperation
    {
        double Perform(double num1, double num2);
    }

    public class Addition : IOperation
    {
        public double Perform(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    public class Subtraction : IOperation
    {
        public double Perform(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    public class Multiplication : IOperation
    {
        public double Perform(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    public class Division : IOperation
    {
        public double Perform(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IOperation> operations = new Dictionary<string, IOperation>()
            {
                { "+", new Addition() },
                { "-", new Subtraction() },
                { "*", new Multiplication() },
                { "/", new Division() }
            };

            while (true)
            {    
                Console.WriteLine("INSTRUCTIONS: Enter a valid operator (+, -, *, /), then PRESS '=' to calculate. \n");
                Console.WriteLine("WELCOME TO CALCULATOR APP!\n");

                List<double> numbers = new List<double>(); // Store entered numbers
                string selectedOperator = null; // Store selected operator (if applicable)

                // Get multiple numerical values or an operator until equal sign encountered
                while (true)
                {
                    Console.WriteLine("Enter a value: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out double num))
                    {
                        numbers.Add(num);
                    }
                    else if (input == "=")
                    {
                        break; // Exit the inner loop when equal sign is entered
                    }
                    else if (operations.ContainsKey(input)) // Check for valid operator
                    {
                        if (selectedOperator != null) // Disallow multiple operators without numbers
                        {
                            Console.WriteLine("Invalid input! Press '=' to calculate.");
                            continue;
                        }
                        selectedOperator = input;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a number, '=' to calculate, or a valid operator (+, -, *, /).");
                    }
                }

                if (numbers.Count < 2 && selectedOperator == null) // Handle case with less than 2 numbers and no operator
                {
                    Console.WriteLine("SYNTAX ERROR! Please enter at least two numbers.");
                    continue;
                }

                // Perform calculation based on number of entries and operator (if applicable haha kung kaya, kailangan pa ba neto syempre oo hindi yan gagana kung hindi :v)
                double result = numbers[0];
                if (selectedOperator != null)
                {
                    for (int i = 1; i < numbers.Count; i++)
                    {
                        result = operations[selectedOperator].Perform(result, numbers[i]);
                    }
                }
                else
                {
                    // Handle basic arithmetic for multiple numbers without an operator (yeah pwedeng wala toh pwede ring i-modify xd)
                    for (int i = 1; i < numbers.Count; i++)
                    {
                        result += numbers[i]; 
                    }
                }

                // Display result
                Console.WriteLine($"Result: {result}");

                // Ask user if they want to perform another calculation
                Console.WriteLine("\nDo you want to perform another calculation? (yes/no)");
                string response = Console.ReadLine().ToLower();
                if (response != "yes")
                {
                    Console.WriteLine("\nBye bye! Come back anytime!");
                    break;
                }
                else
                {
                    Console.Clear(); //Clear the whole screen to make room for the next calculation
                }

                numbers.Clear(); // Clear the list for next iteration
                selectedOperator = null; // Reset operator for next calculation
            }
        }
    }
}

//ASSIGNMENT#02 executed by ABABA, JULIA E. --> BSIT 2-1, 03-25-2024
//ASSIGNMENT#03 MODIFIED patch version 2.0.0 --> 04-08-10 - 04-10-2024
//ASSIGNMENT#04 MODIFIED patch version 2.1.0 --> 04-17-2024

//to someone who's visiting my branch literally pls don't expect anything wala kang makikita rito haha inayos ko lang mostly xd
