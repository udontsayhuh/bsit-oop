// Base Class
abstract class Operator
{
    public abstract double Calculate(double num1, double num2);
}

// Subclass for Addition
class Add : Operator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Subclass for Subtraction
class Subtract : Operator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}

// Subclass for Multiplication
class Multiply : Operator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 * num2;
    }
}

// Subclass for Division
class Divide : Operator
{
    public override double Calculate(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
}

class Calculator
{
    static void Main(string[] args)
    {
        bool repeat = false;
        do
        {
            Console.WriteLine("Simple Calculator!");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            string operation;
            Operator op;

            do
            {
                Console.WriteLine("Choose an operation: +, -, *, /");
                operation = Console.ReadLine();
                op = GetOperator(operation);

                if (op == null)
                {
                    Console.WriteLine("Invalid operation. Please try again.");
                }

            } while (op == null);

            double result = op.Calculate(num1, num2);
            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Do you want to perform another operation? (yes/no)");
            string response = Console.ReadLine();
            repeat = (response.ToLower() == "yes");

        } while (repeat);
    }

    static Operator GetOperator(string operation)
    {
        switch (operation)
        {
            case "+":
                return new Add();
            case "-":
                return new Subtract();
            case "*":
                return new Multiply();
            case "/":
                return new Divide();
            default:
                return null;
        }
    }
}

