/*
Instruction: Write a C# program that contains method that accepts inputs from the user - that will
compute the sum of two integers and two doubles separately, and after showing the
result of the two sums, compute for the product of the sums - the result must be a
double data type.

Dev by : Villesco, Bengie B.
Section : 2-1
 */
using System;
using System.Text;
namespace Coding_Challenges
{
    class SumAndProduct
    {
        private static int GetUserInputForInt() // This method is only accessible within the class of SumAndProduct.
        {
            int[] intOperand = new int[2];  // Array to store the two integers that the user's input (size of the array is 2.)
            int sumOfInt = 0;   // Initialize sumOfInt to 0.

            // Get the user's input for two integers and get the sum of it.
            for (int i = 0; i < 2; i++)
            {
                // Error Handling
                while (true)
                {
                    try
                    {
                        Console.Write("Enter an integer number: ");
                        intOperand[i] = Convert.ToInt32(Console.ReadLine());
                        sumOfInt += intOperand[i];  // Compute the sum of integer.
                        break;  // Exit the while loop.
                    }
                    catch (Exception ex)
                    {   // Execute this if the user's input is not an integer.
                        Console.WriteLine(ex.Message);  // Display the error message.
                    }
                }
            }

            // Display the result of two integers.
            Console.WriteLine($"Sum of two integers: {sumOfInt}\n");
            return sumOfInt;    // return the value of sumOfInt to the calling method.
        }

        private static double GetUserInputForDouble()   // This method is only accessible within the class of SumAndProduct.
        {
            double[] doubleOperand = new double[2]; // Array to store the two doubles that the user's input (size of the array is 2.)
            double sumOfDouble = 0; // Initialize sumOfDouble to 0.

            // Get the user's input for two doubles and get the sum of it.
            for (int i = 0; i < 2; i++)
            {
                // Error Handling
                while (true)
                {
                    try
                    {
                        Console.Write("Enter an integer number: ");
                        doubleOperand[i] = Convert.ToDouble(Console.ReadLine());
                        sumOfDouble += doubleOperand[i];  // Compute the sum of double.
                        break;  // Exit the while loop.
                    }
                    catch (Exception ex)
                    {   // Execute this if the user's input is not a number.
                        Console.WriteLine(ex.Message);  // Display the error message.
                    }
                }
            }

            sumOfDouble = Math.Round(sumOfDouble, 2); // Round the sumOfDouble to two decimal places.

            // Display the result of two doubles.
            Console.WriteLine($"Sum of two doubles: {sumOfDouble}\n");
            return sumOfDouble; // return the value of sumOfDouble to the calling method.
        }

        public static void Main(string[] args)
        {
            int sumOfInt = GetUserInputForInt();    // Method call to GetUserInputForInt, then assign the return value to sumOfInt.
            double sumOfDouble = GetUserInputForDouble();   // Method call to GetUserInputForDouble, then assign the return value to sumOfDouble.

            // Compute the product of two sums (i.e sumOfInt and sumOfDouble).
            double productOfSums = sumOfInt * sumOfDouble;

            // Display the product of two sums.
            Console.WriteLine($"Product of Sums: {productOfSums}\n");

            // The following statement is used when the user decides to run the "MainProgram.cs" file, which can execute all coding challenges.
            Console.Write("Press any key to go back to main...");
            Console.ReadKey();  // read the key that the user's input (similar to getch).
            Console.Clear();    // Clear the console screen.

            /* OTHER SOLUTION TO SHOW THE PRODUCT OF TWO SUMS WITHOUT USING VARIABLES.
             * First, method call to GetUserInputForInt method then return the result value(int) as an argument.
             * Second, method call to GetUserInputForDouble method then return again the result value(double) as an argument.
             * Lastly, compute the product of two arguments (i.e returned value(int) in the first step and the returned value(double) in the second step).
             * Console.WriteLine($"Product of Sums: {GetUserInputForInt() * GetUserInputForDouble()}");
            */
        }
    }
}