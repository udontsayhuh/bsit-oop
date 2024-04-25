using System;

class Program
{
    static void Main(string[] args)
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

        // Variables for operands
        double firstNumber, secondNumber;

        // Get operands from user
        Console.Write("Enter the first number: ");
        firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        secondNumber = double.Parse(Console.ReadLine());

        // Perform selected operation and display result
        switch (operationChoice)
        {
            case 1:
                Console.WriteLine($"Result of addition: {firstNumber} + {secondNumber} = {PerformAddition(firstNumber, secondNumber)}");
                break;
            case 2:
                Console.WriteLine($"Result of subtraction: {firstNumber} - {secondNumber} = {PerformSubtraction(firstNumber, secondNumber)}");
                break;
            case 3:
                Console.WriteLine($"Result of multiplication: {firstNumber} * {secondNumber} = {PerformMultiplication(firstNumber, secondNumber)}");
                break;
            case 4:
                if (secondNumber != 0)
                    Console.WriteLine($"Result of division: {firstNumber} / {secondNumber} = {PerformDivision(firstNumber, secondNumber)}");
                else
                    Console.WriteLine("Cannot divide by zero!");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
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
