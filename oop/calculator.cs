using System;

public class Calculator
{
    // Addition operation
    public double Add(double num1, double num2) => num1 + num2;

    // Subtraction operation
    public double Subtract(double num1, double num2) => num1 - num2;

    // Multiplication operation
    public double Multiply(double num1, double num2) => num1 * num2;

    // Division operation
    public double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divided by zero.");
        }
        return num1 / num2;
    }
}

public class UserInterface
{
    private readonly Calculator calculator;

    public UserInterface()
    {
        calculator = new Calculator();
    }

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("[Main Menu]");
        Console.WriteLine("Calculator Application\n");
        Console.WriteLine("Operations");
        Console.WriteLine("[+] Addition");
        Console.WriteLine("[-] Subtraction");
        Console.WriteLine("[*] Multiplication");
        Console.WriteLine("[/] Division");
        Console.WriteLine("[=] Exit");
    }

    public void PerformOperation()
    {
        double num1, num2;
        char operation;

        num1 = GetNumber("Enter the first number: ");
        operation = GetOperation();

        while (operation != '=')
        {
            num2 = GetNumber("Enter the second number: ");
            try
            {
                num1 = PerformOperation(num1, num2, operation);
                
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                break;
            }

            operation = GetOperation();
        }

        Console.WriteLine($"The final result is: {num1}");
    }

    private double PerformOperation(double num1, double num2, char operation)
    {
        switch (operation)
        {
            case '+':
                return calculator.Add(num1, num2);
            case '-':
                return calculator.Subtract(num1, num2);
            case '*':
                return calculator.Multiply(num1, num2);
            case '/':
                return calculator.Divide(num1, num2);
            default:
                throw new ArgumentException("Invalid operation entered.");
        }
    }

    private double GetNumber(string message)
    {
        double number;
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Input invalid. Please enter a valid number.");
        }
    }

    private char GetOperation()
    {
        char operation;
        while (true)
        {
            Console.Write("Enter Operation ( + , - , * , / , = ) : ");
            if (char.TryParse(Console.ReadLine(), out operation) && IsValidOperation(operation))
            {
                return operation;
            }
            Console.WriteLine("Operation invalid. Please enter a valid operation symbol.");
        }
    }

    private bool IsValidOperation(char operation)
    {
        return operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == '=';
    }

    private string GetOperationSymbol(char operation)
    {
        switch (operation)
        {
            case '+':
                return "+";
            case '-':
                return "-";
            case '*':
                return "*";
            case '/':
                return "/";
            default:
                return "";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        UserInterface ui = new UserInterface();
        while (true)
        {
            ui.DisplayMenu();
            ui.PerformOperation();
            Console.WriteLine("Would you want to try it again? [y] yes, [n] no: ");
            char choice = Console.ReadLine().Trim().ToLower()[0];
            if (choice == 'n')
            {
                break;
            }
        }
    }
}