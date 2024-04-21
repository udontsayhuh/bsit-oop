/*
Dev by: Villesco, Bengie B.
Section: 2-1
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenges
{
    class MainProgram
    {
        public static void DisplayTitlePage(string title)
        {
            Console.Write(new string('─', 80) + "\n" + $"{title}" + "\n" + new string('─', 80) + "\n");
            Console.Write("\tDEV: Villesco, Bengie B.\t|\t\tSECTION: 2-1" + "\n" + new string('─', 80) + "\n");
        }

        static void Main(string[] args)
        {
            // Error handling.
            while (true)
            {
                try
                {
                    DisplayTitlePage("\t\t\tC #  C O D I N G  C H A L L E N G E S");   // Method call to TitlePage method wih an argument of string value.

                    // Choices
                    Console.WriteLine("  (1) Sum of Two Integers/Doubles and Product of Two Sums");
                    Console.WriteLine("  (2) Count Number of Words");
                    Console.WriteLine("  (3) Basic Arithmetic Calculator");
                    Console.WriteLine("  (6) Exit");
                    Console.WriteLine(new string('─', 80));

                    // Ask the user to input the desire choice.
                    Console.Write("Enter choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();    // Clear the console screen.
                    switch (choice)
                    {
                        case 1: DisplayTitlePage("\t\t(1) Sum of Two Integers/Doubles and Product of Two Sums");   // Method call to DisplayTitlePage with an argument of string value.
                                SumAndProduct.Main(args);   // Perform the entry point in SumAndProduct class which can be found in the "SumAndProduct.cs" file.
                                break;  // Exit the switch statement.
                        case 2: DisplayTitlePage("\t\t\t(2) Count Number of Words");    // Method call to DisplayTitlePage with an argument of string value.
                                CountNumberOfWords.Main(args);  // Perform the entry point in CountNumberOfWords class which can be found in the "CountNumberOfWords.cs" file.
                                break;  // Exit the switch statement.
                        case 3: DisplayTitlePage("\t\t(2) Basic Arithmethic Calculator");    // Method call to DisplayTitlePage with an argument of string value.
                                BasicArithmeticCalculator.Main(args);  // Perform the entry point in BasicArithmeticCalculator class which can be found in the "BasicArithmeticCalculator.cs" file.
                                break;  // Exit the switch statement.
                        case 6: Console.WriteLine("End of program!");
                                Environment.Exit(0);    // Exit the program.
                                break;
                        default:Console.Clear();
                                Console.WriteLine("\nInvalid choice!");
                                break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("\nInvalid input! Please enter an integer only!");
                }
            }   // End of while loop.
        }
    }
}