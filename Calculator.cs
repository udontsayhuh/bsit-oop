using System;

public class Calculator
{
    public static void Main(string[] args)
    {
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
        Console.Write("\nPlease Input your first number: ");
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
        Console.Write("\nPlease Input your second number: ");
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

        // Display the calculation result
        Console.WriteLine($"\nHere is the result: {result}");

        // Ask user if they would like to perform another calculation
        Console.Write("\nDo you want to do another calculation? (Y/N): ");

        if (Console.ReadLine().ToLower() == "n")
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~     ");
            Console.WriteLine("Thank you for using Baron's Calculator,Goodbye!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~     ");
            return;
        }

        Calculate();
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
