using System;

namespace MyCalculator
{
    class Calculator
    {
        public void RunCalculator()
        {
            string value = "Y"; // initializing the value with Y 
            do
            {
                float num1, num2;

                Console.Clear(); // clear the console screen before each new calculation

                Console.Write("Enter the first number: ");
                if (!float.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("INVALID INPUT! CLOSING THE CALCULATOR . . .");
                    return;  // terminate if the first number is invalid
                }

                Console.Write("Enter the second number: ");
                if (!float.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("INVALID INPUT! CLOSING THE CALCULATOR . . .");
                    return;  // terminate if the second number is invalid
                }

                string opsymbol;
                while (true)
                {
                    Console.Clear(); // clear the console screen for a new calculation
                    Console.Write("Enter operation symbol you want to use (+, -, *, /): ");
                    opsymbol = Console.ReadLine();

                    if (opsymbol == "+" || opsymbol == "-" || opsymbol == "*" || opsymbol == "/")
                        break;
                    else
                    {
                        Console.WriteLine("INVALID INPUT!");
                        Console.Write("\nPress any key to start a new calculation.");
                        Console.ReadKey();
                        Console.Clear(); // clear the console screen for a fresh start
                        Console.Write("Enter the first number: ");
                        if (!float.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.WriteLine("INVALID INPUT! CLOSING THE CALCULATOR . . .");
                            return;  // terminate if the first number is invalid
                        }

                        Console.Write("Enter the second number: ");
                        if (!float.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.WriteLine("INVALID INPUT! CLOSING THE CALCULATOR . . .");
                            return;  // terminate if the second number is invalid
                        }
                    }
                }

                PerformOperation(num1, num2, opsymbol);

                // ask user if they want to do another calculation again
                Console.WriteLine("\nPress 'Y' to continue or 'N' to exit...");
                value = Console.ReadLine().ToUpper();

                if (value == "N")
                {
                    Console.WriteLine("\n-------------------------------------");
                    Console.WriteLine("   BYE T-T EXITING THE CALCULATOR ...");
                    Console.WriteLine("-------------------------------------");
                    break;  // terminate the program if the user enter n
                }
            }
            while (value != "N");
        }

        private void PerformOperation(float num1, float num2, string opsymbol)
        {
            switch (opsymbol)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} is equal to {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} is equal to {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} is equal to {num1 * num2}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("CANNOT DIVIDE BY ZERO.");
                        return;
                    }
                    Console.WriteLine($"{num1} / {num2} is equal to {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("INVALID INPUT! CLOSING THE CALCULATOR . . .");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.RunCalculator();
        }
    }
}
