using System;

namespace MyCalculator
{
   
    class Calculator // Demonstrates Encapsulation with privated members
    {
        private double num1;
        private double num2;
        private char op;

       
        public Calculator() // Constructor
        {
            num1 = 0;
            num2 = 0;
            op = ' ';
        }

     
        public double Calculate()
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                        Environment.Exit(1);
                    }
                    return num1 / num2;
                default:
                    Console.WriteLine("Invalid operation.");
                    Environment.Exit(1);
                    return 0;
            }
        }

        
        public void SetNum1(double number)
        {
            num1 = number;
        }

       
        public void SetNum2(double number)
        {
            num2 = number;
        }

     
        public void SetOperation(char operation)
        {
            op = operation;
        }
    }

    class CalculatorProgram
    {
        static void Main(string[] args) // Change startup object to this point
        {
            while (true)
            {
                Calculator calculator = new Calculator();

                Console.WriteLine("Basic Calculator Program");

                double num1 = GetUserNumber("Enter the first numerical value: ");
                calculator.SetNum1(num1);

                char op = GetOperation();
                calculator.SetOperation(op);

                double num2 = GetUserNumber("Enter the second numerical value: ");
                calculator.SetNum2(num2);

                double result = calculator.Calculate();
                Console.WriteLine($"{num1} {op} {num2} = {result}");

                if (!PromptForAnotherCalculation())
                    break;

                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Goodbye");
        }

        static double GetUserNumber(string message)
        {
            double number;
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out number))
                return number;
            else
            {
                Console.WriteLine("Invalid input.");
                Environment.Exit(1);
                return 0; // Added to satisfy compiler
            }
        }

        static char GetOperation()
        {
            char op = ' ';
            Console.Write("Enter an operation (+, -, *, /): ");
            switch (Console.ReadLine().Trim())
            {
                case "+":
                    op = '+';
                    break;
                case "-":
                    op = '-';
                    break;
                case "*":
                    op = '*';
                    break;
                case "/":
                    op = '/';
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    Environment.Exit(0);
                    break;
            }
            return op;
        }

        static bool PromptForAnotherCalculation() 
        {
            while (true)
            {
                Console.Write("Perform another calculation? Type 'Yes' or 'No': ");
                string prompt = Console.ReadLine().Trim().ToLower();
                if (prompt == "yes")
                    return true;
                else if (prompt == "no") 
                    return false;
                else
                {
                    Console.WriteLine("Invalid input.");
                    Environment.Exit(1);
                    return false;
                }
            }
        }
    }
}
