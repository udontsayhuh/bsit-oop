using System;

// Calculator class responsible for performing calculations
class Calculator
{
    private double num1;
    private char op;
    private double num2;

    // Constructor to initialize the Calculator object with operands and operator
    public Calculator(double num1, char op, double num2)
    {
        this.num1 = num1;
        this.op = op;
        this.num2 = num2;
    }

    // Method to perform the calculation based on the operator
    public double Calculate()
    {
        double result = 0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return double.NaN; // Return NaN (Not a Number) for invalid division
                }
                result = num1 / num2;
                break;
        }
        return result;
    }
}

// InputOutput class responsible for handling user input and output
class InputOutput
{
    // Method to get numerical input from the user
    public static double GetNumberInput(string message)
    {
        double input;
        while (true)
        {
            Console.Write(message + " ");
            if (double.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            Console.WriteLine("Invalid input. Please enter a numerical value.");
        }
    }

    // Method to get operator input from the user
    public static char GetOperatorInput(string message)
    {
        char op;
        while (true)
        {
            Console.Write(message + " ");
            if (char.TryParse(Console.ReadLine(), out op) && (op == '+' || op == '-' || op == '*' || op == '/'))
            {
                return op;
            }
            Console.WriteLine("Invalid operator. Please enter one of the four basic operators (+, -, *, /).");
        }
    }

    // Method to display the result
    public static void DisplayResult(double result)
    {
        Console.WriteLine($"Result: {result}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            // Get user input for the first number, operator, and second number
            double num1 = InputOutput.GetNumberInput("Enter the first number:");
            char op = InputOutput.GetOperatorInput("Enter the operator (+, -, *, /):");
            double num2 = InputOutput.GetNumberInput("Enter the second number:");

            // Create an instance of the Calculator class with the input values
            Calculator calc = new Calculator(num1, op, num2);
            // Perform the calculation
            double result = calc.Calculate();

            // Display the result
            InputOutput.DisplayResult(result);

            // Ask the user if they want to perform another calculation
            Console.Write("Do you want to perform another calculation? (yes/no) ");
            string input = Console.ReadLine();
            repeat = (input.ToLower() == "yes");
        }
    }
}
 
