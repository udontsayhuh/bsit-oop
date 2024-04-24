using System;
using System.Collections.Generic;
using System.Threading;

// Implementation of abstraction
// For me, putting all the methods in an abstract class help me identify the methods used inside the program
abstract class Operations {
    public abstract void DisplayOperations();
    public abstract void GetUserInput();
    public abstract void Calculate(List<double> numbers, List<char> operators);   
    public abstract void DisplayResult();
    public abstract void ClearLists(List<double> numbers, List<char> operators);
    public abstract void Loading();
    public abstract void ClearConsole();
    public abstract void ThankYou();
}

class Calculator : Operations {
    // Lists declared as private to encapsulate them within the Calculator class
    // They are not directly accessible within other classes
    private List<double> numbers = new List<double>();  // Create a list for numbers
    private List<char> operators = new List<char>();    // Create a list for operators
    public double result; // this variable stores the final result of the Calculator
    // Property to expose the 'numbers' list using getter
    public List<double> GetNumbers {
        get { return numbers; }
    }
    // Property to expose the 'operators' list using getter
    public List<char> GetOperators {
        get { return operators; }
    }

    // Method to display the operations
    public override void DisplayOperations() {
            Console.WriteLine(" =====================================================");
            Console.WriteLine("|                     CALCULATOR                      |");
            Console.WriteLine(" =====================================================");
            Console.WriteLine("|                          |                          |");
            Console.WriteLine("|            ( + )         |            ( - )         |");
            Console.WriteLine("|                          |                          |");
            Console.WriteLine("|            ( x )         |            ( / )         |");
            Console.WriteLine("|                          |                          |");
            Console.WriteLine(" =====================================================");
            Console.WriteLine();
    }

    // Method to get user input for the 'numbers' and 'operators' list
    public override void GetUserInput()
    {
        // Clear lists before starting a new calculation
        ClearLists(numbers, operators);

        // Get the first number
        double num;
        while (true)
        {
            try
            {
                Console.Write("Enter the first number: ");
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    throw new ArgumentException("Invalid input. Please enter a valid number.");
                }
                // Store the number in the 'numbers' list
                numbers.Add(num);
                break;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Get subsequent inputs until '=' is entered
        char op;
        while (true)
        {
            try
            {
                Console.Write("Enter the operator (+, -, *, /, =): ");
                if (!char.TryParse(Console.ReadLine(), out op))
                {
                    throw new ArgumentException("Invalid input. Please enter a valid operator.");
                }
                if (op == '=')
                {
                    break;
                }
                else if (op != '+' && op != '-' && op != '*' && op != '/')
                {
                    throw new ArgumentException("Invalid input. Please enter a valid operator.");
                }

                // Store the operator in the 'operators' list
                operators.Add(op);

                // Get the next number
                Console.Write("Enter the next number: ");
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    throw new ArgumentException("Invalid input. Please enter a valid number.");
                }
                // Store the number in the 'numbers' list
                numbers.Add(num);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    // Method for calculations
    public override void Calculate(List<double> numbers, List<char> operators)
    {
        // Perform calculations based on the provided inputs
        result = numbers[0];
        for (int i = 0; i < operators.Count; i++)
        {
            switch (operators[i])
            {
                case '+':
                    result += numbers[i + 1];
                    break;
                case '-':
                    result -= numbers[i + 1];
                    break;
                case '*':
                    result *= numbers[i + 1];
                    break;
                case '/':
                    if (numbers[i + 1] != 0)
                    {
                        result /= numbers[i + 1];
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    break;
            }
        }
    }
    
    // Method to display final output
    public override void DisplayResult()
    {
        ClearConsole();
        DisplayOperations();

        // Display the result
        Console.WriteLine("Result:");

        // Check if there is at least one number provided
        if (numbers.Count > 0)
        {
            // If there's only one number provided, display it directly
            if (numbers.Count == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            // If there are multiple numbers and operators, display the calculation expression
            else
            {
                Console.Write(numbers[0]);
                for (int i = 0; i < operators.Count; i++)
                {
                    Console.Write($" {operators[i]} ");
                    if (i + 1 < numbers.Count)
                    {
                        Console.Write(numbers[i + 1]);
                    }
                }
                Console.WriteLine($" = {result}");
            }
        }
    }

    // Method to clear the lists
    public override void ClearLists(List<double> numbers, List<char> operators) {
        numbers.Clear();
        operators.Clear();
    }

    // Method to clear console
    public override void ClearConsole() {
        Console.SetCursorPosition(0, 0);
        Console.Write(new string(' ', Console.WindowWidth * Console.WindowHeight));
        Console.SetCursorPosition(0, 0);
    }

    // Method for threading
    public override void Loading() {
        Thread.Sleep(1000);
        for(int i = 0; i < 3; i++) {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
    }

    // Method to display thank you phrase for using the system
    public override void ThankYou() {
        Console.WriteLine(" ===============================================");
        Console.WriteLine("|                                               |");
        Console.WriteLine("|                   THANK YOU                   |");
        Console.WriteLine("|             FOR USING THE PROGRAM!            |");
        Console.WriteLine("|                                               |");
        Console.WriteLine(" ===============================================");
    }
}

class CalculatorApp {
    public static void Main(string[] args) {
        while(true) {
            Calculator calculator = new Calculator();
            calculator.DisplayOperations();
            calculator.GetUserInput();
            List<double> numbers = calculator.GetNumbers;
            List<char> operators = calculator.GetOperators;
            calculator.Calculate(numbers, operators);
            
            // Display result
            Console.Write("\nLoading ");
            calculator.Loading();
            calculator.DisplayResult();

            // Ask the user for another calculation
            Console.Write("Do you want to calculate again? (y / n): ");
            char ans = char.ToLower(Convert.ToChar(Console.ReadLine()));
            if (ans == 'n') {
                Console.Write("\nExiting program ");
                calculator.Loading();
                calculator.ClearConsole();
                calculator.ThankYou();
                break;
            }
            // Clear the lists
            Console.Write("\nClearing lists ");
            calculator.Loading();
            calculator.ClearLists(numbers, operators);

            // Clear the console
            calculator.ClearConsole();
        }     
    }
}
