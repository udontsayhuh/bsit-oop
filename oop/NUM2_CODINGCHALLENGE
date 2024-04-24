using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string:");
        string input = Console.ReadLine();

        // Split the string by spaces to count words
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length; // Count the words

        // Convert the entire string to uppercase
        string uppercasedString = input.ToUpper();

        // Output the results
        Console.WriteLine();
        Console.WriteLine($"Number of words: {wordCount}");
        Console.WriteLine($"\nUppercase: {uppercasedString}");
    }
}
