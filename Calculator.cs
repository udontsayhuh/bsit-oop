//ZAINA E. GHAZI, BSIT 2-2
using System;

namespace c_sharp_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            string value;
            do
            {
                int res;  //Prompting user to input two desired numbers and verifying their validity
                Console.Write("Enter first number:");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid input for the first number.");
                    continue;
                }

                Console.Write("Enter second number:");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid input for the second number.");
                    continue;
                }

                Console.Write("Enter symbol(/, +, -, *):"); //Prompting user to input desired operational symbol and verifying its validity
                string symbol = Console.ReadLine();
                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine($"Result: {res}");
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine($"Result: {res}");
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine($"Result: {res}");
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero."); //exception that displays error where any number cannot be divided by zero
                            continue;
                        }
                        res = num1 / num2;
                        Console.WriteLine($"Result: {res}");
                        break;
                    default:
                        Console.WriteLine("Unsupported operation.");
                        break;
                }
                Console.Write("Do you want to continue? (y/n):"); //asks user if they wish to input again in the calculator
                value = Console.ReadLine();
            } while (value.ToLower() == "y");
        }
    }
}
