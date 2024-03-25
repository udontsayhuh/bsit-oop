﻿using System;
using System.Net.Http.Headers;

namespace Calculator
{
    //Encapsulation attributes
    class Calculator
    {
        private double firstvalue;
        private double secondvalue;
        private char operand;

        //Accessor of encapsulated attributes
        public double Firstvalue
        {
            get { return firstvalue; }
            set { firstvalue = value; }
        }

        public double Secondvalue
        {
            get { return secondvalue; }
            set { secondvalue = value; }
        }
        public char Operand
        {
            get { return operand; }
            set { operand = value; }
        }

        public Calculator(double firstvalue, double secondvalue, char operand)
        {
            Firstvalue = firstvalue;
            Secondvalue = secondvalue;
            Operand = operand;
        }
    }
    //Application of inheritance and polymorphism of the calculator base class
    class Calculator_Addition : Calculator
    {
        public Calculator_Addition(double firstvalue, double secondvalue, char operand) : base(firstvalue, secondvalue, operand)
        {
            Operand = operand;
            Firstvalue = firstvalue;
            Secondvalue = secondvalue;
            double result = Firstvalue + Secondvalue;
            Console.WriteLine($"| The sum of {Firstvalue} {operand} {Secondvalue} = " + result);
        }
    }
    class Calculator_Subtraction : Calculator
    {
        public Calculator_Subtraction(double firstvalue, double secondvalue, char operand) : base(firstvalue, secondvalue, operand)
        {
            Operand = operand;
            Firstvalue = firstvalue;
            Secondvalue = secondvalue;
            double result = Firstvalue - Secondvalue;
            Console.WriteLine($"| The minuend of {Firstvalue} {operand} {Secondvalue} = " + result);
        }
    }
    class Calculator_Multiplication : Calculator
    {
        public Calculator_Multiplication(double firstvalue, double secondvalue, char operand) : base(firstvalue, secondvalue, operand)
        {
            Operand = operand;
            Firstvalue = firstvalue;
            Secondvalue = secondvalue;
            double result = Firstvalue * Secondvalue;
            Console.WriteLine($"| The product of {Firstvalue} {operand} {Secondvalue} = " + result);
        }
    }
    class Calculator_Division : Calculator
    {
        public Calculator_Division(double firstvalue, double secondvalue, char operand) : base(firstvalue, secondvalue, operand)
        {
            Operand = operand;
            Firstvalue = firstvalue;
            Secondvalue = secondvalue;
            double result = Firstvalue / Secondvalue;
            Console.WriteLine($"| The quotient of {Firstvalue} {operand} {Secondvalue} = " + result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char operand;
            double num1, num2;
            char repeat_choice;
            do
            {
                Console.Clear();
                Console.WriteLine("|------------------------------------------------|");
                Console.WriteLine("|               RUBEN'S CALCULATOR               |");
                Console.WriteLine("|------------------------------------------------|");
                Console.Write("| Please Enter first value: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("| Invalid input. Please enter a numerical value.");
                    Console.Write("| Please Enter first value: ");
                }

                Console.Write("| Please Enter second value: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                    Console.Write("| Please Enter second value: ");
                }
                Console.Write("| Choose an operation (+, -, *, /): ");
                while (!char.TryParse(Console.ReadLine(), out operand) ||
                       (operand != '+' && operand != '-' && operand != '*' && operand != '/'))
                {
                    Console.WriteLine("| Invalid operation. Please choose from '+', '-', '*', or '/'.");
                    Console.Write("| Choose an operation (+, -, *, /): ");
                }
                switch (operand)
                {
                    case '+':
                        Calculator_Addition calculate1 = new Calculator_Addition(num1, num2, operand);
                        break;
                    case '-':
                        Calculator_Subtraction calculate2 = new Calculator_Subtraction(num1, num2, operand);
                        break;
                    case '*':
                        Calculator_Multiplication calculate3 = new Calculator_Multiplication(num1, num2, operand);
                        break;
                    case '/':
                        Calculator_Division calculate4 = new Calculator_Division(num1, num2, operand);
                        break;
                }
                Console.Write("| Would you like to try again? (Y) yes / (N) no: ");
                while (!char.TryParse(Console.ReadLine(), out repeat_choice) ||
                       (repeat_choice != 'Y' && repeat_choice != 'y' && repeat_choice != 'N' && repeat_choice != 'n'))
                {
                    Console.WriteLine("| Invalid choice. Please choose (Y) yes or (N) no.");
                    Console.WriteLine("|");
                    Console.Write("| Would you like to try again? (Y) yes / (N) no: ");
                }
            } while (repeat_choice == 'Y' || repeat_choice == 'y');
            Console.WriteLine("\"Thank you for using RUBEN'S CALCULATOR\"");
            Console.ReadKey();
        }
    }
}
