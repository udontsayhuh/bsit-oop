/*Write a C# program that can perform basic arithmetic functions. (Addition, Subtraction, Multiplication, and Division).
The user must be allowed to select which arithmetic function he/she wants to use, and then they will be prompted to 
enter only two numbers after selecting the arithmetic function. Print the result afterwards, and then after printing
ask the user if he/she wants toperform another action or not. If yes, repeat the program, if not terminate the program.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Select an arithmetic operation: ");
            string userChoice = Console.ReadLine();

            if (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4")
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                continue;
            }

            double firstNumber;
            while (true)
            {
                Console.Write("\nFirst number: ");
                if (!double.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                break;
            }

            double secondNumber;
            while (true)
            {
                Console.Write("Second number: ");
                if (!double.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                break;
            }

            double result = 0;
            char operatr;

            switch (userChoice)
            {
                case "1":
                    operatr = '+';
                    result = firstNumber + secondNumber;
                    break;
                case "2":
                    operatr = '-';
                    result = firstNumber - secondNumber;
                    break;
                case "3":
                    operatr = '*';
                    result = firstNumber * secondNumber;
                    break;
                case "4":
                    operatr = '/';
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        Console.WriteLine("\nCannot divide by zero.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    continue;
            }
            Console.WriteLine($"\n{firstNumber} {operatr} {secondNumber} = {result}\n");

            string anotherCalculation;
            while (true)
            {
                Console.Write("Do you want to perform another calculation (y/n)? ");
                anotherCalculation = Console.ReadLine().ToLower();
                if (anotherCalculation == "n" || anotherCalculation == "y")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.\n");
                }
            }
            if (anotherCalculation == "n")
            {
                Console.WriteLine("\nExiting the program...");
                break;
            }
        }
    }
}
