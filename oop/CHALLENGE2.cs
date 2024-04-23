// Coding Challenge 2
// April 20, 2024

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("ENTER A STRING: ");
        string input = Console.ReadLine();

        int Count = CountWords(input);

        string uppercaseStr = input.ToUpper();
        Console.WriteLine($"\nNUMBER OF WORDS: {Count}");
        Console.WriteLine($"UPPERCASED STRING: {uppercaseStr}\n");

    }

    static int CountWords(string input)
    {
        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
