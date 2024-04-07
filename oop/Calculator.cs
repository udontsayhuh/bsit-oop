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
        public string expression = "";

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
                    try
                    {
                        Console.WriteLine("Try Again? (Y/N): ");
                        string yes_no = Console.ReadLine().ToUpper();
                        if (yes_no == "Y")
                        {
                            this.expression = "";
                            break;
                        }
                        else if (yes_no == "N")
                        {
                            will_try_again = false;
                            Console.Clear();
                            break;
                        }
                        else
                            Console.WriteLine("Y or N only!");
                    }
                    catch
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
                try
                {
                    PrintExpression();
                    Console.Write("Enter number: ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    this.expression = this.expression + ' ' + Convert.ToString(num); //Adds the input to expression
                    Console.Clear();
                    return num;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("INVALID INPUT: " + ex.Message);
                }
            }
        }

        public char InputOperator() //Loop na rin sya
        {
            while (true)
            {
                try
                {
                    PrintExpression();
                    Console.Write("Enter Operator ( + , - , / , * , = ): ");
                    char operation = Convert.ToChar(Console.ReadLine());
                    if (operation == '+' || operation == '-' || operation == '/' || operation == '*' || operation == '=')
                    {
                        this.expression = this.expression + ' ' + operation; //Adds input to expression
                        Console.Clear();
                        return operation;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Operator");
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("INVALID INPUT: " + ex.Message);
                }
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
            foreach (char c in this.expression)
                Console.Write("=");
            Console.WriteLine("\n" + $"{this.expression}");
            foreach (char c in this.expression)
                Console.Write("=");
            Console.Write("=");
            Console.WriteLine("\n\n");
        }

        //Prints Expression with Result
        public virtual void PrintResult(double result)
        {
            Console.Clear();
            Console.WriteLine($"\n{this.expression} {result}\n");
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
            Console.WriteLine($"\nResult in Binary: {this.expression} {Convert.ToString((int)result, 2)}\n");
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
                try
                {
                    Console.WriteLine("Choose Calculator type:");
                    Console.WriteLine("NOTE: CALCULATOR CALCULATES LEFT TO RIGHT, NO PEMDAS!");
                    Console.WriteLine("1 Simple Calculator");
                    Console.WriteLine("2 Binary Calculator");
                    Console.WriteLine("3 EXIT");

                    int choice = Convert.ToInt32(Console.ReadLine());
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
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Enter 1, 2, or 3 only!!!!");
                }
            }
        }
    }
}
//GARCES, JOHN MARK A.
//BSIT 2-1
