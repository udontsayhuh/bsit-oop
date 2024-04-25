using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a string
        Console.WriteLine("Please enter a sentence:");
        string userInput = Console.ReadLine();

        // Count the number of words
        int wordCount = CountWords(userInput);

        // Print the sentence in uppercase
        string upperCaseSentence = userInput.ToUpper();
        Console.WriteLine($"Your sentence in uppercase: {upperCaseSentence}");

        // Print the number of words
        Console.WriteLine($"Number of words in your sentence: {wordCount}");
    }

    // Method to count the number of words in a sentence
    static int CountWords(string sentence)
    {
        // Split the sentence into words using whitespace as separator
        string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        
        // Return the number of words
        return words.Length;
    }
}
