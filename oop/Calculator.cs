using System;

namespace CrystalynDanga { 
    // Abstract class representing a basic arithmetic operation
    abstract class BasicOperation
    {
        // Abstract method to perform the operation, to be implemented in derived classes
        public abstract double Calculate(double operand1, double operand2);
    }

    // Class representing addition operation, derived from BasicOperation
        class AdditionOperation : BasicOperation
        {
            // Implementation of Calculate method for addition
            public override double Calculate(double operand1, double operand2)
            {
                return operand1 + operand2; // Returns the sum of operand1 and operand2
            }
        }

    // Class representing subtraction operation, derived from BasicOperation
    class SubtractionOperation : BasicOperation
    {
        // Implementation of Calculate method for subtraction
        public override double Calculate(double operand1, double operand2)
        {
            return operand1 - operand2; // Returns the difference of operand1 and operand2
        }
    }

    // Class representing multiplication operation, derived from BasicOperation
    class MultiplicationOperation : BasicOperation
    {
        // Implementation of Calculate method for multiplication
        public override double Calculate(double operand1, double operand2)
        {
            return operand1 * operand2; // Returns the product of operand1 and operand2
        }
    }

    // Class representing division operation, derived from BasicOperation
    class DivisionOperation : BasicOperation
    {
        // Implementation of Calculate method for division
        public override double Calculate(double operand1, double operand2)
        {
            // Handles division by zero
            if (operand2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN; // Returns NaN (Not a Number) in case of division by zero
            }
            else
            {
                return operand1 / operand2; // Returns the result of division
            }
        }
    }

    // Class representing a basic calculator
    class BasicCalculator
    {
        // Method to get input from the user with a prompt
        public double GetInput(string prompt)
        {
            double operand; // Variable to store the input value
            while (true)
            {
                try
                {
                    Console.Write(prompt); // Display the prompt to the user
                    operand = Convert.ToDouble(Console.ReadLine()); // Read user input and convert it to double
                    break; // Exit the loop if input is successfully converted
                }
                catch
                {
                    Console.Write("Invalid input. Please enter a valid number: \n"); // Display error message for invalid input
                }
            }
            return operand; // Return the input value
        }

        // Method to perform an arithmetic operation
        public double PerformOperation(double operand1, double operand2, BasicOperation operation)
        {
            return operation.Calculate(operand1, operand2); // Calls the Calculate method of the given operation
        }

        // Method to get the operator choice from the user
        public char GetOperatorChoice()
        {
            char choice; // Variable to store the operator choice
            while (true)
            {
                Console.WriteLine("\nChoose an operator (Enter the symbol)"); // Display operator choices to the user
                Console.WriteLine("1. Add (+)\n2. Subtract (-)\n3. Multiply (*)\n4. Divide (/)");
                Console.Write("\nEnter your choice: "); // Prompt the user to enter their choice

                if (!char.TryParse(Console.ReadLine(), out choice)) // Read user input and attempt to parse it as a character
                {
                    Console.WriteLine("Invalid input."); // Display error message for invalid input
                    continue; // Continue the loop to prompt user again
                }

                // Check if the entered choice is a valid operator
                if (choice == '+' || choice == '-' || choice == '/' || choice == '*' || choice == '=')
                {
                    return choice; // Return the valid operator choice
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid operator!"); // Display error message for invalid operator
                }
            }
        }

        // Method to run the calculator
        public void RunCalculator()
        {
            double operand1; // Variable to store the first operand
            double operand2; // Variable to store the second operand
            double result = 0; // Variable to store the result of the operation
            int counter = 1; // Counter to track if it's the first or second operation
            bool restart = true; // Flag to control if the calculator should restart
            BasicOperation operation = null; // Variable to store the selected operation

            // Main loop to run the calculator
            while (restart)
            {
                operand1 = GetInput($"Enter the first operand: "); // Get the first operand from the user

                // Loop to perform the operation
                while (true)
                {
                    char choice = GetOperatorChoice(); // Get the operator choice from the user

                    if (choice != '=')
                    {
                        if (counter == 2)
                        {
                            operand1 = result; // Set operand1 to the previous result for subsequent operations
                        }

                        operand2 = GetInput($"Enter the second operand: "); // Get the second operand from the user
                    }
                    else
                    {
                        Console.WriteLine($"The Final Answer is: {result}"); // Display the final result
                        break; // Exit the loop if user chooses '='
                    }

                    // Select the operation based on the user choice
                    switch (choice)
                    {
                        case '+':
                            operation = new AdditionOperation(); // Instantiate AdditionOperation
                            counter = 2; // Set counter to 2 for subsequent operations
                            break;
                        case '-':
                            operation = new SubtractionOperation(); // Instantiate SubtractionOperation
                            counter = 2; // Set counter to 2 for subsequent operations
                            break;
                        case '*':
                            operation = new MultiplicationOperation(); // Instantiate MultiplicationOperation
                            counter = 2; // Set counter to 2 for subsequent operations
                            break;
                        case '/':
                            operation = new DivisionOperation(); // Instantiate DivisionOperation
                            counter = 2; // Set counter to 2 for subsequent operations
                            break;
                    }

                    // Perform the operation if operation is not null
                    if (operation != null)
                    {
                        result = PerformOperation(operand1, operand2, operation); // Perform the operation
                    }
                }

                Console.WriteLine("Do you want to perform another calculation? (Y/N)."); // Ask user if they want to perform another calculation
                string playAgain = Console.ReadLine().ToLower(); // Read user input
                if (playAgain != "y")
                {
                    Console.Clear(); // Clear the console
                    break; // Exit the loop if user doesn't want to perform another calculation
                }
                else
                {
                    Console.Clear(); // Clear the console
                    continue; // Continue the loop if user wants to perform another calculation
                }
            }
        }

        // Main method
        static void Main(string[] args)
        {
            BasicCalculator calculator = new BasicCalculator(); // Instantiate BasicCalculator
            calculator.RunCalculator(); // Run the calculator
        }
    }
}
