using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop.ass2
{
    internal class Operation : Compute
    {
        private double total = 0; // Variable for storing results

        public void Validator()
        {
            bool continueOpt = true; // to loop the entry and validation
            while (continueOpt)
            {
                try
                {
                    Console.Write("Please enter a number: "); // first input
                    double Number1 = Convert.ToDouble(Console.ReadLine());
                    /*Console.Write("Please enter an operation: "); // first input
                    char operators = Convert.ToChar(Console.ReadLine());*/

                    if (total == 0) // If the total is 0, assign the number
                    {
                        total = Number1;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease choose an operation: \n" + // let's the user choose what operation
                                          "[+] Addition\n" +
                                          "[-] Subtraction\n" +
                                          "[*] Multiplication\n" +
                                          "[/] Division\n" +
                                          "[=] Equals");

                        Console.Write("Enter your choice: ");
                        char operators = Convert.ToChar(Console.ReadLine());

                        switch (operators) // operation cases
                        {
                            case '+':
                                total = Add(total, Number1);
                                break;
                            case '-':
                                total = Subtract(total, Number1);
                                break;
                            case '*':
                                total = Multiply(total, Number1);
                                break;
                            case '/':
                                total = Divide(total, Number1);
                                break;
                            case '=':
                                continueOpt = false;
                                break;
                            default:
                                Console.WriteLine("Error. Please input a valid operation.");
                                continue;
                        }

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error. Please input numbers only."); // catches if the input is not a double, float, or integer
                }
            }

            Console.WriteLine($"Result: {total}");
        }

        public double Add(double total, double number1)
        {
            return total + number1;
        }

        public double Subtract(double total, double number1)
        {
            return total - number1;
        }

        public double Multiply(double total, double number1)
        {
            return total * number1;
        }

        public double Divide(double total, double number1)
        {
            if (number1 != 0) // Avoid division by zero
            {
                return total / number1;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN; // Returning NaN (Not a Number) to indicate error
            }
        }
    }
}
