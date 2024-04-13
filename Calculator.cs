using System;
using System.Collections.Generic;

abstract class Calculator
{
    protected double Num1;
    protected double Num2;
    protected List<string> Inputs = new List<string>();

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
                    if (Inputs.Count < 2)
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

                Inputs.Add(input);
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
                    if (Inputs.Count < 3 || Inputs.Count % 2 != 1)
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

                Inputs.Add(op);
                Inputs.Add(input);
                inputNumber++;
                operatorNumber++;
            }

            if (Inputs.Count > 0)
            {
                Console.WriteLine($"\nCurrent expression: {string.Join(" ", Inputs)}\n");
            }
        }
    }

    public void ClearInputs()
    {
        Inputs.Clear();
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
