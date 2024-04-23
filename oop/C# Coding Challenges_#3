using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        
        bool repeat = true;

        while (repeat)
        {
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.Write("Enter your choice: ");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            try
            {
                double result = calc.PerformOperation(num1, num2, ch);
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.Write("Do you want to perform another action? (yes/no): ");
            string resp = Console.ReadLine().ToLower();
            
            repeat = (resp == "yes");
        }
    }
}

class Calculator
{
    public double PerformOperation(double n1, double n2, char op)
    {
        switch (op)
        {
            case '+':
                return n1 + n2;
            case '-':
                return n1 - n2;
            case '*':
                return n1 * n2;
            case '/':
                if (n2 != 0)
                    return n1 / n2;
                else
                    throw new DivideByZeroException("Cannot divide by zero.");
            default:
                throw new ArgumentException("Invalid operation.");
        }
    }
}
