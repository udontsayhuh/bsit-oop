using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("=============================");
                Console.WriteLine("WELCOME TO CALCULATOR PROGRAM");
                Console.WriteLine("=============================");

                // Input validation for num1

                Console.WriteLine("Enter your first number: ");
                string input1 = Console.ReadLine();
                if (!double.TryParse(input1, out num1))
                {
                    Console.WriteLine("INVALID INPUT, Enter a valid number!");
                    return; // Terminate
                }

                // Input validation for num2

                Console.WriteLine("Enter your second number: ");
                string input2 = Console.ReadLine();
                if (!double.TryParse(input2, out num2))
                {
                    Console.WriteLine("INVALID INPUT. Enter a valid number!");
                    return; // Terminate
                }

                // Ask for the operation until valid is entered
                bool checkOperation = false;
                while (!checkOperation)
                {
                    Console.WriteLine("PLEASE PICK YOUR OPTION: ");
                    Console.WriteLine("===================");
                    Console.WriteLine("= + : ADD         =");
                    Console.WriteLine("= - : SUBTRACT    =");
                    Console.WriteLine("= * : MULTIPLY    =");
                    Console.WriteLine("= / : DIVIDE      =");
                    Console.WriteLine("===================");
                    Console.WriteLine("Enter an option: ");

                    string operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                            checkOperation = true;
                            break;

                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                            checkOperation = true;
                            break;

                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                            checkOperation = true;
                            break;

                        case "/":
                            result = num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                            checkOperation = true;
                            break;

                        default:
                            Console.WriteLine("INVALID OPTION! Please enter a valid option.");
                            break;
                    }
                }

                //after result ask user if wants to use again

                Console.WriteLine("Would you like to continue? (Y)/(N)");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("==========================================");
            Console.WriteLine("THANK YOU FOR USING THE CALCULATOR PROGRAM");
            Console.WriteLine("==========================================");

            Console.ReadKey();
        }
    }
}
