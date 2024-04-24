/*Write a C# program that accepts a string and will count the number of 
words in the provided string and print the string in uppercase as a result.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        int wordCount = 1;

        foreach (char character in userInput)
        {
            if (character == ' ')
            {
                wordCount++;
            }
        }

        Console.WriteLine("\nNumber of word/s: " + wordCount);
        Console.WriteLine("String in uppercase: " + userInput.ToUpper());
    }
}
