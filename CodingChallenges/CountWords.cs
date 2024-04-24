using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class CountWords
    {
        // a method that will display the header
        public void Header()
        {
            Console.Clear(); // will clear the console window
            // display the header
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("  Count the number of words in a string");
            Console.WriteLine("--------------------------------------------------\n");
        }

        // a method that will prompt the user to enter a string
        public void UserInputString()
        {
            // display header
            Header();

            // prompt the user to enter a string
            Console.Write("Enter a string: ");
            string userString = Console.ReadLine();

            // pass the string to the method that will count the number of words in the string
            CountTheWordsInString(userString);
            // variable that will receive the return value from the method
            int wordCount = CountTheWordsInString(userString);
            // display the word count and the string
            Display(wordCount, userString);
        }

        // a method that counts the number of words in a string
        public int CountTheWordsInString(string stringToCount)
        {
            // a variable that will track the number of words in the string
            int count = 0;
            string[] words = stringToCount.Split(' ');

            // loop through the elements in the words array
            foreach (string word in words)
            {
                count++;
            }

            return count;
        }

        // method that will display the word count and the string
        public void Display(int wordCount, string userString)
        {
            // convert the string in uppercase
            string upperCaseString = userString.ToUpper();

            // display the string in uppercase
            Console.WriteLine($"\nThe string in upper case is: {upperCaseString}");
            // display the number of words in the string
            Console.WriteLine($"Number of words in the string: {wordCount}");

        }
    }
}
