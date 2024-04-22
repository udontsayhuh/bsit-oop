/*
Write a C# program that takes two numbers as input: the first number will be the number to be multiplied and the second number
will be the multiplier, and prints its multiplication table up to the given second number (the multiplier).

Dev by : Villesco, Bengie B.
Section : 2-1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenges
{
    // 2 * 10
    class MultiplicationTable
    {
        private static void ComputeAndDisplayResult(double[] number)
        {
            Console.WriteLine("\nMULTIPLICATION TABLE:");
            // SOLUTION WITHOUT USING ANOTHER VARIABLES TO SAVE MEMORY STORAGE.
            for (int i = 1; i <= number[1]; i++) //number[0] is the number to be multiply and number[1] is the multiplier.
                Console.WriteLine($"{number[0]} * {i} = {number[0] * i}");

            /* OTHER SOLUTION TO MAKE THE CODE MORE READABLE.
            double numberToMultiply = number[0];
            double multiplier = number[1];

            for (int i = 1; i <= multiplier; i++)
                Console.WriteLine($"{numberToMultiply} * {i} = {numberToMultiply * i}");
            */
        }

        private static double[] GetTwoNumbers()
        {
            double[] operand = new double[2];   // Array of double(with the size of 2) to store the number to be multipied and the number for multiplier.

            while (true)    // Get the number to be multiplied.
            {
                try
                {
                    Console.Write("Enter a number to be multiplied: ");
                    operand[0] = Convert.ToDouble(Console.ReadLine());
                    break;  // Exit the while loop.
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInvalid input! Please enter a number only!");
                }
            }

            while (true)    // Get the number for multiplier.
            {
                try
                {
                    Console.Write("Enter a number for multiplier: ");
                    operand[1] = Convert.ToDouble(Console.ReadLine());
                    break;  // Exit the while loop.
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInvalid input! Please enter a number only!");
                }
            }
            return operand; // Return the value stored in the operand variable (i.e number to be multiplied and the number for multiplier) to the calling method.
        }

        public static void Main(string[] args)
        {
            // First, method call to GetTwoNumbers method, then used the return value(number to be multiplied and number for multiplier) as an argument for ComputeAndDisplayResult method.
            // Lastly, method call to ComputeAndDisplayResult method with an argument of the return value from the first step.
            ComputeAndDisplayResult(GetTwoNumbers());

            // The following statement is used when the user decides to run the "MainProgram.cs" file, which can execute all coding challenges.
            Console.Write("\nPress any key to go back to main...");
            Console.ReadKey();  // read the key that the user's input (similar to getch).
            Console.Clear();    // Clear the console screen.
        }
    }
}