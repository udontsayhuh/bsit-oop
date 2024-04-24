/* Write a C# program that accepts a string and will count the number of words in the
provided string and print the string in uppercase as a result. */

using System;
    class Program{
    static void Main(string[] args) {
        Console.WriteLine("Enter string:");
        string inputString = Console.ReadLine();

        int wordCount = inputString.Split(new char[]
        {' '}, StringSplitOptions.RemoveEmptyEntries).Length;

        Console.WriteLine($"\nNumber of words: {wordCount}");
        Console.WriteLine(inputString.ToUpper());
    }
 }
