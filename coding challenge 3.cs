using System;

public class BasicArithmetic
{
    public static void Main(string[] args)
    {
        char repeat = 'y'; // Initialize loop control variable

        while (repeat == 'y' || repeat == 'Y')
        {
            // Get numbers from user
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Display menu
            Console.WriteLine("\nSelect operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter choice (1-4): ");

            // Get user choice
            int choice = Convert.ToInt32(Console.ReadLine());

            // Perform calculation based on choice
            double result;
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Result: {0} + {1} = {2}", num1, num2, result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Result: {0} - {1} = {2}", num1, num2, result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Result: {0} * {1} = {2}", num1, num2, result);
                    break;
                case 4:
                    // Handle division by zero
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero!");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: {0} / {1} = {2}", num1, num2, result);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            // Ask for repeat
            Console.Write("Do you want to perform another calculation? (y/n): ");
            repeat = Convert.ToChar(Console.ReadLine());
        }

        Console.WriteLine("Thank you for using the calculator!");
    }
}
