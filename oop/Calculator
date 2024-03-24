//HALILI, MA. ALEX BSIT 2-2
using System;

namespace MyCalculator
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
              // converting the input into float value and using the parameter to pass the value if its converted
                if (!float.TryParse(Console.ReadLine(), out number1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                    continue;
                }

                Console.Write("Enter the second number: ");
                if (!float.TryParse(Console.ReadLine(), out number2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                    continue;
                }

                string symbol;
                while (true) 
                {
                    Console.Write("Enter symbol you want to use (+, -, *, /): ");
                    symbol = Console.ReadLine();

                    if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/")
                        break;
                    else
                        Console.WriteLine("Invalid symbol");
                }
                // method for doing the math ;o
                PerformOperation(number1, number2, symbol);

              //asking the user if they want to continue
                Console.WriteLine("Do you want to continue? (Y/N)");
                value = Console.ReadLine().ToLower(); //reading the value and converting it to a lowercase if the user input uppercase
                if (value == "n")
                {
                    Console.WriteLine("Closing Calculator");
                    break;
                }

            }
            while (value.ToLower() == "y");
        }
        //method for performing arithmetic operation
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
                    if (number2 == 0)// if user input zero it will be invalid 
                    {
                        Console.WriteLine("Division by zero is not allowed");
                        return;
                    }
                    Console.WriteLine("Divison");
                    Console.WriteLine($"{number1} / {number2} is equal to {number1 / number2}");
                    break;
              //if the user input is not in the case this will be the default output 
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
            calculator.RunCalculator(); //calling the method for user input for number
        }
    }
}
