using System;
using System.Collections.Generic;

abstract class Calculator
{
    protected double num1;
    protected double num2;
    protected List<string> inputs = new List<string>();

    public abstract void Solve();

    public void AskUser()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Calculator App!");
        Console.WriteLine("Input '=' when you have a valid expression (of at least TWO numbers and ONE operator).");

        double result = 0;
        bool isFirstInput = true;
        int inputNumber = 1;
        int operatorNumber = 1;

        while (true)
        {
            if (isFirstInput)
            {
                Console.Write($"\nEnter number #{inputNumber}: ");
                string input = Console.ReadLine().Trim();

                if (input == "=")
                {
                    if (inputs.Count < 2)
                    {
                        Console.WriteLine("Invalid input! Please enter at least one operator and one number before '='.");
                        continue;
                    }

                    Console.WriteLine($"Result: {result.ToString("0.#####")}");
                    break;
                }

                if (!double.TryParse(input, out double number))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                inputs.Add(input);
                result = number;
                isFirstInput = false;
                inputNumber++;
            }
            else
            {
                Console.Write($"\nEnter operator #{operatorNumber} (+, -, *, /): ");
                string op = Console.ReadLine().Trim();

                if (op == "=")
                {
                    if (inputs.Count < 3 || inputs.Count % 2 != 1)
                    {
                        Console.WriteLine("Invalid input! Please enter a number after every operator.");
                        continue;
                    }

                    Console.WriteLine($"Result: {result.ToString("0.#####")}");
                    break;
                }

                if (op != "+" && op != "-" && op != "*" && op != "/")
                {
                    Console.WriteLine("Invalid operator! Please enter a valid operator.");
                    continue;
                }

                Console.Write($"Enter number #{inputNumber}: ");
                string input = Console.ReadLine().Trim();

                if (!double.TryParse(input, out double number))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                switch (op)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;
                    case "*":
                        result *= number;
                        break;
                    case "/":
                        if (number == 0)
                        {
                            Console.WriteLine("Cannot divide by zero! Please enter a non-zero number.");
                            continue;
                        }
                        result /= number;
                        break;
                }

                inputs.Add(op);
                inputs.Add(input);
                inputNumber++;
                operatorNumber++;
            }

            if (inputs.Count > 0)
            {
                Console.WriteLine($"\nCurrent expression: {string.Join(" ", inputs)}\n");
            }
        }
    }

    public void ClearInputs()
    {
        inputs.Clear();
    }
}

class Addition : Calculator
{
    public override void Solve()
    {
        AskUser();
    }
}

class Subtraction : Calculator
{
    public override void Solve()
    {
        AskUser();
    }
}

class Multiplication : Calculator
{
    public override void Solve()
    {
        AskUser();
    }
}

class Division : Calculator
{
    public override void Solve()
    {
        AskUser();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Addition(); 

        while (true)
        {
            calculator.Solve();

            string response;
            do
            {
                Console.WriteLine("Do you want to try again (yes or no)?: ");
                response = Console.ReadLine().ToLower();
                if (response != "yes" && response != "no")
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Choose between 'yes' and 'no' only! ");
                }
            } while (response != "yes" && response != "no");

            if (response == "no")
            {
                Console.Clear();
                Console.WriteLine("Program ends.");
                return;
            }

            calculator.ClearInputs();
        }
    }
}
