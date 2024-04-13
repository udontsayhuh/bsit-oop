using System;

// Calculator class
class CalculatorUI
{
    private readonly CalculatorEngine calculatorEngine;

    public CalculatorUI()
    {
        calculatorEngine = new CalculatorEngine();
    }

    public void RunCalculator()
    {
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("                    WELCOME TO C# CALCULATOR\n");
        Console.WriteLine("--------------------------------------------------------------");

        double num1;
        double num2;
        double result = 0;
        int counter = 1;
        bool restart = true;
        char operatorChoice;

        while (restart)
        {
            num1 = Input($"Enter the first number: ");

            while (true)
            {
                operatorChoice = GetOperatorChoice();

                if (operatorChoice != '=')
                {
                    if (counter == 2)
                    {
                        num1 = result;
                    }

                    num2 = Input($"Enter the second number: ");
                }
                else
                {
                    Console.WriteLine($"The Final Answer is: {result}");
                    break;
                }

                result = calculatorEngine.Compute(num1, num2, operatorChoice);
                Console.WriteLine($"Result: {num1} {operatorChoice} {num2} = {result}");

                counter = 2;
            }

            Console.WriteLine("Do you want to do another calculation? (Y/N).");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain != "y")
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("                    THANK YOU FOR USING C# CALCULATOR\n                            BY: CARL BERGADO");
                Console.WriteLine("--------------------------------------------------------------");
                break;
            }
            else
            {
                Console.Clear();
                continue;
            }
        }
    }

    private double Input(string prompt)
    {
        double num;
        while (true)
        {
            try
            {
                Console.Write(prompt);
                num = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch
            {
                Console.Write("Invalid input. Please enter a valid number: \n");
            }
        }
        return num;
    }

    private char GetOperatorChoice()
    {
        char choice;
        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("[+] ADDITION");
            Console.WriteLine("[-] SUBTRACTION");
            Console.WriteLine("[*] MULTIPLICATION");
            Console.WriteLine("[/] DIVISION");
            Console.WriteLine("[=] EQUALS (DISPLAY)");
            Console.Write("\nEnter your choice: ");

            if (!char.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            if (choice == '+' || choice == '-' || choice == '/' || choice == '*' || choice == '=')
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter one of the specified operators: +, -, /, *, =.");
            }
        }
    }

}

// Calculator engine class
class CalculatorEngine
{
    public double Compute(double num1, double num2, char operation)
    {
        Operation op;
        switch (operation)
        {
            case '+':
                op = new Addition();
                break;
            case '-':
                op = new Subtraction();
                break;
            case '*':
                op = new Multiplication();
                break;
            case '/':
                op = new Division();
                break;
            default:
                throw new ArgumentException("Invalid operator");
        }

        return op.OpCompute(num1, num2);
    }
}

// Operation class
abstract class Operation
{
    public abstract double OpCompute(double num1, double num2);
}

// Derived class for addition operation
class Addition : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Derived class for subtraction operation
class Subtraction : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        return num1 - num2;
    }
}

// Derived class for multiplication operation
class Multiplication : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        return num1 * num2;
    }
}

// Derived class for division operation
class Division : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return double.NaN;
        }
        else
        {
            return num1 / num2;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CalculatorUI calculatorUI = new CalculatorUI();
        calculatorUI.RunCalculator();
    }
}
