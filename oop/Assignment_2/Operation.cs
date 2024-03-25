using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Assignment_2
{
    internal class Operation : Calculator
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

        // Method for asking user input for numbers
        public override void getNumbers()
        {
            bool x = true;

            while (x) // it loops when true, else terminate
            {
                try
                {
                    char choice;
                        // Input first number
                        Console.Write("Enter your first number: ");
                        Num1 = Convert.ToDouble(Console.ReadLine());

                        // Input second number
                        Console.Write("Enter your second number: ");
                        Num2 = Convert.ToDouble(Console.ReadLine());

                        // Ask if you want to continue using Calculator
                    x = false; // new value for x, so the loop will stop because x = false
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input Numbers Only!");
                    Console.WriteLine(" ");// Display this when the input is wrong
                }
            }
        }
        // Method for asking user input for operation
        public override void getOperation()
        {
            bool y = true;
            while (y)   // it loops when true, else terminate
            {
                try
                {
                    Console.Write("Enter Operation\n:[+] Addition\n[-] Subtraction\n[*] Multiplication\n-> ");
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
                            throw new Exception(); // throw exception
                    }

                    y = false; // new value for y, so the loop will stop because y = false
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input Valid Operations Only!"); // Display this when the input is wrong
                }
            }
            
        }
    }
}
