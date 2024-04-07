using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;

namespace Calculator
{
    using System;

    namespace Calculator
    {
        public class Calculator
        {   //declare variables
            public double num1 = 0;
            public double num2 = 0;
            public double ans = 0;
            public string operators = "";

            public void GetValue1() //encapsulation
            {
                try
                {
                    Console.Write("Enter 1st number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());//value for num1
                }
                catch //invalid value
                {
                    Console.WriteLine("Error, numbers only"); //display error
                    Console.WriteLine("Terminating Program...");
                    Environment.Exit(1); //terminate the program
                }
            }

            public void GetValue2() //encapsulation
            {
                try
                {
                    Console.Write("Enter 2nd number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());//value for num2
                }
                catch //invalid value
                {
                    Console.WriteLine("Error, numbers only"); //display error
                    Console.WriteLine("Terminating Program...");
                    Environment.Exit(1); //terminate the program
                }
            }

            public void GetOpt() //encapsulation
            {
                Console.Write("Select Operation [+, -, *, /]:");
                operators = Convert.ToString(Console.ReadLine());

                while (operators != "+" && operators != "-" && operators != "*" && operators != "/") // if input for operator is not in the choices, terminate the program
                {
                    Console.WriteLine("Invalid Operation...");
                    Console.Write("Select Operation [+, -, *, /]:");
                    operators = Convert.ToString(Console.ReadLine());
                }
            }
        }

        class Multiplication : Calculator //inheritance
        {
            
            public void Multiply(double num1, double num2) //multiply 2 numbers
            {
                ans = num1 * num2;
                Console.WriteLine($"{num1} x {num2} = {ans}");
            }
        }

        class Addition : Calculator //inheritance
        {
            public void Add(double num1, double num2) //add 2 numbers
            {
                ans = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {ans}");
            }
        }

        class Subtraction : Calculator //inheritance
        {
            public void Subtract(double num1, double num2) //subtract 2 numbers
            {
                ans = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {ans}");
            }
        }

        class Division : Calculator  //inheritance
        {
            public void Divide(double num1, double num2) //divide 2 numbers
            {
                if (num2 == 0) 
                {
                    Console.WriteLine("Any number divided by 0 is undefined.");
                }
                else
                {
                    ans = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {ans}");
                }
            }
        }

        class Program
        {
            static void Main(String[] args)
            {
                string repeat;
                bool Continue;

                do
                {
                    Console.Clear();
                    Calculator calculator = new Calculator();
                    Console.WriteLine("=========================");//spacing
                    Console.WriteLine("        CALCULATOR       ");//spacing
                    Console.WriteLine("=========================");//spacing
                    calculator.GetValue1(); //get the value of 1st number
                    calculator.GetOpt(); // get the operator for calculation
                    calculator.GetValue2(); //get the value of 1st number


                    switch (calculator.operators) //calculate with the chosen operator
                    {
                        case "*":
                            Multiplication multiplication = new Multiplication();
                            multiplication.Multiply(calculator.num1, calculator.num2);
                            break;
                        case "+":
                            Addition addition = new Addition();
                            addition.Add(calculator.num1, calculator.num2);
                            break;
                        case "-":
                            Subtraction subtraction = new Subtraction();
                            subtraction.Subtract(calculator.num1, calculator.num2);
                            break;
                        case "/":
                            Division division = new Division();
                            division.Divide(calculator.num1, calculator.num2);
                            break;
                        default:
                            Console.WriteLine("Invalid Operator");
                            break;
                    }
                    do
                    {
                        Console.Write("\nDo you want to continue [Y/N]?"); //ask the user wether to continue or not
                        repeat = Convert.ToString(Console.ReadLine());
                        repeat = repeat.ToUpper();
  
                        if (repeat != "Y" && repeat != "N") //if input is not Y or N, display error message
                        {
                            Console.WriteLine("Invalid input");
                        }
                        Continue = repeat == "Y";
                    } while (repeat != "Y" && repeat != "N");//if input is not Y or N, ask again

                } while (Continue); //repeat from thhe start if chosen is Y (yes)
                Console.WriteLine("\nTerminating Program"); //closing the program if chosen is N (No)
            }
        }
    }

}