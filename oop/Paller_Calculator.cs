using System;
using System.Runtime.ExceptionServices;

namespace Calculator_Program
{
    abstract class Calculator_Program
    {
        public int val1;
        public int val2;
        public int output;

        public Calculator_Program(int value1, int value2)
        {
            val1 = value1;
            val2 = value2;
        }

        public abstract void compute();
    }

    class Addition : Calculator_Program
    {
        public Addition (int value1, int value2) : base (value1, value2) { }

        public override void compute()
        {
            output = val1 + val2;
        }
    }
    class Subtraction : Calculator_Program
    {
        public Subtraction(int value1, int value2) : base(value1, value2) { }

        public override void compute()
        {
            output = val1 - val2;
        }
    }
    class Multiplication : Calculator_Program
    {
        public Multiplication(int value1, int value2) : base(value1, value2) { }

        public override void compute()
        {
            output = val1 * val2;
        }
    }
    class Division : Calculator_Program
    {
        public Division (int value1, int value2) : base(value1, value2) { }

        public override void compute()
        {
            output = val1 / val2;
        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("WELCOME TO MY CALCULATOR PROGRAM");
            Console.WriteLine("-------------------------------------");

            int val1, val2;

            try
            {
                while (true)
                {
                    Console.Write("\n\nENTER FIRST OPERAND: ");
                    val1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n\nCHOOSE YOUR OPERATOR");
                    Console.WriteLine("\nEnter + for Addition");
                    Console.WriteLine("\nEnter - for Subtraction");
                    Console.WriteLine("\nEnter * for Multiplication");
                    Console.WriteLine("\nEnter / for Division");
                    Console.Write("\n\nOperator to be used: ");
                    string op = Console.ReadLine();
                    if (op != "+" && op != "-" && op != "*" && op != "/") // to verify if the operator entered is valid
                    {
                        throw new InvalidOperationException();
                    }

                    Console.Write("\n\nENTER SECOND OPERAND: ");
                    val2 = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case "+":
                            Addition plus = new Addition(val1, val2);
                            plus.compute();
                            Console.WriteLine($"Addition Result: {val1} + {val2} = {plus.output}");
                            break;
                        case "-":
                            Subtraction minus = new Subtraction(val1, val2);
                            minus.compute();
                            Console.WriteLine($"Subtraction Result: {val1} - {val2} = {minus.output}");
                            break;
                        case "*":
                            Multiplication mul = new Multiplication(val1, val2);
                            mul.compute();
                            Console.WriteLine($"Addition Result: {val1} * {val2} = {mul.output}");
                            break;
                        case "/":
                            Division divide = new Division(val1, val2);
                            divide.compute();
                            Console.WriteLine($"Addition Result: {val1} / {val2} = {divide.output}");
                            break;
                        default:
                            Console.WriteLine("\n Please enter a valid operator (+, -, *, /)");
                            break;
                    }
                    while (true)
                    {
                        Console.WriteLine("Would you still like to continue? (Y = yes, N = no)");
                        char answer = char.ToUpper(Console.ReadKey().KeyChar);
                        if (answer == 'Y')
                        {
                            break;
                        }
                        else if (answer == 'N')
                        {
                            Console.WriteLine("\n\nTerminating Program");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Enter valid key. (Y/N)");
                            continue;

                        }
                    }
                }
            }
            catch (FormatException) 
            {
                Console.WriteLine("\nPlease try again. Integer only.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("\nInvalid operator. + - & / only.");
            }
            finally
            {
                Console.WriteLine("Terminating Program");
            }
        }
    }


}
