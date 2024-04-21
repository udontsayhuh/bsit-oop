using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's on your mind?");
            string text = Console.ReadLine();

            // Call the method
            int wordCount = CountWords(text);

            // Converting the string to uppercase
            string uppercaseString = text.ToUpper();

            Console.WriteLine("Number of words: " + wordCount);
            Console.WriteLine("Uppercase string: " + uppercaseString);
        }

        // Method for counting the number of words
        static int CountWords(string text)
        {
            // Split the string by whitespaces
            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}
