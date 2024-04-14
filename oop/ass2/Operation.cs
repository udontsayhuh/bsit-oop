using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop.ass2
{
    internal class Operation
    {
        private double total = 0;

        //Validator Method loops continuously until the user enters "="
        public void Compute()
        {
            //Instruction for users
            Console.WriteLine("Enter values and operators ALTERNATIVELY. Press '=' to calculate.");

            while (true)
            {
                try
                {
                    Console.Write("-> ");

                    //reads the input and store in str variable 'input'
                    string input = Console.ReadLine();

                    //if the user input is '=', the loop stops and calculates to get the final result
                    if (input == "=")
                        break;

                    //if the input can be parsed into double,  it is treated as a numeric value & will be assigned in the 'total' variable
                    if (double.TryParse(input, out double number))
                    {
                        //'total' variable holds the total of the calculation
                        total = number;
                    }

                    //and if input can't be parsed into double, it is treated as an operation
                    else
                    {
                        //prompts the user to enter the next value
                        Console.Write("-> ");

                        //switch case for operators, using input[0] to access the 1st character of the input string
                        char operation = input[0];
                        switch (operation)
                        {
                            case '+':
                                Add();
                                break;
                            case '-':
                                Subtract();
                                break;
                            case '*':
                                Multiply();
                                break;
                            case '/':
                                Divide();
                                break;
                            default:
                                //will show an error message and  prompt the user to enter a valid operation to continue
                                Console.WriteLine("Invalid operation.");
                                break;
                        }
                    }
                }

                //if input is not recognized as an operator or a number, the program will catch an argument exception
                //which will prompt the user to re enter a valid input (will reset the whole calculation process)
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid Input. Try Again.\n");
                }

            }

            //displays when the user enter '='
            Console.WriteLine($"Result: {total}");
        }

        //the methods to perform the frespective arithmetic operations
        private void Add()
        {
            double value;
            if (double.TryParse(Console.ReadLine(), out value))
                total = total + value;
            else
                throw new ArgumentException();
        }

        private void Subtract()
        {
            double value;
            if (double.TryParse(Console.ReadLine(), out value))
                total = total - value;
            else
                throw new ArgumentException();
        }

        private void Multiply()
        {
            double value;
            if (double.TryParse(Console.ReadLine(), out value))
                total = total * value;
            else
                throw new ArgumentException();
        }

        private void Divide()
        {
            try
            {
                double value = ReadDouble();
                if (value != 0)
                    total /= value;
                else
                    Console.WriteLine("Cannot divide by zero.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        private double ReadDouble()
        {
            double value;
            if (!double.TryParse(Console.ReadLine(), out value))
                throw new ArgumentException();
            return value;
        }
    }
}