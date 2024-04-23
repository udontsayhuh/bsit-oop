using System;

// A class for processing strings
class StringProcessor
{
    // Method to count the number of words in a string
    public int CountWords(string inputString)
    {
        // Split the input string into words using whitespace as separator
        string[] words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        // Return the number of words
        return words.Length;
    }

    // Method to convert a string to uppercase
    public string ToUpperCase(string inputString)
    {
        // Convert the input string to uppercase
        return inputString.ToUpper();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a string
        Console.WriteLine("Enter a string:");
        
        // Read the user input
        string userInput = Console.ReadLine();

        // Create an instance of the StringProcessor class
        StringProcessor processor = new StringProcessor();

        // Count the number of words in the user input using the StringProcessor
        int wordCount = processor.CountWords(userInput);
        
        // Display the number of words in the string to the user
        Console.WriteLine("Number of words in the string: " + wordCount);

        // Convert the user input to uppercase using the StringProcessor
        string upperCaseString = processor.ToUpperCase(userInput);

        // Display the string in uppercase
        Console.WriteLine("String in uppercase: " + upperCaseString);
    }
}
