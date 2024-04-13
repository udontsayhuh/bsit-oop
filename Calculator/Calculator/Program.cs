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
    //  Optimized: reducing the redundancy of each in each inherited polymorphed classes by not storing the result but directly returning it
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
            return Firstvalue + Secondvalue; ;
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
            return Firstvalue - Secondvalue;
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
            return Firstvalue * Secondvalue;
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
            return Firstvalue / Secondvalue;
        }
    }


    //  Optimized: different functions has been broken down to different methods to a single functionality to ensure code readability and to avoid writing "spaghetti code"
    //  Addition: By using function calls instead of nested loops makes the code more efficient than before and that also improves readability
    //  Addition: Also applied right naming conventions even though the code is not entirely Pascal case applied but by using meaningful names for classes it enhances readability
    //  Addition: Also the code has been formatted and indented as properly for the current knowledge have in the programming language.
    class Program
    {
        static void Main(string[] args)
        {
            char operand = 'g', repeat_choice = 'g';
            double num1 = 0, num2 = 0;
            intro(ref num1, ref num2, ref operand, ref repeat_choice);
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


        static void intro(ref double num1, ref double num2, ref char operand, ref char repeat_choice)
        {
            Console.Clear();
            Console.WriteLine("|-------------------------------------------------------------------|");
            Console.WriteLine("|                   RUBEN'S CALCULATOR (UPDATED)                    |");
            Console.WriteLine("|-------------------------------------------------------------------|");
            user_input(ref num1, ref num2, ref operand, ref repeat_choice);
        }


        static void user_input(ref double num1, ref double num2, ref char operand, ref char repeat_choice)
        {
            Console.Write("| Please Enter a value: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("| Invalid input. Please enter a numerical value.");
                Console.WriteLine("| Please Enter first value: ");
            }
            double entry = num1;
            do
            {
                if (num1 == entry || num2 == 0)
                {
                    Console.Write("| Choose an operation (+, -, *, /): ");
                    while (!char.TryParse(Console.ReadLine(), out operand) ||
                        (operand != '+' && operand != '-' && operand != '*' && operand != '/'))
                    {
                        Console.WriteLine("| Invalid operation. Please choose from '+', '-', '*', '/'");
                        Console.Write("| Choose an operation (+, -, *, /: ");
                    }
                }
                else
                {
                    Console.Write("| Choose an operation (+, -, *, / or '='(to end computation)): ");
                    while (!char.TryParse(Console.ReadLine(), out operand) ||
                           (operand != '+' && operand != '-' && operand != '*' && operand != '/' && operand != '='))
                    {
                        Console.WriteLine("| Invalid operation. Please choose from '+', '-', '*', '/' or '='");
                        Console.Write("| Choose an operation (+, -, *, / or '='(to end computation)): ");
                    }
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
            } while (true);
            Console.WriteLine($"| The result is: {num1}");
            repeat(ref num1, ref num2, ref operand, ref repeat_choice);
        }


        static void repeat(ref double num1, ref double num2, ref char operand, ref char repeat_choice)
        {
            Console.Write("| Would you like to try again? (Y) yes / (N) no: ");
            while (!char.TryParse(Console.ReadLine(), out repeat_choice) ||
                   (repeat_choice != 'Y' && repeat_choice != 'y' && repeat_choice != 'N' && repeat_choice != 'n'))
            {
                Console.WriteLine("| Invalid choice. Please choose (Y) yes or (N) no.");
                Console.WriteLine("|");
                Console.Write("| Would you like to try again? (Y)yes / (N)no: ");
            }
            if (repeat_choice == 'Y' || repeat_choice == 'y')
            {
                intro(ref num1, ref num2, ref operand, ref repeat_choice);
            }
            else
            {
                end();
            }
        }


        static void end()
        {
            Console.WriteLine("|-------------------------------------------------------------------|");
            Console.WriteLine("|             \"Thank you for using RUBEN'S CALCULATOR\"              |");
            Console.WriteLine("|-------------------------------------------------------------------|");
            Console.ReadKey();
        }
    }
}
