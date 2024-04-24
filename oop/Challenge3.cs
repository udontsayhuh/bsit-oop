/* Write a C# program that can perform basic arithmetic functions. (Addition,
Subtraction, Multiplication, and Division). The user must be allowed to select which
arithmetic function they wants to use, and then they will be prompted to enter only two numbers after
selecting the arithmetic function. Print the result afterwards, and then after printing
ask the user if he/she wants toperform another action or not. If yes, repeat the
program, if not terminate the program. */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("        Simple Calculator");
        Console.WriteLine("----------------------------------");
        while (true)
        {
            Console.WriteLine("Enter operator (+, -, *, /): ");
            char operation;
            if (!char.TryParse(Console.ReadLine(), out operation) ||
               (operation != '+' && operation != '-' && operation != '*' && operation != '/'))
            {
                Console.WriteLine("Invalid operator.\n");
                continue;
            }

            Console.Write("Enter the first number: ");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input.\n");
                continue;
            }

            Console.Write("Enter the second number: ");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input.\n");
                continue;
            }

            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Undefined.\n");
                        continue;
                    }
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine("Result: " + result);
            Console.WriteLine();

            Console.Write("Calculate more? (Y/N): ");
            string answer = Console.ReadLine().Trim().ToUpper();
            if (answer != "Y")
            {
                Console.WriteLine("Program Terminated.");
                break;
            }
            Console.WriteLine();
        }
    }
}
