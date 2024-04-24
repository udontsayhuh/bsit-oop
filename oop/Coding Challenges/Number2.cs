/*Write a C# program that accepts a string and will count the number of 
words in the provided string and print the string in uppercase as a result.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        //asks user for input
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();
        //wordCount initialized to 1 to count the first word entered
        int wordCount = 1;
        //counts the word based on the number of spaces
        foreach (char character in userInput)
        {
            if (character == ' ')
            {
                wordCount++;
            }
        }
        // displays the output
        Console.WriteLine("\nNumber of word/s: " + wordCount);
        Console.WriteLine("String in uppercase: " + userInput.ToUpper());
    }
}
