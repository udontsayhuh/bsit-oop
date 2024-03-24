using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //Super class
    abstract class Calculator
    {
        //Attributes
        public int FirstVal;
        public int SecondVal;
        public int Result;

        //Constructor
        public Calculator(int firstVal, int secondVal)
        {
            FirstVal = firstVal;
            SecondVal = secondVal;
        }

        //Method
        public abstract void Compute();
    }

    //Derived Class
    class Addition : Calculator
    {
        public Addition(int firstVal, int secondVal) : base(firstVal, secondVal) { }

        public override void Compute()
        {
            Result = FirstVal + SecondVal; //Addition method
        }
    }

    //Derived Class
    class Subtraction : Calculator
    {
        public Subtraction(int firstVal, int secondVal) : base(firstVal, secondVal) { }

        public override void Compute()
        {
            Result = FirstVal - SecondVal; //Subtraction method
        }
    }

    // Derived Class
    class Multiplication : Calculator
    {
        public Multiplication(int firstVal, int secondVal) : base(firstVal, secondVal) { }

        public override void Compute()
        {
            Result = FirstVal * SecondVal; //Multiplication method
        }
    }

    //Derived Class
    class Division : Calculator
    {
        public Division(int firstVal, int secondVal) : base(firstVal, secondVal) { }

        public override void Compute()
        {
            Result = FirstVal / SecondVal; //Division method
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================");
            Console.WriteLine("                       CALCULATOR");
            Console.WriteLine("===========================================================");

            int firstVal, secondVal;
            try
            {
                while (true)
                {
                    Console.Write("\nEnter the first value: ");
                    firstVal = int.Parse(Console.ReadLine()); //Reads the input and check if the data type entered is right, otherwise, throw it to the exception

                    Console.WriteLine("\nOPERATIONS");
                    Console.WriteLine("[1] Addition (+)");
                    Console.WriteLine("[2] Subtraction (-)");
                    Console.WriteLine("[3] Multiplication (*)");
                    Console.WriteLine("[4] Division (/)");

                    Console.Write("\nEnter the operator in symbols: ");
                    string math = Console.ReadLine(); 
                    if (math != "+" && math != "-" && math != "*" && math != "/") // to verify if the operator entered is valid
                    {
                        throw new InvalidOperationException();
                    }

                    Console.Write("\nEnter the second value: ");
                    secondVal = int.Parse(Console.ReadLine());

                    switch (math) // process depending on the user's choice
                    {
                        case "+":
                            Addition add = new Addition(firstVal, secondVal);
                            add.Compute();
                            Console.WriteLine($"\n{firstVal} + {secondVal} = {add.Result}");
                            break;
                        case "-":
                            Subtraction subtract = new Subtraction(firstVal, secondVal);
                            subtract.Compute();
                            Console.WriteLine($"\n{firstVal} - {secondVal} = {subtract.Result}");
                            break;
                        case "*":
                            Multiplication multiply = new Multiplication(firstVal, secondVal);
                            multiply.Compute();
                            Console.WriteLine($"\n{firstVal} * {secondVal} = {multiply.Result}");
                            break;
                        case "/":
                            if (firstVal == 0 || secondVal == 0)
                            {
                                Console.WriteLine("\nValues cannot be divided.");
                                break;
                            }
                            Division divide = new Division(firstVal, secondVal);
                            divide.Compute();
                            Console.WriteLine($"\n{firstVal} / {secondVal} = {divide.Result}");
                            break;
                        default:
                            Console.WriteLine("\nInvalid operator.");
                            break;
                    }

                    while (true)
                    {
                    Console.WriteLine("\nDo you want to perform another calculation? (Y/N)"); // ask the user if they want to continue
                    char choice = char.ToUpper(Console.ReadKey().KeyChar);
                    if (choice == 'N')
                    {
                        Console.WriteLine("\nThank you for using the Calculator. Adios mi amigo, mi amiga! mwamwa <3");
                        return;
                    }
                    else if (choice == 'Y')
                        {
                            break;
                        }
                    else
                        {
                            Console.WriteLine("\nEnter a valid key.");
                            continue;
                        }
                    }

                }
            }
            catch (FormatException) //If the user input is not compatible with the expected data type
            {
                Console.WriteLine("\nInvalid input. The calculator only accepts numerical values.");
            }
            catch (InvalidOperationException) //If the user input is not compatible with the expected operation
            {
                Console.WriteLine("\nInvalid symbol for operator.");
            }
            finally //General error messaage
            {
                Console.WriteLine("\nEnd of program!");
            }
        }
    }
}
