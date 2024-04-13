using System;

namespace CalculatorApp
{
    class Calculator
    {
        // Method to add two numbers
        public double Add(double num1, double num2) => num1 + num2;

        // Method to subtract two numbers
        public double Subtract(double num1, double num2) => num1 - num2;

        // Method to multiply two numbers
        public double Multiply(double num1, double num2) => num1 * num2;

        // Method to divide two numbers
        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("CAN'T BE DIVIDED BY ZERO!");
                return double.NaN; // Not a Number
            }
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("WELCOME TO RAINE'S CALCULATOR!");

            while (true)
            {
                double result = 0;

                Console.Write("\nENTER A NUMBER: ");
                if (!double.TryParse(Console.ReadLine(), out double currentNumber))
                {
                    Console.WriteLine("\nINVALID INPUT. PLEASE ENTER A VALID NUMBER.");
                    continue;
                }

                result = currentNumber; // Assign the first number to result

                while (true)
                {
                    Console.Write("\nSELECT AN OPERATOR (+, -, *, /) \nENTER ( = ) TO SHOW RESULT : ");
                    char operation = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (operation == '=')
                        break;

                    if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
                    {
                        Console.WriteLine("\nINVALID OPERATOR. PLEASE ENTER A VALID OPERATOR.");
                        continue;
                    }

                    Console.Write("\nENTER NUMBER: ");
                    if (!double.TryParse(Console.ReadLine(), out double nextNumber))
                    {
                        Console.WriteLine("\nINVALID INPUT. PLEASE ENTER A VALID NUMBER.");
                        continue;
                    }

                    switch (operation)
                    {
                        case '+':
                            result = calculator.Add(result, nextNumber);
                            break;
                        case '-':
                            result = calculator.Subtract(result, nextNumber);
                            break;
                        case '*':
                            result = calculator.Multiply(result, nextNumber);
                            break;
                        case '/':
                            result = calculator.Divide(result, nextNumber);
                            break;
                    }
                }

                Console.WriteLine("RESULT: " + result);
                Console.Write("\nDO YOU WANT TO PERFORM ANOTHER CALCULATION? (y/n): ");
                char repeat = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (repeat != 'y' && repeat != 'Y')
                    break;

                Console.Clear(); // Clear the screen for the next calculation
            }
        }
    }
}
