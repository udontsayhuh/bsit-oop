using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class Arithmetic
    {
        public double firstNum;
        public double secondNum;

        // a method to display the arithmetic operations
        public void DisplayArithmeticOperations()
        {
            Console.Clear(); // will clear the console window

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("  Performing basic arithmetic functions");
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("Choose an arithmetic operation: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            while (true)
            {
                again: // goto statement will go here if input is invalid

                Console.Write("\nEnter your option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Subtract();
                        break;
                    case "3":
                        Multiply();
                        break;
                    case "4":
                        Divide();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Choose a number from 1 to 4. Try again!");
                        goto again;
                }
                break;
            }

           
        }

        // a method that will prompt the user to enter two numbers
        public void InputNumbers()
        {
            while (true)
            {
                Console.Write("Enter the first number: ");
                string firstNumber = Console.ReadLine();

                // validate the input
                try
                {
                    firstNum = Convert.ToDouble(firstNumber);

                    while (true)
                    {
                        // ask for second number
                        Console.Write("Enter the second number: ");
                        string secondNumber = Console.ReadLine();
                        
                        if (double.TryParse(secondNumber, out secondNum))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Must be numeric");
                        }
                    }
                    break;

                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Must be numeric. Try again");
                }

            }
            
        }

        // a method that will display the header
        public void Header(string operation)
        {
            Console.Clear(); // will clear the console window

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("  " + operation);
            Console.WriteLine("-------------------------------------------\n");
        }


        // method for addition
        public void Add()
        {
            Header("Addition");

            // ask for input
            InputNumbers();

            double sum = firstNum + secondNum;

            Console.WriteLine($"\n{firstNum} + {secondNum} = {sum} ");

            CalculateAgain();
        }

        // method for subtraction
        public void Subtract()
        {
            Header("Subtraction");

            // ask for input
            InputNumbers();

            double difference = (firstNum) - (secondNum);

            Console.WriteLine($"\n{firstNum} - {secondNum} = {difference} ");

            CalculateAgain();
        }

        // method for multiplication
        public void Multiply()
        {
            Header("Multiplication");

            // ask for input
            InputNumbers();

            double product = firstNum * secondNum;

            Console.WriteLine($"\n {firstNum} x {secondNum} = {product} ");

            CalculateAgain();
        }

        // method for division
        public void Divide()
        {
            Header("Division");

            // ask for input
            InputNumbers();

            if (secondNum == 0)
            {
                Console.WriteLine("\nUndefined. Cannot divide by zero.");
            }
            else
            {
                double quotient = firstNum / secondNum;

                Console.WriteLine($"\n{firstNum} / {secondNum} = {quotient} ");
            }

            CalculateAgain();
        }

        // a method that ask if user wants to calculate again
        public void CalculateAgain()
        {
            while (true)
            {
                Console.Write("\nDo you want to perform another arithmetic operation? (yes/no): ");
                string option = Console.ReadLine().ToLower();

                if (option == "yes")
                {
                    // reset the value of the numbers
                    firstNum = 0;
                    secondNum = 0;

                    DisplayArithmeticOperations();
                    break;
                }
                else if (option == "no")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }
        }
    }
}
