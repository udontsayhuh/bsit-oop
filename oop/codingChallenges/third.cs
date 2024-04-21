using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //Parent class
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
            while (true)
            {
                Console.WriteLine("\nBASIC ARITHMETIC FUNCTIONS");
                Console.WriteLine("[1] Addition (+)");
                Console.WriteLine("[2] Subtraction (-)");
                Console.WriteLine("[3] Multiplication (*)");
                Console.WriteLine("[4] Division (/)");

                // Enter desired arithmetic function
                Console.Write("\nChoose desired arithmetic function (1-4 only): ");
                int arithmeticFunction = Convert.ToInt32(Console.ReadLine());

                // Enter two integer values
                Console.Write("Enter first value: ");
                int firstVal = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second value: ");
                int secondVal = Convert.ToInt32(Console.ReadLine());

                // Process depending on the user's desired arithmetic function
                switch (arithmeticFunction)
                {
                    case 1:
                        Addition add = new Addition(firstVal, secondVal);
                        add.Compute();
                        Console.WriteLine($"\n{firstVal} + {secondVal} = {add.Result}");
                        break;
                    case 2:
                        Subtraction subtract = new Subtraction(firstVal, secondVal);
                        subtract.Compute();
                        Console.WriteLine($"\n{firstVal} - {secondVal} = {subtract.Result}");
                        break;
                    case 3:
                        Multiplication multiply = new Multiplication(firstVal, secondVal);
                        multiply.Compute();
                        Console.WriteLine($"\n{firstVal} * {secondVal} = {multiply.Result}");
                        break;
                    case 4:
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
                    // Ask the user if they want to do another calculation
                    Console.Write("\nDo you want to perform another calculation (Y/N) ? ");
                    char choice = char.ToUpper(Console.ReadKey().KeyChar);
                    if (choice != 'Y')
                    {
                        Console.WriteLine("\nEnd of program!");
                        return;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
