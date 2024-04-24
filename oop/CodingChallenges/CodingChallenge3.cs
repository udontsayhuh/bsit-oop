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

        // Property for input numbers
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
        public char Operation
        {
            get { return operation; }
            set { operation = value; }
        }
        public char Choice
        {
            get { return choice; }
            set { choice = value; }
        }

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
                Num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter your second number: ");
                Num2 = double.Parse(Console.ReadLine());
                Console.Write("Enter Operation:[+] Addition [-] Subtraction [*] Multiplication [/] Division, PRINT RESULT[=]: ");
                Operation = char.Parse(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        Console.WriteLine($"{Num1} + {Num2} = {Add(num1, num2)}");
                        break;
                    case '-':
                        Console.WriteLine($"{Num1} - {Num2} = {Sub(num1, num2)}");
                        break;
                    case '*':
                        Console.WriteLine($"{Num1} * {Num2} = {Mul(num1, num2)}");
                        break;
                    case '/':
                        Console.WriteLine($"{Num1} / {Num2} = {Div(num1, num2)}");
                        break;
                }
                while(responseContinue)
                {
                    Console.Write("\nDo you want to continue? Press y if YES or else n for NO: ");
                    Choice = char.Parse(Console.ReadLine());

                    if (Choice == 'y' || Choice == 'Y')
                    {
                        continuee = true;
                        break;
                    }
                    else if (Choice == 'n' || Choice == 'N')
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
