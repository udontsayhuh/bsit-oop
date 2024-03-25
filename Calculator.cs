using System;

class Calculator
{
    private double num1;
    private char op;
    private double num2;

    public Calculator(double num1, char op, double num2)
    {
        this.num1 = num1;
        this.op = op;
        this.num2 = num2;
    }

    public double Calculate()
    {
        switch (op)
        {
            case '+': return num1 + num2;
            case '-': return num1 - num2;
            case '*': return num1 * num2;
            case '/':
                if (num2 == 0) throw new ArgumentException("Error: Division by zero!");
                return num1 / num2;
            default:
                throw new ArgumentException("Error: Invalid input! Please enter a numerical value.");
        }
    }

    public void DisplayResult()
    {
        try
        {
            double result = Calculate();
            Console.WriteLine("Result: " + result);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

class Program
{
    static void Main()
    {
        do
        {
            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Error: Invalid input! Please enter a numerical value.");
                return;
            }
            Console.WriteLine();
            Console.Write("Enter an operator (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());
            if (op != '+' && op != '-' && op != '*' && op != '/')
            {

                Console.WriteLine("Error: Invalid operator!");
                return;
            }

            Console.WriteLine();

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {

                Console.WriteLine("Error: Invalid input! Please enter a numerical value.");
                return;
            }

            Console.WriteLine();

            Calculator calculator = new Calculator(num1, op, num2);

            calculator.DisplayResult();

            Console.WriteLine();

            Console.WriteLine("Do you want to calculate again? (Y/N)");
            Console.WriteLine();
            
        } while (Console.ReadLine().Trim().ToUpper() == "Y");
    }
}