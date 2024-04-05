//GHAZI, ZAINA E. BSIT 2-2
using System;

namespace c_sharp_calculator
{
    class Calculator
    {
        public void RunCalculator()
        {
            string value = "y"; // initializing the value with y 
            do
            {
                float number1, number2;
                Console.Write("Enter the first number: ");
              // convert the input into float value and pass value using parameter
                if (!float.TryParse(Console.ReadLine(), out number1))
                {
                    Console.WriteLine("Invalid input. Terminating the calculator");
                    break;
                }

                Console.Write("Enter the second number: ");
                if (!float.TryParse(Console.ReadLine(), out number2))
                {
                    Console.WriteLine("Invalid input. Terminating the calculator");
                    break;
                }

                string symbol;
                while (true) 
                {
                    Console.Write("Enter desired Operational Symbol (+, -, *, /): ");
                    symbol = Console.ReadLine();

                    if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/")
                        break;
                    else
                        Console.WriteLine("Invalid symbol");
                }
            
                PerformOperation(number1, number2, symbol);

              //code for retrying calculator or exit
                Console.WriteLine("Do you want to continue? (Y/N)");
                value = Console.ReadLine().ToLower(); //converts input to lowercase if it was uppercase
                if (value == "n")
                {
                    Console.WriteLine("Exiting Program. Thank you for using this Calculator!");
                    break;
                }

            }
            while (value.ToLower() == "y");
        }
        //performing arithmetic operations
        private void PerformOperation(float number1, float number2, string symbol) //calling the input 
        {
            switch (symbol)
            {
                case "+":
                    Console.WriteLine("Addition");
                    Console.WriteLine($"{number1} + {number2} is equal to {number1 + number2}"); //printing and perform the math
                    break;
                case "-":
                    Console.WriteLine("Subtraction");
                    Console.WriteLine($"{number1} - {number2} is equal to {number1 - number2}");
                    break;
                case "*":
                    Console.WriteLine("Multiplication");
                    Console.WriteLine($"{number1} * {number2} is equal to {number1 * number2}");
                    break;
                case "/":
                    if (number2 == 0)// output if user input is zero in division
                    {
                        Console.WriteLine("Division by zero is not allowed");
                        return;
                    }
                    Console.WriteLine("Divison");
                    Console.WriteLine($"{number1} / {number2} is equal to {number1 / number2}");
                    break;
              //default message for invalid symbol input 
                default:
                    Console.WriteLine("Invalid symbol");
                    break;
            }
        }
    }

    //entry point
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.RunCalculator(); //function call for user input in numbers
        }
    }
}
