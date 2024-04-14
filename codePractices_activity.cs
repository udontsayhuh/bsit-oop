using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// This code is from the second (calculator) laboratory activity. 


abstract class Operation
{
    public abstract double Calculate(double num1, double num2);
}
 // Application of proper naming convention; name classes as NOUNS
class Addition : Operation // changed Add to Addition
{
    public override double Calculate(double num1, double num2)
    {
        return num1 + num2;
    }
}

class Subtraction : Operation // changed Subtract to Subtraction
{
    public override double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}

class Multiplication : Operation // changed Multiply to Multiplication
{
    public override double Calculate(double num1, double num2)
    {
        return num1 * num2;
    }
}

class Division : Operation // changed Divide to Division
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
            string tempSymbol = ""; // use of Camel case; changed temp_symbol to tempSymbol

            while (true)
            {
                Console.Write("\nEnter a number: ");
                isNumValid = double.TryParse(Console.ReadLine(), out num1);

                if (isNumValid)
                {
                    if (tempSymbol == "+")
                    {
                        Operation add = new Addition();
                        double tempResult = add.Calculate(result, num1); // changed temp_result to tempResult
                        result = tempResult;
                    }
                    else if (tempSymbol == "-")
                    {
                        Operation subtract = new Subtraction();
                        double tempResult = subtract.Calculate(result, num1);
                        result = tempResult;
                    }
                    else if (tempSymbol == "*")
                    {
                        Operation multiply = new Multiplication();
                        double tempResult = multiply.Calculate(result, num1);
                        result = tempResult;
                    }
                    else if (tempSymbol == "/")
                    {
                        Operation divide = new Division();
                        double tempResult = divide.Calculate(result, num1);
                        result = tempResult;
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
                        tempSymbol = operationSymbol;
                    }
                    else if (operationSymbol == "-")
                    {
                        tempSymbol = operationSymbol;
                    }
                    else if (operationSymbol == "*")
                    {
                        tempSymbol = operationSymbol;
                    }
                    else if (operationSymbol == "/")
                    {
                        tempSymbol = operationSymbol;
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
