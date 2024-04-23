using System;

class Program
{
    static void Main(string[] args)
    {
        double num1;
        int num2;

        // Loop to ensure valid input
        while (true)
        {
            Console.WriteLine("-----------------------------------");
            Console.Write("Enter a number: "); // Prompt the user to enter a number

            // Validate and parse the input for num1
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("\nInvalid input. \nPlease enter a valid number.");
                continue;
            }

            Console.Write("Enter the multiplier: "); // Prompt the user to enter the multiplier

            // Validate and parse the input for num2
            if (!int.TryParse(Console.ReadLine(), out num2) || num2 <= 0)
            {
                Console.WriteLine("\nInvalid multiplier. \nMust be positive and not zero.");
                continue;
            }

            break; // Exit the loop if valid input is provided
        }

        Console.WriteLine("-----------------------------------");

        // Calculate and display the multiplication table
        for (int i = 1; i <= num2; i++)
        {
            Console.WriteLine($"{num1} x {i} = {num1 * i}");
        }

        Console.WriteLine("-----------------------------------");
    }
}
