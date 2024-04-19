using System;

// Interface for operations
public interface IOperation
{
    float Calculate(float num1, float num2);
}

// Addition operation
public class Addition : IOperation
{
    public float Calculate(float num1, float num2) => num1 + num2;
}

// Subtraction operation
public class Subtraction : IOperation
{
    public float Calculate(float num1, float num2) => num1 - num2;
}

// Multiplication operation
public class Multiplication : IOperation
{
    public float Calculate(float num1, float num2) => num1 * num2;
}

// Division operation
public class Division : IOperation
{
    public float Calculate(float num1, float num2)
    {
        if (num2 == 0)
            throw new ArgumentException("Cannot divide by zero.");
        return num1 / num2;
    }
}

// Factory for creating operations
public static class OperationFactory
{
    public static IOperation GetOperation(char op)
    {
        return op switch
        {
            '+' => new Addition(),
            '-' => new Subtraction(),
            '*' => new Multiplication(),
            '/' => new Division(),
            _ => throw new ArgumentException("Invalid operator."),
        };
    }
}

// Class responsible for user interaction
public class UserInterface
{
    public static float GetUserInput(string message)
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
            }
        }
    }

    public static char GetOperator()
    {
        char op;
        while (true)
        {
            Console.Write("Enter the operator (+, -, *, /, =): ");
            op = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (op == '+' || op == '-' || op == '*' || op == '/' || op == '=')
                return op;
            else
                Console.WriteLine("Invalid operator! Please enter one of +, -, *, /, =");
        }
    }
}

// Main calculator class
public class Calculator
{
    public static void Main(string[] args)
    {
        Console.Title = "Mark's Calculator";

        while (true)
        {
            Console.WriteLine("Welcome to Mark's Calculator\n");

            float result = UserInterface.GetUserInput("Enter a number:");

            while (true)
            {
                char op = UserInterface.GetOperator();

                if (op == '=')
                    break;

                float num2 = UserInterface.GetUserInput("Enter another number:");

                try
                {
                    IOperation operation = OperationFactory.GetOperation(op);
                    result = operation.Calculate(result, num2);
                    Console.WriteLine($"Result so far: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine($"Final result: {result}");

            Console.WriteLine("\nDo you want to do another calculation? (yes/no)");

            string choice = Console.ReadLine().ToLower();
            if (choice != "yes")
                break;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Thank you for using Simple Calculator!");
    }
}
