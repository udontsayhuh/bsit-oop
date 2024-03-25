using System;

// ABSTRACTION
abstract class Operation
{
    public abstract double Execute(double num1, double num2);
}

// INHERITANCE AND POLYMORPHISM 
// all operations inherit from the Operation class and overrides the Execute() method
class Addition : Operation
{
    public override double Execute(double num1, double num2)
    { return num1 + num2;}
}

class Subtraction : Operation
{
    public override double Execute(double num1, double num2)
    { return num1 - num2; }
}

class Multiplication : Operation
{
    public override double Execute(double num1, double num2)
    { return num1 * num2; }
}

class Division : Operation
{
    public override double Execute(double num1, double num2)
    {// throwing an exception if division by zero is encountered 
        if (num2 == 0)
        {
            throw new DivideByZeroException("\n>>Error! Cannot divide by zero.");
        }
        return num1 / num2;
    }
}

class Calculator
{
    // ENCAPSULATION
    // private GetOperation hides the logic of creating Operation objects from users
    private Operation GetOperation(string operatorSymbol)
        {
            switch (operatorSymbol)
            {
                case "+": return new Addition();
                case "-": return new Subtraction();
                case "*": return new Multiplication();
                case "/": return new Division();
                default: throw new ArgumentException("\n>>Error! Invalid operator input.");
        }
        }
    // encapsulates the functionalities and provides UI
    public void Start()
    {
        bool continueSession = true;
        while (continueSession)
        {
            double num1, num2;
            string operationSymbol;

            Console.WriteLine("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("\n>>Error! Please enter a numerical value.");
                Console.WriteLine("--------------------------------------------------\n");
                Console.WriteLine("\t\tExiting the program...");
                Console.ReadKey();
                return;
            }


            try // handles and catches thrown exceptions
            {
                Console.WriteLine("Enter the operator (+ - * /): ");
                operationSymbol = Console.ReadLine();

                Operation operation = GetOperation(operationSymbol);

                Console.WriteLine("Enter the second number: ");
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("\n>>Error! Please enter a numerical value.");
                    Console.WriteLine("--------------------------------------------------\n");
                    Console.WriteLine("\t\tExiting the program...");
                    Console.ReadKey();
                    return;
                }
                //RESULT
                double result = operation.Execute(num1, num2);
                Console.WriteLine($"\n\n\t\tResult: {num1} {operationSymbol} {num2} = {result}");
                Console.WriteLine("--------------------------------------------------\n");
            }
            catch (ArgumentException ex){
                //handles thrown invalid operator input
                Console.WriteLine(ex.Message);
                Console.WriteLine("--------------------------------------------------\n");
                Console.WriteLine("\t\tExiting the program....");
                Console.ReadKey();
                return;
            }

            catch (DivideByZeroException ex)
            { //handles thrwon division by zero
                Console.WriteLine(ex.Message);
                Console.WriteLine("--------------------------------------------------\n");
                Console.WriteLine("\t\tExiting the program...");
                Console.ReadKey();
                return;
            }

            // asks for new session
            continueSession = AskToContinue();
            Console.WriteLine("--------------------------------------------------\n");
        }
        Console.WriteLine("\tPress any key to exit the program...");
        Console.ReadKey();
    }
    // ENCAPSILATION
    // handles the logic of asking the user to start new session
    private bool AskToContinue()
    {
        while (true) // loop until valid input is received
        {
            Console.WriteLine("Do you want to start a new calculator session? (y/n):");
            var response = Console.ReadLine();
            if (response.ToLower() == "y")
            {
                return true;
            }
            else if (response.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("\n>>Error! Invalid input. Please enter 'y' or 'n'.\n");
            }
        }
    }
}

class Program
{// main entry point
    static void Main(string[] args)
    {//creating Calculator object -- starting the calculator application
        var calculator = new Calculator();
        calculator.Start();
    }
}
