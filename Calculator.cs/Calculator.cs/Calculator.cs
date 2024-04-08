using System;
namespace MyCalculatorApp
// Class representing a calculator
class Calculator
{
    // Method for addition
    public double Add(double x, double y) // Encapsulation - Methods encapsulate behavior.
    {
        return x + y;
    }

    // Method for subtraction
    public double Subtract(double x, double y) // Encapsulation - Methods encapsulate behavior.
    {
        return x - y;
    }

    // Method for multiplication
    public double Multiply(double x, double y) // Encapsulation - Methods encapsulate behavior.
    {
        return x * y;
    }

    // Method for division

    public double Divide(double x, double y) // Encapsulation - Methods encapsulate behavior.
    {
        if (y == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return x / y;
    }
}

// Main program class
class Program
{
    // Entry point of the program
    static void Main(string[] args)
    {
        Calculator calc = new Calculator(); // Instantiation - Creating an object of class Calculator.

        while (true)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("* \t\tCALCULATOR\t\t *");
            Console.WriteLine("******************************************");
            double number1 = isValid("Enter the first number: ");
            //Console.WriteLine("\n\t [ +  - / * ] ");
            Console.WriteLine("Choose Operator [ +  - / * ] :");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (choice != '+' && choice != '-' && choice != '*' && choice != '/')
            {
                Console.WriteLine("Invalid operator. Please try again.");
                ClearScreen();
                continue;
            }

            double number2 = isValid("\nEnter the second number: ");

            double result = 0;
            string operation = "";

            switch (choice)
            {
                case '+':
                    Console.WriteLine("******************************************");
                    result = calc.Add(number1, number2); // Inheritance - Using methods from the Calculator class.
                    operation = "+";
                    break;
                case '-':
                    Console.WriteLine("******************************************");
                    result = calc.Subtract(number1, number2); // Inheritance - Using methods from the Calculator class.
                    operation = "-";
                    break;
                case '*':
                    Console.WriteLine("******************************************");
                    result = calc.Multiply(number1, number2); // Inheritance - Using methods from the Calculator class.
                    operation = "*";
                    break;
                case '/':
                    try
                    {
                        Console.WriteLine("******************************************");
                        result = calc.Divide(number1, number2); // Inheritance - Using methods from the Calculator class.
                        operation = "/";
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                        continue;
                    }
                    break;
            }

            Console.WriteLine($"Result: {number1} {operation} {number2} = {result}");

            Console.WriteLine("Do you want to try again? [Y/N]: ");
            char tryAgainChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (tryAgainChoice != 'Y' && tryAgainChoice != 'y')
            {
                Console.WriteLine("Exiting...");
                ClearScreen();
                break;
            }
            Console.WriteLine();
            ClearScreen();
        }
    }

    // Method to validate input
    private static double isValid(string message) // Abstraction - Hides the details of input validation.
    {
        double number;
        bool isTrue;
        do
        {
            Console.Write(message);
            isTrue = double.TryParse(Console.ReadLine(), out number);
            if (!isTrue)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (!isTrue);
        return number;
    }

    // Method to clear screen
    private static void ClearScreen() // Abstraction - Hides the details of clearing the screen., user defined getch() + system("cls") like
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
}
}
