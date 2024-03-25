//SOLANO, CEDRIC MARK G.
//BSIT 2-2
//Calculator that accepts any user inputs.

using System;
using System.Collections.Generic; // to utilize generic collections in our code, like a lists.

namespace MyCalculator
{
    // Encapsulation: The Calculator class encapsulates the functionality of a calculator.
    class Calculator
    {
        class Calculation
        {
            // Encapsulation: Using properties to encapsulate the data related to a calculation.
            public float Number1 { get; set; }
            public float Number2 { get; set; }
            public string Symbol { get; set; }
            public float Result { get; set; }
            public string OperationWord { get; set; } // Added OperationWord property for readability
        }

        // List to store calculation history
        List<Calculation> history = new List<Calculation>();

        // Abstraction: The RunCalculator method abstracts the process of running the calculator, hiding its internal implementation details.
        // Encapsulation: The RunCalculator method encapsulates the logic for running the calculator within the Calculator class.
        public void RunCalculator()
        {
            string value = "y";
            do
            {
                // User interface
                Console.WriteLine("=============================================");
                Console.WriteLine("   CALCULATOR THAT ACCEPTS ANY USER INPUT!    ");
                Console.WriteLine("=============================================");

                // Input validation loop for operator symbol
                string symbol;
                while (true)
                {
                    Console.Write("Enter symbol you want to use (+, -, *, /): ");
                    symbol = Console.ReadLine();

                    if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/")
                        break;
                    else
                        Console.WriteLine("Invalid symbol");
                }

                // Input for first number
                float number1, number2;
                Console.Write("Input first number: ");
                if (!float.TryParse(Console.ReadLine(), out number1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                    continue;
                }

                // Input for second number
                Console.Write("Input second number: ");
                if (!float.TryParse(Console.ReadLine(), out number2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                    continue;
                }

                // Get operation word for display
                string operationWord = GetOperationWord(symbol);

                // Inform the user about the ongoing operation
                Console.WriteLine($"Calculating ({operationWord}) for input {number1} and {number2}...");
                float result = PerformOperation(number1, number2, symbol);

                // Record the calculation in history
                history.Add(new Calculation { Number1 = number1, Number2 = number2, Symbol = symbol, Result = result, OperationWord = operationWord });

                // Check if the user wants to continue
                Console.WriteLine("=============================================");
                Console.WriteLine("Do you want to do another calculation? (Y/N)");
                value = Console.ReadLine().ToLower();
            }
            while (value.ToLower() == "y");

            // Display the calculation history
            Console.WriteLine("\n==========    Calculator Closed    ==========\n");
            DisplayHistory();
        }

        // Polymorphism: The PerformOperation method is polymorphic, as it performs different arithmetic operations based on the symbol parameter.
        // Encapsulation: The PerformOperation method encapsulates the logic for performing arithmetic operations within the Calculator class.
        private float PerformOperation(float number1, float number2, string symbol)
        {
            float result = 0;
            switch (symbol)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed");
                        break;
                    }
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Invalid symbol");
                    break;
            }
            Console.WriteLine($"Result: {result}");
            return result;
        }

        // Encapsulation: The GetOperationWord method encapsulates the logic for determining the operation word based on the symbol within the Calculator class.
        private string GetOperationWord(string symbol)
        {
            switch (symbol)
            {
                case "+":
                    return "ADDITION";
                case "-":
                    return "SUBTRACTION";
                case "*":
                    return "MULTIPLICATION";
                case "/":
                    return "DIVISION";
                default:
                    return "UNKNOWN";
            }
        }

        // Encapsulation: The DisplayHistory method encapsulates the logic for displaying the calculation history within the Calculator class.
        private void DisplayHistory()
        {
            Console.WriteLine("==========   Calculation History   ==========");
            foreach (var calc in history)
            {
                // Display each calculation with operation word
                Console.WriteLine($"({calc.OperationWord}): {calc.Number1} {calc.Symbol} {calc.Number2} = {calc.Result}");
            }
        }
    }

    // Entry point
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.RunCalculator(); // Start the calculator
        }
    }
}
