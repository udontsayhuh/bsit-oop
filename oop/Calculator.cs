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
    public class Addition : Arithmetic
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

    public class Multiplication : Arithmetic
    {

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
        static bool operatorIsValid(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        static double calculate(double operand1, char operation, double operand2)
        {
            switch (operation)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        return operand1;
                    }
                    return operand1 / operand2;
                default:
                    throw new ArgumentException("Invalid operator.");
            }
        }

        // Main
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


            start:
            double answer = 0;
            bool isFirst = true;
            char operation = '+';


            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input == "=")
                {
                    Console.WriteLine("The answer is: " + answer);
                    break;
                }

                if (isFirst)
                {
                    if (!double.TryParse(input, out answer))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }
                    isFirst = false;
                    continue;
                }

                if (!char.TryParse(input, out operation) || !operatorIsValid(operation))
                {
                    Console.WriteLine("Invalid operator!!");
                    continue;
                }

                Console.Write("> ");
                if (!double.TryParse(Console.ReadLine(), out double operand))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                answer = calculate(answer, operation, operand);


            }

            askAgain:
            Console.WriteLine("Do you want another calculation? (Y/N): ");
            string continueCalculation = Console.ReadLine();

            if (continueCalculation.ToUpper() == "Y")
            {
                Console.WriteLine("=====================================");
                goto start;
            }
            else if (continueCalculation.ToUpper() == "N")
            {

                Console.WriteLine("Goodbye!");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter Y or N.");
                goto askAgain;
            }



        }
    }

}
