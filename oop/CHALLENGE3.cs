// Coding Challenge 3
// April 22, 2024

using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("\nWelcome to the basic calculator!");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choice (1-4): ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("ERROR: Please enter a valid integer choice between 1 and 4.");
                Console.Write("Enter your choice (1-4): ");
            }

            Console.Write("\nENTER THE FIRST NUMBER: ");
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("ERROR: Please enter a valid number.");
                Console.Write("ENTER THE FIRST NUMBER: ");
            }

            Console.Write("ENTER THE SECOND NUMBER: ");
            double num2;
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("ERROR: Please enter a valid number.");
                Console.Write("ENTER THE SECOND NUMBER: ");
            }

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("ERROR: Cannot divide by zero!");
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid choice!");
                    break;
            }

            if (choice >= 1 && choice <= 4 && num2 != 0)
            {
                Console.WriteLine("\nRESULT " + result);
            }

            Console.Write("Do you want to perform another calculation? (yes/no): ");
            string continueChoice = Console.ReadLine().ToLower();
            if (continueChoice != "yes")
                if (continueChoice != "y")
                {
                keepRunning = false;
            }
        }
    }
}
