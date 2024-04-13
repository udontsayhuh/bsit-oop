using System;

// ABSTRACTION
abstract class Operation
{
    public abstract double Execute(double num1, double num2);
}

// INHERITANCE AND POLYMORPHISM
//all operations inherit from the Operation class and overrides the Execute() method
class Addition : Operation
{
    public override double Execute(double num1, double num2) => num1 + num2;
}

class Subtraction : Operation
{
    public override double Execute(double num1, double num2) => num1 - num2;
}

class Multiplication : Operation
{
    public override double Execute(double num1, double num2) => num1 * num2;
}

class Division : Operation
{
    public override double Execute(double num1, double num2)
    {// throws an exception if division by zero is encountered
        if (num2 == 0) throw new DivideByZeroException("\t\t>>Error! Cannot divide by zero.");
        return num1 / num2;
    }
}

class Calculator
{
    // ENCAPSULATION
    // private GetOperation hides the logic of creating Operation objects from users
    private Operation GetOperation(string operationSymbol)
    {
        switch (operationSymbol)
        {
            case "+": return new Addition();
            case "-": return new Subtraction();
            case "*": return new Multiplication();
            case "/": return new Division();
            default: throw new ArgumentException("\t\t>>Error! Invalid operator input.");
        }
    }
    // main loop. handles the functionalities and provides UI

    private double Calculation()
    {
        double result = 0;
        double currentNumber = GetValidNumber("\tEnter number: ");
        result = currentNumber;

        while (true) // loop for ongoing calculation within a session
        {
            string operationSymbol = GetValidOperationOrEqual();
            if (operationSymbol == "=")
            {
                return result;
            }
            double nextNumber = GetValidNumber("\tEnter number: ");
            Operation operation = GetOperation(operationSymbol);
            result = operation.Execute(result, nextNumber);
        }
    }

    public void Start()
    {
        Console.WriteLine("\t\t\t>>>Simple Calculator<<<\n\nEnter operands with an operator in between each. Press '=' to get the result.");
        Console.WriteLine("-----------------------------------------------------------------------------\n");

        bool continueSession = true;
        while (continueSession) // loop for new sessions
        {
            try
            {
                double result = Calculation();
                Console.WriteLine($"\n\n\t\t\tResult: {result}");
                Console.WriteLine("\n--------------------------------------------\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            continueSession = AskToContinue(); // start new session
        }
        Console.WriteLine("\n-----------------------------------------------------------------------------");
        Console.WriteLine("\n\t\t\tPress any key to exit the program...");
        Console.ReadKey();
    }
    // ENCAPSULATION
    // ensures the user inputs a valid number
    private double GetValidNumber(string prompt)
    {
        double number;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("\t\t>>Error! Please enter a valid numerical value.");
            Console.Write(prompt);
        }
        return number;
    }
    // ensures the user inputs a valid operation
    private string GetValidOperationOrEqual()
    {
        Console.Write("\tEnter operator: ");
        while (true) // loop until valid input is received
        {
            string operation = Console.ReadLine();
            if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "=")
            {
                return operation;
            }
            else
            {
                Console.WriteLine("\t\t>>Error! Invalid operation. Please enter +, -, *, /, or '='.");
                Console.Write("\tEnter operator: ");
            }
        }
    }
    // handles the logic of asking the user to start new session
    private bool AskToContinue()
    {
        Console.Write("Do you want to start a new session? (y/n): ");
        while (true) 
        {
            var response = Console.ReadLine().ToLower();
            if (response == "y")
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\n\n\t\t\t>>>New Calculator Session!<<<\n\nEnter operands with an operator in between each. Press '=' to get the result.");
                Console.WriteLine("-----------------------------------------------------------------------------\n");
                return true;
            }
            else if (response == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine(">>Error! Invalid input. Please enter 'y' or 'n'.");
                Console.Write("Do you want to start a new session? (y/n): ");
            }
        }
    }
}

class Program
{// main entry point
    static void Main(string[] args)
    {//creating Calculator object -- starting the calculator program
        var calculator = new Calculator();
        calculator.Start();
    }
}

// i created a new method in class Calculator, Calculation(), to handle the actual calculation logic of the program instead of piling it up together with other functions on Start(), i believe this avoids spaghetti code 
// i also removed the redundancy of using response.ToLower, i already used the conversion method beforehand and didn't notice it. 
