using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int wordCount = input.Split(' ').Length;
        string uppercaseInput = input.ToUpper(); 

        Console.WriteLine($"Number of words: {wordCount}");
        Console.WriteLine($"Uppercase string: {uppercaseInput}");
    }
}
