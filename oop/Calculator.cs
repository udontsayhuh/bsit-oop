using System;

// Parent class for operations
abstract class Operation
{
    public abstract double PerformOperation(double num1, double num2);
}

// Addition operation
class Addition : Operation
{
    public override double PerformOperation(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Subtraction operation
class Subtraction : Operation
{
    public override double PerformOperation(double num1, double num2)
    {
        return num1 - num2;
    }
}

// Multiplication operation
class Multiplication : Operation
{
    public override double PerformOperation(double num1, double num2)
    {
        return num1 * num2;
    }
}

// Division operation
class Division : Operation
{
    public override double PerformOperation(double num1, double num2)
    {
        if (num2 != 0)
            return num1 / num2;
        else
            throw new DivideByZeroException("Cannot divide by zero");
    }
}

class Calculator
{
    // Method to get user input, validate and display output
    public void PerformCalculation()
    {   //Loop for performing calculation
        string value;
        do
        {
            Console.Write("\nEnter first number:");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("\nInput is invalid.");
                return; //terminate
            }

            string symbol;
            do
            {
                Console.Write("Enter symbol (/,+,-,*):");
                symbol = Console.ReadLine();
                if (symbol != "/" && symbol != "+" && symbol != "-" && symbol != "*")
                {
                    Console.WriteLine("\nInput is invalid.");
                    return; //terminate
                }
            } while (symbol != "/" && symbol != "+" && symbol != "-" && symbol != "*");

            double num2;
            while (true)
            {
                Console.Write("Enter second number:");
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("\nInput is invalid.");
                    return; //terminate
                }
                else
                {
                    break;
                }
            }
            //Variable to retrieve the appropriate operation based on the user's input choice
            Operation operation = GetOperation(symbol);

            try
            { //To perform arithmetic operation then display the output
                double result = operation.PerformOperation(num1, num2);
                Console.WriteLine($"\n {num1} {symbol} {num2} = {result}");
            }
            catch (DivideByZeroException zero)
            {
                Console.WriteLine(zero.Message);
            }
            //Mthod to ask the user if they want to continue
            Console.Write("\nDo you want to continue(y/n):");
            value = Console.ReadLine();
        } while (value == "y" || value == "Y");
    }

    //Mthod to to perform arithmetic operation chosen by the user
    private Operation GetOperation(string symbol)
    {
        switch (symbol)
        {
            case "+":
                return new Addition();
            case "-":
                return new Subtraction();
            case "*":
                return new Multiplication();
            case "/":
                return new Division();
            default:
                throw new ArgumentException("\nInput is invalid.");
        }
    }
}

// Main 
class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Basic Arithmetic Calculator");
        Console.WriteLine("----------------------------");
        //Instance of Calculator class
        Calculator calculator = new Calculator();
        calculator.PerformCalculation();
    }
}

