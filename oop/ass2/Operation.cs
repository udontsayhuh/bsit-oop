using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


using System;

namespace oop.ass2
{
    internal class Operation
    {
        private double total = 0;

        public void Validator()
        {
            Console.WriteLine("Enter values and operators ALTERNATIVELY. Press '=' to calculate.");

            while (true)
            {
                try
                {
                    Console.Write("-> ");
                    string input = Console.ReadLine();

                    if (input == "=")
                        break;

                    if (double.TryParse(input, out double number))
                    {
                        total = number;
                    }
                    else
                    {
                        Console.Write("-> ");
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
                                Console.WriteLine("Invalid operation.");
                                break;
                        }
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }

            }

            Console.WriteLine($"Result: {total}");
        }

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