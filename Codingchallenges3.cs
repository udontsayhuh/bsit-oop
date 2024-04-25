using System;

class Program
{
    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            // Display menu
            Console.WriteLine("Welcome to the Basic Arithmetic Calculator!");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            // Get user's choice
            Console.Write("Enter the operation number (1-4): ");
            int operationChoice = int.Parse(Console.ReadLine());

            // Get operands from user
            Console.Write("Enter the first number: ");
            double firstOperand = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double secondOperand = double.Parse(Console.ReadLine());

            // Perform selected operation and display result
            switch (operationChoice)
            {
                case 1:
                    Console.WriteLine($"Result of addition: {firstOperand} + {secondOperand} = {PerformAddition(firstOperand, secondOperand)}");
                    break;
                case 2:
                    Console.WriteLine($"Result of subtraction: {firstOperand} - {secondOperand} = {PerformSubtraction(firstOperand, secondOperand)}");
                    break;
                case 3:
                    Console.WriteLine($"Result of multiplication: {firstOperand} * {secondOperand} = {PerformMultiplication(firstOperand, secondOperand)}");
                    break;
                case 4:
                    if (secondOperand != 0)
                        Console.WriteLine($"Result of division: {firstOperand} / {secondOperand} = {PerformDivision(firstOperand, secondOperand)}");
                    else
                        Console.WriteLine("Cannot divide by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            // Ask if the user wants to perform another action
            Console.Write("Do you want to perform another action? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            // If user doesn't want to repeat, set repeat to false to exit the loop
            if (response != "yes")
                repeat = false;

            Console.WriteLine(); // Add a blank line for readability
        }
    }

    // Method to perform addition
    static double PerformAddition(double firstNum, double secondNum)
    {
        return firstNum + secondNum;
    }

    // Method to perform subtraction
    static double PerformSubtraction(double firstNum, double secondNum)
    {
        return firstNum - secondNum;
    }

    // Method to perform multiplication
    static double PerformMultiplication(double firstNum, double secondNum)
    {
        return firstNum * secondNum;
    }

    // Method to perform division
    static double PerformDivision(double firstNum, double secondNum)
    {
        return firstNum / secondNum;
    }
}
