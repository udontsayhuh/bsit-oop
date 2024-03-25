using System;
// Borja, Nadine BSIT 2-2

// this sequence of code is used to implement inheritance and polymorphism
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

        Console.WriteLine("\t\t\tCALCULATOR PROGRAM\n");

        while (true) 
        {
            double num1, num2, result;
            bool isNum1Valid, isNum2Valid;

            Console.Write("\nEnter first number: ");
            isNum1Valid = double.TryParse(Console.ReadLine(), out num1); // Try.Parse function is used to check if the user input is numerical

            if (isNum1Valid)
            {
                while (true)
                {
                    Console.Write("Enter second number: ");
                    isNum2Valid = double.TryParse(Console.ReadLine(), out num2);

                    if (isNum2Valid)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("\tInvalid input for the second number. Please enter a valid number.");
                    }
                }

                Operation operation; // operation variable is used as a placeholder or variable to execute the operation chosen by the user

                while (true) 
                {
                    Console.WriteLine("\n\tADDITION = +");
                    Console.WriteLine("\tSUBTRACTION = -");
                    Console.WriteLine("\tMULTIPLICATION = *");
                    Console.WriteLine("\tDIVISION = /");

                    Console.Write("\nSelect Operation: ");
                    string operationSymbol = Console.ReadLine();

                    switch (operationSymbol)
                    {
                        case "+":
                            operation = new Add();
                            break;
                        case "-":
                            operation = new Subtract();
                            break;
                        case "*":
                            operation = new Multiply();
                            break;
                        case "/":
                            operation = new Divide();
                            break;
                        default:
                            Console.WriteLine("\tInvalid operation. Please select from +, -, *, or /.");
                            continue; 
                    }

                    break; 
                }

                result = operation.Calculate(num1, num2);
                Console.WriteLine("RESULT: " + result);
            }
            else
            {
                Console.WriteLine("\tInvalid input for the first number. Program is Terminated. ");
            }

            Console.Write("\nDo you want to run the program again? (yes/no): ");
            string runAgain = Console.ReadLine().ToLower();

            if (runAgain != "yes" && runAgain != "y")
            {
                Console.WriteLine("Program Closing...");
                break; 
            }
        }
    }
}
