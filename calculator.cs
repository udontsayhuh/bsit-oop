using System;

namespace CalculatorApp
{
    class Calculator
    {
        // Method to add two numbers
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Method to subtract two numbers
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Method to multiply two numbers
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

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

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("WELCOME TO RAINE'S CALCULATOR!");

            while (true)
            {
                double result = 0;
                bool isFirstNumber = true;
                double currentNumber = 0;
                char operation = '+';

                while (true)
                {
                    if (isFirstNumber)
                    {
                        Console.Write("\nENTER A NUMBER: ");
                        string input = Console.ReadLine();

                        if (input == "=")
                            break;

                        if (!double.TryParse(input, out currentNumber))
                        {
                            Console.WriteLine("\nINVALID INPUT. PLEASE ENTER A VALID NUMBER.");
                            continue;
                        }

                        result = currentNumber; // Assign the first number to result
                        isFirstNumber = false;
                    }
                    else
                    {
                        Console.Write("\nSELECT AN OPERATOR (+, -, *, /) \nENTER ( = ) TO SHOW RESULT : ");
                        operation = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                        if (operation == '=')
                            break;

                        if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
                        {
                            Console.WriteLine("\nINVALID OPERATOR. PLEASE ENTER A VALID OPERATOR.");
                            continue;
                        }

                        double nextNumber;
                        while (true)
                        {
                            Console.Write("\nENTER NUMBER: ");
                            string input = Console.ReadLine();
                            if (!double.TryParse(input, out nextNumber))
                            {
                                Console.WriteLine("\nINVALID INPUT. PLEASE ENTER A VALID NUMBER.");
                                continue;
                            }
                            break;
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
