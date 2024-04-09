using System;

abstract class Operation
{
    public abstract double Calculate(double num1, double num2);
}

class Addition : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 + num2;
    }
}

class Subtraction : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}

class Multiplication : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 * num2;
    }
}

class Division : Operation
{
    public override double Calculate(double num1, double num2)
    {
        if (num2 != 0)
            return num1 / num2;
        else
            throw new DivideByZeroException("WARNING: Cannot divide by zero!");
    }
}

class Calculator
{
    public double PerformOperation(Operation operation, double num1, double num2)
    {
        return operation.Calculate(num1, num2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        bool keepCalculating = true;

        while (keepCalculating)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================");
            Console.WriteLine("||        CALCULATOR        ||");
            Console.WriteLine("==============================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.WriteLine("———————————————————————————————————");
            Console.WriteLine("|          > OPERATORS <          |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|   >> Addition (+)               |");
            Console.WriteLine("|   >> Subtraction (-)            |");
            Console.WriteLine("|   >> Multiplication (*)         |");
            Console.WriteLine("|   >> Division (/)               |");
            Console.WriteLine("|   >> Equals to get Result (=)   |");
            Console.WriteLine("———————————————————————————————————");
            Console.WriteLine();

            double result = 0;
            bool isFirstNumber = true;
            char currentOperator = ' ';
            Console.WriteLine("Current Equation: " + result);
            Console.WriteLine();

            while (true)
            {
                double num;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("> Enter a number: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out num))
                {
                    result = isFirstNumber ? num : PerformOperation(currentOperator, result, num);
                    isFirstNumber = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Invalid input! Please enter a valid number...");
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("> Enter an operator: ");
                string operatorInput = Console.ReadLine();

                while (!IsValidOperator(operatorInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Invalid operator! Please enter a valid operator");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("> Enter an operator: ");
                    operatorInput = Console.ReadLine();
                }

                if (operatorInput == "=")
                    break;
                else
                    currentOperator = operatorInput[0];
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Final result: " + result);

            bool validChoice = false;
            while (!validChoice)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(">> Do you want to Calculate again? (y/n)");
                Console.Write(">> ");
                string contchoice = Console.ReadLine().ToLower();

                if (contchoice == "n" || contchoice == "no")
                {
                    keepCalculating = false;
                    validChoice = true;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                    Console.WriteLine(">> Calculator closed. <<");
                }
                else if (contchoice == "y" || contchoice == "yes")
                {
                    validChoice = true;
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Invalid Choice! Please type 'y' or 'n'... =");
                }
            }
        }
    }

    static bool IsValidOperator(string input)
    {
        string allowedOperators = "+-*/=";
        return input.Length == 1 && allowedOperators.Contains(input);
    }

    static double PerformOperation(char operation, double num1, double num2)
    {
        switch (operation)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 != 0)
                    return num1 / num2;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Cannot divide by zero! Please enter a valid divisor...");
                    return num1;
                }
            default:
                throw new ArgumentException("Invalid operation");
        }
    }
}
