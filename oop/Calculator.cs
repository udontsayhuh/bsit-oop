using System;
//I tried to change the structure of my code to implement the requirements easily T__T
//Encapsulation and Abstraction are the only pillars I applied, but I will try to apply the other pillars too on the next activity

//Define an interface for a simple calculator
public interface Simple_Calculator
{
    //Method signature for performing arithmetic operations
    double PerformOperation(double num1, double num2, char operation);
}

//Implementation of the simple calculator interface
public class BasicCalculator : Simple_Calculator
{
    //Method to perform arithmetic operations
    public double PerformOperation(double num1, double num2, char operation)
    {
        double result = 0.0;

        switch (operation)
        {
            //Addition operation
            case '+':
                result = num1 + num2;
                break;
            //Subtraction operation
            case '-':
                result = num1 - num2;
                break;
            //Multiplication operation
            case '*':
                result = num1 * num2;
                break;
            //Division operation
            case '/':
                try
                {
                    if (num2 == 0)
                    {
                        //Throw an exception if attempting to divide by zero
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    //Perform division if the divisor is not zero
                    result = num1 / num2;
                }
                //Catch and handle the DivideByZeroException
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    //Return NaN (Not-a-Number) as the result
                    return double.NaN;
                }
                break;
            //Default case for invalid operation
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }

        //Return the result of the arithmetic operation
        return result;
    }
}

//Service class responsible for interacting with the calculator
public class CalculatorService
{
    //Private field to hold the calculator instance
    private readonly Simple_Calculator _calculator;

    //Constructor to initialize the calculator service
    public CalculatorService(Simple_Calculator calculator)
    {
        _calculator = calculator;
    }

    //Method to perform arithmetic calculations using the calculator
    public double Calculate(double num1, double num2, char operation)
    {
        //Delegate the calculation to the calculator implementation
        return _calculator.PerformOperation(num1, num2, operation);
    }
}

//Main program class
class Program
{
    //Main method
    static void Main(string[] args)
    {
        //Variable to control the continuation of calculations
        bool continueCalculating = true;
        //Create an instance of the basic calculator
        Simple_Calculator calculator = new BasicCalculator();
        //Create a calculator service with the basic calculator
        CalculatorService calculatorService = new CalculatorService(calculator);

        //Main loop for accepting user input and performing calculations
        while (continueCalculating)
        {
            //Variables to store user input and calculation results
            double num1, num2, result;
            char operation;

            //Prompt the user to enter the first number
            Console.Write("Enter a number: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter a number: ");
            }

            //Prompt the user to enter the operation symbol
            Console.Write("Enter operation (+, -, *, /, or = to get the result): ");
            while (!char.TryParse(Console.ReadLine(), out operation) || !IsValidOperation(operation))
            {
                Console.WriteLine("Invalid input. Please enter a valid operation.");
                Console.Write("Enter operation (+, -, *, /, or = to get the result): ");
            }

            //Loop for continuous calculation until the user decides to exit
            while (operation != '=')
            {
                //Prompt the user to enter the second number
                Console.Write("Enter a number (or '=' to exit): ");
                while (!double.TryParse(Console.ReadLine(), out num2) && operation != '=')
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter a number (or '=' to exit): ");
                }

                //Perform the calculation using the calculator service
                result = calculatorService.Calculate(num1, num2, operation);

                //Update the first number with the result for further calculations
                if (!double.IsNaN(result))
                    num1 = result;

                //Prompt the user to enter the next operation
                Console.Write("Enter operation (+, -, *, /, or = to get the result): ");
                while (!char.TryParse(Console.ReadLine(), out operation) || !IsValidOperation(operation))
                {
                    Console.WriteLine("Invalid input. Please enter a valid operation.");
                    Console.Write("Enter operation (+, -, *, /, or = to get the result): ");
                }

                //Display the result if the user chooses to exit
                if (operation == '=')
                    Console.WriteLine("Result: " + result);
            }

            //Prompt the user if they want to continue with more calculations
            Console.Write("\nDo you want to continue (y/n): ");
            char choice = char.ToLower(Console.ReadKey().KeyChar);
            if (choice != 'y')
                continueCalculating = false;

            Console.WriteLine();
        }
    }

    //Method to check if the operation symbol is valid
    static bool IsValidOperation(char operation)
    {
        return operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == '=';
    }
}
