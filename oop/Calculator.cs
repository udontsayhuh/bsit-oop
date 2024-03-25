using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.Title = "Mark's Calculator";

        while (true)
        {
            Console.WriteLine("Welcome to Mark's Calculator\n");


            // Input first number
            float num1 = GetUserInput("Enter a number:");

            // Input operator
            char op = GetOperator();

            // Input second number
            float num2 = GetUserInput("Enter another number:");

            try
            {
                // Perform calculation based on the operator
                float result = Calculate(num1, num2, op);

                // Display the result
                Console.WriteLine($"Result: {result}");


                // Ask user if they want to do another calculation
                Console.WriteLine("\nDo you want to do another calculation? (yes/no)");

                string choice = Console.ReadLine().ToLower();
                if (choice != "yes")
                    break; // Exit the loop if the user doesn't want to perform another calculation
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Thank you for using Simple Calculator!");

    }

    // Encapsulation: Method for encapsulating input handling.
    static float GetUserInput(string message)
    {
        float num;
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (float.TryParse(input, out num))
                return num;
            else
            {
                Console.WriteLine("Invalid input! Please enter a numerical value.");

                Environment.Exit(0); // Terminate the program if input is non-numerical
            }
        }
    }

    // Encapsulation: Method for encapsulating input handling
    static char GetOperator()
    {
        char op;
        while (true)
        {
            Console.Write("Enter the operator (+, -, *, /): ");
            op = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (op == '+' || op == '-' || op == '*' || op == '/')
                return op;
            else
                Console.WriteLine("Invalid operator! Please enter one of +, -, *, /");
        }
    }

    // Abstraction: Calculate method abstracts the process of performing calculations.
    static float Calculate(float num1, float num2, char op)
    {
        switch (op)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 == 0)
                    throw new ArgumentException("Cannot divide by zero.");

                return num1 / num2;
            default:
                throw new ArgumentException("Invalid operator.");

        }
    }
}

