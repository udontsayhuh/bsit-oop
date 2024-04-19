//Base class
abstract class Operator
{
    public abstract double Calculate(double num1, double num2);
}
// Subclass for Addition (Good practice of Single Responsibility Principle/OCP)
class Add : Operator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 + num2;
    }
}
// Subclass for Subtraction (Good practice of Single Responsibility Principle/OCP)
class Subtract : Operator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}
// Subclass for Multiplication (Good practice of Single Responsibility Principle/OCP)
class Multiply : Operator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 * num2;
    }
}
// Subclass for Division (Good practice of Single Responsibility Principle/OCP)
class Divide : Operator
{
    public override double Calculate(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
}
//Handles flow of repeated calculations and interaction with the user.
class Calculator
{
    private InputHandler inputHandler;
    private CalculatorService calculatorService;

    public Calculator()
    {
        inputHandler = new InputHandler();
        calculatorService = new CalculatorService();
    }

    public void Start()
    {
        bool repeat = true;

        while (repeat)
        {
            double result = CalculateResult();
            Console.WriteLine($"Result: {result}");
 //It is good practice to always convert string variables into uppercase or lowercase before comparing them with user input.
            Console.WriteLine("Do you want to perform another calculation? (yes/no)");
            string response = Console.ReadLine();
            repeat = (response.ToLower() == "yes"); 
        }
    }

    private double CalculateResult()
    {
        double result = 0;

        while (true)
        {
            string input = inputHandler.GetUserInput();

            if (input == "=")
            {
                break;
            }

            if (inputHandler.TryParseNumber(input, out double number))
            {
                result = number;
            }
            else if (inputHandler.IsValidOperator(input))
            {
                char operation = input[0];
                Console.WriteLine("Enter the next number:");
                double num2;
                if (!inputHandler.TryParseNumber(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid number input. Please try again.");
                    continue;
                }
                result = calculatorService.PerformOperation(result, num2, operation);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number, operator (+, -, *, /), or = to calculate:");
            }
        }

        return result;
    }
}
//Validates and gets user input.
class InputHandler
{
    public string GetUserInput()
    {
        Console.WriteLine("Enter a number, operator (+, -, *, /), or = to calculate:");
        return Console.ReadLine();
    }

    public bool TryParseNumber(string input, out double number)
    {
        return double.TryParse(input, out number);
    }

    public bool IsValidOperator(string input)
    {
        return input == "+" || input == "-" || input == "*" || input == "/";
    }
}
// Calculator service can add more operations without modifiying existing code.
class CalculatorService
{
    public double PerformOperation(double num1, double num2, char operation)
    {
        Operator op = GetOperator(operation);
        return op.Calculate(num1, num2);
    }

    private Operator GetOperator(char operation)
    {
        switch (operation)
        {
            case '+':
                return new Add();
            case '-':
                return new Subtract();
            case '*':
                return new Multiply();
            case '/':
                return new Divide();
            default:
                throw new ArgumentException("Invalid operation");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.Start();
    }
}
//Lennox Macadangdang BSIT 2-1
//The Changes made to this code were to fix its readability and fix the pattern
//As the previous version of the code did not follow the SOLID principles
//Also the previous code mix and matched creating a spaghetti code pattern which made it hard to read
//I made seperate classes for functionality and logic which helps in future modifications and code readability
//Also I followed the lower or uper case practice in our powerpoint
