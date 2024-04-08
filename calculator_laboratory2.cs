using System;

abstract class Operation
{
    public abstract double Calculate(double num1, double num2);
}

class Add : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 + num2;
    }
}

class Subtract : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}

class Multiply : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 * num2;
    }
}

class Divide : Operation
{
    public override double Calculate(double num1, double num2)
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            Console.WriteLine("Cannot be divided by zero.");
            return 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\t\t\tCALCULATOR PROGRAM\n");

            double num1, result = 0;
            bool isNumValid;
            string temp_symbol = "";

            while (true)
            {
                Console.Write("\nEnter a number: ");
                isNumValid = double.TryParse(Console.ReadLine(), out num1);

                if (isNumValid)
                {
                    if (temp_symbol == "+")
                    {
                        Operation add = new Add();
                        double temp_result = add.Calculate(result, num1);
                        result = temp_result;
                    }
                    else if (temp_symbol == "-")
                    {
                        Operation subtract = new Subtract();
                        double temp_result = subtract.Calculate(result, num1);
                        result = temp_result;
                    }
                    else if (temp_symbol == "*")
                    {
                        Operation multiply = new Multiply();
                        double temp_result = multiply.Calculate(result, num1);
                        result = temp_result;
                    }
                    else if (temp_symbol == "/")
                    {
                        Operation divide = new Divide();
                        double temp_result = divide.Calculate(result, num1);
                        result = temp_result;
                    }

                    Console.WriteLine("\n\tADDITION = +");
                    Console.WriteLine("\tSUBTRACTION = -");
                    Console.WriteLine("\tMULTIPLICATION = *");
                    Console.WriteLine("\tDIVISION = /");
                    Console.WriteLine("\tRESULT: =");

                    Console.Write("\nSelect Operation: ");
                    string operationSymbol = Console.ReadLine();

                    if (operationSymbol == "+")
                    {
                        temp_symbol = operationSymbol;
                    }
                    else if (operationSymbol == "-")
                    {
                        temp_symbol = operationSymbol;
                    }
                    else if (operationSymbol == "*")
                    {
                        temp_symbol = operationSymbol;
                    }
                    else if (operationSymbol == "/")
                    {
                        temp_symbol = operationSymbol;
                    }
                    else if (operationSymbol == "=")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Operation. Choose from +, -, *, /, or =");
                    }

                    if (result == 0)
                    {
                        result = num1;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Enter an integer");
                }
            }

            Console.WriteLine("RESULT: " + result);

            Console.Write("\nDo you want to run the program again? (yes/no): ");
            string runAgain = Console.ReadLine().ToLower();

            if (runAgain != "yes" && runAgain != "y")
            {
                Console.WriteLine("\nProgram Closing...");
                break;
            }
        }
    }
}
