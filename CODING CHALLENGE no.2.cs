using System;

class Program
{
    static void Main()
    {
        // Welcome message and input prompt
        Console.WriteLine("Welcome to the String Counter!");
        Console.Write("Please enter a string: ");
        string inputString = Console.ReadLine();
        
        // Counting the number of words
        int wordCount = CountWords(inputString);

        // Display the result
        Console.WriteLine($"The number of words in the provided string is: {wordCount}");

        // Displaying the input string in uppercase
        string upperCaseString = inputString.ToUpper();
        Console.WriteLine($"The string in uppercase: {upperCaseString}");
    }

    // Function to count the number of words in a string
    static int CountWords(string str)
    {
        // Splitting the string by whitespace to count words
        string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        
        // Returning the count of words
        return words.Length;
    }
}
