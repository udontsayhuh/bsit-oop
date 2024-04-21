/*
Instruction: Write a C# program that accepts a string and will count the number of words in the
provided string and print the string in uppercase as a result. 

Dev by: Villesco, Bengie B.
Section: 2-1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenges
{
    class CountNumberOfWords
    {
        private static string CountNumberOfWordsInAString(string userInput) // This method is only accessible within the class of CountNumberOfWords.
        {
            /* Splits the userInput (which is "Coding challenges") by spaces and tabs and removes any empty entries.
             * Then, assign all the result of splits(which will be ["Coding", "challenges"]) in splitUserInput(which is declared as array of string) */
            string[] splitUserInput = userInput.Split(new char[] {' ',  '\t'}, StringSplitOptions.RemoveEmptyEntries);

            // Count the length of the splitUserInput then display the result (In our case, the length is 2).
            Console.WriteLine($"\nNumber of words in a string: {splitUserInput.Length}");
            return userInput;   // Return the value of the userInput(which is "Coding challenges") to the calling method.
        }

        private static string GetUserInput()    // This method is only accessible within the class of CountNumberOfWords.
        {
            Console.Write("Enter any string: ");    // Ask the user to input any string.
            return Console.ReadLine();  // Reads the user input(Example input: Coding challenges) and then returns it to the calling method. 
        }

        public static void Main(string[] args)
        {
            /* First, method call to GetUserInput method then used the returned string value(which is "Coding challenges" in our example) as an argument.
             * Second, method call to CountNumberOfWordsInAString method with an argument of the returned string value from the first step(which is "Coding challenges")...
             * then used the returned string value(which is "Coding challenges") to convert it to uppercase.
             * Finally, display the string in uppercase. */
            Console.WriteLine($"String: {CountNumberOfWordsInAString(GetUserInput()).ToUpper()}");

            // The following statement is used when the user decides to run the "MainProgram.cs" file, which can execute all coding challenges.
            Console.Write("Press any key to go back to main...");
            Console.ReadKey();  // read the key that the user's input (similar to getch).
            Console.Clear();    // Clear the console screen.
        }
    }
}