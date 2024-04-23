using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueLoop = true;

        while (continueLoop)
        {
            Console.WriteLine("Select Arithmetic Function:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choice (1-4): ");

            
            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
                continue;
            }

            if (option < 1 || option > 4)
            {
                Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
                continue;
            }

            Console.Write("Enter the first number: ");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.Write("Enter the second number: ");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            double result = 0;

            
            switch (option)
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
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        continue;
                    }
                    break;
            }

            
            Console.WriteLine($"Result: {result}");

            
            Console.Write("Do you want to perform another action? (yes/no): ");
            string continueChoice = Console.ReadLine().ToLower();

            continueLoop = (continueChoice == "yes");
        }
    }
}
