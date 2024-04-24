using System;

class Program
{
    static void Main()
    {
        // Accept input string from the user
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        // Count the number of words in the string
        int wordCount = CountWords(inputString);

        // Print the string in uppercase
        string upperCaseString = inputString.ToUpper();
        Console.WriteLine($"String in uppercase: {upperCaseString}");

        // Display the word count
        Console.WriteLine($"Number of words: {wordCount}");
    }

    static int CountWords(string input)
    {
        // Split the string into words using whitespace as delimiter
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        // Return the count of words
        return words.Length;
    }
}
