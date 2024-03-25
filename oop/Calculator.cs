
using System;

public class BasicCalculator
{
    // Method to perform basic arithmetic operations
    public virtual double PerformOperation(double num1, double num2, char op)
    {
        // Switch statement to handle different operations
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
                {
                    return 0;
                }
                return num1 / num2;
            default:
                return 0;
        }
    }
}

// Define a SquareRoot calculator class inheriting from BasicCalculator
public class SquareRootCalculator : BasicCalculator
{
    // Override PerformOperation method to add square root functionality
    public override double PerformOperation(double num1, double num2, char op)
    {
        // Call the base method to perform basic arithmetic operation
        double result = base.PerformOperation(num1, num2, op);

        // Additional functionality for ScientificCalculator: Calculate square root of the result
        double sqrtResult = Math.Sqrt(result);
        Console.WriteLine($"Square root of the result: {sqrtResult}");

        return result;
    }
}

// Main program class
class Program
{
    // Main method, entry point of the program
    static void Main()
    {
        // Prompt user to select calculator type
        Console.WriteLine("Select Calculator Type:");
        Console.WriteLine("\n1. Basic Calculator");
        Console.WriteLine("2. SquareRoot Calculator");

        // Read user choice
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
        {
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            return;
        }

        BasicCalculator calculator = choice == 1 ? new BasicCalculator() : new SquareRootCalculator();

        // Run the selected calculator
        RunCalculator(calculator);
    }

    // Method to run the calculator
    static void RunCalculator(BasicCalculator calculator)
    {
        // Main loop for calculator operations
        while (true)
        {
            // first numerical value
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Enter a numerical value:");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("\nInvalid input. Please enter a numerical value.");
                return;
            }

            //  ask the user na maglagay ng operator
            Console.WriteLine("Enter one of the following operators: +, -, *, /");
            char op = Console.ReadKey().KeyChar;

            // Check if operator is valid
            if (op != '+' && op != '-' && op != '*' && op != '/')
            {
                Console.WriteLine("\n\nInvalid operator. Please enter one of the four specified operators.");
                return;
            }

            //  user enter thw second numerical value
            Console.WriteLine("\nEnter another numerical value:");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("\nInvalid input. Please enter a numerical value.");
                return;
            }

            // Perform the calculation using the selected calculator
            double result = calculator.PerformOperation(num1, num2, op);
            Console.WriteLine($"Result: {result}");

            // Ask user if they want to perform another calculation
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Do you want to do another calculation? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response != "yes" && response != "YES" && response != "Yes")
            {
                break;
            }
        }
    }
}
