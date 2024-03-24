// Base Class
abstract class Operator
{
    public abstract int Calculate(int num1, int num2);
}

// Subclass for Addition
class Add : Operator
{
    public override int Calculate(int num1, int num2)
    {
        return num1 + num2;
    }
}

// Subclass for Subtraction
class Subtract : Operator
{
    public override int Calculate(int num1, int num2)
    {
        return num1 - num2;
    }
}

// Subclass for Multiplication
class Multiply : Operator
{
    public override int Calculate(int num1, int num2)
    {
        return num1 * num2;
    }
}

// Subclass for Division
class Divide : Operator
{
    public override int Calculate(int num1, int num2)
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
        Console.WriteLine("Activity#2 OOP (Calculator)");

        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose an operation: +, -, *, /");
        string operation = Console.ReadLine();

        Operator op = GetOperator(operation);

        if (op != null)
        {
            int result = op.Calculate(num1, num2);
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Invalid operation.");
        }
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
