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
        public override void getNumbers(int i)
        {
            bool x = true;

            while (x) // it loops when true, else terminate
            {
                
                try
                {
                    // Input first number
                    

                    if (i <= 0)
                    {
                        Console.Write("Enter number: ");
                        Num1 = Convert.ToDouble(Console.ReadLine());
                    }
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
        public override void getOperation(int j, List<double> myList)
        {
            bool y = true;
            do  // it loops when true, else terminate
            {
                try
                {
                    Console.Write("Enter Operation:[+] Addition [-] Subtraction [*] Multiplication [/] Division, PRINT RESULT[=]: ");
                    op = Convert.ToChar(Console.ReadLine());
                    if (op == '=')
                    {
                        if (myList.Count > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("= " + myList[myList.Count - 1]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        y = false;
                    }
                    else
                    {
                        switch (op)
                        {
                            case '+':
                                // Input second number
                                Console.Write("Enter number: ");
                                Num2 = Convert.ToDouble(Console.ReadLine());

                                myList.Add(add(Num1, Num2));
                                Num1 = sum;
                                y = false;
                                break;
                            case '-':
                                // Input second number
                                Console.Write("Enter number: ");
                                Num2 = Convert.ToDouble(Console.ReadLine());

                                myList.Add(sub(Num1, Num2));
                                Num1 = diff;
                                y = false;
                                break;
                            case '*':
                                // Input second number
                                Console.Write("Enter number: ");
                                Num2 = Convert.ToDouble(Console.ReadLine());

                                myList.Add(mul(Num1, Num2));
                                Num1 = prod;
                                y = false;
                                break;
                            case '/':
                                // Input second number
                                Console.Write("Enter number: ");
                                Num2 = Convert.ToDouble(Console.ReadLine());

                                myList.Add(div(Num1, Num2));
                                Num1 = quo;
                                y = false;

                                break;
                            default:
                                throw new Exception(); // throw exception
                        }

                    }
                         // new value for y, so the loop will stop because y = false
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input Valid Operations Only!"); // Display this when the input is wrong
                }
                // if the user choose equals sign
                
            } while (y);
            
        }

    
    }
}
