using System;

namespace SimpleCalculator
{
    // Base class for arithmetic operations
    abstract class Operation
    {
        // Abstract method to perform calculation
        public abstract double Calculate(double num1, double num2);
    }

    // Derived class for addition operation
    class Addition : Operation
    {
        // Method to perform addition calculation
        public override double Calculate(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    // Derived class for subtraction operation
    class Subtraction : Operation
    {
        // Method to perform subtraction calculation
        public override double Calculate(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    // Derived class for multiplication operation
    class Multiplication : Operation
    {
        // Method to perform multiplication calculation
        public override double Calculate(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    // Derived class for division operation
    class Division : Operation
    {
        // Method to perform division calculation
        public override double Calculate(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Cannot divide by zero");
            }
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables
            Operation operation;
            string choice;

            // Main program loop
            do
            {
                // Display menu
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("+. Add");
                Console.WriteLine("-. Subtract");
                Console.WriteLine("*. Multiply");
                Console.WriteLine("/. Divide");
                Console.WriteLine("5. Exit");
                choice = Console.ReadLine();

                // Perform operation based on user choice
                switch (choice)
                {
                    case "+":
                        operation = new Addition();
                        break;
                    case "-":
                        operation = new Subtraction();
                        break;
                    case "*":
                        operation = new Multiplication();
                        break;
                    case "/":
                        operation = new Division();
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        Console.WriteLine("Thanks for using Simple Calculator.");
                        continue;
                    default:
                        Console.WriteLine("Invalid choice. Please enter +, -, *, /, or 5 to exit.");
                        continue;
                }

                // Get input numbers from user
                Console.WriteLine("Enter number 1:");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value for number 1.");
                    continue;
                }

                Console.WriteLine("Enter number 2:");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value for number 2.");
                    continue;
                }

                // Check for division by zero
                if (choice == "/" && num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero");
                    continue;
                }

                // Perform calculation and display result
                Console.WriteLine($"Result: {operation.Calculate(num1, num2)}");

                // Ask if user wants to do another calculation
                Console.WriteLine("Do you want to do another calculation? (Y/N).");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain != "y")
                {
                    Console.WriteLine("Exiting...");
                    Console.WriteLine("Thanks for using Simple Calculator.");
                    break;
                }

            } while (choice != "5"); // Loop until user chooses to exit
        }
    }
}
