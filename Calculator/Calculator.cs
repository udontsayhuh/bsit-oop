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
            public double num = 0;
            public double num2 = 0;
            public double ans = 0;
            public string operators = "";

            public double GetValue() //encapsulation
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Enter a number: ");
                        num = Convert.ToDouble(Console.ReadLine());//value for num1
                        break;
                    }
                    catch //invalid value
                    {
                        Console.WriteLine("Enter numbers only"); //display error
                    }
                }
                return num;
            }


            public void GetOpt() //encapsulation
            {
                Console.Write("Select Operation [+, -, *, /, =]:");
                operators = Convert.ToString(Console.ReadLine());

                while (operators != "+" && operators != "-" && operators != "*" && operators != "/" && operators != "=") // if input for operator is not in the choices, terminate the program
                {
                    Console.WriteLine("Invalid Operation...");
                    Console.Write("Select Operation [+, -, *, /, =]:");
                    operators = Convert.ToString(Console.ReadLine());
                }
            }
        }

        class Multiplication : Calculator //inheritance
        {
            
            public double Multiply(double num1, double num2) //multiply 2 numbers
            {
                return num1 * num2;
            }
        }

        class Addition : Calculator //inheritance
        {
            public double Add(double num1, double num2) //add 2 numbers
            {
                return num1 + num2;
            }
        }

        class Subtraction : Calculator //inheritance
        {
            public double Subtract(double num1, double num2) //subtract 2 numbers
            {
                return num1 - num2;
            }
        }

        class Division : Calculator  //inheritance
        {
            public double Divide(double num1, double num2) //divide 2 numbers
            {
                if (num2 == 0) 
                {
                    Console.WriteLine("Any number divided by 0 is undefined.");
                    return num1;
                }
                else
                {
                    return num1 / num2;
                }
            }
        }

        class Program
        {
            static void Main(String[] args)
            {
                string repeat;
                double Num1;
                bool Continue;
                bool notEqual = true;
                do
                {
                    Console.Clear();
                    notEqual = true;
                    Calculator calculator = new Calculator();
                    Console.WriteLine("=========================");//spacing
                    Console.WriteLine("        CALCULATOR       ");//spacing
                    Console.WriteLine("=========================");//spacing
                    Num1 = calculator.GetValue(); //get the value of 1st number
                    do
                    {
                        calculator.GetOpt(); // get the operator for calculation
                        if (calculator.operators != "=")
                            calculator.GetValue(); //get the value of 1st number


                        switch (calculator.operators) //calculate with the chosen operator
                        {
                            case "*":
                                Multiplication multiplication = new Multiplication();
                                Num1 = Convert.ToDouble(multiplication.Multiply(Num1, calculator.num));
                                break;
                            case "+":
                                Addition addition = new Addition();
                                Num1 = Convert.ToDouble(addition.Add(Num1, calculator.num));
                                break;
                            case "-":
                                Subtraction subtraction = new Subtraction();
                                Num1 = Convert.ToDouble(subtraction.Subtract(Num1, calculator.num));
                                break;
                            case "/":
                                Division division = new Division();
                                Num1 = Convert.ToDouble(division.Divide(Num1, calculator.num));
                                break;
                            case "=":
                                notEqual = false;
                                break;
                            default:
                                Console.WriteLine("Invalid Operator");
                                break;
                        }
                    } while (notEqual);
                    Console.WriteLine($"answer:{Num1}");


                    do //repeat the process??
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