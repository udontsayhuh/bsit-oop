using System;

namespace Coding_Challenges
{
    internal class WordCount
    {

        internal WordCount()
        {
            Console.WriteLine("\nWord Count\n");

            string message = InputString();

            Console.WriteLine($"Word Count: {CountWord(message)}");
            Console.WriteLine($"UpperCase: {message.ToUpper()}");
        }

        private string InputString()
        {
            Console.Write("Enter a String: ");
            return Console.ReadLine();
        }

        private int CountWord(string word)
        {

            int counter = 0;
            bool IsWhiteSpace = true;

            foreach (char character in word)
            {

                if (Char.IsWhiteSpace(character))
                    IsWhiteSpace = true;

                else if (IsWhiteSpace)
                {
                    counter++;
                    IsWhiteSpace = false;
                } 
            }

            return counter;
        }

    }
}
