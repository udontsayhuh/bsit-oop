using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("================================");
            Console.WriteLine("= Welcome to Simple Calculator =");
            Console.WriteLine("================================");

            Console.WriteLine("===============================================");
            Console.WriteLine("= Enter an expression (use '=' to calculate): =");
            Console.WriteLine("= Example: 1+2+3+4+5= (Operators:+,-,*,/)     =");
            Console.WriteLine("===============================================");
            string input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("===================================================");
                Console.WriteLine("= Invalid input. Please enter a valid expression. =");
                Console.WriteLine("===================================================");
                continue;
            }

            input = input.Replace(" ", ""); // Remove spaces for simplicity

            // Check if the input ends with '='
            if (input.EndsWith("="))
            {
                input = input.TrimEnd('='); // Remove '='
                double result = Calculate(input);
                Console.WriteLine("=================");
                Console.WriteLine("Result: " + result);
                Console.WriteLine("=================");
            }
            else
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("= Expression must end with '=' to calculate. =");
                Console.WriteLine("==============================================");
            }
        }
    }

    static double Calculate(string expression)
    {
        try
        {
            return Convert.ToDouble(new System.Data.DataTable().Compute(expression, ""));
        }
        catch (Exception)
        {
            Console.WriteLine("===================================================================");
            Console.WriteLine("= Invalid expression. Please enter a valid arithmetic expression. =");
            Console.WriteLine("===================================================================");
            return double.NaN;
        }
    }
}