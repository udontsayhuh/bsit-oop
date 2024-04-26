using System;

public class WordCountAndUppercase
{
    public static void Main(string[] args)
    {
        // Get user input
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        // Split the string into words (using a space as delimiter)
        string[] words = inputString.Split(' ');

        // Count the number of words
        int wordCount = words.Length;

        // Convert string to uppercase
        string upperCaseString = inputString.ToUpper();

        // Display results
        Console.WriteLine("Number of words: {0}", wordCount);
        Console.WriteLine("String in uppercase: {0}", upperCaseString);
    }
}
