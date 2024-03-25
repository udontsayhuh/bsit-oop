using System;
using System.Threading.Tasks;

namespace OOP_works;

// Abstract class for different arithmetic operations
abstract class Operation
{
    public abstract double Calculate(double num1, double num2);
}

// Concrete class for addition operation
class Addition : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Concrete class for subtraction operation
class Subtraction : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}

// Concrete class for multiplication operation
class Multiplication : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 * num2;
    }
}

// Concrete class for division operation
class Division : Operation
{
    public override double Calculate(double num1, double num2)
    {
        if (num2 != 0)
            return num1 / num2;
        else
            throw new DivideByZeroException("Cannot divide by zero!");
    }
}

// Calculator class encapsulating the calculator logic
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
            Console.Write("Enter the First number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Operation operation;

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 5)
            {
                keepCalculating = false;
                continue;
            }
			
			switch (choice)
            {
                case 1:
                    operation = new Addition();
                    break;
                case 2:
                    operation = new Subtraction();
                    break;
                case 3:
                    operation = new Multiplication();
                    break;
                case 4:
                    operation = new Division();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    continue;
            }
			
            try
            {
                double result = calculator.PerformOperation(operation, num1, num2);
                Console.WriteLine("Result: " + result);
				Console.WriteLine("Do you want to Calculate again (y/n)?");
				Console.ReadLine();
                
				string contchoice = Console.ReadLine ().ToLower ();
				
				if (contchoice == "y" || contchoice == "yes")
				{	
				   keepCalculating = true;
				   continue;
                }
				else if (contchoice == "n" || contchoice == "no")
                {
                    keepCalculating = false;
					Console.WriteLine("Calculator closed.");
					break;
                }
				else
				{
                    Console.WriteLine("Invalid Choice! Please type 'y' or 'n'...");
                }
            }
			
			catch
			{
                Console.Clear();
            }
        }
    }
}

