using System;

namespace CalculatorApp
{
    public class Calculator
    {
        //addition operation
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        //subtraction operation
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        //multiplication operation
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        //division operation
        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }

    // Inheritance
    public class UserInterface : Calculator
    {
        // Method to view and get the user queries
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("[Main Menu]");
            Console.WriteLine("Calculator Application\n");
            Console.WriteLine("Operation");
            Console.WriteLine("[+] Addition");
            Console.WriteLine("[-] Subtraction");
            Console.WriteLine("[*] Multiplication");
            Console.WriteLine("[/] Division");
        }

        // Perform selected operation
        public void PerformOperation()
        {
                double num1, num2;
                char operation;
                num1 = GetNumber("Enter a Number: ");
                Console.Write("Enter Operation ( + , - , * , / ) : ");
                operation = Convert.ToChar(Console.ReadLine());
                num2 = GetNumber("Enter a Number: ");
                if (operation == '+')
                {
                    num1 = Add(num1, num2);
                    Console.WriteLine(num1);
                }
                else if (operation == '-')
                {
                    num1 = Subtract(num1, num2);
                    Console.WriteLine(num1);
                }
                else if (operation == '*')
                {
                    num1 = Multiply(num1, num2);
                    Console.WriteLine(num1);
                }
                else if (operation == '/')
                {
                    num1 = Divide(num1, num2);
                    Console.WriteLine(num1);
                }
                while (operation != '=')
                {
                    Console.Write("Enter Operation ( + , - , * , / , =) : ");
                    operation = Convert.ToChar(Console.ReadLine());
                    if (operation == '=')
                    {
                        break;
                    }
                    num2 = GetNumber("Enter a Number: ");
                    if (operation == '+')
                    {
                        num1 = Add(num1, num2);
                        Console.WriteLine(num1);
                    }
                    else if (operation == '-')
                    {
                        num1 = Subtract(num1, num2);
                        Console.WriteLine(num1);
                    }
                    else if (operation == '*')
                    {
                        num1 = Multiply(num1, num2);
                        Console.WriteLine(num1);
                    }
                    else if (operation == '/')
                    {
                        num1 = Divide(num1, num2);
                        Console.WriteLine(num1);
                    }
                    else if (operation == '=')
                    {
                        Console.WriteLine(num1);
                        break;
                    }

                }
                Console.WriteLine($"The output is: {num1}");
        }

        private double GetNumber(string message)
        {
            double number;
            bool isValid;
            do
            {
                Console.Write(message);
                isValid = double.TryParse(Console.ReadLine(), out number);
                if (!isValid)
                    Console.WriteLine("Invalid input. Please enter a valid number.");
            } while (!isValid);
            return number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            while (true)
            {
                ui.DisplayMenu();
                ui.PerformOperation();
                Console.WriteLine("Would you like to try again? [y] yes, [n] no: ");
                char choice = Convert.ToChar(Console.ReadLine());
                if (choice == 'n')
                {
                    break;
                }
            }
        }
    }
}
