using System;

namespace simple_calculator
{
    class Calculator
    {
        private int num1;
        private int num2;

        // Constructor
        public Calculator(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        // Addition
        public int Add()
        {
            return num1 + num2;
        }

        // Subtraction
        public int Subtract()
        {
            return num1 - num2;
        }

        // Multiplication
        public int Multiply()
        {
            return num1 * num2;
        }

        // Division
        public int Divide()
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter symbol(/, +, -, *): ");
                string symbol = Console.ReadLine();

                Calculator calculator = new Calculator(num1, num2);
                int result = 0;

                switch (symbol)
                {
                    case "+":
                        result = calculator.Add();
                        Console.WriteLine("Sum: " + result);
                        break;
                    case "-":
                        result = calculator.Subtract();
                        Console.WriteLine("Difference: " + result);
                        break;
                    case "*":
                        result = calculator.Multiply();
                        Console.WriteLine("Product: " + result);
                        break;
                    case "/":
                        try
                        {
                            result = calculator.Divide();
                            Console.WriteLine("Quotient: " + result);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                Console.Write("\nDo you want to continue (y/n): \n");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }
}
