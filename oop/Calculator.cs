using System;

class Calculator
{
    public double Add(double x, double y)
    {
        return x + y;
    }

    public double Subtract(double x, double y)
    {
        return x - y;
    }

    public double Multiply(double x, double y)
    {
        return x * y;
    }

    public double Divide(double x, double y)
    {
        if (y != 0)
        {
            return x / y;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return double.NaN; // NaN represents "Not a Number"
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        while (true)
        {
            double number1, number2;
            string input;

            // Input for first number
            while (true)
            {
                Console.Write("Enter the first numerical value: ");
                input = Console.ReadLine();

                if (double.TryParse(input, out number1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                }
            }

            // Input for operation
            Console.Write("Enter the operator (+, -, *, /): ");
            input = Console.ReadLine();

            // Input validation for operator
            if (input != "+" && input != "-" && input != "*" && input != "/")
            {
                Console.WriteLine("Operators invalid. We only accept +, -, /, and *.");
                continue; // Restart the loop
            }

            // Input for second number
            while (true)
            {
                Console.Write("Enter the second numerical value: ");
                input = Console.ReadLine();

                if (double.TryParse(input, out number2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                }
            }

            // Perform the operation based on user input
            double result = 0;
            switch (input)
            {
                case "+":
                    result = calc.Add(number1, number2);
                    break;
                case "-":
                    result = calc.Subtract(number1, number2);
                    break;
                case "*":
                    result = calc.Multiply(number1, number2);
                    break;
                case "/":
                    result = calc.Divide(number1, number2);
                    break;
            }

            // Display the result
            Console.WriteLine($"Result: {result}");

            // Ask if the user wants to perform another calculation
            Console.Write("Do you want to perform another calculation? (yes/no): ");
            input = Console.ReadLine().ToLower();

            if (input != "yes")
            {
                break; // Exit the loop if input is not "yes"
            }
        }
    }
}
