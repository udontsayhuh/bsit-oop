using System;

// Abstract base class representing an arithmetic operation
abstract class Operation
{
    // Method signature for performing an operation
    public abstract double Execute(double num1, double num2);
}

// Concrete subclass for operation
class AdditionOperation : Operation
{
    public override double Execute(double num1, double num2)
    {
        return num1 + num2;
    }
}


class SubtractionOperation : Operation
{
    public override double Execute(double num1, double num2)
    {
        return num1 - num2;
    }
}

class MultiplicationOperation : Operation
{

    public override double Execute(double num1, double num2)
    {
        return num1 * num2;
    }
}

class DivisionOperation : Operation
{
    public override double Execute(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero.");
            return double.NaN;
        }
        return num1 / num2;
    }
}

// Class representing a calculator
class Calculator
{
    // Operation objects for each arithmetic operation
    private Operation addition;
    private Operation subtraction;
    private Operation multiplication;
    private Operation division;

    // Constructor to instantiate operation objects
    public Calculator()
    {
        // Instantiate operation objects
        addition = new AdditionOperation();
        subtraction = new SubtractionOperation();
        multiplication = new MultiplicationOperation();
        division = new DivisionOperation();
    }

    // Method to perform basic arithmetic operations
    public double PerformOperation(double num1, double num2, char op)
    {
        switch (op)
        {
            case '+':
                return addition.Execute(num1, num2);
            case '-':
                return subtraction.Execute(num1, num2);
            case '*':
                return multiplication.Execute(num1, num2);
            case '/':
                return division.Execute(num1, num2);
            default:
                Console.WriteLine("Invalid operator.");
                return double.NaN;
        }
    }

    // Method to display result
    public void DisplayResult(double result)
    {
        Console.WriteLine($"The result is: {result}");
    }
}

class Program
{
    static void Main()
    {
        bool repeat = true;

        while (repeat)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("                       BASIC CALCULATOR");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Enter a number:");
            double result = 0;
            bool isFirstValue = true;
            char prevOperator = '+';

            Calculator calculator = new Calculator();

            // Loop to handle user inputs for calculations
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "=")
                    break;

                double num;
                if (!double.TryParse(input, out num))
                {
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("Invalid input. Please enter a numerical value ");
                    Console.WriteLine("--------------------------------------------------------------------");
                    continue;
                }

                if (isFirstValue)
                {
                    result = num;
                    isFirstValue = false;
                }
                else
                {
                    result = calculator.PerformOperation(result, num, prevOperator);
                }

                Console.WriteLine("Enter an operation (+, -, *, /) or '=' to compute:");
                string op = Console.ReadLine();

                if (op != "+" && op != "-" && op != "*" && op != "/" && op != "=")
                {
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("Invalid operator. Please enter a valid operator or '=' to calculate.");
                    Console.WriteLine("--------------------------------------------------------------------");
                    continue;
                }

                if (op == "=")
                    break;

                prevOperator = op[0];

                // Prompt for the next number
                Console.WriteLine("Enter a number:");
            }

            // Display result
            Console.WriteLine("--------------------------------------------------------------------");
            calculator.DisplayResult(result);
            Console.WriteLine("--------------------------------------------------------------------");

            // Prompt to start a new calculation session or exit
            Console.WriteLine("Do you want to start a new calculation session? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                repeat = false;
            }
        }
    }
}
