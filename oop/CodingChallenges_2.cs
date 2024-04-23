using System;

class Program
{
    static void Main(string[] args)
    {
        // Input string from the user
        Console.WriteLine("Enter a string:");
        string stringInput = Console.ReadLine();

        // Count the number of words
        int wordCount = CountWords(stringInput);

        // Print the number of words
        Console.WriteLine($"Number of words: {wordCount}");

        // Convert the string to uppercase
        string upperCaseString = stringInput.ToUpper();

        // Print the string in uppercase
        Console.WriteLine($"Uppercase string: {upperCaseString}");
    }

    // Method to count the number of words in a string
    static int CountWords(string input)
    {
        // Split the string into words based on whitespace
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        // Return the count of words
        return words.Length;
    }
}
