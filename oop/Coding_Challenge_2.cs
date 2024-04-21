using System;

namespace CrystalynDanga
{
    /*Write a C# program that accepts a string and will count the number of words in the provided string and print the string in uppercase as a result.*/


    class Program
    {
        static void Main(string[] args) 
        {
            int wordCounter = 1; // will treat evey sentence to have 1 minimum word
            
            // gets user input
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            foreach (char letter in userInput) // loop for checking the string
            {
                if (char.IsWhiteSpace(letter)) // will check if letter variable is a whitespace
                {
                    wordCounter++; // If yes, it will add number to wordCounter
                }
            }

            Console.WriteLine("Number of words: " + wordCounter);

            userInput = userInput.ToUpper(); // Converts string to uppercase.
            Console.WriteLine(userInput);



        } // Main Method
    } // Program Class

} // Namespace
