using System;

namespace Calculator
{
    public class ArithmeticOperations
    {
        // Addition operation
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Subtraction operation
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Multiplication operation
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Division operation
        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }

    // UserInterface class to handle user interactions
    public class UserInterface : ArithmeticOperations
    {
        // Method to display menu and get user choice
        public int DisplayMenu()
        {
            Console.WriteLine("[Main Menu]");
            Console.WriteLine("Calculator\n");
            Console.WriteLine("Operation");
            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Subtraction");
            Console.WriteLine("(3) Multiplication");
            Console.WriteLine("(4) Division");
            Console.WriteLine("(5) Exit");
            Console.Write("Enter Choice: ");
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
                case 2:
                case 3:
                case 4:
                    num1 = GetNumber("Enter First Number: ");
                    num2 = GetNumber("Enter Second Number: ");
                    try
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine($"The result of addition is: {Add(num1, num2)}");
                                break;
                            case 2:
                                Console.WriteLine($"The result of subtraction is: {Subtract(num1, num2)}");
                                break;
                            case 3:
                                Console.WriteLine($"The result of multiplication is: {Multiply(num1, num2)}");
                                break;
                            case 4:
                                Console.WriteLine($"The result of division is: {Divide(num1, num2)}");
                                break;
                        }
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

        // Method to get valid numerical input from user
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

    // Main program class
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
