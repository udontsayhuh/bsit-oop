using System;

class Program
{
    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            // Allow user to select an Operation
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Prompts the user to input two numbers
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Perform the selected operation base on the users choice
            switch (choice)
            {
                case 1: // Addition
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;
                case 2: // Subtraction
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;
                case 3: // Multiplication
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;
                case 4: // Division
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            // Ask the user if he wants to perform another calculation
            Console.Write("Do you want to perform another operation? (yes/no): ");
            string answer = Console.ReadLine().ToLower();

            // Check if the user wants to repeat the program
            if (answer != "yes")
            {
                repeat = false;
            }
        }
    }
}
