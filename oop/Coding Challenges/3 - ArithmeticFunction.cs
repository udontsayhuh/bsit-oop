using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        char choice, answer;

        do
        {
            while (true)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Select an arithmetic operation:");
                Console.WriteLine("[+] Addition");
                Console.WriteLine("[-] Subtraction");
                Console.WriteLine("[*] Multiplication");
                Console.WriteLine("[/] Division");
                Console.Write("Enter your choice: ");
                choice = Convert.ToChar(Console.ReadLine());

                if (choice != '+' && choice != '-' && choice != '*' && choice != '/')
                    Console.WriteLine("Invalid operation. Please try again.");
                else
                    break;
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("-----------------------------------------------");
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }

            switch (choice)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"\nResult: {num1} + {num2} = {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"\nResult: {num1} - {num2} = {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"\nResult: {num1} * {num2} = {result}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"\nResult: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("\nUndefined. Division by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("\nInvalid operation. Please try again.");
                    break;
            }

            Console.Write("\nDo you want to perform another calculation? \nPress Y if Yes. Press any key if No: ");
            answer = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

        } while (answer == 'Y');

        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("\t\t\t\tEnd of Program.");
        Console.WriteLine("-----------------------------------------------");
    }
}