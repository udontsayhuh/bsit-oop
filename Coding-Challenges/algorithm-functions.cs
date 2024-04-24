using System;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            // Display menu and get user's choice
            Console.WriteLine("Select an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                continue;
            }

            if (choice == 5)
            {
                continueProgram = false;
                Console.WriteLine("Exiting program...");
                break;
            }

            // Get two numbers from the user
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            // Perform selected arithmetic operation
            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Result of addition: {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Result of subtraction: {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Result of multiplication: {result}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result of division: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            // Ask user if they want to continue
            Console.Write("Do you want to perform another action? (yes/no): ");
            string continueChoice = Console.ReadLine().Trim().ToLower();

            if (continueChoice != "yes")
            {
                continueProgram = false;
                Console.WriteLine("Exiting program...");
            }
        }
    }
}
