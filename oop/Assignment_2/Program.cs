using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            Operation calc = new Operation();
            Console.WriteLine("Calculator");
            // Input first number
            Console.WriteLine("Enter your first number: ");
            calc.Num1 = Convert.ToInt32(Console.ReadLine());

            // Input second number
            Console.WriteLine("Enter your first number: ");
            calc.Num2 = Convert.ToInt32(Console.ReadLine());

            // Choosing operation
            Console.WriteLine("Enter Operation\n: [+] Addition\n[-] Subtraction\n[*] Multiplication");
            Console.Write("=> ");
            op = Convert.ToChar(Console.ReadLine());
            char choice;
            switch (op)
            {
                case '+':
                    Console.WriteLine("= " + calc.add(calc.Num1, calc.Num2));
                    break;
                case '-':
                    Console.WriteLine("= " + calc.sub(calc.Num1, calc.Num2));
                    break;
                case '*':
                    Console.WriteLine("= " + calc.mul(calc.Num1, calc.Num2));
                    break;
                case '/':
                    Console.WriteLine("= " + calc.div(calc.Num1, calc.Num2));
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }


        }
    }
}
