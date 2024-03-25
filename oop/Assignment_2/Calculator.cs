using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Assignment_2
{
    internal abstract class Calculator
    {
        private double num1, num2;
        protected double sum, diff, prod, quo;
        protected char op;
        public abstract void displayCalculator();

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
    }

    class Operation : Calculator
    {

        public double add(double num1, double num2)
        {
            sum = num1 + num2;
            return sum;
        }
        public double sub(double num1, double num2)
        {
            diff = num1 - num2;
            return diff;
        }
        public double mul(double num1, double num2)
        {
            prod = num1 * num2;
            return prod;
        }
        public double div(double num1, double num2)
        {
            quo = num1 / num2;
            return quo;
        }

        public override void displayCalculator()
        {
            Console.WriteLine("Enter your first number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            // Input second number
            Console.WriteLine("Enter your first number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            // Choosing operation
            Console.Write("Enter Operation\n: [+] Addition\n[-] Subtraction\n[*] Multiplication\n-> ");
            Console.Write("");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine("= " + add(Num1, Num2));
                    break;
                case '-':
                    Console.WriteLine("= " + sub(Num1, Num2));
                    break;
                case '*':
                    Console.WriteLine("= " + mul(Num1, Num2));
                    break;
                case '/':
                    Console.WriteLine("= " + div(Num1, Num2));
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }
        }
    }
}
