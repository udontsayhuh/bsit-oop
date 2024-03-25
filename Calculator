// Palaje BSIT 2-2
// Calculator Program

using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                string symbol;
                double result = 0;

                Console.WriteLine("\n=====================================");
                Console.WriteLine("         Calculator Program");
                Console.WriteLine("=====================================");

                Console.Write("Enter a number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Select an operator (+, -, /, *): ");
                symbol = Console.ReadLine();

                Console.Write("Enter another number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                // Switch Case to handle different operators and display result
                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Answer: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Answer: {num1} - {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Answer: {num1} / {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Answer: {num1} * {num2} = " + result);
                        break;
                }

                Console.Write("\nWould you like to calculate again? (Y/N): ");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("\nExiting program...\nThank you for using this calculator!");
        }
    }

}
