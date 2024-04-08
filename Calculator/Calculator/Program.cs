using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

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


    //  Application of inheritance and polymorphism of the calculator base class
    //  Changes: instead of just printing the result of each inherited polymorphed classes each classes will return their result

    class Calculator_Addition : Calculator
    {
        public Calculator_Addition(double firstvalue, double secondvalue, char operand) : base(firstvalue, secondvalue, operand)
        {
            Operand = operand;
            Firstvalue = firstvalue;
            Secondvalue = secondvalue;
        }

        public double compute(double firstvalue, double secondvalue, char operand)
        {
            double result = Firstvalue + Secondvalue;
            return result;
        }


    }
    class Calculator_Subtraction : Calculator
    {
        public Calculator_Subtraction(double firstvalue, double secondvalue, char operand) : base(firstvalue, secondvalue, operand)
        {
            Operand = operand;
            Firstvalue = firstvalue;
            Secondvalue = secondvalue;
        }

        public double compute(double firstvalue, double secondvalue, char operand)
        {
            double result = Firstvalue - Secondvalue;
            return result;
        }
    }
    class Calculator_Multiplication : Calculator
    {
        public Calculator_Multiplication(double firstvalue, double secondvalue, char operand) : base(firstvalue, secondvalue, operand)
        {
            Operand = operand;
            Firstvalue = firstvalue;
            Secondvalue = secondvalue;
        }

        public double compute(double firstvalue, double secondvalue, char operand)
        {
            double result = Firstvalue * Secondvalue;
            return result;
        }
    }
    class Calculator_Division : Calculator
    {
        public Calculator_Division(double firstvalue, double secondvalue, char operand) : base(firstvalue, secondvalue, operand)
        {
            Operand = operand;
            Firstvalue = firstvalue;
            Secondvalue = secondvalue;
        }

        public double compute(double firstvalue, double secondvalue, char operand)
        {
            double result = Firstvalue / Secondvalue;
            return result;
        }
    }
    class Program
    {
        


        static void Main(string[] args)
        {
            char operand, repeat_choice;
            double num1, num2;
            do
            {
                Console.Clear();
                Console.WriteLine("|-------------------------------------------------------------------|");
                Console.WriteLine("|                   RUBEN'S CALCULATOR (UPDATED)                    |");
                Console.WriteLine("|-------------------------------------------------------------------|");
                Console.Write("| Please Enter a value: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("| Invalid input. Please enter a numerical value.");
                    Console.WriteLine("| Please Enter first value: ");
                }
                Console.Write("| Choose an operation (+, -, *, /): ");
                while (!char.TryParse(Console.ReadLine(), out operand) ||
                       (operand != '+' && operand != '-' && operand != '*' && operand != '/'))
                {
                    Console.WriteLine("| Invalid operation. Please choose from '+', '-', '*', '/'");
                    Console.Write("| Choose an operation (+, -, *, /: ");
                }
                Console.Write("| Please Enter a value: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("| Invalid input. Please enter a numerical value.");
                    Console.WriteLine("| Please Enter first value: ");
                }
                num1 = function(num1, num2, operand);
                do
                {
                    
                    Console.Write("| Choose an operation (+, -, *, / or '='(to end computation)): ");
                    while (!char.TryParse(Console.ReadLine(), out operand) ||
                           (operand != '+' && operand != '-' && operand != '*' && operand != '/' && operand != '='))
                    {
                        Console.WriteLine("| Invalid operation. Please choose from '+', '-', '*', '/' or '='");
                        Console.Write("| Choose an operation (+, -, *, / or '='(to end computation)): ");
                    }
                    if (operand == '=')
                    {
                        break;
                    }
                    Console.Write("| Please Enter a value: ");
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("| Invalid input. Please enter a numerical value.");
                        Console.WriteLine("| Please Enter first value: ");
                    }
                    num1 = function(num1, num2, operand);
                } while (operand != '=');
                Console.WriteLine($"| The result is: {num1}");
                Console.Write("| Would you like to try again? (Y) yes / (N) no: ");
                while (!char.TryParse(Console.ReadLine(), out repeat_choice) ||
                       (repeat_choice != 'Y' && repeat_choice != 'y' && repeat_choice != 'N' && repeat_choice != 'n'))
                {
                    Console.WriteLine("| Invalid choice. Please choose (Y) yes or (N) no.");
                    Console.WriteLine("|");
                    Console.Write("| Would you like to try again? (Y)yes / (N)no: ");
                }
            } while (repeat_choice == 'Y' || repeat_choice == 'y');
            Console.WriteLine("|-------------------------------------------------------------------|");
            Console.WriteLine("|             \"Thank you for using RUBEN'S CALCULATOR\"              |");
            Console.WriteLine("|-------------------------------------------------------------------|");
            Console.ReadKey();
        }

        static double function(double num1, double num2, char operand)
        {
            switch (operand)
            {
                case '+':
                    Calculator_Addition calculate1 = new Calculator_Addition(num1, num2, operand);
                    num1 = calculate1.compute(num1, num2, operand);
                    break;
                case '-':
                    Calculator_Subtraction calculate2 = new Calculator_Subtraction(num1, num2, operand);
                    num1 = calculate2.compute(num1, num2, operand);
                    break;
                case '*':
                    Calculator_Multiplication calculate3 = new Calculator_Multiplication(num1, num2, operand);
                    num1 = calculate3.compute(num1, num2, operand);
                    break;
                case '/':
                    Calculator_Division calculate4 = new Calculator_Division(num1, num2, operand);
                    num1 = calculate4.compute(num1, num2, operand);
                    break;
            }
            return num1;
        }
    }
}
