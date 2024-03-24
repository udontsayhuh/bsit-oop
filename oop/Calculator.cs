using System;

class Calculator
{
    // Properties to store the numbers
    private double num1;
    private double num2;
    private double num3;

    // Constructor
    public Calculator()
    {
        num1 = 0;
        num2 = 0;
        num3 = 0;
    }

    // Method to input numbers
    public void InputNumbers()
    {
        Console.Write("Enter First Number:");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number value!.");
        }

        Console.Write("Enter Second number:");
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number value!.");
        }

        Console.Write("Enter Third number:");
        if (!double.TryParse(Console.ReadLine(), out num3))
        {
            Console.WriteLine("Invalid input. Please enter a valid number value!.");
        }
    }

    // Method to perform calculation
    public void PerformCalculation(char operation)
    {
        double result = 0;
        switch (operation)
        {
            case '+':
                result = num1 + num2 + num3;
                Console.WriteLine("Addition:" + result);
                break;
            case '-':
                result = num1 - num2 - num3;
                Console.WriteLine("Subtraction:" + result);
                break;
            case '*':
                result = num1 * num2 * num3;
                Console.WriteLine("Multiplication:" + result);
                break;
            case '/':
                result = num1 / num2 / num3;
                Console.WriteLine("Division:" + result);
                break;
            default:
                Console.WriteLine("Invalid operator. Please enter one of the four specified operators.");
                break;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        
        while (true)
        {
            Console.WriteLine("Welcome to The Calculator");
            
            calculator.InputNumbers();

            Console.WriteLine("Pick a Symbol Given Below.");
            Console.WriteLine("[+]");
            Console.WriteLine("[-]");
            Console.WriteLine("[*]");
            Console.WriteLine("[/]");
            Console.Write("Type Here:");
            char operation = Console.ReadLine()[0];

            calculator.PerformCalculation(operation);

            Console.Write("Do you want to perform another calculation? (Y/N): ");
            char choice = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (choice != 'Y')
            {
                break;
            }
        }
    }
}
