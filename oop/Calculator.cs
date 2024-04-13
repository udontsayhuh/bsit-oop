using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class SimpleCalculator
    {
        //Stores the expression
        public string expression = String.Empty;

        //Calculator Logic
        public void CalculatorMain()
        {
            bool will_try_again = true;
            while (will_try_again)
            {
                Console.Clear();

                //Call input functions
                double num_1 = InputNum();
                char operation = InputOperator();

                //Loops kapag hindi '='
                while (operation != '=')
                {
                    double num_2 = InputNum();
                    num_1 = Calculate(num_1, operation, num_2);
                    operation = InputOperator();
                }

                //Prints Result
                PrintResult(num_1);

                //Prompts user to input Y or N, will not terminate unless Y or N
                while (true)
                {
                    Console.Write("Try Again? (Y/N): ");
                    string yes_no = Console.ReadLine()?.ToUpper()?? String.Empty;

                    if (yes_no == "Y")
                    {
                        expression = String.Empty;
                        break;
                    }
                    else if (yes_no == "N")
                    {
                        will_try_again = false;
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Y or N only!");
                    }
                }
            }
        }

        public double InputNum() //Loop na sya, di na terminate
        {
            while (true)
            {
                PrintExpression();
                Console.Write("Enter number: ");
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double num))
                {
                    if (num < 0)
                        expression = $"{expression} ({num})";
                    else
                        expression = $"{expression} {num}"; //Adds the input to expression
                    Console.Clear();
                    return num;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("INVALID INPUT: Please enter a valid number.");
                }
            }
        }

        public char InputOperator() //Loop na rin sya
        {
            while (true)
            {
                PrintExpression();
                Console.Write("Enter Operator (+, -, /, *, =): ");
                string? input = Console.ReadLine();

                if (input?.Length == 1)
                {
                    char operation = input[0];
                    if (operation == '+' || operation == '-' || operation == '/' || operation == '*' || operation == '=')
                    {
                        expression = $"{expression} {operation}"; // Adds input to expression
                        Console.Clear();
                        return operation;
                    }
                }

                Console.Clear();
                Console.WriteLine("Invalid Operator");
            }

        }

        public double Calculate(double num_1, char operation, double num_2) //Calculates result
        {
            switch (operation)
            {
                case '+':
                    return num_1 + num_2;
                case '-':
                    return num_1 - num_2;
                case '/':
                    if (num_2 == 0)
                    {
                        Console.WriteLine("You cannot divide by 0");
                        Console.ReadKey();
                        Environment.Exit(1);
                        return 0;
                    }
                    else
                    {
                        return num_1 / num_2;
                    }
                case '*':
                    return num_1 * num_2;
                default:
                    return 0;
            }
        }

        //Prints Expression with Border
        public void PrintExpression()
        {
            Console.Write("=");
            for (int i = 0; i < expression.Length; i++)
                Console.Write("=");
            Console.WriteLine("\n" + $"{expression}");
            for (int i = 0; i < expression.Length; i++)
                Console.Write("=");
            Console.Write("=");
            Console.WriteLine("\n\n");
        }

        //Prints Expression with Result
        public virtual void PrintResult(double result)
        {
            Console.Clear();
            Console.WriteLine($"\n{expression} {result}\n");
        }
    }

    //Inheritance
    //Inherited Methods from SimpleCalculator
    class BinaryCalculator : SimpleCalculator
    {
        //Polymorphism
        //Overrides Print Result to print binary instead of decimal
        public override void PrintResult(double result)
        {
            Console.Clear();
            if (result < 0)
                Console.WriteLine($"\nResult in Binary: {expression} -{Convert.ToString((int)Math.Abs(result), 2)}\n");
            else
                Console.WriteLine($"\nResult in Binary: {expression} {Convert.ToString((int)result, 2)}\n");
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            //Choose Calculator Type
            bool exit_program = false;
            while (!exit_program)
            {
                Console.WriteLine("Choose Calculator type:");
                Console.WriteLine("NOTE: CALCULATOR CALCULATES LEFT TO RIGHT, NO PEMDAS!");
                Console.WriteLine("1 Simple Calculator");
                Console.WriteLine("2 Binary Calculator");
                Console.WriteLine("3 EXIT");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            SimpleCalculator simpleCal = new SimpleCalculator();
                            simpleCal.CalculatorMain();
                            break;
                        case 2:
                            BinaryCalculator biCal = new BinaryCalculator();
                            biCal.CalculatorMain();
                            break;
                        case 3:
                            exit_program = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Enter 1, 2, or 3 only!!!!");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Enter a valid integer!");
                }
            }

        }
    }
}
//GARCES, JOHN MARK A.
//BSIT 2-1
