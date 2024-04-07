using System;

namespace oop
{
    abstract class Operation // Abstract class for Pillars.
    {
        // Protected property.
        protected int Num { get; }

        protected Operation(int num) // For Operation Class.
        {
            // Initializing Num with value.
            Num = num;
        }

        public abstract int PerformOperation(); // Abstract Method.
    }

    // Inheritance for the Pillars.
    class Addition : Operation // Defining class that inherits from Operation.
    {
        public Addition(int num) : base(num) { } // Constructor for this class.

        public override int PerformOperation()
        {
            return Num + Num; // Returning the result.
        }
    }

    class Subtraction : Operation
    {
        public Subtraction(int num) : base(num) { }

        public override int PerformOperation()
        {
            return Num - Num;
        }
    }

    class Multiplication : Operation
    {
        public Multiplication(int num1, int num2) : base(num1) { }

        public override int PerformOperation()
        {
            return Num * Num;
        }
    }

    class Calculator // Class for the Calculator.
    {
        static void Main(string[] args) // Entry point.
        {
            bool tryAgain = true; // Boolean

            while (tryAgain) // While loop; It will loop until the user input "No."
            {
                List<int> numbers = new List<int>(); // Initialize an empty list
                List<string> symbols = new List<string>();

                bool NumberInput = true; // Boolean

                while (true) // Loop until the conditon is met.
                {
                    if (NumberInput)
                    {
                        int num;
                        while (true) // Keep asking for a number until it is valid.
                        {
                            Console.Write("Enter Number: ");
                            string input = Console.ReadLine();

                            if (input == "=") // If the user inputs "=", print this below message.
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                                continue; // Continue to next iteration of the loop.
                            }

                            if (int.TryParse(input, out num))
                            {
                                numbers.Add(num); // Add number to the list.
                                NumberInput = false; // Used to switch the "Enter Number: " to "Enter Symbol: ".
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number."); // Print this if it is invalid input.
                            }
                        }

                    }
                    else
                    {
                        Console.Write("Enter Symbol (+, -, *, /, =): ");
                        string input = Console.ReadLine();

                        if (input == "=") // If the user input "=", break the loop.
                            break;

                        if (input == "+" || input == "-" || input == "*" || input == "/") // Check if the input is a valid symbol.
                        {
                            symbols.Add(input); // Add symbol to the list.
                            NumberInput = true; // Switch to number input.
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid symbol.");
                        }
                    }
                }

                // Perform calculations based on the lists of numbers and symbols.
                int result = numbers[0]; 

                for (int i = 0; i < symbols.Count; i++) // For loop; It will iterate through each symbol in the symbol list.
                {
                    switch (symbols[i]) // It will check the current index in the symbol list.
                    {
                        case "+":
                            result = result + numbers[i + 1]; // Add the next number in the list to the current result.
                            break;
                        case "-":
                            result = result - numbers[i + 1];
                            break;
                        case "*":
                            result = result * numbers[i + 1];
                            break;
                        case "/":
                            result = result / numbers[i + 1];
                            break;
                        default:
                            Console.WriteLine("Invalid symbol.");
                            break;
                    }
                }

                Console.WriteLine($"Result is {result}"); // Print the result.

                while (true) // Keep looping until it is valid.
                {
                    Console.Write("Do you want to try again? (Yes or No): "); // Prompt the user.
                    string tryAgainInput = Console.ReadLine();

                    try // Error Handling.
                    {
                        if (tryAgainInput.ToLower() == "yes") // Convert the user's input to lowercase and check if it equals "yes". 
                        {
                            tryAgain = true; // Set tryAgain to true.
                            break;
                        }
                        else if (tryAgainInput.ToLower() == "no") // Equals to "no".
                        {
                            tryAgain = false; // Set tryAgain to false.
                            break;
                        }
                        else
                        {
                            throw new Exception("Invalid input. Please enter 'Yes' or 'No'."); // Throw an exception for invalid input.
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message); // Print the error message.
                    }
                }
            }
        }
    }
}
