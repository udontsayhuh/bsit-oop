/*
Write a C# program that can perform basic arithmetic functions. (Addition, Subtraction, Multiplication, and Division).
The user must be allowed to select which arithmetic function he/she wants to use, and then they will be prompted to
enter only two numbers after selecting the arithmetic function. Print the result afterwards, and then after printing
ask the user if he/she wants to perform another action or not. If yes, repeat the program, if not terminate the program.

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
    class BasicArithmeticCalculator
    {
        private static double Compute(double[] operand, string selectedOperator)
        {
            if (selectedOperator == "+")
                return operand[0] + operand[1];
            else if (selectedOperator == "-")
                return operand[0] - operand[1];
            else if (selectedOperator == "*")
                return operand[0] * operand[1];
            else
                return operand[0] / operand[1];
        }

        private static bool IsNotValidChosenOperator(string selectedOperator)
        {
            // Check the first requirement. The selectedOperator should not be a null/empty and its length is only 1.
            // The conditon (String.IsNullOrEmpty(selectedOperator) || selectedOperator.Length != 1) represent the first requirement.
            // Check the second requirement. The selectedOperator should be +, -, *, or /
            // The condition (selectedOperator != "+" && selectedOperator != "-" && selectedOperator != "*" && selectedOperator != "/") represent the second requirement.
            if ((String.IsNullOrEmpty(selectedOperator) || selectedOperator.Length != 1) || (selectedOperator != "+" && selectedOperator != "-" && selectedOperator != "*" && selectedOperator != "/"))
                return true;    // Return the true to calling method which means the selectedOperator is not a valid.
            else
                return false;   // Return the false to calling method which means the selectedOperator is valid.
        }

        private static double[] GetTwoOperands()
        {
            double[] operand = new double[2];   // Array to store the two numbers that the user's will input. (Declared as array of double with the size of 2)

            for (int i = 0; i < 2; i++)
            {
                while (true)    // Error handling
                {
                    try
                    {
                        Console.Write($"\nEnter number for operand{i + 1}: ");
                        operand[i] = Convert.ToDouble(Console.ReadLine());
                        break;  // Exit the loop.
                    }
                    catch (Exception)
                    {
                        Console.Write("\nInvalid input! Please enter a number only!");
                    }
                }
            }
            return operand; // Return the value stored in operand to calling method.
        }

        private static void DisplayOperationOption()
        {
            Console.Clear();
            Console.WriteLine("\t\t     A R I T H M E T I C  O P E R A T I O N");
            Console.WriteLine(new string('─', 80));
            Console.WriteLine("────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("|    ADDITION    ║     SUBTRACTION      ║    MULTIPLICATION   ║    DIVISION    |");
            Console.WriteLine(new string('─', 80));
            Console.WriteLine("|       +        ║          -           ║          *          ║        /       |");
            Console.WriteLine(new string('─', 80));
        }

        public static void Main(string[] args)
        {
            string anotherAction = "Y"; // Initialize anotherAction to "Y".

            while (anotherAction == "Y" || anotherAction == "YES")  // Loop as long as the user wants to perform another action. Outer loop.
            {
                string chosenOperator = String.Empty;   // Initialize the chosenOperator as empty.

                // Validate the chosenOperator.
                // Method call to IsNotValidChosenOperator method with parameter of chosenOperator, then used the return value as an argument/condition for the while loop.
                while (IsNotValidChosenOperator(chosenOperator))    // First inner loop.
                {
                    DisplayOperationOption();   // Method call to DisplayOperationOption.
                    Console.Write("Enter the disire operator to perform: "); //Ask the user to input the desire choice
                    chosenOperator = Console.ReadLine();
                }   // End of the first inner loop.

                // First, method call to GetTwoOperands method, then used the return value as an argument to the Compute method.
                // Second, method call to Compute method with an argument of the return value in the first step and parameter of chosenOperator. Lastly, assign the return value to the result variable.
                double result = Compute(GetTwoOperands(), chosenOperator);

                // Display the result
                if (Double.IsInfinity(result))
                    Console.WriteLine("\nCannot divide by 0!\n");
                else
                    Console.WriteLine($"\nResult: {result}\n");

                // Ask the user if the user wants to perform another action.
                Console.Write("Do you want to perform another action?(Y/N): ");
                anotherAction = Console.ReadLine()?.ToUpper();

                // Validate the user input for anotherAction.
                while (String.IsNullOrEmpty(anotherAction) || anotherAction != "Y" && anotherAction != "YES" && anotherAction != "N" && anotherAction != "NO")
                {   // Second Inner loop.
                    Console.Write("\nInvalid input! Please enter (Y/N) or (YES/NO)\nDo you want to perform another action?(Y/N): ");
                    anotherAction = Console.ReadLine()?.ToUpper();
                }   // End of the second inner loop.
                Console.Clear();
            }   // End of the outer loop.
        }
    }
}