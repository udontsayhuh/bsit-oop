using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        char choice, answer;

        // A do-while loop in case user wants to do another calculation
        do
        {
            // Loop to ensure a valid arithmetic operation is selected
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

                // Check if the choice is valid
                if (choice != '+' && choice != '-' && choice != '*' && choice != '/')
                    Console.WriteLine("Invalid operation. Please try again.");
                else
                    break;
            }

            // Loop to ensure valid numeric input for numbers
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

            // Perform the selected arithmetic operation and displays result
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

            // Ask the user if they want to perform another calculation
            Console.Write("\nDo you want to perform another calculation? \nPress Y if Yes. Press any key if No: ");
            answer = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

        } while (answer == 'Y'); // Continue the loop if the user chooses 'Y'

        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("\t\t\t\tEnd of Program.");
        Console.WriteLine("-----------------------------------------------");
    }
}
