using System;

class Program
{
    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Count num of words
        int wordCount = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;

        // Print words in uppercase
        string uppercaseString = input.ToUpper();

        // Show Results
        Console.WriteLine($"Number of words: {wordCount}");
        Console.WriteLine($"Uppercase string: {uppercaseString}");
    }
}
