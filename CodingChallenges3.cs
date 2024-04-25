using System;

class Program
{
    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            // Menu
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choice (1-4): ");

            // User's choice
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.Write("Invalid input. Please enter a number between 1 and 4: ");
            }

            // Get 2 nums from user
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            // Perform arithmetic operation based on user's choice
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
                    {
                        Console.WriteLine("Error: Division by zero!");
                        continue;
                    }
                    break;
            }

            // Print result
            Console.WriteLine($"Result: {result}");

            // Ask if the user wants to perform another action
            Console.Write("Do you want to perform another action? (yes/no): ");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes")
                repeat = false;
        }
    }
}
