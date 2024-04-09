using System;

// Abstract class for different arithmetic operations
abstract class Operation
{
    public abstract double Calculate(double num1, double num2); // Abstract method for calculation
}

// Concrete class for addition operation
class Addition : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Concrete class for subtraction operation
class Subtraction : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}

// Concrete class for multiplication operation
class Multiplication : Operation
{
    public override double Calculate(double num1, double num2)
    {
        return num1 * num2;
    }
}

// Concrete class for division operation
class Division : Operation
{
    public override double Calculate(double num1, double num2)
    {
        if (num2 != 0)
            return num1 / num2;
        else
            throw new DivideByZeroException("WARNING: Cannot divide by zero!"); // Throw exception for division by zero
    }
}

// Calculator class encapsulating the calculator logic
class Calculator
{
    public double PerformOperation(Operation operation, double num1, double num2)
    {
        return operation.Calculate(num1, num2); // Perform calculation based on selected operation
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator(); // Instantiate Calculator object

        bool keepCalculating = true;

        while (keepCalculating)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================");
            Console.WriteLine("||        CALCULATOR        ||");
            Console.WriteLine("==============================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    ");

            Console.WriteLine("———————————————————————————————————");
            Console.WriteLine("|          > OPERATORS <          |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|   >> Addition (+)               |");
            Console.WriteLine("|   >> Subtraction (-)            |");
            Console.WriteLine("|   >> Multiplication (*)         |");
            Console.WriteLine("|   >> Division (/)               |");
            Console.WriteLine("|   >> Equals to get Result (=)   |");
            Console.WriteLine("———————————————————————————————————");
            Console.WriteLine("    ");

            double result = 0; // Store the result of each operation

            char currentOperator = ' '; // Store the current operator

            while (true)
            {
                double num;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("> Enter a number: ");
                string? input = Console.ReadLine();

                if (double.TryParse(input, out num)) // Validate and parse user input for the number
                {
                    switch (currentOperator)
                    {
                        case '+':
                            result += num;
                            break;
                        case '-':
                            result -= num;
                            break;
                        case '*':
                            result *= num;
                            break;
                        case '/':
                            if (num != 0)
                                result /= num;
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("= WARNING: Cannot divide by zero! Please enter a valid divisor...");
                                continue; // Continue to next iteration to prompt for operator again
                            }
                            break;
                        default:
                            result = num;
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Invalid input! Please enter a valid number...");
                    continue; // Continue to next iteration to prompt for number again
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("> Enter an operator: ");
                string? operatorInput = Console.ReadLine();

                // Validate the operator input
                if (operatorInput == "=")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Final result: " + result); // Display the final result
                    break; // Break out of the loop to perform calculation
                }
                else if (operatorInput.Length == 1 && "+-*/".Contains(operatorInput))
                {
                    currentOperator = operatorInput[0];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Invalid operator! Please enter a valid operator");
                }
            }

            bool validChoice = false;
            while (!validChoice)
            {
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(">> Do you want to Calculate again? (y/n)");
                Console.Write(">> ");
                string contchoice = Console.ReadLine().ToLower(); // Get user's choice to continue or exit

                if (contchoice == "n" || contchoice == "no")
                {
                    keepCalculating = false; // Exit the loop if user chooses 'n' or 'no'
                    validChoice = true;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" ");
                    Console.WriteLine(">> Calculator closed. <<");
                }
                else if (contchoice == "y" || contchoice == "yes")
                {
                    validChoice = true; // Continue the loop if user chooses 'y' or 'yes'
                    Console.Clear(); // Clear the console screen
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Invalid Choice! Please type 'y' or 'n'... =");
                }
            }
        }
    }
}
