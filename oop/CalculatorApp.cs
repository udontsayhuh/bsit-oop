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
        public int DisplayMenu()
        {
            Console.WriteLine("[Main Menu]");
            Console.WriteLine("Calculator Application\n");
            Console.WriteLine("Operation");
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine("[3] Multiplication");
            Console.WriteLine("[4] Division");
            Console.WriteLine("[5] Exit");
            Console.Write("[Main Menu] Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        // Perform selected operation
        public void PerformOperation(int choice)
        {
            double num1, num2;
            switch (choice)
            {
                case 1:
                    num1 = GetNumber("Enter First Number: ");
                    num2 = GetNumber("Enter Second Number: ");
                    Console.WriteLine($"The sum of {num1} and {num2} is: {Add(num1, num2)}");
                    break;
                case 2:
                    num1 = GetNumber("Enter First Number: ");
                    num2 = GetNumber("Enter Second Number: ");
                    Console.WriteLine($"The difference {num1} and {num2} is: {Subtract(num1, num2)}");
                    break;
                case 3:
                    num1 = GetNumber("Enter First Number: ");
                    num2 = GetNumber("Enter Second Number: ");
                    Console.WriteLine($"The product {num1} and {num2} is: {Multiply(num1, num2)}");
                    break;
                case 4:
                    num1 = GetNumber("Enter First Number: ");
                    num2 = GetNumber("Enter Second Number: ");
                    try
                    {
                        Console.WriteLine($"The quotient {num1} and {num2} is: {Divide(num1, num2)}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
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
            int choice = 0;
            while (choice != 5)
            {
                choice = ui.DisplayMenu();
                ui.PerformOperation(choice);
            }
        }
    }
}
