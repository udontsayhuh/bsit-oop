// Calculator
// >Program Checklist<
// User Input: /
// Invalid Input Termination: /
// Input Checking: /
// Calculation & Display: /
// Program Restart Prompt: /
// Applications of OOP: encapsulation and abstraction

using System;

namespace calculator_using_Csharp
{   //encapsulation
    class Calculator
    {
        public double Calculate(double num1, double num2, string operation)
        {
            switch (operation)
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
                        throw new ArgumentException("Undefined");
                    }
                    return num1 / num2;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }
    //abstraction
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>> Basic Calculator <<<<<");

            string value;
            Calculator calculator = new Calculator();

            do
            {
                Console.Write("\nEnter first number: ");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("\nInvalid input. \nProgram Terminated.");
                    break;
                }

                Console.Write("Enter symbol(/,+,-,*): ");
                string operation = Console.ReadLine();
                if (operation != "/" && operation != "+" && operation != "-" && operation != "*")
                {
                    Console.WriteLine("\nInvalid operation. \nProgram Terminated.");
                    break;
                }

                Console.Write("Enter second number: ");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("\nInvalid input. \nProgram Terminated.");
                    break;
                }

                try
                {
                    double answer = calculator.Calculate(num1, num2, operation);
                    Console.WriteLine($"\n{num1} {operation} {num2} = {answer}\n");
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine($"\n{ex.Message}\n");
                }

                Console.Write("Do you want to continue (y/n): ");
                value = Console.ReadLine();
            } while (value == "y" || value == "Y");
        }
    }
}