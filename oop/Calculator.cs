using System;
using System.Linq.Expressions;

namespace Calculator
{   

    // Parent Class
    abstract public class Arithmetic
    {
        public char Symbol;
        public string Name;
        public Arithmetic(char symbol, string name)
        {
            this.Symbol = symbol;
            this.Name = name;
        }

        public abstract double solve(double num1, double num2);
    }

    // Child Classes
    public class Addition: Arithmetic
    {

        public Addition(char symbol, string name) : base(symbol, name)
        {

        }
        public override double solve(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    public class Subtraction : Arithmetic
    {
        public Subtraction(char symbol, string name) : base(symbol, name)
        {

        }

        public override double solve(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    public class Multiplication : Arithmetic { 
        
        public Multiplication(char symbol, string name) : base(symbol, name)
        {

        }

        public override double solve(double num1, double num2)
        {
            return num1 * num2;
        }

    }

    public class Division : Arithmetic
    {
        public Division(char symbol, string name) : base(symbol, name)
        {

        }

        public override double solve(double num1, double num2)
        {
            return num1 / num2;
        }
    }


    // Main Method
    public class Calculator
    {
        public static void Main(string[] args)
        {

            // Declaration
           double num1, num2;

            // Instances
            Addition add = new Addition('+', "Addition");
            Subtraction subtract = new Subtraction('-', "Subtraction");
            Multiplication multiply = new Multiplication('*', "Multiplication");
            Division divide = new Division('/', "Division");

            // Put all the objects in an array
            Arithmetic[] operations = { add, subtract, multiply, divide };


            // Prompt for 2 numbers to calculate
            start:
            Console.WriteLine("==============================================");
            try
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter numerical Values only!");
                Console.WriteLine("Program ends.");
                return;
            }

            bool operationIsValid = false;
            Arithmetic operationToUse = null;
            while (!operationIsValid)
            {
                // Prompt for operation to use
                Console.Write("Enter an operator to use (+,-,*,/): ");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                // Check if the symbol is in the array of operations
                foreach (Arithmetic operation in operations)
                {
                    if (input == operation.Symbol)
                    {
                        operationIsValid = true;
                        operationToUse = operation;
                        
                    }
                }


            }

            // Solve the 2 numbers depending on the opeartion chosen
            Console.WriteLine($"The artihmetic operation used is {operationToUse.Symbol}");
            Console.WriteLine($"{num1} {operationToUse.Symbol} {num2} = {operationToUse.solve(num1, num2)}");
            Console.WriteLine("==============================================");
            // Ask the user for another calculation
            Console.Write("Do you want to do another calculation? (Press Y for another calculation, any key to end): ");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.ToUpper(choice) == 'Y')
            {
                goto start;
            } else
            {
                Console.WriteLine("Program ends.");
            }

            

        }
    }
   
}
