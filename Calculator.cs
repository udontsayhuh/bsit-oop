// MODIFIED CALCULATOR
using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        // Start the calculation process
        Calculate();
    }

    private static void Calculate()
    {
        Console.Clear();

        // Display welcome and header text
        Console.WriteLine("     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~       ");
        Console.WriteLine("    |Welcome to Baron's Calculator|       ");
        Console.WriteLine("     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~       ");

        double firstNumber = 0;


        // Request user for first number
        Console.Write("\nPlease Input number: ");
        firstNumber = GetNumberInput();

        string operation = null;

        // Loop for operator input validation
        while (operation == null || (operation != "+" && operation != "-" && operation != "*" && operation != "/"))
        {
            // Request user for operator
            Console.Write("\nPlease choose what operator you want to use(+, -, *, /): ");
            operation = Console.ReadLine();

            // Perform input validation for operator
            if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Error!!! Please input a valid operator!!!");
                operation = null;
            }
        }

        double secondNumber = 0;

        // Request user for second number
        Console.Write("\nPlease Input number: ");
        secondNumber = GetNumberInput();

        double result = 0;

        // Perform the selected mathematical operation
        switch (operation)
        {
            case "+":
                result = firstNumber + secondNumber;
                break;
            case "-":
                result = firstNumber - secondNumber;
                break;
            case "*":
                result = firstNumber * secondNumber;
                break;
            case "/":
                // Error handling to prevent division by zero
                if (secondNumber == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }

                result = firstNumber / secondNumber;
                break;
        }
        do
        {
            
            operation = null;

            // Loop for operator input validation
            while (operation == null || (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "="))
            {
                // Request user for operator
                Console.Write("\nPlease choose what operator you want to use(+, -, *, / or '=' to compute): ");
                operation = Console.ReadLine();

                // Perform input validation for operator
                if (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "=")
                {
                    Console.WriteLine("Error!!! Please input a valid operator!!!");
                    operation = null;
                }
            }
            if (operation == "=")
                break;

            secondNumber = 0;

            // Request user for second number
            Console.Write("\nPlease Input number: ");
            secondNumber = GetNumberInput();
            switch (operation)
            {
                case "+":
                    result = result + secondNumber;
                    break;
                case "-":
                    result = result - secondNumber;
                    break;
                case "*":
                    result = result * secondNumber;
                    break;
                case "/":
                    // Error handling to prevent division by zero
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }

                    result = result / secondNumber;
                    break;
            }
        } while (true);
        // Display the calculation result
        Console.WriteLine($"\nHere is the result: {result}");

        // Ask user if they would like to perform another calculation
        Console.Write("\nDo you want to do another calculation? (Y/N): ");

        string input = Console.ReadLine().ToLower();

        if (input == "n")
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~     ");
            Console.WriteLine("|Thank you for using Baron's Calculator,Goodbye|");
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    ");
            return;
        }
        else if (input == "y")
        {
            Calculate();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter Y or N.");
            Calculate();
        }
    }

    private static double GetNumberInput()
    {
        double number = 0;

        // Validate and parse the user input as a number
        if (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Error!!! Please enter a valid number!!!");
            return GetNumberInput();
        }

        return number;
    }
}
