﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop.ass2
{
    internal class Operation : Compute
    {

        public void validator() //
        {
            bool n = true;                                                      //to loop the entry and validation
            while (n)
            {
                try
                {
                    Console.Write("Please enter the first number: ");           //first input
                    Number1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    Number2 = Convert.ToDouble(Console.ReadLine());             //second input
                    n = false;                                                  //to stop the loop

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error. Please input numbers only.");     //catches if the input is not a double, float, or integer
                }
            }
        }
        public void operation()
        {
            bool t = true;                                                      //to loop the entry and validations
            while (t)
            {
                try
                {
                    Console.WriteLine("\nPlease choose an operation: \n" +      //let's the user choose what operation
                    "[+] Addition\n" +
                    "[-] Subtraction\n" +
                    "[*] Multiplication\n" +
                    "[/] Division");
                    Console.Write("Enter your choice: ");
                    operators = Convert.ToChar(Console.ReadLine());

                    switch (operators)                                              //operation cases
                    {
                        case '+':
                            Console.WriteLine("= " + Add(Number1, Number2));
                            break;
                        case '-':
                            Console.WriteLine("= " + Subtract(Number1, Number2));
                            break;
                        case '*':
                            Console.WriteLine("= " + Multiply(Number1, Number2));
                            break;
                        case '/':
                            Console.WriteLine("= " + Divide(Number1, Number2));
                            break;
                        default:
                            throw new Exception();
                    }
                    t = false;                                                      //to stop the loop
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error! Please enter valid operations only\n");//catches if the input is not any of the given choices
                }
            }
            
            
        }
        public double Add(double number1, double number2)               
        {
            sum = number1 + number2;
            return sum;
        }
        public double Subtract(double number1, double number2)
        {
            difference = number1 - number2;
            return difference;
        }
        public double Multiply(double number1, double number2)
        {
            product = number1 * number2;
            return product;
        }
        public double Divide(double number1, double number2)
        {
            quotient = number1 / number2;
            return quotient;
        }
    }
        
 }