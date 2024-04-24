using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class MultiplicationTable
    {
        // a method that will display the header
        public void Header()
        {
            Console.Clear(); // will clear the console window

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Display the multiplication table based on the input number");
            Console.WriteLine("-------------------------------------------------------------\n");
        }

        // method that will ask for user input
        public void InputNumbers()
        {
            int num1, num2;


            Header();

            while (true)
            {
                Console.Write("Enter the first number: ");
                string firstNumber = Console.ReadLine();

                // validate the input
                try
                {
                    num1 = Convert.ToInt32(firstNumber);

                    string success = "no";
                    while (success != "yes")
                    {
                        // ask for second number
                        Console.Write("Enter the second number: ");
                        string secondNumber = Console.ReadLine();

                        if (int.TryParse(secondNumber, out num2))
                        {
                            success = "yes";
                            // calculate the multiplication table
                            Calculate(num1, num2);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Must be numeric");
                        }
                    }

                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Must be numeric. Try again");
                }
            }

        }

        // method that generates multiplication table based on the number
        public void Calculate(int num1, int num2)
        {
            Console.WriteLine($"\nMultiplication table for {num1} up to {num2}: ");

            for (int i = 1; i <= num2; i++)
            {
                Console.WriteLine($"{num1} x {i} = {num1 * i}");
            }
        }
    }
}
