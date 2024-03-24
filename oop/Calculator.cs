using System;

// Calculator class
abstract class Operation
{
    // Abstract method to perform the operation
    public abstract double OpCompute(double num1, double num2);
}

// Derived class for addition operation
class Addition : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Derived class for subtraction operation
class Subtraction : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        return num1 - num2;
    }
}

// Derived class for multiplication operation
class Multiplication : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        return num1 * num2;
    }
}

// Derived class for division operation
class Division : Operation
{
    public override double OpCompute(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return double.NaN;
        }
        else
        {
            return num1 / num2;
        }
    }
}

class Calculator
{
    public double Input(string prompt)
    {
        double num;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out num))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }
        return num;
    }

    // Method to perform the selected operation
    public double Compute(double num1, double num2, Operation operation)
    {
        return operation.OpCompute(num1, num2);
    }

    public char GetOperatorChoice()
    {
        // Get user choice of operation
        char choice;

        // Keep prompting the user until a valid input is provided
        while (true)
        {
            // Display menu of operations
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("[+] ADDITION");
            Console.WriteLine("[-] SUBTRACTION");
            Console.WriteLine("[*] MULTIPLICATION");
            Console.WriteLine("[/] DIVISION");
            Console.WriteLine("[=] EQUALS (DISPLAY)");
            Console.Write("\nEnter your choice: ");

            // Try to parse the input to a char
            if (!char.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input.");
                continue; // Restart the loop
            }

            // Check if the input is one of the specified operators
            if (choice == '+' || choice == '-' || choice == '/' || choice == '*' || choice == '=')
            {
                return choice; // Exit the loop if a valid input is provided
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter one of the specified operators: +, -, /, *, =.");
            }
        }
    }

    public void RunCalculator()
    {
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("                    WELCOME TO C# CALCULATOR\n");
        Console.WriteLine("--------------------------------------------------------------");

        double num1;
        double num2;
        double result = 0;
        int counter = 1;
        bool restart = true;
        Operation operation = null;

        while (restart)
        {

            num1 = Input($"Enter the first number: ");
            counter = 1;
            while (true)
            {

                char choice = GetOperatorChoice();

                if (choice != '=')
                {
                    if (counter == 2)
                    {
                        num1 = result;
                    }

                    num2 = Input($"Enter the second number: ");
                }
                else
                {
                    Console.WriteLine($"The Final Answer is: {result}");
                    break;
                }

                switch (choice)
                {
                    case '+':
                        operation = new Addition();
                        counter = 2;
                        break;
                    case '-':
                        operation = new Subtraction();
                        counter = 2;
                        break;
                    case '*':
                        operation = new Multiplication();
                        counter = 2;
                        break;
                    case '/':
                        operation = new Division();
                        counter = 2;
                        break;
                }

                if (operation != null)
                {
                    result = Compute(num1, num2, operation);
                    Console.WriteLine($"Result: {num1} {choice} {num2} = {result}");
                }
            }
            Console.WriteLine("Do you want to do another calculation? (Y/N).");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain != "y")
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("                    THANK YOU FOR USING C# CALCULATOR\n                            BY: CARL BERGADO");
                Console.WriteLine("--------------------------------------------------------------");
                break;
            }
            else
            {
                Console.Clear();
                continue;
            }
        }
    }

    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.RunCalculator();
    }
}
