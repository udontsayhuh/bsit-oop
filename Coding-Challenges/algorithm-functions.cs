using System;

class Program
{
    static void Main()
    {
        bool continueProgram = true;
        int choice = 0;

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

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice < 1 || choice > 5)
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

                double num1 = GetValidNumber("Enter first number: ");
                double num2 = GetValidNumber("Enter second number: ");

                PerformOperation(choice, num1, num2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input. Please enter a valid integer choice.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }

            // Ask user if they want to continue
            Console.Write("Do you want to perform another action? (Y if yes, any other key if no): ");
            string continueChoice = Console.ReadLine().Trim().ToUpper();

            if (continueChoice != "Y")
            {
                continueProgram = false;
                Console.WriteLine("Exiting program...");
            }
        }
    }

    static double GetValidNumber(string message)
    {
        double number;
        bool isValid;

        do
        {
            Console.Write(message);
            isValid = double.TryParse(Console.ReadLine(), out number);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (!isValid);

        return number;
    }

    static void PerformOperation(int choice, double num1, double num2)
    {
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
                    throw new DivideByZeroException();
                }
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
