using oop.Assignment_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.CodingChallenges
{
    internal class CodingChallenge3
    {
        private double num1, num2;
        private char operation, choice;
        bool continuee, responseContinue = true;
        public double sum, diff, prod, quo;


        public double Add(double num1, double num2)
        {
            sum = num1 + num2;
            return sum;
        }
        public double Sub(double num1, double num2)
        {
            diff = num1 - num2;
            return diff;
        }
        public double Mul(double num1, double num2)
        {
            prod = num1 * num2;
            return prod;
        }
        public double Div(double num1, double num2)
        {
            quo = num1 / num2;
            return quo;
        }
        public void CalculatorResult()
        {
            Console.WriteLine("Coding Challenges #3");
            do
            {
                Console.Write("\nEnter your first number: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter your second number: ");
                num2 = double.Parse(Console.ReadLine());
                Console.Write("Enter Operation:[+] Addition [-] Subtraction [*] Multiplication [/] Division: ");
                operation = char.Parse(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        Console.WriteLine($"{num1} + {num2} = {Add(num1, num2)}");
                        break;
                    case '-':
                        Console.WriteLine($"{num1} - {num2} = {Sub(num1, num2)}");
                        break;
                    case '*':
                        Console.WriteLine($"{num1} * {num2} = {Mul(num1, num2)}");
                        break;
                    case '/':
                        Console.WriteLine($"{num1} / {num2} = {Div(num1, num2)}");
                        break;
                }

                while(responseContinue)
                {
                    Console.Write("\nDo you want to continue? Press y if YES or else n for NO: ");
                    choice = char.Parse(Console.ReadLine());

                    if (choice == 'y' || choice == 'Y')
                    {
                        continuee = true;
                        break;
                    }
                    else if (choice == 'n' || choice == 'N')
                    {
                        continuee = false;
                        Environment.Exit(0);
                    }
                    else
                    {
                        continue;
                    }
                }
               
            } while (continuee);
        }
    }
}
